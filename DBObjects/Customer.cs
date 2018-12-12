using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// <seealso cref="Customer"/> is a class that constitutes 
   ///   <seealso cref="User"/>s with limited permissions. They are able to
   ///   create <seealso cref="Rental"/>s and <seealso cref="Purchase"/>s
   ///   related to <seealso cref="Vehicle"/>s.
   /// </summary>
   public class Customer : User
   {

      private int customerID; // Actually used by DBObject Framework
      private bool isBlacklisted;
      private int fee;

      /// <summary>
      /// Is able to get the <seealso cref="Customer"/>'s ID but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int CustomerID
      {
         get { return customerID; }
      }

      /// <summary>
      /// The <seealso cref="Customer"/> blacklist state can be viewed or set.
      /// </summary>
      [SchemaField()]
      public bool IsBlacklisted
      {
         get { return isBlacklisted; }
         set { isBlacklisted = value; }
      }

      /// <summary>
      /// The <seealso cref="Customer"/>'s fees can be viewed or changed.
      /// </summary>
      [SchemaField()]
      public int Fee
      {
         get { return fee; }
         set { fee = value; }
      }
      
      /// <summary>
      /// Default constructor to create a <seealso cref="Customer"/> object.
      /// </summary>
      public Customer() { }

      /// <summary>
      /// Parameterized constructor for a <seealso cref="Customer"/> object.
      /// </summary>
      /// <param name="newFirstName"><seealso cref="string"/> representing
      ///   the <seealso cref="Customer"/>'s first name.</param>
      /// <param name="newLastName"><seealso cref="string"/> representing the
      ///   <seealso cref="Customer"/>'s last name.</param>
      /// <param name="usrnm"><seealso cref="string"/> representing the 
      ///   <seealso cref="Customer"/>'s userame.</param>
      /// <param name="psswrd"><seealso cref="string"/> representing the 
      ///   <seealso cref="Customer"/>'s password.</param>
      public Customer(string newFirstName, string newLastName, string usrnm,
         string psswrd) : base(newFirstName, newLastName, usrnm, psswrd)
      {
         isBlacklisted = false;
         fee = 0;
      }

      /// <summary>
      /// Gives a <seealso cref="string"/> for <seealso cref="Admin"/>s
      ///   to view the <seealso cref="Customer"/>'s information.
      /// </summary>
      /// <returns>A <seealso cref="string"/> containing the information
      ///   valuable to an <seealso cref="Admin"/></returns>
      public override string ToString()
      {
         if (isBlacklisted)
            return $"{FirstName} {LastName} ({Username}): blacklisted";
         return $"{FirstName} {LastName} ({Username}): not blacklisted";
      }
   }
}