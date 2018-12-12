using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.Controllers;
using CarRentalSystem.DBObjects;
using AccessAssistant;
using System.Linq;

namespace CarRentalSystemTest
{
   [TestClass]
   public class UserControlTest
   {
      [TestMethod]
      public void AddCustomerTest()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         UserControl.AddCustomer(c1);
         Assert.AreEqual(c1.FirstName, UserControl.FindUser(c1.Username).FirstName);
      }

      [TestMethod]
      public void BlacklistTest()
      {
         Customer c = new Customer();
         UserControl.Blacklist(c);
         Assert.IsTrue(c.IsBlacklisted);
      }

      [TestMethod]
      public void FindUserTest()
      {
         string firstName = "James";
         string lastName = "Bane";
         string username = "carGuy";
         string adminUser = "carGuru";
         string password = "password";
         Customer c1 = new Customer(firstName, lastName, username, password);
         Customer c2 = (Customer)UserControl.FindUser(username);
         Assert.AreEqual(c1.Username, c2.Username);
         Admin a1 = new Admin(firstName, lastName, adminUser, password);
         Admin a2 = (Admin)UserControl.FindUser(adminUser);
         Assert.AreEqual(a1.Username, a2.Username);
      }

      [TestMethod]
      public void AddAdminTest()
      {
         string firstName = "John";
         string lastName = "Bane";
         string username = "carGuru";
         string password = "password";
         Admin a1 = new Admin(firstName, lastName, username, password);
         UserControl.AddAdmin(a1);
         Assert.AreEqual(a1.FirstName, UserControl.FindUser(a1.Username).FirstName);
      }

      [TestMethod]
      public void ApplyFeeTest()
      {
         Customer c1 = UserControl.GetAllCustomer().FirstOrDefault();
         int feeIni = c1.Fee;
         int feeFin = 10;
         int feeTot = feeIni + feeFin;
         UserControl.ApplyFee(c1, feeFin);
         Assert.AreEqual(c1.Fee, feeTot);
      }

      [TestMethod]
      public void RemoveFeeTest()
      {
         Customer c1 = UserControl.GetAllCustomer().FirstOrDefault();
         UserControl.ApplyFee(c1, 10);
         Assert.AreNotEqual(c1.Fee, 0);
         UserControl.RemoveFee(c1);
         Assert.AreEqual(c1.Fee, 0);
      }

      [TestMethod]
      public void FindCustomerTest()
      {
         Customer c1 = UserControl.GetAllCustomer().FirstOrDefault();
         Customer c2 = UserControl.FindCustomer(c1.Username);
         Assert.AreEqual(c1.Username, c2.Username);
      }

      [TestMethod]
      public void CustomerBlacklistTest()
      {
         Customer c1 = UserControl.GetAllCustomer().FirstOrDefault();
         UserControl.Blacklist(c1);
         Assert.AreEqual(c1.IsBlacklisted, true);
         UserControl.NotBlacklist(c1);
         Assert.AreEqual(c1.IsBlacklisted, false);
      }

      [TestMethod]
      public void GetSetCurrentUserTest()
      {
         Customer c1 = UserControl.GetAllCustomer().FirstOrDefault();
         UserControl.CurrentUser = c1;
         Assert.AreEqual(UserControl.CurrentUser, c1);
         Customer c2 = (Customer)UserControl.CurrentUser;
         Assert.AreEqual(c1, UserControl.CurrentUser);
      }
   }
}
