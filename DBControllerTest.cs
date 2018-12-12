using System;
using System.Collections.Generic;
using AccessAssistant;
using CarRentalSystem.DBObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccessAssistantTest
{
   [TestClass]
   public class DBControllerTest
   {
      [TestMethod]
      public void TestSave()
      {
         // Testing Inserting into empty table
         /*foreach (Admin adminInDB in DBController.GetAllRecords<Admin>())
            DBController.Delete(adminInDB);
         Admin brandNewSoloAdmin = new Admin("f", "l", "u", "p");
         DBController.Save(brandNewSoloAdmin, DBObject.SaveTypes.Insert);*/

         // Testing Insert
         Admin adminToInsert = new Admin("fName", "lName", "uName", "pWord");
         DBController.Save(adminToInsert, DBObject.SaveTypes.Insert);
         Admin insertedInsertAdmin = DBController.GetByPrimaryKey<Admin>(adminToInsert.PrimaryKey);
         Assert.AreEqual(adminToInsert.PrimaryKey, insertedInsertAdmin.PrimaryKey);

         // Testing Update
         Admin adminToUpdate = new Admin("fNameUpdate", "lNameUpdate", "uNameUpdate", "pWordUpdate");
         DBController.Save(adminToUpdate, DBObject.SaveTypes.Insert);
         Admin insertedUpdateAdmin = DBController.GetByPrimaryKey<Admin>(adminToUpdate.PrimaryKey);
         Assert.AreEqual(adminToUpdate.PrimaryKey, insertedUpdateAdmin.PrimaryKey);
         adminToUpdate.FirstName = "brandNewFNameUpdate";
         Assert.AreNotEqual(adminToUpdate.FirstName, insertedUpdateAdmin.FirstName);
         DBController.Save(adminToUpdate, DBObject.SaveTypes.Update);
         Admin updatedInsertAdmin = DBController.GetByPrimaryKey<Admin>(adminToUpdate.PrimaryKey);
         Assert.AreEqual(adminToUpdate.FirstName, updatedInsertAdmin.FirstName);

      }

      [TestMethod]
      public void TestDelete()
      {
         Admin adminToDelete = new Admin("fNameDelete", "lNameDelete", "uNameDelete", "pWordDelete");
         DBController.Save(adminToDelete, DBObject.SaveTypes.Insert);
         Admin insertedAdmin = DBController.GetByPrimaryKey<Admin>(adminToDelete.PrimaryKey);
         Assert.AreEqual(adminToDelete.PrimaryKey, insertedAdmin.PrimaryKey);

         DBController.Delete(adminToDelete);
         Admin deletedAdmin = DBController.GetByPrimaryKey<Admin>(adminToDelete.PrimaryKey);
         Assert.IsNull(deletedAdmin);

      }

      [TestMethod]
      public void TestGetAllRecords()
      {
         List<Admin> adminListPreInsert = DBController.GetAllRecords<Admin>();
         int countPreInsert = adminListPreInsert.Count;
         Admin adminToInsert = new Admin("fName", "lName", "uName", "pWord");
         DBController.Save(adminToInsert, DBObject.SaveTypes.Insert);

         List<Admin> adminListPostInsert = DBController.GetAllRecords<Admin>();
         int countPostInsert = adminListPostInsert.Count;
         Assert.AreEqual(countPreInsert, adminListPostInsert.Count - 1);
      }

      [TestMethod]
      public void TestGetByPrimaryKey()
      {
         Admin adminToInsert = new Admin("fName", "lName", "uName", "pWord");
         DBController.Save(adminToInsert, DBObject.SaveTypes.Insert);
         Admin insertedAdmin = DBController.GetByPrimaryKey<Admin>(adminToInsert.PrimaryKey);
         Assert.AreEqual(adminToInsert.PrimaryKey, insertedAdmin.PrimaryKey);
      }
   }
}
