using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CarRentalSystem.Controllers;
using CarRentalSystem.DBObjects;
using AccessAssistant;
using System;
namespace CarRentalSystemTest
{
   [TestClass]
   public class VehicleControlTest
   {
      [TestMethod]
      public void AddVehicleTest()
      {
         Vehicle v1 = new Vehicle("1", "Blue", 2018, "2", "3", false, false, 10, "Madison");
         VehicleControl.AddVehicle(v1);
         Vehicle v2 = DBController.GetByPrimaryKey<Vehicle>(v1.PrimaryKey);
         Assert.IsNotNull(v2);
      }

      [TestMethod]
      public void FindVehicleTest()
      {
         string id = "1";
         Vehicle v = VehicleControl.FindVehicle(id);
         Vehicle v2 = new Vehicle("test", "test", 1, "test", "test", false, false, 1, "Madison");
         Assert.AreEqual(v2.Make, v.Make);
         Assert.AreEqual(v.Model, v2.Model);
         Assert.AreEqual(v.VehicleYear, v2.VehicleYear);
         Assert.AreEqual(v.Color, v2.Color);
      }

      [TestMethod]
      public void DisplayCarInfoTest()
      {
         string id = "1";
         Vehicle v2 = new Vehicle("DEFAULT", "DEFAULT", 0, "DEFAULT", "DEFAULT", false, false, 0, "Madison");
         List<string> features = VehicleControl.DisplayCarInfo(id);
         Assert.AreEqual(v2.PrimaryKey, v2.PrimaryKey);
      }

      [TestMethod]
      public void RemoveVehicleTest()
      {
         Vehicle v = new Vehicle();
         DBController.Save(v, DBObject.SaveTypes.Insert);
         VehicleControl.RemoveVehicle(v);
         Vehicle v2 = DBController.GetByPrimaryKey<Vehicle>(v.PrimaryKey);
         Assert.IsNull(v2);
      }

      [TestMethod]
      public void ModifyCarTest()
      {
         Vehicle v = new Vehicle();
         DBController.Save(v, DBObject.SaveTypes.Insert);
         v.Color = "chartreuse";
         VehicleControl.ModifyVehicle(v);
         Vehicle v2 = VehicleControl.GetAllVehicles().Where(car => car.Color == "chartreuse").FirstOrDefault();
         Assert.IsNotNull(v2);
         Assert.AreEqual(v2.Color, "chartreuse");
         if (v2.Color == "chartreuse")
            DBController.Delete(v);
      }

      [TestMethod]
      public void FilterCarTest()
      {
         Vehicle v = VehicleControl.GetAllVehicles().FirstOrDefault();
         Vehicle vR = VehicleControl.GetAllVehicles().Where(vehicle => vehicle.IsRented).FirstOrDefault();
         string cartype = v.Type;
         string carcolor = v.Color;
         string carmake = v.Make;
         int caryear1 = 0;
         int caryear2 = 2019;
         DateTime startDate = new DateTime(2018, 1, 1);
         DateTime endDate = new DateTime(2018, 1, 2);
         DateTime startDate2 = new DateTime(2018, 5, 1);
         DateTime endDate2 = new DateTime(2018, 5, 2);
         List<Vehicle> lv = VehicleControl.FilterCar(vR.Type, vR.Color, vR.Make, vR.VehicleYear, vR.VehicleYear, vR.RightHandControlled, vR.ManualTransmission, vR.CurrentLocation, startDate2, endDate2);
         Assert.IsNotNull(lv);
         lv = VehicleControl.FilterCar(cartype, carcolor, carmake, caryear1, caryear2, false, false, "Madison", startDate, endDate);
         Assert.IsNotNull(lv);
         Vehicle v2 = lv.Where(car => car.Type == cartype && car.Color == carcolor && car.VehicleYear >= caryear1 && car.VehicleYear <= caryear2).FirstOrDefault();
         Assert.IsNotNull(v2);
         lv = VehicleControl.FilterCar(null, null, null, 1900, 2020, false, false, null, startDate, endDate);
         Assert.IsNotNull(lv);
      }

      [TestMethod]
      public void DeterminePriceTest()
      {
         Vehicle v = new Vehicle("t", "c", 1, "m", "m2", false, false, 50, "m");
         int price = VehicleControl.DeterminePrice(v);
         Assert.AreEqual(price, v.Rate * 100);
      }

      [TestMethod]
      public void PreliminaryFilterTest()
      {
         List<Vehicle> lv = VehicleControl.PreliminaryFilter();
         foreach(Vehicle item in lv)
         {
            Assert.IsFalse(item.IsRented);
         }
      }
   }
}
