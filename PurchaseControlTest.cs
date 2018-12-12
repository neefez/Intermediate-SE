using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using AccessAssistant;
using CarRentalSystem.Controllers;
using System.Linq;

namespace CarRentalSystemTest
{
   [TestClass]
   public class PurchaseControlTest
   {
      [TestMethod]
      public void PurchaseControlDataTest()
      {
         string location = "here";
         DateTime dateEx = new DateTime(2001, 1, 1);
         Vehicle purchasedV = VehicleControl.GetAllVehicles().FirstOrDefault();
         PurchaseControl.PickUpLocation = "here";
         PurchaseControl.StartDate = dateEx;
         PurchaseControl.SelectedVehicle = purchasedV;
         Assert.AreEqual(PurchaseControl.PickUpLocation, location);
         Assert.AreEqual(PurchaseControl.SelectedVehicle, purchasedV);
         Assert.AreEqual(PurchaseControl.StartDate, dateEx);
      }

      [TestMethod]
      public void AddPurchaseTest()
      {
         Vehicle v = new Vehicle("type", "color", 100, "model", "make", true, true, 10, "here");
         DBController.Save(v, DBObject.SaveTypes.Insert);
         DateTime startDate1 = new DateTime(2018, 1, 1);
         DateTime endDate1 = new DateTime(2018, 1, 2);
         Vehicle v2 = VehicleControl.FilterCar("type", "color", "make", 99, 101, true, true, "here", startDate1, endDate1).FirstOrDefault();
         Assert.IsNotNull(v2);
         Customer c1 = new Customer("John", "Doe", "username", "password");
         DBController.Save(c1, DBObject.SaveTypes.Insert);
         DateTime startDate = new DateTime(2018, 1, 1);
         DateTime endDate = new DateTime(2018, 1, 2);
         Purchase p1 = new Purchase(startDate, "here", v2, c1);
         PurchaseControl.AddPurchase(p1);
         Vehicle v3 = VehicleControl.FilterCar("type", "color", "make", 99, 101, true, true, "here", startDate, endDate).FirstOrDefault();
         Assert.IsNull(v3);
         Vehicle v4 = VehicleControl.GetAllVehicles().Where(vehicle => vehicle.VehicleID == p1.VehicleID).FirstOrDefault();
         Assert.IsTrue(v4.IsRented);
      }

      [TestMethod]
      public void DeterminePurchaseCostTest()
      {
         Purchase p1 = DBController.GetAllRecords<Purchase>().FirstOrDefault();
         Vehicle v1 = DBController.GetByPrimaryKey<Vehicle>(p1.VehicleID);
         int vehicleRate = v1.Rate;
         int amountT = vehicleRate * 100;
         PurchaseControl.DeterminePurchaseCost(p1);
         double amount = p1.Cost;
         Assert.AreEqual(amount, amountT);
      }

      [TestMethod]
      public void FindPurchaseTest()
      {
         Vehicle v1 = new Vehicle();
         VehicleControl.AddVehicle(v1);
         int key = v1.PrimaryKey;
         Purchase p1 = PurchaseControl.FindPurchase(key);
         Assert.IsNull(p1);
         p1 = new Purchase();
         p1.VehicleID = key;
         Customer c1 = DBController.GetAllRecords<Customer>().FirstOrDefault();
         p1.CustomerID = c1.PrimaryKey;
         PurchaseControl.AddPurchase(p1);
         Purchase p2 = PurchaseControl.FindPurchase(key);
         Assert.IsNotNull(p2);
      }
   }
}
