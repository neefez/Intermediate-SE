using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using CarRentalSystem.Commands;
using AccessAssistant;

namespace CarRentalSystemTest
{
   [TestClass]
   public class AddCarCommandTest
   {
      [TestMethod]
      public void AddCarCommand()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         var aType = aD.GetType();
         Assert.IsInstanceOfType(aD, aType);
      }

      [TestMethod]
      public void ExecuteTest()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         aD.Execute();
         Vehicle v2 = DBController.GetByPrimaryKey<Vehicle>(v.PrimaryKey);
         Assert.IsNotNull(v2);
      }

      [TestMethod]
      public void UnexecuteTest()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         aD.Execute();
         Vehicle v2 = DBController.GetByPrimaryKey<Vehicle>(v.PrimaryKey);
         aD.Unexecute();
         v2 = DBController.GetByPrimaryKey<Vehicle>(v.PrimaryKey);
         Assert.IsNull(v2);
      }

      [TestMethod]
      public void GetCommandNameTest()
      {
         Vehicle vehicle = new Vehicle();
         AddCarCommand addCarCmd = new AddCarCommand(vehicle);
         string commandName = addCarCmd.CommandName;
         Assert.AreEqual(commandName, addCarCmd.CommandName);
      }
   }
}
