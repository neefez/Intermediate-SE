//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lyn, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This class is to maintain rental in the database.
//------------------------------------------------------------------------
using System;
using System.Linq;
using AccessAssistant;
using CarRentalSystem.DBObjects;
using System.Collections.Generic;

namespace CarRentalSystem.Controllers
{
   /// <summary>
   /// Handles <seealso cref="Rental"/> objects.
   /// </summary>
   public static class RentalControl
   {
      private static int numRentedOut = 0;
      private static int totalRentals = 0;
      public const int FEES = 50;

      public static DateTime StartDate { get; set; }
      public static DateTime EndDate { get; set; }
      public static string PickUpLocation { get; set; }
      public static string DropOffLocation { get; set; }
      public static Vehicle SelectedVehicle { get; set; }
      public static string Comment { get; set; }

      /// <summary>
      /// add rental in the database, return true if it is added, otherwise
      /// return false.
      /// </summary>
      /// <param name="r"></param>
      /// <returns></returns>
      public static bool AddRental(Rental r)
      {
         List<Rental> r1 = DBController.GetAllRecords<Rental>().Where(rental =>
            rental.CustomerID == r.CustomerID).ToList();
         bool noneActive = true;
         foreach(Rental item in r1)
         {
            if (item.Active)
               noneActive = false;
         }
         if (r1 == null || noneActive)
         {
            r.Active = true;
            Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle =>
               vehicle.VehicleID == r.VehicleID).FirstOrDefault();
            v.IsRented = true;
            DBController.Save(r, DBObject.SaveTypes.Insert);
            VehicleControl.ModifyVehicle(v);
            return true;
         }
         return false;
      }

      /// <summary>
      /// set rental is active in the database.
      /// </summary>
      /// <param name="r"></param>
      public static void CompleteRental(Rental r)
      {
         r.Active = false;
         DBController.Save(r, DBObject.SaveTypes.Update);
      }

      /// <summary>
      /// Determine the cost of the rental, if there is babyseat of navigation
      /// system then add the additional cost to the rental.
      /// </summary>
      /// <param name="r"></param>
      /// <param name="babySeat"></param>
      /// <param name="navigationSystem"></param>
      public static void DetermineCost(Rental r, bool babySeat, 
                                       bool navigationSystem)
      {
         int vehicleId = r.VehicleID;
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle =>
            vehicle.VehicleID == vehicleId).FirstOrDefault();
         int vehicleRate = v.Rate;
         int rentDate = r.EndDate.DayOfYear - r.StartDate.DayOfYear + 1;
         int accFee = AccessoryFee(r, babySeat, navigationSystem);
         int totalCost = vehicleRate * rentDate + accFee;
         Customer c = DBController.GetAllRecords<Customer>().Where(customer =>
            customer.CustomerID == r.CustomerID).FirstOrDefault();
         totalCost += c.Fee;
         r.Cost = totalCost;
      }

      /// <summary>
      /// find rental in the database.
      /// </summary>
      /// <returns></returns>
      public static Rental findRental()
      {
         Customer c1 = (Customer)UserControl.CurrentUser;
         Rental r1 = DBController.GetAllRecords<Rental>().Where(rental => 
            rental.CustomerID == c1.CustomerID && 
            rental.Active).FirstOrDefault();
         return r1;
      }

      /// <summary>
      /// determine the accessory fees of a rental.
      /// </summary>
      /// <param name="r"></param>
      /// <param name="baby"></param>
      /// <param name="satnav"></param>
      /// <returns></returns>
      public static int AccessoryFee(Rental r, bool baby, bool satnav)
      {
         int amount = 0;
         if (baby)
            amount += FEES;
         if (satnav)
            amount += FEES;
         r.feeAmt = amount;
         return amount;
      }

      /// <summary>
      /// return a list of all the rentals in the database.
      /// </summary>
      /// <returns></returns>
      public static List<Rental> returnaAllRentals()
      {
         List<Rental> rl = DBController.GetAllRecords<Rental>();
         return rl;
      }
   }
}