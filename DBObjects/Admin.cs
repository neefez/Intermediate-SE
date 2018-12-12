using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// <seealso cref="Admin"/> is a class that constitutes 
   /// <seealso cref="User"/>s with backend permissions. They are able to Add,
   /// Modify, Return, and Delete <seealso cref="Vehicle"/>s from the system,
   /// and can penalize <seealso cref="Customer"/>s.
   /// </summary>
   public class Admin : User
   {
      private int adminID; // Actually used by DBObject Framework

      /// <summary>
      /// Is able to get the <seealso cref="Admin"/>'s ID but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int AdminID
      {
         get { return adminID; }
      }

      /// <summary>
      /// Default '[empty]' constructor needed for selecting all records.
      /// </summary>
      public Admin() { }

      /// <summary>
      /// Parameterized constructor for an <seealso cref="Admin"/> object.
      /// </summary>
      /// <param name="newFirstName"><seealso cref="string"/> representing the
      ///   <seealso cref="Admin"/>'s first name.</param>
      /// <param name="newLastName"><seealso cref="string"/> representing the
      ///   <seealso cref="Admin"/>'s last name.</param>
      /// <param name="usrnm"><seealso cref="string"/> representing the
      ///   <seealso cref="Admin"/>'s userame.</param>
      /// <param name="psswrd"><seealso cref="string"/> representing the
      ///   <seealso cref="Admin"/>'s password.</param>
      public Admin(string newFirstName, string newLastName, string usrnm,
         string psswrd) : base(newFirstName, newLastName, usrnm, psswrd) { }
   }
}