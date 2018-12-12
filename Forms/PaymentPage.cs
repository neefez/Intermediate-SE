//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: The purpose of this form is to display the rental information 
//          to the user, and for final acceptance of rental.
//---------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;
using System.Collections.Generic;
using FormAssistant;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// The private class has severeal variables, Stings for errors, an object
   /// for rental, the vehicle for the rental, and the customer for the rental. 
   /// </summary>
   public partial class PaymentPage : Form
   {
      private const string PMT_ERROR_USER_IN_RENTAL = "Sorry, you must return your other car before you rent this one.";
      private const string PMT_ERROR_INVALID_CUS = "Sorry, there was an error in processing your order.";
      private Rental _rentalToPayFor;
      private Vehicle _vehicleOfRental;
      private Customer _customerOfRental;
      private Dictionary<ComboBox, Label> cBoxPmtInfoErrorMap = new Dictionary<ComboBox, Label>();
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;


      /// <summary>
      /// The constructor for the form will center the form, 
      /// and update the cost for the rental.
      /// </summary>
      /// <param name="rentalToPayFor"></param>
      public PaymentPage(Rental rentalToPayFor)
      {
         InitializeComponent();
         payPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET -
            payPanel.Size.Width / CENTER_OFFSET,
            (ClientSize.Height / CENTER_OFFSET -
            payPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         _rentalToPayFor = rentalToPayFor;
         _vehicleOfRental = DBController.GetByPrimaryKey<Vehicle>(_rentalToPayFor.VehicleID);
         _customerOfRental = DBController.GetByPrimaryKey<Customer>(_rentalToPayFor.CustomerID);
         AddComboBoxErrorMapping();
         DetermineRentalDays();
         UpdateRentalCost();
      }

      /// <summary>
      /// This method will run through the details of the rental(including fees)
      /// give a sufficient calculation for the cost of the rental /day.
      /// </summary>
      private void UpdateRentalCost()
      {
         int fees = RentalControl.AccessoryFee(_rentalToPayFor, babySeat.Checked, satNav.Checked)
            + _customerOfRental.Fee;
         txtRentRate.Text = "$" + _vehicleOfRental.Rate.ToString() + "/day";
         txtFees.Text = "$" + fees.ToString();
         RentalControl.DetermineCost(_rentalToPayFor, babySeat.Checked, satNav.Checked);
         txtCost.Text = "$" + _rentalToPayFor.Cost.ToString();
      }

      /// <summary>
      /// This method breaks up the length f the rantel and the rate of the
      /// vehicle and calculates the cost of just the car /day.
      /// </summary>
      private void DetermineRentalDays()
      {
         int rentalDays = _rentalToPayFor.EndDate.Subtract(_rentalToPayFor.StartDate).Days + 1;
         txtTotalDays.Text = rentalDays.ToString();
      }

      /// <summary>
      /// This method ensures, the customer is not currently renting a car
      /// then proceeds with sending the rental information to the database.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnPay_Click(object sender, EventArgs e)
      {
         HideAllErrorMessages();

         if (!_customerOfRental.IsBlacklisted)
         {
            if (ArePaymentInfoComboBoxesSelected())
               AttemptRental();
            else
            {
               List<ComboBox> formComboBoxList = FormHelper.GetControlsInControlContainer<ComboBox, Panel>(payPanel);
               SetPaymentInfoErrorVisibility(formComboBoxList);
            }
         }
         else
            SetAndMakeVisiblePaymentErrorText(PMT_ERROR_INVALID_CUS);
      }

      /// <summary>
      /// If the rental had an error this method will display the proper message.
      /// </summary>
      /// <param name="formComboBoxList"></param>
      private void SetPaymentInfoErrorVisibility(List<ComboBox> formComboBoxList)
      {
         foreach (ComboBox comboBox in formComboBoxList)
         {
            if (comboBox.SelectedItem == null)
               cBoxPmtInfoErrorMap[comboBox].Visible = true;
            else
               cBoxPmtInfoErrorMap[comboBox].Visible = false;
         }
      }

      /// <summary>
      /// This method sets the paymentError depending on what form of 
      /// error has occured.
      /// </summary>
      /// <param name="paymentErrorText"></param>
      private void SetAndMakeVisiblePaymentErrorText(string paymentErrorText)
      {
         payError.Text = paymentErrorText;
         payError.Visible = true;
      }

      /// <summary>
      /// This method will hide any error messages on the panel.
      /// </summary>
      private void HideAllErrorMessages()
      {
         nullinfo1.Visible = false;
         nullinfo2.Visible = false;
         payError.Visible = false;
      }

      /// <summary>
      /// This method checks of the combobox selected info is within bounds.
      /// </summary>
      private void AddComboBoxErrorMapping()
      {
         cBoxPmtInfoErrorMap.Add(cboxPmtType, nullinfo1);
         cBoxPmtInfoErrorMap.Add(dropoffCB, nullinfo2);
      }

      /// <summary>
      /// This method will attempt to send the rental to the database
      /// and if the rental worked, the rental confirmation page is displayed
      /// otherwise, an error messgae is shown.
      /// </summary>
      private void AttemptRental()
      {
         _rentalToPayFor.DropOffLocation = dropoffCB.Text;
         if (RentalControl.AddRental(_rentalToPayFor))
         {
            DisplayRentalConfirmationPage();
            Controllers.UserControl.RemoveFee(_customerOfRental);
         }
         else
            SetAndMakeVisiblePaymentErrorText(PMT_ERROR_USER_IN_RENTAL);
      }

      /// <summary>
      /// This method brings up the confirmation page, and sends the rental 
      /// number through to its constructor.
      /// </summary>
      private void DisplayRentalConfirmationPage()
      {
         ConfirmationPage c = new ConfirmationPage(_rentalToPayFor)
         {
            MdiParent = MdiParent,
            ClientSize = new Size(),
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill
         };
         WindowState = FormWindowState.Normal;
         c.Show();
      }

      /// <summary>
      /// This method just checks the index of the combobox
      /// </summary>
      /// <returns></returns>
      private bool ArePaymentInfoComboBoxesSelected()
      {
         return cboxPmtType.SelectedItem != null && dropoffCB.SelectedItem != null;
      }

      /// <summary>
      /// This method checks the additional fees and updates if 
      /// the satnav is added to the rental.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void satNav_CheckedChanged(object sender, EventArgs e)
      {
         UpdateRentalCost();
      }

      /// <summary>
      /// This method checks if the checkbox for the babyseat is checked
      /// and updates the rental cost depending on this.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void babySeat_CheckedChanged(object sender, EventArgs e)
      {
         UpdateRentalCost();
      }
   }
}
