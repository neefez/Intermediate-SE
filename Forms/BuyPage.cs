//-----------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This form will show all the related information for the possible
//          purchase, and will calculate the cost of the purchase.
//-----------------------------------------------------------------------------
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// The private class for use in the form, this class holds the 
   /// -purchaseToPayFor and _vehicleToPayFor as paremeters in setting
   /// up the form.
   /// </summary>
   public partial class BuyPage : Form
   {
      private Purchase _purchaseToPayFor;
      private Vehicle _vehicleToPayFor;
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;

      /// <summary>
      /// The constructor takes in the purchase object and with its
      /// information, displays everything the user needs to see before
      /// purchase.
      /// </summary>
      /// <param name="purchaseToPayFor"></param>
      public BuyPage(Purchase purchaseToPayFor)
      {
         InitializeComponent();
            buyPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET
         - buyPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET - 
         buyPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         _purchaseToPayFor = purchaseToPayFor;
         _vehicleToPayFor = DBController.GetByPrimaryKey<Vehicle>(
            _purchaseToPayFor.VehicleID);

         UpdatePurchaseInfo();
      }

      /// <summary>
      /// updates the information displaying the purchase cost.
      /// </summary>
      private void UpdatePurchaseInfo()
      {
         carInfoLabel.Text = _vehicleToPayFor.ToString();
         moneyAmountLabel.Text = 
            VehicleControl.DeterminePrice(_vehicleToPayFor).ToString();
      }

      /// <summary>
      /// Once the purchase button is pressed, the information is stored in
      /// the purchase table, and the user is notified of their purchase order
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buyButton_Click(object sender, System.EventArgs e)
      {
         _purchaseToPayFor.Location = _vehicleToPayFor.CurrentLocation;
         _purchaseToPayFor.PurchaseDate = _purchaseToPayFor.PurchaseDate.Date;
         PurchaseControl.AddPurchase(_purchaseToPayFor);
         ConfirmationPage c = new ConfirmationPage(_purchaseToPayFor)
         {
            MdiParent = MdiParent,
            ClientSize = new Size(),
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill
         };
         WindowState = FormWindowState.Normal;
         c.Show();
      }
   }
}