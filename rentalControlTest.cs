using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using System.Collections.Generic;
using AccessAssistant;
using System.Linq;

namespace CarRentalSystemTest
{
   [TestClass]
   public class RentalControlTest
   {

      [TestMethod]
      public void AddRentalTest()
      {
         List<string> nameslist = new List<string>();
         Vehicle v1 = new Vehicle("car", "blue", 123, "100", "s", false, false, 15, "Madison");
         DBController.Save(v1, DBObject.SaveTypes.Insert);
         Customer c1 = new Customer("John", "Doe", "username", "password");
         DBController.Save(c1, DBObject.SaveTypes.Insert);
         DateTime startDate = new DateTime(2018, 1, 1);
         DateTime endDate = new DateTime(2018, 1, 2);
         Rental r1 = new Rental(startDate, endDate, "Platteville", "Madison", v1, c1, "");
         RentalControl.AddRental(r1);
         Rental r2 = DBController.GetByPrimaryKey<Rental>(r1.PrimaryKey);
         Assert.AreEqual(r1.PrimaryKey, r2.PrimaryKey);
      }

      [TestMethod]
      public void CompleteRentalTest()
      {
         List<string> nameslist = new List<string>();
         Vehicle v1 = new Vehicle("car", "blue", 123, "100", "s", false, false, 15, "Platteville");
         DBController.Save(v1, DBObject.SaveTypes.Insert);
         Customer c1 = new Customer("John", "Doe", "username", "password");
         DBController.Save(c1, DBObject.SaveTypes.Insert);
         DateTime startDate = new DateTime(2018, 1, 1);
         DateTime endDate = new DateTime(2018, 1, 2);
         Rental r1 = new Rental(startDate, endDate, "Platteville", "Madison", v1, c1, "");
         RentalControl.AddRental(r1);
         Assert.IsTrue(r1.Active);
         RentalControl.CompleteRental(r1);
         Rental r2 = DBController.GetByPrimaryKey<Rental>(r1.PrimaryKey);
         Assert.IsFalse(r2.Active);
      }

      [TestMethod]
      public void DetermineCostTest()
      {
         Rental r1 = DBController.GetAllRecords<Rental>().FirstOrDefault();
         Vehicle v1 = DBController.GetByPrimaryKey<Vehicle>(r1.VehicleID);
         int vehicleRate = v1.Rate;
         int vehicleDate = r1.EndDate.DayOfYear - r1.StartDate.DayOfYear;
         int acc = RentalControl.AccessoryFee(r1, false, false);
         int amountT = vehicleRate * (vehicleDate + 1) + acc;
         RentalControl.DetermineCost(r1, false, false);
         double amount = r1.Cost;
         Assert.AreEqual(amount, amountT);
      }

      [TestMethod]
      public void ListOfVehicleRental()
      {
         Vehicle v = new Vehicle("t", "c", 1, "m", "m2", true, true, 100, "here");
         List<Rental> vehicleRentals = RentalControl.returnaAllRentals();
      }
   }
}
