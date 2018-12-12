using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;

namespace CarRentalSystemTest
{
   [TestClass]
   public class UserTest
   {
      [TestMethod]
      public void TestFirstName()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         Assert.AreEqual(firstName, c1.FirstName);
      }

      [TestMethod]
      public void TestLastName()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         Assert.AreEqual(lastName, c1.LastName);
      }

      [TestMethod]
      public void TestUsername()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         Assert.AreEqual(username, c1.Username);
      }

      [TestMethod]
      public void TestPassword()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         Assert.AreEqual(password, c1.Password);
      }
   }
}
