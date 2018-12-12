using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;

namespace CarRentalSystemTest
{
   [TestClass]
   public class VehicleTest
   {
      [TestMethod]
      public void defaultVehicle()
      {
         Vehicle v = new Vehicle();
         var vType = v.GetType();
         Assert.IsInstanceOfType(v, vType);
      }

      [TestMethod]
      public void VehicleConstructor()
      {
         string type = "Vehicle";
         string color = "test";
         string make = "test";
         string model = "test";
         int year = 0;
         bool isRightHandControlled = false;
         bool isManualTransmission = false;
         int rate = 1;
         Vehicle v = new Vehicle(type, color, year, model, make, isRightHandControlled, isManualTransmission, rate, "test");
         Assert.AreEqual(v.Type, type);
         Assert.AreEqual(v.Color, color);
         Assert.AreEqual(v.VehicleYear, year);
         Assert.AreEqual(v.Model, model);
         Assert.AreEqual(v.RightHandControlled, isRightHandControlled);
         Assert.AreEqual(v.ManualTransmission, isManualTransmission);
         Assert.AreEqual(v.Rate, rate);
      }

      [TestMethod]
      public void VehicleToString()
      {
         Vehicle v = new Vehicle("test", "test", 1, "test", "test", false, false, 1, "test");
         Assert.AreEqual("1 test test test test $1/day", v.ToString());
      }
   }
}