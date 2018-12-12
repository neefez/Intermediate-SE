using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;
using System.Linq;

namespace CarRentalSystemTest
{
   [TestClass]
   public class VehicleIssueControlTest
   {
      [TestMethod]
      public void AddVehicleIssue()
      {
         DateTime issueDate = new DateTime(2018, 1, 1);
         string Issue = "The car broke down and won't start!";
         Vehicle v1 = new Vehicle();
         VehicleIssue vI1 = new VehicleIssue(issueDate, Issue, v1);
         VehicleIssueControl.AddIssue(vI1);
         VehicleIssue vI2 = DBController.GetByPrimaryKey<VehicleIssue>(vI1.PrimaryKey);
         Assert.AreEqual(vI1.PrimaryKey, vI2.PrimaryKey);
      }

      [TestMethod]
      public void FixTest()
      {
         DateTime issueDate = new DateTime(2018, 1, 1);
         string Issue = "The car broke down and won't start!";
         Vehicle v1 = VehicleControl.GetAllVehicles().FirstOrDefault();
         VehicleIssue vI1 = new VehicleIssue(issueDate, Issue, v1);
         Assert.IsFalse(vI1.IsFixed);
         VehicleIssueControl.Fix(vI1);
         Assert.IsTrue(vI1.IsFixed);
      }

      [TestMethod]
      public void DenyTest()
      {
         DateTime issueDate = new DateTime(2018, 1, 1);
         string Issue = "The car broke down and won't start!";
         Vehicle v1 = VehicleControl.GetAllVehicles().FirstOrDefault();
         VehicleIssue vI1 = new VehicleIssue(issueDate, Issue, v1);
         VehicleIssueControl.AddIssue(vI1);
         VehicleIssue vI2 = DBController.GetByPrimaryKey<VehicleIssue>(vI1.PrimaryKey);
         Assert.AreEqual(vI1.PrimaryKey, vI2.PrimaryKey);
         VehicleIssueControl.Deny(vI1);
         VehicleIssue vI3 = DBController.GetByPrimaryKey<VehicleIssue>(vI1.PrimaryKey);
         Assert.IsNull(vI3);
      }
   }
}
