//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lyu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This class is to determine purchases of a car.
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.DBObjects;
using AccessAssistant;

namespace CarRentalSystem.Controllers
{
   /// <summary>
   /// Maintain <seealso cref="Purchase"/>, get and set purchase order.
   /// </summary>
   public class PurchaseControl
   {
      public static int PURCHASE_RATE = 100;
      public static DateTime StartDate { get; set; }
      public static string PickUpLocation { get; set; }
      public static Vehicle SelectedVehicle { get; set; }

      /// <summary>
      /// add purchase in the database.
      /// </summary>
      /// <param name="p"></param>
      public static void AddPurchase(Purchase p)
      {
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle =>
            vehicle.VehicleID == p.VehicleID).FirstOrDefault();
         v.IsRented = true;
         DeterminePurchaseCost(p);
         DBController.Save(p, DBObject.SaveTypes.Insert);
         VehicleControl.ModifyVehicle(v);
      }

      /// <summary>
      /// add purchase and determine the cost of each vehicle
      /// </summary>
      /// <param name="p"></param>
      public static void DeterminePurchaseCost(Purchase p)
      {
         int vehicleId = p.VehicleID;
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle =>
            vehicle.VehicleID == vehicleId).FirstOrDefault();
         int totalCost = VehicleControl.DeterminePrice(v);
         p.Cost = totalCost;
      }

      /// <summary>
      /// add vehicle Id to find each purchase in the database
      /// </summary>
      /// <param name="vID"></param>
      /// <returns></returns>
      public static Purchase FindPurchase(int vID)
      {
         return DBController.GetAllRecords<Purchase>().Where(purchase =>
            purchase.VehicleID == vID).FirstOrDefault();
      }
   }
}
