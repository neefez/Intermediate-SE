//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This form will display all the customer in the database, 
// set customer to blacklist, add fees to a customer, add comments why 
// they are blacklist or have fees.
//------------------------------------------------------------------------
using CarRentalSystem.Controllers;
using System;
using CarRentalSystem.DBObjects;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Forms;
using AccessAssistant;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// this is the blacklistpage form
   /// </summary>
   public partial class BlacklistPage : Form
   {
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;

      /// <summary>
      /// basic set up of the blacklistpage
      /// </summary>
      public BlacklistPage()
      {
         InitializeComponent();
         if (BlackListCB.Checked == true)
            blackListTxtBox.Enabled = true;
         blackListPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET - 
         blackListPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET -
         blackListPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         foreach (var item in Controllers.UserControl.GetAllCustomer())
            Customerlist.Items.Add(item);
         Customerlist.SetSelected(0, true);
      }
      /// <summary>
      /// set a customer to be blacklist
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void RightHandControl_CheckedChanged(object sender, EventArgs e)
      {
         if (BlackListCB.Checked)
         {
            Controllers.UserControl.Blacklist(
               (Customer)Customerlist.SelectedItem);
            DBController.Save((Customer)Customerlist.SelectedItem, 
               DBObject.SaveTypes.Update);
         }
         else
         {
            Controllers.UserControl.NotBlacklist(
               (Customer)Customerlist.SelectedItem);
            DBController.Save((Customer)Customerlist.SelectedItem, 
               DBObject.SaveTypes.Update);
         }
         UpdateList();
      }

      /// <summary>
      /// update the list everytime the component of customer list is changed
      /// </summary>
      private void UpdateList()
      {
         int currentIndex = Customerlist.SelectedIndex;
         Customerlist.Items.Clear();
         foreach (var item in Controllers.UserControl.GetAllCustomer())
            Customerlist.Items.Add(item);
         Customerlist.SelectedIndex = currentIndex;
      }

      /// <summary>
      /// the blacklist checked box will show the right information
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void Customerlist_SelectedIndexChanged(object sender,
                                                     EventArgs e)
      {
         blackListTxtBox.Clear();
         feeAdded.Visible = false;
         if (Customerlist.SelectedItem == null)
         {
            NewMethod();
            return;
         }
         Customer c = (Customer)Customerlist.SelectedItem;
         BlackListCB.Checked = c.IsBlacklisted;
         if (BlackListCB.Checked == true)
            blackListTxtBox.Enabled = true;
         else
            blackListTxtBox.Enabled = false;
      }
      /// <summary>
      /// set blacklist combobox to false
      /// </summary>
      private void NewMethod()
      {
         BlackListCB.Checked = false;
      }

      /// <summary>
      /// confirm fee button clicks, fees will be added to the customer
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void confirmFeeButton_Click(object sender, EventArgs e)
      {
         int fees = (Int32)feeAmount.Value;
         feeAdded.Visible = true;
         if (fees > 0)
         {
            Customer c = (Customer)Customerlist.SelectedItem;
            CarRentalSystem.Controllers.UserControl.ApplyFee(c, fees);
            feeAdded.Text = "The fee was added to " + c.FirstName + " " + c.LastName ;
            feeAdded.ForeColor = Color.Green;
         }
         else
         {
            feeAdded.Text = "Please enter a value higher than 0.";
            feeAdded.ForeColor = Color.Crimson;
         }
         feeAmount.Value = 1;
      }
      /// <summary>
      /// send button clicks, the blacklist clear and message is 
      /// sent to the databse.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void sendBtn_Click(object sender, EventArgs e)
      {
         blackListTxtBox.Clear();
      }
   }
}