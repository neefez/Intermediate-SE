using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessAssistant;

namespace CarRentalSystem.DBObjects
{
   /// <summary>
   /// A <seealso cref="VehicleIssue"/> is a report associated with a
   ///   <seealso cref="Vehicle"/> detailing an issue the 
   ///   <seealso cref="Customer"/> has reported.
   /// </summary>
   public class VehicleIssue : DBObject
   {
      private int issueID;
      private string issue;
      private DateTime issueDate;
      private Vehicle vehicle;
      private bool isFixed;

      /// <summary>
      /// Is able to get the ID of the <seealso cref="VehicleIssue"/>, 
      ///   but not set it.
      /// </summary>
      [SchemaField(IsPrimaryKey = true)]
      public int IssueID
      {
         get { return issueID; }
      }

      /// <summary>
      /// The <seealso cref="VehicleIssue"/>'s date of entry 
      ///   can be viewed or set.
      /// </summary>
      [SchemaField()]
      public DateTime IssueDate
      {
         get { return issueDate; }
         set { issueDate = value; }
      }

      /// <summary>
      /// The <seealso cref="VehicleIssue"/> details can be viewed or set.
      /// </summary>
      [SchemaField()]
      public String Issue
      {
         get { return issue; }
         set { issue = value; }
      }

      /// <summary>
      /// The ID of the <seealso cref="Vehicle"/> associated with the 
      ///   <seealso cref="VehicleIssue"/> can be viewed and is set by
      ///   the database.
      /// </summary>
      [SchemaField()]
      public int VehicleID
      {
         get { return vehicle.PrimaryKey; }
         set { vehicle = DBController.GetByPrimaryKey<Vehicle>(value); }
      }

      /// <summary>
      /// The damage state of the <seealso cref="VehicleIssue"/> can be 
      ///   viewed or set.
      /// </summary>
      [SchemaField()]
      public bool IsFixed
      {
         get { return isFixed; }
         set { isFixed = value; }
      }

      /// <summary>
      /// Default constructor for <seealso cref="VehicleIssue"/> objects.
      ///   Needed for selecting all records.
      /// </summary>
      public VehicleIssue() { }

      /// <summary>
      /// Parameterized constructor for an object of type 
      ///   <seealso cref="VehicleIssue"/>.
      /// </summary>
      /// <param name="date"><seealso cref="DateTime"/> representing the
      ///   date the <seealso cref="VehicleIssue"/> was reported.</param>
      /// <param name="problem"><seealso cref="string"/> containing the
      ///   details of the <seealso cref="VehicleIssue"/>.</param>
      /// <param name="v1">The <seealso cref="Vehicle"/> which is having the 
      ///   <seealso cref="VehicleIssue"/>.</param>
      public VehicleIssue(DateTime date, string problem, Vehicle v1)
      {
         issueDate = date;
         issue = problem;
         vehicle = v1;
         isFixed = false;
      }

      /// <summary>
      /// Gives a <seealso cref="string"/> for an <seealso cref="Admin"/>
      ///   to view the ID of the <seealso cref="VehicleIssue"/>.
      /// </summary>
      /// <returns>A <seealso cref="string"/> containing the ID of the 
      ///   <seealso cref="VehicleIssue"/></returns>
      public override string ToString()
      {
         return $"Report #{IssueID}";
      }
   }
}