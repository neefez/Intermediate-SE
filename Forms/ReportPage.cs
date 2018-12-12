//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This form will display the users rental number and give them 
//          a text box to fill with information on what issue has occured.
//---------------------------------------------------------------------
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using System;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// The ReportPage class holds the rental information of the current user.
   /// this information is used to fill out a report.
   /// </summary>
   public partial class ReportPage : Form
   {
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;
      Rental r1 = RentalControl.findRental();

      /// <summary>
      /// The constructor will center the form in the middle of the window.
      /// </summary>
      public ReportPage()
      {
         InitializeComponent();
         reportPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET - 
            reportPanel.Size.Width / CENTER_OFFSET,
            ClientSize.Height / CENTER_OFFSET - 
            reportPanel.Size.Height / CENTER_OFFSET);
            if (r1 != null)
                rentalID.Text = r1.PrimaryKey.ToString();
            else
            {
                sendButton.Enabled = false;
                noRentalLabel.Visible = true;
            }
      }

      /// <summary>
      /// The sendButton once pressed will generate and send a vehicle issue
      /// to the database. 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void sendButton_Click(object sender, System.EventArgs e)
      {
         Vehicle v1 = VehicleControl.FindVehicle(r1.VehicleID.ToString());
         DateTime issueDate = problemDate.Value.Date;
         string Issue = descriptionTextBox.Text;
         try
         {
            VehicleIssue vehicleIssue = new VehicleIssue(issueDate.Date, Issue, v1);
            if(VehicleIssueControl.AddIssue(vehicleIssue))
            {
               messageLabel.Text = "The report has been sent. Thank you for your patience.";
               descriptionTextBox.Clear();
               messageLabel.Visible = true;
            }
         }
         catch(Exception)
         {

         }
      }
   }
}
