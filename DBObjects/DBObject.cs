using CarRentalSystem.DBHelpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.DBObjects
{
   public abstract class DBObject
   {

      private static readonly string DB_PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;";
      private static readonly string DATA_SOURCE = $"Data source= {Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}";
      private static readonly string CONNECTION_STRING = $@"{DB_PROVIDER}{DATA_SOURCE}\CarRentalDB.accdb";

      /// <summary>
      /// Specifies how to save a <seealso cref="DBObject"/>.
      /// </summary>
      public enum SaveTypes
      {
         Insert,
         Update
      };

      #region Properties

      /// <summary>
      /// The primary key of the <seealso cref="DBObject"/>.
      /// </summary>
      public int PrimaryKey
      {
         get
         {
            return (int)PrimaryKeyPropertyInfo.GetValue(this);
         }
         private set
         {
            SetPrimaryKey(value);
         }
      }

      /// <summary>
      /// The <seealso cref="PropertyInfo"/> for the primary key of the <seealso cref="DBObject"/>.
      /// </summary>
      private PropertyInfo PrimaryKeyPropertyInfo
      {
         get
         {
            var primaryKeyProperty = SchemaFieldProperties.Where(pi => pi.GetCustomAttribute<SchemaField>().IsPrimaryKey).FirstOrDefault();
            if (primaryKeyProperty != null)
               return primaryKeyProperty;
            else
               throw new Exception($"{GetType().Name} does not have Primary Key defined using {nameof(SchemaField)}");
         }
      }

      /// <summary>
      /// An <seealso cref="IEnumerable{T}"/> containing all <seealso cref="PropertyInfo"/> of Properties 
      ///    that have the <seealso cref="SchemaField"/> attribute.
      /// </summary>
      private IEnumerable<PropertyInfo> SchemaFieldProperties
      {
         get
         {
            return GetType().GetProperties().Where(pi => pi.GetCustomAttribute<SchemaField>() != null);
         }
      }

      #endregion

      #region Methods

      /// <summary>
      /// Saves the <seealso cref="DBObject"/> to the datasource.
      /// </summary>
      /// <param name="saveType">Specifies how to save the <seealso cref="DBObject"/>.</param>
      /// 
      /// <example>
      /// The following example shows how to create and saves an <seealso cref="Admin"/> to the datasource.
      /// <code>
      /// Admin admin = new Admin();
      /// admin.Save(DBObject.SaveTypes.Insert);
      /// </code>
      /// </example>
      /// 
      /// <example>
      /// The following example shows how to update and save an <seealso cref="Admin"/> currently in the datasource.
      /// <code>
      /// foreach (Admin admin in DBObject.GetAllRecords&lt;Admin&gt;())
      /// {
      ///    if (admin.Username == "user123") // or other unique identifier
      ///    {
      ///       admin.FirstName = "myNewFirstName";
      ///       admin.Save(DBObject.SaveTypes.Update);
      ///    }
      /// }
      /// </code>
      /// </example>
      /// 
      /// <returns>
      /// Whether the save was successful or not.
      /// </returns>
      public bool Save(SaveTypes saveType)
      {
         string query;
         switch (saveType)
         {
            case SaveTypes.Insert:
               SetNextPrimaryKey();
               query = CreateInsertString();
               break;
            case SaveTypes.Update:
               query = CreateUpdateString();
               break;
            default:
               throw new NotImplementedException($"SaveType {saveType.ToString()} has not been implemented in the Save method.");
         }
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            using (OleDbCommand command = new OleDbCommand(query, dbConnection))
            {
               AddValuesToPropertyPlaceholders(command, saveType);
               dbConnection.Open();
               return command.ExecuteNonQuery() == 1;
            }
         }
      }

      /// <summary>
      /// Deletes the <seealso cref="DBObject"/> from the datasource.
      /// </summary>
      /// 
      /// <example>
      /// The following example shows how to <see cref="Delete"/> a <seealso cref="Customer"/> with a username of "billy123" from the datasource.
      /// <code>
      /// DBObject.GetAllRecords&lt;"Customer"&gt;().Where(cust => cust.Username == "billy123").FirstOrDefault().Delete();
      /// </code>
      /// </example>
      /// 
      /// <example>
      /// The following example shows an alternative way to <see cref="Delete"/> a <seealso cref="Customer"/> with a username of "billy123" from the datasource.
      /// <code>
      /// List&lt;Customer&gt; customers = DBObject.GetAllRecords&lt;Customer&gt;();
      /// customers.Where(cust => cust.Username == "billy123").FirstOrDefault().Delete();
      /// </code>
      /// </example>
      /// 
      /// <returns>
      /// Whether the delete was successful or not.
      /// </returns>
      /// <exception cref="OleDbException">
      /// Throws an exception when a foreign key linkage is being violated.
      /// </exception>
      public bool Delete()
      {
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            string table = GetType().Name;
            string query = $"DELETE FROM {table} WHERE {PrimaryKeyPropertyInfo.Name} = {PrimaryKeyPropertyInfo.GetValue(this)}";
            int rowsAffected;
            using (OleDbCommand command = new OleDbCommand(query, dbConnection))
            {
               dbConnection.Open();
               try
               {
                  rowsAffected = command.ExecuteNonQuery();
               }
               catch (OleDbException ex)
               {
                  Console.Error.WriteLine(ex.Message);
                  throw;
               }
            }
            return rowsAffected != 0;
         }
      }

      /// <summary>
      /// Returns the <seealso cref="DBObject"/> that is attributed with the specified <paramref name="primaryKey"/>.
      /// </summary>
      /// <typeparam name="T">Type of <seealso cref="DBObject"/>.</typeparam>
      /// <param name="primaryKey">The <paramref name="primaryKey"/> associated with a <seealso cref="DBObject"/>.</param>
      /// 
      /// <returns>
      /// <seealso cref="DBObject"/> that is attributed with the specified <paramref name="primaryKey"/>.
      /// Otherwise, a null <seealso cref="DBObject"/> is returned;
      /// </returns>
      public static T GetByPrimaryKey<T>(int primaryKey) where T : DBObject
      {
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            dynamic instance = Activator.CreateInstance<T>();
            string table = typeof(T).Name;
            string query = $"SELECT * FROM [{table}] WHERE [{instance.PrimaryKeyPropertyInfo.Name}] = {primaryKey}";
            using (OleDbCommand command = new OleDbCommand(query, dbConnection))
            {
               dbConnection.Open();
               using (OleDbDataReader dbDataReader = command.ExecuteReader())
               {
                  if (dbDataReader.HasRows)
                  {
                     T dbObject = Activator.CreateInstance<T>();
                     foreach (DbDataRecord record in dbDataReader)
                        SetPropertyValuesFromRecord(ref dbObject, record);
                     dbObject.SetPrimaryKey(primaryKey);
                     return dbObject;
                  }
                  else
                     return default(T);
               }
            }
         }
      }

      /// <summary>
      /// Returns a list of all of the <seealso cref="DBObject"/> records of type <typeparamref name="T"/>.
      /// </summary>
      /// <typeparam name="T">Type of <seealso cref="DBObject"/>.</typeparam>
      /// 
      /// <example>
      /// This example shows how to return a list of all <seealso cref="Admin"/> records.
      /// <code>
      /// public class TestClass
      /// {
      ///    public void Main()
      ///    {
      ///       List<seealso cref="Admin"/> admins = DBObject.GetAllRecords<seealso cref="Admin"/>();
      ///    }
      /// }
      /// </code>
      /// </example>
      /// 
      /// <returns>
      /// List of <seealso cref="DBObject"/>s.
      /// </returns>
      public static List<T> GetAllRecords<T>() where T : DBObject
      {
         dynamic thingOfTypeT = Activator.CreateInstance<T>();
         List<DBObject> list = GetAllRecords(thingOfTypeT.GetType());
         return list.Cast<T>().ToList();
      }

      /// <summary>
      /// Searches the datasource for records of the specified <paramref name="type"/>, creates a 
      /// <seealso cref="DBObject"/> for each record, and returns a list of those created <seealso cref="DBObject"/>s.
      /// </summary>
      /// <param name="type">Type of <seealso cref="DBObject"/>.</param>
      /// 
      /// <returns>
      /// List of created <seealso cref="DBObject"/>s.
      /// </returns>
      private static List<DBObject> GetAllRecords(Type type)
      {
         List<DBObject> list = new List<DBObject>();
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            string table = type.Name;
            string query = $"SELECT * FROM {table}";
            try
            {
               using (OleDbCommand command = new OleDbCommand(query, dbConnection))
               {
                  dbConnection.Open();
                  using (OleDbDataReader dbDataReader = command.ExecuteReader())
                  {
                     if (dbDataReader.HasRows)
                     {
                        foreach (DbDataRecord record in dbDataReader)
                        {
                           DBObject dbObject = Activator.CreateInstance(type) as DBObject;
                           SetPropertyValuesFromRecord(ref dbObject, record);
                           dbObject.SetPrimaryKey(record);
                           list.Add(dbObject);
                        }
                     }
                  }
               }
            }
            catch (OleDbException)
            {
               throw;
            }
         }
         return list;
      }

      /// <summary>
      /// Creates the query for inserting data into the datasource.
      /// </summary>
      /// 
      /// <returns>
      /// Generated Insert query.
      /// </returns>
      private string CreateInsertString()
      {
         StringBuilder partOne = new StringBuilder("(");
         StringBuilder partTwo = new StringBuilder("(");
         string lastPropertyName = SchemaFieldProperties.Last().Name;
         foreach (PropertyInfo property in SchemaFieldProperties)
         {
            partOne.Append($"[{property.Name}]");
            partTwo.Append($"@{property.Name}");
            if (property.Name.Equals(lastPropertyName))
            {
               partOne.Append(")");
               partTwo.Append(")");
            }
            else
            {
               partOne.Append(", ");
               partTwo.Append(", ");
            }
         }
         string tableName = GetType().Name;
         return $"INSERT INTO [{tableName}]{partOne.ToString()} VALUES {partTwo.ToString()}";
      }

      /// <summary>
      /// Creates the query for updating data in the datasource.
      /// </summary>
      /// 
      /// <returns>
      /// Generated Update query.
      /// </returns>
      private string CreateUpdateString()
      {
         string tableName = GetType().Name;
         StringBuilder stringBuilder = new StringBuilder($"UPDATE [{tableName}]{Environment.NewLine}SET ");
         foreach (PropertyInfo property in SchemaFieldProperties.Where(pi => !pi.GetCustomAttribute<SchemaField>().IsPrimaryKey))
         {
            stringBuilder.Append($"[{property.Name}] = @{property.Name}");
            if (!property.Name.Equals(SchemaFieldProperties.Last().Name))
               stringBuilder.Append($", ");
         }
         stringBuilder.Append($"{Environment.NewLine}WHERE {PrimaryKeyPropertyInfo.Name} = {PrimaryKeyPropertyInfo.GetValue(this)}");
         return stringBuilder.ToString();
      }

      /// <summary>
      /// Adds values to the <seealso cref="PropertyInfo"/> placeholders nested in the generated query.
      /// </summary>
      /// <param name="command">Command to execute against the datasource.</param>
      /// <param name="saveType">Specifies how to save the <seealso cref="DBObject"/></param>
      private void AddValuesToPropertyPlaceholders(OleDbCommand command, SaveTypes saveType)
      {
         IEnumerable<PropertyInfo> propertyList = SchemaFieldProperties;
         if (saveType == SaveTypes.Update)
            propertyList = propertyList.Where(pi => !pi.GetCustomAttribute<SchemaField>().IsPrimaryKey);
         foreach (PropertyInfo property in propertyList)
            AddParameterToCommandFromProperty(command, property);
      }

      /// <summary>
      /// Adds a parameter to the <paramref name="command"/> using the value of the <paramref name="property"/>.
      /// </summary>
      /// <param name="command">Command to execute against the datasource.</param>
      /// <param name="property"><seealso cref="PropertyInfo"/> of which a value will be attained.</param>
      private void AddParameterToCommandFromProperty(OleDbCommand command, PropertyInfo property)
      {
         object value = property.GetValue(this);
         string name = $"@{property.Name}";
         command.Parameters.AddWithValue(name, value);
      }

      /// <summary>
      /// Sets each <seealso cref="PropertyInfo"/> of the <paramref name="dbObject"/> to the value of
      /// the <paramref name="record"/>, so long as the <seealso cref="PropertyInfo"/> is not the
      /// primary key of the <paramref name="dbObject"/>.
      /// </summary>
      /// <typeparam name="T">Type of <seealso cref="DBObject"/></typeparam>
      /// <param name="dbObject"><seealso cref="DBObject"/> to set <seealso cref="PropertyInfo"/> values for.</param>
      /// <param name="record"><seealso cref="DbDataRecord"/> to read values from.</param>
      private static void SetPropertyValuesFromRecord<T>(ref T dbObject, DbDataRecord record) where T : DBObject
      {
         for (int i = 0; i < record.FieldCount; i++)
            if (record.GetName(i) != dbObject.PrimaryKeyPropertyInfo.Name)
               dbObject.GetType().GetProperty(record.GetName(i)).SetValue(dbObject, record.GetValue(i));
      }

      /// <summary>
      /// Sets the primary key of a <seealso cref="DBObject"/> using the specified <paramref name="record"/>.
      /// </summary>
      /// <param name="record"><seealso cref="DbDataRecord"/> to get the primary key from.</param>
      private void SetPrimaryKey(DbDataRecord record)
      {
         for (int i = 0; i < record.FieldCount; i++)
            if (record.GetName(i) == PrimaryKeyPropertyInfo.Name)
               SetPrimaryKey((int)record.GetValue(i));
      }

      /// <summary>
      /// Sets the primary key of a <seealso cref="DBObject"/> using the specified <paramref name="value"/>.
      /// </summary>
      /// <param name="value">Value to set the primary key of the <seealso cref="DBObject"/> to.</param>
      private void SetPrimaryKey(int value)
      {
         string backingFieldName = PrimaryKeyPropertyInfo.Name;
         backingFieldName = backingFieldName.First().ToString().ToLower() + backingFieldName.Substring(1);
         BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
         GetType().GetFields(flags).Where(field => field.Name == backingFieldName).FirstOrDefault().SetValue(this, value);
      }

      /// <summary>
      /// Sets the primary key of the <seealso cref="DBObject"/> to the next available primary key for that <seealso cref="DBObject"/>.
      /// </summary>
      private void SetNextPrimaryKey()
      {
         if (GetAllRecords(GetType()).Count == 0)
            PrimaryKey = 0;
         else
            PrimaryKey = GetAllRecords(GetType()).Max(dbObject => dbObject.PrimaryKey) + 1;
      }

      #endregion

   }
}
