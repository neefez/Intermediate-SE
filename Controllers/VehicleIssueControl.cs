//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This is the vehicle issue control class, it controls the
// vehicle issue and send them to the database.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.DBObjects;
using AccessAssistant;

namespace CarRentalSystem.Controllers
{
   public static class VehicleIssueControl
   {
      /// <summary>
      /// The method will use the VehicleIssue Object, and insert the
      /// VehicleIssue into the table, as well as update the vehicle 
      /// attribute, isDamaged to signify the car is in need of repair
      /// </summary>
      /// <param name="vI"></param>
      /// <returns></returns>
      public static bool AddIssue(VehicleIssue vI)
      {
         try
         {
            Vehicle v1 = VehicleControl.FindVehicle(vI.VehicleID.ToString());
            v1.IsDamaged = true;
            DBController.Save(vI, DBObject.SaveTypes.Insert);
            DBController.Save(v1, DBObject.SaveTypes.Update);
         }
         catch (Exception e)
         {
            return false;
         }
         return true;
      }


      /// <summary>
      /// The Fix method will update the vehicle in questions isDamaged
      /// to represent the car is fixed, and update the issue as being 
      /// fixed.
      /// </summary>
      /// <param name="vi"></param>
      public static void Fix(VehicleIssue vi)
      {
         Vehicle v1 = VehicleControl.FindVehicle(vi.VehicleID.ToString());
         v1.IsDamaged = false;
         vi.IsFixed = true;
         DBController.Save(vi, DBObject.SaveTypes.Update);
         DBController.Save(v1, DBObject.SaveTypes.Update);
      }

      /// <summary>
      /// The Deny method will remove the issue if the issue is deemed
      /// invalid, and return the cars state to not damaged
      /// </summary>
      /// <param name="vi"></param>
      public static void Deny(VehicleIssue vi)
      {
         Vehicle v1 = VehicleControl.FindVehicle(vi.VehicleID.ToString());
         v1.IsDamaged = false;
         DBController.Delete(vi);
         DBController.Save(v1, DBObject.SaveTypes.Update);
      }
   }
}
