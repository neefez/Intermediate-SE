//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lyu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This class is user control class. This class controls the 
// entity of user class.
//------------------------------------------------------------------------
using CarRentalSystem.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AccessAssistant;

namespace CarRentalSystem.Controllers
{
   /// <summary>
   /// This class controls the <seealso cref="User"/> objects.
   /// </summary>
   public static class UserControl
   {
      private static int numCustomer;

      public static User CurrentUser { get; set; }

      /// <summary>
      /// add customer to the database
      /// </summary>
      /// <param name="c"></param>
      public static void AddCustomer(Customer c)
      {
         DBController.Save(c, DBObject.SaveTypes.Insert);
      }

      /// <summary>
      /// set a customer to the blacklist
      /// </summary>
      /// <param name="c"></param>
      public static void Blacklist(Customer c)
      {
         c.IsBlacklisted = true;
      }

      /// <summary>
      /// set a customer not in the blacklist
      /// </summary>
      /// <param name="c"></param>
      public static void NotBlacklist(Customer c)
      {
         c.IsBlacklisted = false;
      }

      /// <summary>
      /// find the user in the database, return the user
      /// </summary>
      /// <param name="user"></param>
      /// <returns></returns>
      public static User FindUser(string user)
      {
         Customer c = DBController.GetAllRecords<Customer>().Where(cust => 
            cust.Username == user).FirstOrDefault();
         if (c != null)
            return c;
         Admin a = DBController.GetAllRecords<Admin>().Where(admin => 
            admin.Username == user).FirstOrDefault();
         return a;
      }

      /// <summary>
      /// find the customer in the database, return the customer
      /// </summary>
      /// <param name="customer"></param>
      /// <returns></returns>
      public static Customer FindCustomer(string customer)
      {
         Customer c = DBController.GetAllRecords<Customer>().Where(cust => 
            cust.Username == customer).FirstOrDefault();
         return c;
      }

      /// <summary>
      /// add admin in the database
      /// </summary>
      /// <param name="a"></param>
      public static void AddAdmin(Admin a)
      {
         DBController.Save(a, DBObject.SaveTypes.Insert);
      }

      /// <summary>
      /// get the list of all customer
      /// </summary>
      /// <returns></returns>
      public static List<Customer> GetAllCustomer()
      {
         List<Customer> c = DBController.GetAllRecords<Customer>();
         return c;
      }


      /// <summary>
      /// apply fees to a customer
      /// </summary>
      /// <param name="c"></param>
      /// <param name="amount"></param>
      public static void ApplyFee(Customer c, int amount)
      {
         c.Fee += amount;
         DBController.Save(c, DBObject.SaveTypes.Update);
      }

      /// <summary>
      /// remove the customer's fee
      /// </summary>
      /// <param name="c"></param>
      public static void RemoveFee(Customer c)
      {
         c.Fee = 0;
         DBController.Save(c, DBObject.SaveTypes.Update);
      }
   }
}
