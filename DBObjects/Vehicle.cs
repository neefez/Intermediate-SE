using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// An object of type <seealso cref="Vehicle"/> can be rented or purchased
   ///   by a <seealso cref="Customer"/> and is managed by 
   ///   <seealso cref="Admin"/>s.
   /// </summary>
   public class Vehicle : DBObject
   {
      private int vehicleID; // Actually used by DBObject Framework
      private string type;
      private string color;
      private string make;
      private string model;
      private string currentLocation;
      private int year;
      private bool isRightHandControlled;
      private bool isManualTransmission;
      private bool isDamaged;
      private bool isRented;
      private int rate;

      #region VehicleProperties

      /// <summary>
      /// Is able to get the <seealso cref="Vehicle"/> ID, but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int VehicleID
      {
         get { return vehicleID; }
      }

      /// <summary>
      /// The type of <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Type
      {
         get { return type; }
         set { type = value; }
      }

      /// <summary>
      /// The color of the <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Color
      {
         get { return color; }
         set { color = value; }
      }

      /// <summary>
      /// The make of the <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Make
      {
         get { return make; }
         set { make = value; }
      }

      /// <summary>
      /// The <seealso cref="Vehicle"/> model can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string Model
      {
         get { return model; }
         set { model = value; }
      }

      /// <summary>
      /// The model year of the <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public int VehicleYear
      {
         get { return year; }
         set { year = value; }
      }

      /// <summary>
      /// The damage state of the <seealso cref="Vehicle"/> can be
      ///   viewed or set.
      /// </summary>
      [SchemaField()]
      public bool IsDamaged
      {
         get { return isDamaged; }
         set { isDamaged = value; }
      }

      /// <summary>
      /// The rental state of the <seealso cref="Vehicle"/> can be 
      ///   viewed or set.
      /// </summary>
      [SchemaField()]
      public bool IsRented
      {
         get { return isRented; }
         set { isRented = value; }
      }

      /// <summary>
      /// The daily cost of the <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public int Rate
      {
         get { return rate; }
         set { rate = value; }
      }

      /// <summary>
      /// The control type of the <seealso cref="Vehicle"/> can be 
      ///   viewed or set.
      /// </summary>
      [SchemaField()]
      public bool RightHandControlled
      {
         get { return isRightHandControlled; }
         set { isRightHandControlled = value; }
      }

      /// <summary>
      /// The transmission type of the <seealso cref="Vehicle"/> can be 
      ///   viewed or set.
      /// </summary>
      [SchemaField()]
      public bool ManualTransmission
      {
         get { return isManualTransmission; }
         set { isManualTransmission = value; }
      }

      /// <summary>
      /// The location of the <seealso cref="Vehicle"/> can be viewed or set.
      /// </summary>
      [SchemaField()]
      public string CurrentLocation
      {
         get { return currentLocation; }
         set { currentLocation = value; }
      }
      #endregion

      /// <summary>
      /// Default constructor for <seealso cref="Vehicle"/> objects needed
      ///   for selecting all records.
      /// </summary>
      public Vehicle()
      {
         type = "DEFAULT";
         color = "DEFAULT";
         make = "DEFAULT";
         model = "DEFAULT";
         year = 0;
         currentLocation = "DEFAULT";
         isRightHandControlled = false;
         isManualTransmission = false;
         isDamaged = false;
         isRented = false;
         rate = 0;
      }

      /// <summary>
      /// Parameterized constructor for a <seealso cref="Vehicle"/> object.
      /// </summary>
      /// <param name="carType"><seealso cref="string"/> representing the 
      ///   type of the <seealso cref="Vehicle"/>.</param>
      /// <param name="carColor"><seealso cref="string"/> representing the 
      ///   color of the <seealso cref="Vehicle"/>.</param>
      /// <param name="carYear"><seealso cref="int"/> representing the 
      ///   model year of the <seealso cref="Vehicle"/>.</param>
      /// <param name="carModel"><seealso cref="string"/> representing the 
      ///   <seealso cref="Vehicle"/> model.</param>
      /// <param name="carMake"><seealso cref="string"/> representing the 
      ///   make of the <seealso cref="Vehicle"/>.</param>
      /// <param name="rightHandControl"><seealso cref="bool"/> signifying that
      ///   the <seealso cref="Vehicle"/> has controls on the 
      ///   right-hand side.</param>
      /// <param name="manualTrans"><seealso cref="bool"/> signifying that the
      ///   <seealso cref="Vehicle"/> has a manual transmission system.</param>
      /// <param name="carRate"><seealso cref="int"/> representing the 
      ///   price per day of the <seealso cref="Vehicle"/>.</param>
      /// <param name="curntLocation"><seealso cref="string"/> representing the
      ///   location of the <seealso cref="Vehicle"/>.</param>
      public Vehicle(string carType, string carColor, int carYear,
         string carModel, string carMake, bool rightHandControl,
         bool manualTrans, int carRate, string curntLocation)
      {
         type = carType;
         color = carColor;
         make = carMake;
         model = carModel;
         year = carYear;
         currentLocation = curntLocation;
         isRightHandControlled = rightHandControl;
         isManualTransmission = manualTrans;
         isDamaged = false;
         isRented = false;
         rate = carRate;
      }

      /// <summary>
      /// Gives a <seealso cref="string"/> for <seealso cref="User"/>s to view
      ///   the <seealso cref="Vehicle"/>'s information.
      /// </summary>
      /// <returns>A <seealso cref="string"/> containing the information 
      ///   valuable to an <seealso cref="User"/></returns>
      public override string ToString()
      {
         return $"{VehicleYear} {Color} {Make} {Model} {Type} ${Rate}/day";
      }
   }
}