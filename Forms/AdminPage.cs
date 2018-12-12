//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This is the Form that will work on adding a vehicle to the system
//---------------------------------------------------------------------
using CarRentalSystem.Commands;
using CarRentalSystem.Controllers;
using CarRentalSystem.DBObjects;
using FormAssistant;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// This Admin Page focuses on adding a car to the databse with the proper
   /// information with it.
   /// </summary>
   public partial class AdminPage : Form
   {
      private const string VEHICLE_ADDED_MESSAGE = 
                                             "Vehicle was successfully added.";
      private const string VEHICLE_NOT_ADDED_MESSAGE =
                                                      "Vehicle was not added.";
      private const string VEHICLE_REMOVED_MESSAGE = 
                                           "Vehicle was successfully removed.";
      private const string FORM_NOT_FILLED_MESSAGE = 
                                                 "Please fill out all fields.";
      private const int BAR_OFF_SET = 34;
      private const int TIMER = 1000;
      private const int WAIT_TIME = 3;
      private const int DEFAULT_RATE = 100;
      private const int CENTER_OFFSET = 2;

      private Stopwatch stopWatch = new Stopwatch();              
      //The Stopwatch will help in reseting the information on the form
      private Timer confirmationMessageTimer = new Timer();       
      //The message timer will reset the confirmationmessage in the form.

      /// <summary>
      /// The Contructor will set up the panel with the timers values being set
      /// </summary>
      public AdminPage()
      {
         InitializeComponent();
         addPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET
            - addPanel.Size.Width / CENTER_OFFSET,
            (ClientSize.Height / CENTER_OFFSET
            - addPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);

         confirmationMessageTimer.Tick += TimeToHideConfirmationMessage;
         confirmationMessageTimer.Interval = TIMER;
      }

      /// <summary>
      /// AddVehicle button will take the information entered on the form and
      /// create a vehicle representation in the database.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnAddVehicle_Click(object sender, EventArgs e)
      {
         if (carColorCB.SelectedItem == null || carTypeCB.SelectedItem == null
             || carMakeCB.SelectedItem == null || carModelCB.Text == ""
             || carLocationCB.SelectedItem == null)
         {
            SetAndDisplayResponseMessage(FORM_NOT_FILLED_MESSAGE);
         }
         else
         {
            string type = carTypeCB.SelectedItem.ToString();
            string color = carColorCB.SelectedItem.ToString();
            int year = (Int32)carYearCB.Value;
            string model = carModelCB.Text.ToString();
            string carMake = carMakeCB.SelectedItem.ToString();
            string carlocation = carLocationCB.SelectedItem.ToString();
            bool rightHand = rightHandCheck.Checked;
            bool manual = manualCheck.Checked;
            int rate = (Int32)rateBox.Value;
            Vehicle v = new Vehicle(type, color, year, model, carMake,
                                    rightHand, manual, rate, carlocation);
            VehicleControl.AddVehicle(v);

            if (VehicleWasAdded(v.PrimaryKey))
               SetAndDisplayResponseMessage(VEHICLE_ADDED_MESSAGE);
            else
               SetAndDisplayResponseMessage(VEHICLE_NOT_ADDED_MESSAGE);
            ResetForm();
         }
      }

      /// <summary>
      /// The SetAndDisplayResponseMessage method will take the information 
      /// from the addvehicle method and present the proper message to the
      /// user. If the form isnt fully filled the user will be notified.
      /// </summary>
      /// <param name="responseMessage"></param>
      private void SetAndDisplayResponseMessage(string responseMessage)
      {
         lblResponseMessage.Text = responseMessage;
         switch (responseMessage)
         {
            case VEHICLE_ADDED_MESSAGE:
               lblResponseMessage.ForeColor = Color.Green;
               break;
            case VEHICLE_NOT_ADDED_MESSAGE:
               lblResponseMessage.ForeColor = Color.Crimson;
               break;
            case VEHICLE_REMOVED_MESSAGE:
               lblResponseMessage.ForeColor = Color.Green;
               break;
            case FORM_NOT_FILLED_MESSAGE:
               lblResponseMessage.ForeColor = Color.Red;
               break;
         }
         lblResponseMessage.Visible = true;
         confirmationMessageTimer.Start();
         stopWatch.Start();
      }

      /// <summary>
      /// VehiclewasAdded method will confirm if the vehicle could be added
      /// to the database.
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      private bool VehicleWasAdded(int id)
      {
         Vehicle v1 = VehicleControl.FindVehicle(id.ToString());
         string vehicleID = v1.PrimaryKey.ToString();
         return id.ToString() == vehicleID;
      }

      /// <summary>
      /// The ResetForm method is called once the stopwatch finishes,
      /// and will clean up the form information.
      /// </summary>
      private void ResetForm()
      {
         carTypeCB.SelectedIndex = -1;
         carColorCB.SelectedIndex = -1;
         carMakeCB.SelectedIndex = -1;
         carLocationCB.SelectedIndex = -1;
         carYearCB.Value = DateTime.Now.Year;
         carModelCB.Clear();
         rateBox.Value = DEFAULT_RATE;
         rightHandCheck.Checked = false;
         manualCheck.Checked = false;
      }

      /// <summary>
      /// The TimeToHideConfirmationMessage method will watch the stopwatch
      /// and once 3 seconds have passed, the message will be removed from
      /// the users screen.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void TimeToHideConfirmationMessage(object sender, EventArgs e)
      {
         if (stopWatch.Elapsed.Seconds == WAIT_TIME)
         {
            lblResponseMessage.Visible = false;
            stopWatch.Stop();
            stopWatch.Reset();
            confirmationMessageTimer.Stop();
         }
      }
   }
}
