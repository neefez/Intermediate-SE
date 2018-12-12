//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This file specifies a concrete implementation of an
//          ICommand in the form of an AddCarCommand.
//---------------------------------------------------------------------

using AccessAssistant;
using CarRentalSystem.DBObjects;

namespace CarRentalSystem.Commands
{
   /// <summary>
   /// This class defines an add car command that implements the ICommand 
   /// interface.
   /// </summary>
   public class AddCarCommand : ICommand
   {

      private Vehicle vehicleToAdd;

      public string CommandName => "Add Car to System";

      /// <summary>
      /// Creates an instance of an <seealso cref="AddCarCommand"/>.
      /// </summary>
      /// <param name="vehicle"><seealso cref="Vehicle"/> to add to the 
      /// database.</param>
      public AddCarCommand(Vehicle vehicle)
      {
         vehicleToAdd = vehicle;
      }

      /// <summary>
      /// Defines the execution of the <seealso cref="AddCarCommand"/> by
      /// actually saving a car to the database.
      /// </summary>
      public void Execute()
      {
         DBController.Save(vehicleToAdd, DBObject.SaveTypes.Insert);
      }

      /// <summary>
      /// Defines the unexecution of the <seealso cref="AddCarCommand"/> by
      /// deleting a car from the database.
      /// </summary>
      public void Unexecute()
      {
         DBController.Delete(vehicleToAdd);
      }

   }
}