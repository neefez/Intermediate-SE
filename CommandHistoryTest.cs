using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using CarRentalSystem.Commands;
using AccessAssistant;


namespace CarRentalSystemTest
{
   [TestClass]
   public class CommandHistoryTest
   {
      [TestMethod]
      public void CommandHistoryRedoTest()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         CommandHistory.ExecuteCommand(aD);
         CommandHistory.Undo();
         CommandHistory.Redo();
         Assert.IsNotNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.UNDO));
         Assert.IsNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.REDO));
         CommandHistory.Undo();
      }

      [TestMethod]
      public void CommandHistoryUndoTest()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         CommandHistory.ExecuteCommand(aD);
         CommandHistory.Undo();
         Assert.IsNotNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.REDO));
         Assert.IsNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.UNDO));
      }

      [TestMethod]
      public void ExecuteTest()
      {
         Vehicle v = new Vehicle();
         AddCarCommand aD = new AddCarCommand(v);
         CommandHistory.ExecuteCommand(aD);
         Assert.IsNotNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.UNDO));
         Assert.IsNull(CommandHistory.PeekInStack(CommandHistory.StackTypes.REDO));
      }
   }
}
