using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// A <seealso cref="Purchase"/> is created by a <seealso cref="Customer"/>
   ///   when they elect to buy a <seealso cref="Vehicle"/>.
   /// </summary>
   public class Purchase : DBObject
   {
      private int purchaseNo; // Actually used by DBObject Framework
      private DateTime purchaseDate;
      private int cost;
      private string pickUpLocation;
      private Customer customer;
      private Vehicle vehicle;

      /// <summary>
      /// Is able to get the <seealso cref="Purchase"/>'s ID but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int PurchaseNo
      {
         get { return purchaseNo; }
      }

      /// <summary>
      /// The date of the <seealso cref="Purchase"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public DateTime PurchaseDate
      {
         get { return purchaseDate; }
         set { purchaseDate = value; }
      }

      /// <summary>
      /// The ID of the <seealso cref="Customer"/> associated with the
      /// <seealso cref="Purchase"/> can be viewed and is set by the database.
      /// </summary>
      [SchemaField()]
      public int CustomerID
      {
         get { return customer.PrimaryKey; }
         set { customer = DBController.GetByPrimaryKey<Customer>(value); }
      }

      /// <summary>
      /// The ID of the <seealso cref="Vehicle"/> associated with the 
      /// <seealso cref="Purchase"/> can be viewed and is set by the database.
      /// </summary>
      [SchemaField()]
      public int VehicleID
      {
         get { return vehicle.PrimaryKey; }
         set { vehicle = DBController.GetByPrimaryKey<Vehicle>(value); }
      }

      /// <summary>
      /// The <seealso cref="Purchase"/>'s location can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Location
      {
         get { return pickUpLocation; }
         set { pickUpLocation = value; }
      }

      /// <summary>
      /// The <seealso cref="Purchase"/>'s cost can be viewed or set.
      /// </summary>
      [SchemaField()]
      public int Cost
      {
         get { return cost; }
         set { cost = value; }
      }

      /// <summary>
      /// Default constructor for a <seealso cref="Purchase"/> object.
      /// </summary>
      public Purchase()
      {
         purchaseDate = new DateTime(2001, 1, 1);
         pickUpLocation = "DEFAULT";
      }

      /// <summary>
      /// Parameterized constructor for an object of type
      /// <seealso cref="Purchase"/>.
      /// </summary>
      /// <param name="setStartDate"><seealso cref="DateTime"/> representing
      ///   the date of the <seealso cref="Purchase"/>.</param>
      /// <param name="setStartLocation"><seealso cref="string"/> representing
      ///   the location of the <seealso cref="Purchase"/>.</param>
      /// <param name="setVehicle">The <seealso cref="Vehicle"/> that is being
      ///   <seealso cref="Purchase"/>d</param>
      /// <param name="setCustomer">The <seealso cref="Customer"/> that is
      ///   making the <seealso cref="Purchase"/>.</param>
      public Purchase(DateTime setStartDate, string setStartLocation,
         Vehicle setVehicle, Customer setCustomer)
      {
         purchaseDate = setStartDate;
         pickUpLocation = setStartLocation;
         customer = setCustomer;
         vehicle = setVehicle;
      }
   }
}