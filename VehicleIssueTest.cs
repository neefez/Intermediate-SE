using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;

namespace CarRentalSystemTest
{
   [TestClass]
   public class VehicleIssueTest
   {
      [TestMethod]
      public void IssueDefault()
      {
         VehicleIssue vi1 = new VehicleIssue();
         var type = vi1.GetType();
         Assert.IsInstanceOfType(vi1, type);
      }

      [TestMethod]
      public void CreateIssue()
      {
         DateTime issueDate= new DateTime(2018, 1, 1);
         string Issue = "The car broke down and won't start!";
         Vehicle v1 = new Vehicle();
         VehicleIssue vi1 = new VehicleIssue(issueDate, Issue, v1);
         Assert.AreEqual(vi1.IssueDate, issueDate);
         Assert.AreEqual(vi1.Issue, Issue);
         Assert.AreEqual(vi1.VehicleID, v1.VehicleID);
      }

      [TestMethod]
      public void IssueToString()
      {
         DateTime issueDate = new DateTime(2018, 1, 1);
         Vehicle v = new Vehicle();
         VehicleIssue vi = new VehicleIssue(issueDate, "test", v);
         Assert.AreEqual("Report #0", vi.ToString());
      }
   }
}
