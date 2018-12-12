using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;

namespace CarRentalSystemTest
{
   [TestClass]
   public class RentalTest
   {
      [TestMethod]
      public void RentalCostTest()
      {
         int days = 10;
         Vehicle v = new Vehicle();
         Customer c = new Customer();
         DateTime date1 = new DateTime(2018, 3, 1);
         DateTime date2 = new DateTime(2018, 3, 11);
         Rental r = new Rental(date1, date2, "here", "there", v, c, "");
         days = date2.Day - date1.Day;
         Assert.AreEqual(r.Cost, v.Rate * days);
      }

      [TestMethod]
      public void RentalDefaultTest()
      {
         Rental r = new Rental();
         var rType = r.GetType();
         Assert.IsInstanceOfType(r, rType);
      }

      [TestMethod]
      public void RentalConstructorTest()
      {
         int days = 10;
         Vehicle v = new Vehicle();
         Customer c = new Customer();
         DateTime date1 = new DateTime(2018, 3, 1);
         DateTime date2 = new DateTime(2018, 3, 11);
         Rental r = new Rental(date1, date2, "test", "test", v, c, "");
         days = date2.Day - date1.Day;
         Assert.AreEqual(r.StartDate, date1);
         Assert.AreEqual(r.EndDate, date2);
         Assert.AreEqual(r.Cost, v.Rate * days);
      }

      [TestMethod]
      public void RentalfeeAnt()
      {
         Rental r = new Rental();
         r.Cost = 100;
         Assert.IsNotNull(r.feeAmt);
      }
   }
}