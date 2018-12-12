using System;
using System.Collections.Generic;
using CarRentalSystem.DBObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccessAssistant;

namespace CarRentalSystemTest
{
   [TestClass]
   public class DBObjectTest
   {
      [TestMethod]
      public void TestSave()
      {
         // TODO: Write code for update next release
         Admin testAdmin = new Admin("Joe", "Schmoe", "myUname", "myPword");
         DBController.Save(testAdmin, DBObject.SaveTypes.Insert);
         Admin testAdmin2 = DBController.GetByPrimaryKey<Admin>(testAdmin.PrimaryKey);
         Assert.AreEqual(testAdmin.PrimaryKey, testAdmin2.PrimaryKey);
      }

      // TODO: Write unit test for Delete method

      [TestMethod]
      public void TestGetByPrimaryKey()
      {
         int existingPrimaryKey = 3;
         Admin testAdmin = DBController.GetByPrimaryKey<Admin>(existingPrimaryKey);
         Assert.IsNotNull(testAdmin);
      }

      [TestMethod]
      public void TestGetAllRecords()
      {
         List<Admin> adminList = new List<Admin>();
         Assert.IsTrue(adminList.Count == 0);
         adminList = DBController.GetAllRecords<Admin>();
         Assert.IsTrue(adminList.Count != 0);
      }
   }
}
