//-----------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe
// Project: Car Rental System - SE Project 
// Purpose: This is the form where admins can mark cars as returned.
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using AccessAssistant;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// This is the page where an <seealso cref="Admin"/> can mark a
   /// <seealso cref="Vehicle"/> as returned.
   /// </summary>
   public partial class ReturnCarPage : Form
   {
      private const int CENTER_OFFSET = 2;
      /// <summary>
      /// Specifies how to change the error label.
      /// </summary>
      public enum LabelType
      {
         Purchase,
         Return,
         Success,
         NoRent,
         NoData
      };

      /// <summary>
      /// Default constructor for <seealso cref="ReturnCarPage"/>.
      /// </summary>
      public ReturnCarPage()
      {
         InitializeComponent();
         returnPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET - 
            returnPanel.Size.Width / CENTER_OFFSET,
            ClientSize.Height / CENTER_OFFSET - 
            returnPanel.Size.Height / CENTER_OFFSET);
      }

      /// <summary>
      /// Enter button <seealso cref="Admin"/> presses after entering
      /// <seealso cref="Vehicle"/> ID.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void button1_Click(object sender, EventArgs e)
      {
         errorLabel.Visible = false;
         errorLabel.ForeColor = Color.Crimson;
         int vehicleID = (Int32)returnCarID.Value;
         Vehicle vehicle = DBController.GetByPrimaryKey<Vehicle>(vehicleID);
         if (vehicle != null)
         {
            if (vehicle.IsRented)
            {
               Purchase p = PurchaseControl.FindPurchase(vehicleID);
               if (p != null)
               {
                  setLabel(LabelType.Purchase);
                  return;
               }
               vehicle.IsRented = false;
               DBController.Save(vehicle, DBObject.SaveTypes.Update);
               Rental r = DBController.GetAllRecords<Rental>().Where(rent =>
                  rent.VehicleID == vehicle.VehicleID && 
                  rent.Active == true).FirstOrDefault();
               if (r == null)
                  setLabel(LabelType.Return);               
               r.Active = false;
               r.Comment = commentTB.Text;
               DBController.Save(r, DBObject.SaveTypes.Update);
               setLabel(LabelType.Success);
            }
            else
               setLabel(LabelType.NoRent);
         }
         else
            setLabel(LabelType.NoData);
      }

      /// <summary>
      /// Changes the text and/or color of the dialogue label on the page.
      /// </summary>
      /// <param name="typed">The type of output desired.</param>
      private void setLabel(LabelType typed)
      {
         switch (typed)
         {
            case LabelType.Purchase:
               errorLabel.Text = "Sorry, but the car has been purchased";
               break;
            case LabelType.Return:
               errorLabel.Text = 
                  "Sorry, but this vehicle was already returned";
               break;
            case LabelType.Success:
               errorLabel.Text = "Vehicle has been successfully returned.";
               errorLabel.ForeColor = Color.SeaGreen;
               break;
            case LabelType.NoRent:
               errorLabel.Text =
                  "Sorry, but this vehicle has not been rented yet.";
               break;
            case LabelType.NoData:
               errorLabel.Text = "Sorry, but this vehicle is not in database.";
               break;
            default:
               break;
         }
         errorLabel.Visible = true;
      }
   }
}