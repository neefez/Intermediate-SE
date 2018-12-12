using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace AccessAssistant
{
   /// <summary>
   /// This abstract class defines the properties and methods that a DBObject
   /// should have.
   /// </summary>
   public abstract class DBObject
   {

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
         internal set
         {
            SetPrimaryKey(value);
         }
      }

      /// <summary>
      /// The <seealso cref="PropertyInfo"/> for the primary key of the <seealso cref="DBObject"/>.
      /// </summary>
      internal PropertyInfo PrimaryKeyPropertyInfo
      {
         get
         {
            var primaryKeyProperty = SchemaFieldProperties.Where(pi => pi.GetCustomAttribute<SchemaField>().IsPrimaryKey).FirstOrDefault();
            if (primaryKeyProperty != null)
               return primaryKeyProperty;
            else
               throw new NotImplementedException($"{GetType().Name} does not have Primary Key defined using {nameof(SchemaField)}");
         }
      }

      /// <summary>
      /// An <seealso cref="IEnumerable{T}"/> containing all of the <seealso cref="PropertyInfo"/> of 
      ///    <seealso cref="DBObject"/> properties that have the <seealso cref="SchemaField"/> attribute.
      /// </summary>
      internal IEnumerable<PropertyInfo> SchemaFieldProperties
      {
         get
         {
            return GetType().GetProperties().Where(pi => pi.GetCustomAttribute<SchemaField>() != null);
         }
      }

      #endregion

      #region Methods

      /// <summary>
      /// Sets the primary key of a <seealso cref="DBObject"/> using the specified <paramref name="value"/>.
      /// </summary>
      /// <param name="value">Value to set the primary key of the <seealso cref="DBObject"/> to.</param>
      internal void SetPrimaryKey(int value)
      {
         string backingFieldName = PrimaryKeyPropertyInfo.Name;
         backingFieldName = backingFieldName.First().ToString().ToLower() + backingFieldName.Substring(1);
         BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
         GetType().GetFields(flags).Where(field => field.Name == backingFieldName).FirstOrDefault().SetValue(this, value);
      }

      /// <summary>
      /// Sets the primary key of a <seealso cref="DBObject"/> using the specified <paramref name="record"/>.
      /// </summary>
      /// <param name="record"><seealso cref="DbDataRecord"/> to get the primary key from.</param>
      internal void SetPrimaryKey(DbDataRecord record)
      {
         for (int i = 0; i < record.FieldCount; i++)
            if (record.GetName(i) == PrimaryKeyPropertyInfo.Name)
               SetPrimaryKey((int)record.GetValue(i));
      }

      /// <summary>
      /// Determines the next available primary key for the <seealso cref="DBObject"/> and returns it.
      /// </summary>
      /// <returns>Next available primary key for the <seealso cref="DBObject"/></returns>
      internal int NextAvailablePrimaryKey()
      {
         if (DBController.GetAllRecords(GetType()).Count == 0)
            return 0;
         else
            return DBController.GetAllRecords(GetType()).Max(dbObject => dbObject.PrimaryKey) + 1;
      }

      #endregion

   }
}