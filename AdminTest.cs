using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;

namespace CarRentalSystemTest
{
   [TestClass]
   public class AdminTest
   {
      [TestMethod]
      public void TestAdminID()
      {
         Admin a = new Admin("test", "test", "test", "test");
         Assert.AreEqual(a.AdminID, 0);
      }

      [TestMethod]
      public void TestAdmin()
      {
         Admin a = new Admin();
         var aType = a.GetType();
         Assert.IsInstanceOfType(a, aType);
      }

      [TestMethod]
      public void TestAdminParam()
      {
         string f = "f";
         string l = "l";
         string u = "u";
         string p = "p";
         Admin a = new Admin(f, l, u, p);
         Assert.AreEqual(a.FirstName, f);
         Assert.AreEqual(a.LastName, l);
         Assert.AreEqual(a.Username, u);
         Assert.AreEqual(a.Password, p);
      }
   }
}
