//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This interface declares what an ICommand must implement.
//---------------------------------------------------------------------

namespace CarRentalSystem.Commands
{
   /// <summary>
   /// Declares the interface for a command which will serve the purpose of
   /// acting as the abstract class for the command pattern.
   /// </summary>
   public interface ICommand
   {

      string CommandName { get; }

      /// <summary>
      /// Declares the execution of a command.
      /// </summary>
      void Execute();

      /// <summary>
      /// Declares the unexecution of a command.
      /// </summary>
      void Unexecute();
   }
}