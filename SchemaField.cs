using System;

namespace AccessAssistant
{
   /// <summary>
   /// This class defines an attribute which will be used on properties
   /// to define what DBObject properties are part of a DBObject schema.
   /// </summary>
   [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
   public class SchemaField : Attribute
   {
      public bool IsPrimaryKey { get; set; } = false;
   }

}
