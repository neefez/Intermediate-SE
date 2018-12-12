//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe
// Project: Car Rental System - SE Project 
// Purpose: This form is meant to display the purchase order number
//          and give the user confirmation of the purchase.
//------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;
using CarRentalSystem.Forms;
using System.Collections.Generic;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// The class for use in the form, holds two variables rentalNo
   /// and purchaseNo, both used in representing to the user, the 
   /// order of purchase, or rental.
   /// </summary>
   public partial class ConfirmationPage : Form
   {
      private Rental rentalNo;
      private Purchase purchaseNo;
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;
      /// <summary>
      /// The constructor will properly pace the panel in the center of the
      /// form and grab the designated rental, and display it on the screen.
      /// </summary>
      /// <param name="r1"></param>
      public ConfirmationPage(Rental r1)
      {
         InitializeComponent();
            conformationPanel.Location = new Point(
            (ClientSize.Width / CENTER_OFFSET - conformationPanel.Size.Width / CENTER_OFFSET),
            (ClientSize.Height / CENTER_OFFSET - conformationPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
            rentalNo = r1;
         numLabel.Text = rentalNo.RentalNo.ToString();
      }

      /// <summary>
      /// The constructor will properly pace the panel in the center of the 
      /// form and grab the designated purchase, and display it on the screen.
      /// </summary>
      /// <param name="p1"></param>
      public ConfirmationPage(Purchase p1)
      {
         InitializeComponent();
         conformationPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET
         - conformationPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET
         - conformationPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         purchaseNo = p1;
         numLabel.Text = purchaseNo.PurchaseNo.ToString();
      }
   }
}