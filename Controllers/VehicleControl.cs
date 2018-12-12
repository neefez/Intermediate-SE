//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lyu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This is vehicle control class. It control the entity vehicle.
//---------------------------------------------------------------------
using CarRentalSystem.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AccessAssistant;
using CarRentalSystem.Commands;

namespace CarRentalSystem.Controllers
{
   /// <summary>
   /// this class controls the vehicle
   /// </summary>
   public static class VehicleControl
   {
      public static int PURCHASE_RATE = 100;

      /// <summary>
      /// add vehicle to the database
      /// </summary>
      /// <param name="v"></param>
      public static void AddVehicle(Vehicle v)
      {
         CommandHistory.ExecuteCommand(new AddCarCommand(v));
      }

      /// <summary>
      /// find vehicle in the database through vehicle's id
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public static Vehicle FindVehicle(string id)
      {
         int numID = Convert.ToInt32(id);
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => 
                                  vehicle.VehicleID == numID).FirstOrDefault();
         return v;
      }

      /// <summary>
      /// display useful car information of the vehicle
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public static List<string> DisplayCarInfo(string id)
      {
         Vehicle v = FindVehicle(id);
         string carType = v.Type.ToString();
         string carColor = v.Color.ToString();
         string carYear = v.VehicleYear.ToString();
         string carModel = v.Model.ToString();
         string carMake = v.Make.ToString();
         bool rightHandControl = v.RightHandControlled;
         bool manualTransmission = v.ManualTransmission;
         string rate = v.Rate.ToString();
         List<string> list = new List<string>() { carType, carColor, carYear,
                                                  carModel, carMake,
                  rightHandControl.ToString(), manualTransmission.ToString() };
         return list;
      }

      /// <summary>
      /// remove vehicle in the database
      /// </summary>
      /// <param name="v"></param>
      /// <returns></returns>
      public static bool RemoveVehicle(Vehicle v)
      {
         List<Rental> lr = RentalControl.returnaAllRentals().Where(rental => 
                           rental.VehicleID == v.VehicleID).ToList();
         foreach (Rental item in lr)
            DBController.Delete(item);
         List<VehicleIssue> lvi = 
            DBController.GetAllRecords<VehicleIssue>().Where(vehicleIssue =>
            vehicleIssue.VehicleID == v.VehicleID).ToList();
         foreach (VehicleIssue item in lvi)
            DBController.Delete(item);
         return DBController.Delete(v);
      }

      /// <summary>
      /// modify vehicle in the database
      /// </summary>
      /// <param name="v"></param>
      /// <returns></returns>
      public static bool ModifyVehicle(Vehicle v)
      {
         return DBController.Save(v, DBObject.SaveTypes.Update);
      }

      /// <summary>
      /// form a vehicle list, get all the vehicle in the database
      /// </summary>
      /// <returns></returns>
      public static List<Vehicle> GetAllVehicles()
      {
         List<Vehicle> v = DBController.GetAllRecords<Vehicle>();
         return v;
      }

      /// <summary>
      /// form a vehicle list, get all the vehicle which is not rented.
      /// </summary>
      /// <returns></returns>
      public static List<Vehicle> PreliminaryFilter()
      {
         List<Vehicle> lv = GetAllVehicles();
         lv = lv.Where(vehicle => !vehicle.IsRented).ToList();
         return lv;
      }

      /// <summary>
      /// filter car by all the components
      /// </summary>
      /// <param name="carType"></param>
      /// <param name="carColor"></param>
      /// <param name="makeType"></param>
      /// <param name="carYearFirst"></param>
      /// <param name="carYearSecond"></param>
      /// <param name="rightHand"></param>
      /// <param name="manual"></param>
      /// <param name="location"></param>
      /// <param name="pickUp"></param>
      /// <param name="dropOff"></param>
      /// <returns></returns>
      public static List<Vehicle> FilterCar(string carType, string carColor,
         string makeType, int carYearFirst, int carYearSecond, bool rightHand,
         bool manual, string location, DateTime pickUp, DateTime dropOff)
      {
         bool isRent = true;
         bool isPurchased = true;
         List<Vehicle> lv = PreliminaryFilter();
         List<Vehicle> lv2 = GetAllVehicles().Where(vehicle => 
            vehicle.IsRented).ToList();
         List<Rental> lr = RentalControl.returnaAllRentals().ToList();
         List<Purchase> lp = DBController.GetAllRecords<Purchase>().ToList();
         foreach (Vehicle vitem in lv2)
         {
            List<Rental> lr2 = lr.Where(rental => rental.Active && 
               rental.VehicleID == vitem.VehicleID).ToList();
            foreach (Rental ritem in lr2)
            {
               if (!((pickUp.Date < ritem.StartDate.Date && 
                      dropOff.Date < ritem.StartDate.Date) || 
                     (pickUp.Date > ritem.EndDate.Date && 
                      dropOff.Date > ritem.EndDate.Date)))
                  isRent = false;
            }
            Purchase purchaseCheck = lp.Where(purchase => 
               purchase.VehicleID == vitem.VehicleID).FirstOrDefault();
            isPurchased = (purchaseCheck == null);
            if (isRent && isPurchased)
               lv.Add(vitem);
            purchaseCheck = null;
         }
         if (carType != null && carType != "None")
            lv = lv.Where(vehicle => vehicle.Type == carType).ToList();
         if (carColor != null && carColor != "None")
            lv = lv.Where(vehicle => vehicle.Color == carColor).ToList();
         if (makeType != null && makeType != "None")
            lv = lv.Where(vehicle => vehicle.Make == makeType).ToList();
         if (location != null && location != "None")
            lv = lv.Where(vehicle => 
                 vehicle.CurrentLocation == location).ToList();
         lv = lv.Where(vehicle => vehicle.VehicleYear >= carYearFirst && 
            vehicle.VehicleYear <= carYearSecond && 
            vehicle.RightHandControlled == rightHand && 
            vehicle.ManualTransmission == manual).ToList();

         return lv;
      }

      /// <summary>
      /// determine the price of the vehicle.
      /// </summary>
      /// <param name="v"></param>
      /// <returns></returns>
      public static int DeterminePrice(Vehicle v)
      {
         return v.Rate * PURCHASE_RATE;
      }
   }
}