//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This file manages the history of the commands executed in
//          the application and also handles the undo/redo.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace CarRentalSystem.Commands
{

   public delegate void StackChangedHandler();

   /// <summary>
   /// This class defines the CommandHistory of all commands processed by
   /// the application.
   /// </summary>
   public static class CommandHistory
   {
      private static Stack<ICommand> undoStack = new Stack<ICommand>();
      private static Stack<ICommand> redoStack = new Stack<ICommand>();

      public static event StackChangedHandler StackChangedEvent;

      public enum StackTypes { UNDO, REDO }

      /// <summary>
      /// This method performs the actual execution of the 
      /// <paramref name="commandToExecute"/>, clears the redo stack, pushes 
      /// the <paramref name="commandToExecute"/> onto the undo stack, and
      /// then invokes the StackChangedEvent if it has any handlers subscribed
      /// to it.
      /// </summary>
      /// <param name="commandToExecute"></param>
      public static void ExecuteCommand(ICommand commandToExecute)
      {
         commandToExecute.Execute();
         redoStack.Clear();
         undoStack.Push(commandToExecute);
         StackChangedEvent?.Invoke();
      }

      /// <summary>
      /// Performs an undo on the top-most <seealso cref="ICommand"/>, pushes 
      /// it to the redo stack, and invokes the StackChangedEvent if it has
      /// any handlers subscribed to it.
      /// </summary>
      public static void Undo()
      {
         ICommand commandToUndo = undoStack.Pop();
         commandToUndo.Unexecute();
         redoStack.Push(commandToUndo);
         StackChangedEvent?.Invoke();
      }

      /// <summary>
      /// Performs a redo on the top-most <seealso cref="ICommand"/>, pushes
      /// it to the undo stack, and invokes the StackChangedEvent if it has
      /// any handlers subscribed to it.
      /// </summary>
      public static void Redo()
      {
         ICommand commandToRedo = redoStack.Pop();
         commandToRedo.Execute();
         undoStack.Push(commandToRedo);
         StackChangedEvent?.Invoke();
      }

      /// <summary>
      /// Gets the top-most element in the specified <paramref name="stackType"/>.
      /// </summary>
      /// <param name="stackType">Type of the stack to peek in.</param>
      /// <returns>Top-most element in the specified 
      /// <seealso cref="stackType"/>.</returns>
      public static ICommand PeekInStack(StackTypes stackType)
      {
         Stack<ICommand> stackToPeekIn = GetStack(stackType);
         return stackToPeekIn.Count == 0 ? null : stackToPeekIn.Peek();
      }

      /// <summary>
      /// Gets the stack associated with the specified 
      /// <paramref name="stackType"/>.
      /// </summary>
      /// <param name="stackType">Type of the stack to return.</param>
      /// <returns>The stack associated with the specified 
      /// <paramref name="stackType"/>.</returns>
      private static Stack<ICommand> GetStack(StackTypes stackType)
      {
         switch (stackType)
         {
            case StackTypes.UNDO:
               return undoStack;
            case StackTypes.REDO:
               return redoStack;
            default:
               throw new NotImplementedException(
                  $"The stackType argument {stackType} is not associated with a stack.");
         }
      }

   }
}