using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// A <seealso cref="User"/> is an abstract class that is inherited in
   ///   order to create specific types of <seealso cref="User"/>s.
   /// </summary>
   public abstract class User : DBObject
   {
      private string firstName;
      private string lastName;
      private string username;
      private string password;

      /// <summary>
      /// The <seealso cref="User"/>'s first name can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string FirstName
      {
         get { return firstName; }
         set { firstName = value; }
      }

      /// <summary>
      /// The <seealso cref="User"/>'s last name can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string LastName
      {
         get { return lastName; }
         set { lastName = value; }
      }

      /// <summary>
      /// The <seealso cref="User"/>'s username can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Username
      {
         get { return username; }
         set { username = value; }
      }

      /// <summary>
      /// The <seealso cref="User"/>'s password can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Password
      {
         get { return password; }
         set { password = value; }
      }

      /// <summary>
      /// Default '[empty]' constructor needed for objects
      ///   of type <seealso cref="User"/>.
      /// </summary>
      public User() { }

      /// <summary>
      /// Parameterized constructor for a <seealso cref="User"/> object.
      /// </summary>
      /// <param name="newFirstName"><seealso cref="string"/> representing the
      ///   <seealso cref="User"/>'s first name.</param>
      /// <param name="newLastName"><seealso cref="string"/> representing the
      ///   <seealso cref="User"/>'s last name.</param>
      /// <param name="usrnm"><seealso cref="string"/> representing the
      ///   <seealso cref="User"/>'s userame.</param>
      /// <param name="psswrd"><seealso cref="string"/> representing the
      ///   <seealso cref="User"/>'s password.</param>
      public User(string newFirstName, string newLastName, string usrnm,
         string psswrd)
      {
         firstName = newFirstName;
         LastName = newLastName;
         password = psswrd;
         username = usrnm;
      }
   }
}