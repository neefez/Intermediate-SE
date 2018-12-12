using System;
using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// A <seealso cref="Rental"/> is created by a <seealso cref="Customer"/> 
   ///   after they choose a <seealso cref="Vehicle"/> to rent.
   /// </summary>
   public class Rental : DBObject
   {
      private int rentalNo; // Actually used by DBObject Framework
      private DateTime startDate;
      private DateTime endDate;
      private int cost;
      private string pickUpLocation;
      private string dropOffLocation;
      private Customer customer;
      private Vehicle vehicle;
      public int feeAmt { get; set; }
      private const int BABYSEATAMOUNT = 50;
      private const int NAVIGATIONSYSTEMAMOUNT = 100;
      private bool active;
      private string comment;

      /// <summary>
      /// Is able to get the <seealso cref="Rental"/>'s ID but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int RentalNo
      {
         get { return rentalNo; }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s pickup date can be viewed or set.
      /// </summary>
      [SchemaField()]
      public DateTime StartDate
      {
         get { return startDate; }
         set { startDate = value; }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s dropoff date can be viewed or set.
      /// </summary>
      [SchemaField()]
      public DateTime EndDate
      {
         get { return endDate; }
         set { endDate = value; }
      }

      /// <summary>
      /// The ID of the <seealso cref="Customer"/> associated with the 
      /// <seealso cref="Rental"/> can be viewed and is set by the database.
      /// </summary>
      [SchemaField()]
      public int CustomerID
      {
         get { return customer.PrimaryKey; }
         set { customer = DBController.GetByPrimaryKey<Customer>(value); }
      }

      /// <summary>
      /// The ID of the <seealso cref="Vehicle"/> associated with the 
      /// <seealso cref="Rental"/> can be viewed and is set by the database.
      /// </summary>
      [SchemaField()]
      public int VehicleID
      {
         get { return vehicle.PrimaryKey; }
         set { vehicle = DBController.GetByPrimaryKey<Vehicle>(value); }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s pickup location can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string PickUpLocation
      {
         get { return pickUpLocation; }
         set { pickUpLocation = value; }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s dropoff location can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string DropOffLocation
      {
         get { return dropOffLocation; }
         set { dropOffLocation = value; }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s cost can be viewed or set.
      /// </summary>
      [SchemaField()]
      public int Cost
      {
         get { return cost; }
         set { cost = value; }
      }

      /// <summary>
      /// The state of activity of the <seealso cref="Rental"/> can be
      /// viewed or set.
      /// </summary>
      [SchemaField()]
      public bool Active
      {
         get { return active; }
         set { active = value; }
      }

      /// <summary>
      /// The <seealso cref="Rental"/>'s comment can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Comment
      {
         get { return comment; }
         set { comment = value; }
      }

      /// <summary>
      /// Default constructor for an object of type <seealso cref="Rental"/>.
      /// </summary>
      public Rental() { }

      /// <summary>
      /// Parameterized constructor for a <seealso cref="Rental"/> object.
      /// </summary>
      /// <param name="setStartDate"><seealso cref="DateTime"/> representing
      ///   the date of pickup for the <seealso cref="Rental"/>.</param>
      /// <param name="setEndDate"><seealso cref="DateTime"/> representing
      ///   the date of dropoff for the <seealso cref="Rental"/>.</param>
      /// <param name="setStartLocation"><seealso cref="string"/> representing
      ///   the pickup location of the <seealso cref="Rental"/>.</param>
      /// <param name="setEndLocation"><seealso cref="string"/> representing
      ///   the dropoff location of the <seealso cref="Rental"/>.</param>
      /// <param name="setVehicle">The <seealso cref="Vehicle"/> that is being
      ///   rented for the given <seealso cref="Rental"/>.</param>
      /// <param name="setCustomer">The <seealso cref="Customer"/> that is 
      ///   making the <seealso cref="Rental"/>.</param>
      /// <param name="setComment">A <seealso cref="string"/> that can be
      ///   filled with a complaint by an <seealso cref="Admin"/>.</param>
      public Rental(DateTime setStartDate, DateTime setEndDate,
         string setStartLocation, string setEndLocation, Vehicle setVehicle,
         Customer setCustomer, string setComment)
      {
         startDate = setStartDate;
         endDate = setEndDate;
         pickUpLocation = setStartLocation;
         dropOffLocation = setEndLocation;
         customer = setCustomer;
         vehicle = setVehicle;
         active = false;
         comment = setComment;
      }
   }
}