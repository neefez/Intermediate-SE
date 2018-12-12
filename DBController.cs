using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using static AccessAssistant.DBObject;

namespace AccessAssistant
{
   /// <summary>
   /// This class controls the passage of data to and from the Access database.
   /// </summary>
   public static class DBController
   {

      private static readonly string DB_PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;";
      private static readonly string DATA_SOURCE = $"Data source= {Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}";
      private static readonly string CONNECTION_STRING = $@"{DB_PROVIDER}{DATA_SOURCE}\CarRentalDB.accdb";


      /// <summary>
      /// Saves the <seealso cref="DBObject"/> to the datasource.
      /// </summary>
      /// <param name="dbObject"><seealso cref="DBObject"/> to save to the datasource.</param>
      /// <param name="saveType">Specifies how to save the <seealso cref="DBObject"/>.</param>
      /// 
      /// <example>
      /// The following example shows how to create and saves an <seealso cref="Admin"/> to the datasource.
      /// <code>
      /// Admin admin = new Admin();
      /// DBController.Save(admin, DBObject.SaveTypes.Insert);
      /// </code>
      /// </example>
      /// 
      /// <example>
      /// The following example shows how to update and save an <seealso cref="Admin"/> currently in the datasource.
      /// <code>
      /// foreach (Admin admin in DBController.GetAllRecords&lt;Admin&gt;())
      /// {
      ///    if (admin.Username == "user123") // or other unique identifier
      ///    {
      ///       admin.FirstName = "myNewFirstName";
      ///       DBController.Save(admin, DBObject.SaveTypes.Update);
      ///    }
      /// }
      /// </code>
      /// </example>
      /// 
      /// <returns>
      /// Whether the save was successful or not.
      /// </returns>
      public static bool Save(DBObject dbObject, SaveTypes saveType)
      {
         string query;
         switch (saveType)
         {
            case SaveTypes.Insert:
               dbObject.SetPrimaryKey(dbObject.NextAvailablePrimaryKey());
               query = CreateInsertString(dbObject);
               break;
            case SaveTypes.Update:
               query = CreateUpdateString(dbObject);
               break;
            default:
               throw new NotImplementedException($"SaveType {saveType.ToString()} has not been implemented in the Save method.");
         }
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            using (OleDbCommand command = new OleDbCommand(query, dbConnection))
            {
               AddValuesToPropertyPlaceholders(command, saveType, dbObject);
               dbConnection.Open();
               return command.ExecuteNonQuery() == 1;
            }
         }
      }

      /// <summary>
      /// Deletes the <seealso cref="DBObject"/> from the datasource.
      /// </summary>
      /// <param name="dbObject"><seealso cref="DBObject"/> to delete from the datasource.</param>
      /// 
      /// <example>
      /// The following example shows how to <see cref="Delete"/> a <seealso cref="Customer"/> with a username of "billy123" from the datasource.
      /// <code>
      /// List<Customer> customers = DBController.GetAllRecords<Customer>().Where(cust => cust.Username == "billy123").ToList();
      ///   foreach (Customer customer in customers)
      ///      DBController.Delete(customer);
      /// </code>
      /// </example>
      /// 
      /// <returns>
      /// Whether the delete was successful or not.
      /// </returns>
      /// <exception cref="OleDbException">
      /// Throws an exception when a foreign key linkage is being violated.
      /// </exception>
      public static bool Delete(DBObject dbObject)
      {
         using (OleDbConnection dbConnection = new OleDbConnection(CONNECTION_STRING))
         {
            string table = dbObject.GetType().Name;
            string query = $"DELETE FROM {table} WHERE {dbObject.PrimaryKeyPropertyInfo.Name} = {dbObject.PrimaryKey}";
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
            dynamic typeInstance = Activator.CreateInstance<T>();
            string table = typeof(T).Name;
            string query = $"SELECT * FROM [{table}] WHERE [{typeInstance.PrimaryKeyPropertyInfo.Name}] = {primaryKey}";
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
      internal static List<DBObject> GetAllRecords(Type type)
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
      /// <param name="dbObject"><seealso cref="DBObject"/> to get information from.</param>
      /// 
      /// <returns>
      /// Generated Insert query.
      /// </returns>
      private static string CreateInsertString(DBObject dbObject)
      {
         StringBuilder partOne = new StringBuilder("(");
         StringBuilder partTwo = new StringBuilder("(");
         string lastPropertyName = dbObject.SchemaFieldProperties.Last().Name;
         foreach (PropertyInfo property in dbObject.SchemaFieldProperties)
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
         string tableName = dbObject.GetType().Name;
         return $"INSERT INTO [{tableName}]{partOne.ToString()} VALUES {partTwo.ToString()}";
      }

      /// <summary>
      /// Creates the query for updating data in the datasource.
      /// </summary>
      /// <param name="dbObject"><seealso cref="DBObject"/> to get information from.</param>
      /// 
      /// <returns>
      /// Generated Update query.
      /// </returns>
      private static string CreateUpdateString(DBObject dbObject)
      {
         StringBuilder updatedValues = new StringBuilder();
         string lastPropertyName = dbObject.SchemaFieldProperties.Last().Name;
         foreach (PropertyInfo property in dbObject.SchemaFieldProperties.Where(pi => !pi.GetCustomAttribute<SchemaField>().IsPrimaryKey))
         {
            updatedValues.Append($"[{property.Name}] = @{property.Name}");
            if (!property.Name.Equals(lastPropertyName))
               updatedValues.Append(", ");
         }
         string tableName = dbObject.GetType().Name;
         return $"UPDATE [{tableName}] SET {updatedValues} WHERE {dbObject.PrimaryKeyPropertyInfo.Name} = {dbObject.PrimaryKey}";
      }

      /// <summary>
      /// Adds values to the <seealso cref="PropertyInfo"/> placeholders nested in the generated query.
      /// </summary>
      /// <param name="command">Command to execute against the datasource.</param>
      /// <param name="saveType">Specifies how to save the <seealso cref="DBObject"/></param>
      /// <param name="dbObject"><seealso cref="DBObject"/> to get information from.</param>
      private static void AddValuesToPropertyPlaceholders(OleDbCommand command, SaveTypes saveType, DBObject dbObject)
      {
         IEnumerable<PropertyInfo> propertyList = dbObject.SchemaFieldProperties;
         if (saveType == SaveTypes.Update)
            propertyList = propertyList.Where(pi => !pi.GetCustomAttribute<SchemaField>().IsPrimaryKey);
         foreach (PropertyInfo property in propertyList)
            AddParameterToCommandFromProperty(command, property, dbObject);
      }

      /// <summary>
      /// Adds a parameter to the <paramref name="command"/> using the value of the <paramref name="property"/>.
      /// </summary>
      /// <param name="command">Command to execute against the datasource.</param>
      /// <param name="property"><seealso cref="PropertyInfo"/> of which a value will be attained.</param>
      /// <param name="dbObject"><seealso cref="DBObject"/> to get the <paramref name="property"/> value from.</param>
      private static void AddParameterToCommandFromProperty(OleDbCommand command, PropertyInfo property, DBObject dbObject)
      {
         object value = property.GetValue(dbObject); // Used to say .GetValue(this)
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

   }
}
