using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using System.Collections.Generic;


namespace CarRentalSystemTest
{
   [TestClass]
   public class CustomerTest
   {
      [TestMethod]
      public void TestCustomerID()
      {
         Customer c = new Customer("test", "test", "test", "test");
         Assert.AreEqual(c.CustomerID, 0);
      }

      [TestMethod]
      public void TestIsBlackList()
      {
         Customer c = new Customer("test", "test", "test", "test");
         Assert.IsFalse(c.IsBlacklisted);
         c.IsBlacklisted = true;
         Assert.IsTrue(c.IsBlacklisted);
      }

      [TestMethod]
      public void TestFee()
      {
         Customer c = new Customer("test", "test", "test", "test");
         Assert.AreEqual(c.Fee, 0);
      }

      [TestMethod]
      public void TestCustomer()
      {
         Customer c = new Customer();
         var cType = c.GetType();
         Assert.IsInstanceOfType(c, cType);
      }

      [TestMethod]
      public void TestCustomerParam()
      {
         string f = "f";
         string l = "l";
         string u = "u";
         string p = "p";
         Customer c = new Customer(f, l, u, p);
         Assert.AreEqual(c.FirstName, f);
         Assert.AreEqual(c.LastName, l);
         Assert.AreEqual(c.Username, u);
         Assert.AreEqual(c.Password, p);
         Assert.IsFalse(c.IsBlacklisted);
      }

      [TestMethod]
      public void TestToString()
      {
         Customer c1 = new Customer("test", "test", "test", "test");
         Customer c2 = new Customer("test", "test", "test", "test");
         c1.IsBlacklisted = true;
         c2.IsBlacklisted = false;
         Assert.AreEqual("test test (test): blacklisted", c1.ToString());
         Assert.AreEqual("test test (test): not blacklisted", c2.ToString());

      }
   }
}
