using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;

namespace CarRentalSystemTest
{
   [TestClass]
   public class PurchaseTest
   {
      [TestMethod]
      public void TestPurchase()
      {
         Purchase p = new Purchase();
         var pType = p.GetType();
         Assert.IsInstanceOfType(p, pType);
      }

      [TestMethod]
      public void TestPurchaseParam()
      {
         Vehicle v = new Vehicle();
         Customer c = new Customer();
         DateTime date = new DateTime(2018, 3, 1);
         Purchase p = new Purchase(date, "test", v, c);
         Assert.AreEqual(p.PurchaseDate, date);
      }
   }
}
