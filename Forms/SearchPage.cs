//-----------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe
// Project: Car Rental System - SE Project 
// Purpose: This is the form that shows the search results and car information
//-----------------------------------------------------------------------------
using CarRentalSystem.Controllers;
using System;
using CarRentalSystem.DBObjects;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Forms;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// This page focuses on displaying search results and car information.
   /// </summary>
   public partial class SearchPage : Form
   {
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;
      ListViewItem listItem;
      private bool isModifySearchPage;

      /// <summary>
      /// Parameterized constructor for the <seealso cref="SearchPage"/>.
      /// </summary>
      /// <param name="isModify">
      /// Determines whether the search page is an <seealso cref="Admin"/>
      /// or <seealso cref="Customer"/> view type.
      /// </param>
      public SearchPage(bool isModify)
      {
         InitializeComponent();
         searchPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET -
            searchPanel.Size.Width / CENTER_OFFSET,
            (ClientSize.Height / CENTER_OFFSET - 
            searchPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);

         carInfoPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET -
         carInfoPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET - 
         carInfoPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);

            modifyPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET -
         modifyPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET - 
         modifyPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         
         isModifySearchPage = isModify;
         if (isModify)
         {
            datesLabel.Visible = false;
            toLabel.Visible = false;
            fromLabel.Visible = false;
            pickUpDate.Visible = false;
            dropOffDate.Visible = false;
         }

         UpdateList();
      }

      /// <summary>
      /// Shows buttons and labels relevant for <seealso cref="Admin"/>s.
      /// </summary>
      public void AdminView()
      {
         buyButton.Visible = false;
         rentButton.Visible = false;
         deleteButton.Visible = true;
         disclamerLabel.Visible = false;
         datesLabel.Visible = false;
         toLabel.Visible = false;
         fromLabel.Visible = false;
         pickUpDate.Visible = false;
         dropOffDate.Visible = false;
      }

      /// <summary>
      /// Shows buttons and labels relevant for <seealso cref="Customer"/>s.
      /// </summary>
      public void UserView()
      {
         buyButton.Visible = true;
         rentButton.Visible = true;
         deleteButton.Visible = false;
         disclamerLabel.Visible = false;
         datesLabel.Visible = true;
         toLabel.Visible = true;
         fromLabel.Visible = true;
         pickUpDate.Visible = true;
         dropOffDate.Visible = true;
      }

      /// <summary>
      /// Populates the modify panel with the current information for the
      /// selected <seealso cref="Vehicle"/>.
      /// </summary>
      /// <param name="l">List of <seealso cref="Vehicle"/> information</param>
      private void FillModifyInfo(List<string> l)
      {
         Vehicle modifiedVehicle = RentalControl.SelectedVehicle;
         modifiedVehicle = RentalControl.SelectedVehicle;
         makeM.Text = modifiedVehicle.Make;
         modelM.Text = modifiedVehicle.Model;
         typeM.Text = modifiedVehicle.Type;
         colorM.Text = modifiedVehicle.Color;
         yearM.Value = modifiedVehicle.VehicleYear;
         rightM.Checked = modifiedVehicle.RightHandControlled;
         transmissionM.Checked = modifiedVehicle.ManualTransmission;
      }

      /// <summary>
      /// Populates the listview with the <seealso cref="Vehicle"/> information.
      /// </summary>
      /// <param name="l">List of <seealso cref="Vehicle"/> information</param>
      private void FillInfo(List<string> l)
      {
         int index = 0;
         whichTypeLabel.Text = l[index++];
         whichColorLabel.Text = l[index++];
         whichYearLabel.Text = l[index++];
         whichModelLabel.Text = l[index++];
         whichMakeLabel.Text = l[index++];
         whichRightLabel.Text = GetYesNo(l[index++]);
         whichTransmissionLabel.Text = GetYesNo(l[index++]);
         if (RentalControl.SelectedVehicle.Type == "Sedan")
            pictureBox1.Image = Properties.Resources.Sedan;

         else if (RentalControl.SelectedVehicle.Type == "Sports Car")
            pictureBox1.Image = Properties.Resources.Sports_Car;

         else if (RentalControl.SelectedVehicle.Type == "Luxury")
            pictureBox1.Image = Properties.Resources.Luxury;

         else if (RentalControl.SelectedVehicle.Type == "SUV")
            pictureBox1.Image = Properties.Resources.SUV;

         else if (RentalControl.SelectedVehicle.Type == "Truck")
            pictureBox1.Image = Properties.Resources.Truck;

         else if (RentalControl.SelectedVehicle.Type == "Hatchback")
            pictureBox1.Image = Properties.Resources.Hatchback;

         else if (RentalControl.SelectedVehicle.Type == "Van")
            pictureBox1.Image = Properties.Resources.Van;

         pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      }

      /// <summary>
      /// Turns a True/False string into Yes/No.
      /// </summary>
      /// <param name="answer">The True/False string from the database</param>
      /// <returns>Yes/No based on the database string</returns>
      private string GetYesNo(string answer)
      {
         if (answer.Equals("True"))
            return "Yes";
         return "No";
      }

      /// <summary>
      /// Creates a new <seealso cref="Rental"/> and moves user to a page
      /// to pay for it.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void rentButton_Click(object sender, EventArgs e)
      {
         Rental r = new Rental(pickUpDate.Value.Date,
            dropOffDate.Value.Date,
            RentalControl.SelectedVehicle.CurrentLocation,
            "",
            RentalControl.SelectedVehicle,
            (Customer)Controllers.UserControl.CurrentUser, "");

         PaymentPage p = new PaymentPage(r)
         {
            MdiParent = MdiParent,
            ClientSize = new Size(),
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill
         };
         WindowState = FormWindowState.Normal;
         p.Show();
      }

      /// <summary>
      /// Updates list when the car type is changed.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void carTypyCB_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Updates list when the car color is changed. 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void colorCB_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Changes the displayed information in the <seealso cref="ListView"/>.
      /// </summary>
      private void UpdateList()
      {
         listView1.LargeImageList = imageList1;
         string carColor = null;
         string carType = null;
         string location = null;
         string makeType = null;
         DateTime carPickup = pickUpDate.Value.Date;
         DateTime carDropOff = dropOffDate.Value.Date;
         if (carTypeCB.SelectedItem != null)
            carType = carTypeCB.SelectedItem.ToString();
         if (colorCB.SelectedItem != null)
            carColor = colorCB.SelectedItem.ToString();
         if (makeComboBox.SelectedItem != null)
            makeType = makeComboBox.SelectedItem.ToString();
         if (PickUpBox.SelectedItem != null)
            location = PickUpBox.SelectedItem.ToString();
         int caryearfirst = (Int32)yearBoxFirst.Value;
         int caryearsecond = (Int32)yearBoxSecond.Value;
         List<Vehicle> lv = VehicleControl.FilterCar(carType, carColor, 
            makeType, caryearfirst, caryearsecond, RightHandControl.Checked, 
            ManualTransmission.Checked, location, carPickup, carDropOff);
         listView1.Clear();
         foreach (var item in lv)
         {
            listItem = new ListViewItem();
            listItem.Text = item.ToString();
            listItem.Tag = item;
            if (item.Type == "Sedan")
            {
               listItem.ImageKey = "Sedan.png";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "Sports Car")
            {
               listItem.ImageKey = "Sports Car.bmp";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "Luxury")
            {
               listItem.ImageKey = "Luxury.bmp";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "SUV")
            {
               listItem.ImageKey = "SUV.bmp";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "Truck")
            {
               listItem.ImageKey = "Truck.jpg";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "Hatchback")
            {
               listItem.ImageKey = "Hatchback.png";
               listView1.Items.Add(listItem);
            }
            else if (item.Type == "Van")
            {
               listItem.ImageKey = "Van.png";
               listView1.Items.Add(listItem);
            }
         }
      }

      /// <summary>
      /// Updates list when the car year is changed if the first year is less
      /// than the second year.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void yearBoxFirst_ValueChanged(object sender, EventArgs e)
      {
         if (yearBoxFirst.Value > yearBoxSecond.Value)
            yearBoxFirst.Value = yearBoxSecond.Value;
         UpdateList();
      }

      /// <summary>
      /// Updates list when the car year is changed if the first year is less
      /// than the second year.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void yearBoxSecond_ValueChanged(object sender, EventArgs e)
      {
         if (yearBoxSecond.Value < yearBoxFirst.Value)
            yearBoxSecond.Value = yearBoxFirst.Value;
         UpdateList();
      }

      /// <summary>
      /// Updates list when the right hand control choice is changed.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void RightHandControl_CheckedChanged(object sender, EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Updates list when the manual transmission choice is changed.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ManualTransmission_CheckedChanged(object sender,
                                                     EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Returns the user's view to the search page from the car info page.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void backButton_Click(object sender, EventArgs e)
      {
         carInfoPanel.Visible = false;
         searchPanel.Visible = true;
      }

      /// <summary>
      /// Creates a new <seealso cref="Purchase"/> and moves user to a page
      /// to pay for it.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buyButton_Click(object sender, EventArgs e)
      {
         Purchase p = new Purchase(pickUpDate.Value.Date,
            RentalControl.PickUpLocation,
            RentalControl.SelectedVehicle,
            (Customer)Controllers.UserControl.CurrentUser);

         BuyPage cf = new BuyPage(p)
         {
            MdiParent = MdiParent,
            ClientSize = new Size(),
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill
         };
         WindowState = FormWindowState.Normal;
         cf.Show();
      }

      /// <summary>
      /// Deletes the <seealso cref="Vehicle"/> that the 
      /// <seealso cref="Admin"/> has selected.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void deleteButton_Click(object sender, EventArgs e)
      {
         Vehicle v = RentalControl.SelectedVehicle;
         VehicleControl.RemoveVehicle(v);
         UpdateList();
         carInfoPanel.Visible = false;
         searchPanel.Visible = true;
      }

      /// <summary>
      /// Updates list when the pickup location is changed.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void PickUpBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Saves the modifications to the <seealso cref="Vehicle"/> that the
      /// <seealso cref="Admin"/> has entered.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void saveButton_Click(object sender, EventArgs e)
      {
         RentalControl.SelectedVehicle.Make = makeM.SelectedItem.ToString();
         RentalControl.SelectedVehicle.Model = modelM.Text;
         RentalControl.SelectedVehicle.Type = typeM.SelectedItem.ToString();
         RentalControl.SelectedVehicle.Color = colorM.SelectedItem.ToString();
         RentalControl.SelectedVehicle.VehicleYear = (Int32)yearM.Value;
         RentalControl.SelectedVehicle.RightHandControlled = rightM.Checked;
         RentalControl.SelectedVehicle.ManualTransmission = 
            transmissionM.Checked;
         VehicleControl.ModifyVehicle(RentalControl.SelectedVehicle);
            UpdateList();
         modifyPanel.Visible = false;
         searchPanel.Visible = true;
      }

      /// <summary>
      /// Updates list when the car make is changed.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void makeComboBox_SelectedIndexChanged(object sender, 
                                                     EventArgs e)
      {
         UpdateList();
      }

      /// <summary>
      /// Updates list when the pickup date is changed if the pickup date
      /// is before the dropoff date.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void pickUpDate_ValueChanged(object sender, EventArgs e)
      {
         if (pickUpDate.Value.Date > dropOffDate.Value.Date)
            dropOffDate.Value = pickUpDate.Value;
         UpdateList();
      }

      /// <summary>
      /// Updates list when the dropoff date is changed if the pickup date
      /// is before the dropoff date.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void dropOffDate_ValueChanged(object sender, EventArgs e)
      {
         if (dropOffDate.Value.Date < pickUpDate.Value.Date)
            pickUpDate.Value = dropOffDate.Value;
         UpdateList();
      }

      /// <summary>
      /// Brings up the car info page for the <seealso cref="Vehicle"/>
      /// the <seealso cref="User"/> clicks on.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listView1_ItemSelectionChanged(object sender, 
         ListViewItemSelectionChangedEventArgs e)
      {
         Vehicle v1 = (Vehicle)e.Item.Tag;
         if (v1 != null)
         {

            RentalControl.SelectedVehicle = v1;
            if (isModifySearchPage)
            {
               List<string> features = VehicleControl.DisplayCarInfo(
                  RentalControl.SelectedVehicle.VehicleID.ToString());
               modifyPanel.Visible = true;
               searchPanel.Visible = false;
               FillModifyInfo(features);
            }
            else
            {
               List<string> features = VehicleControl.DisplayCarInfo(
                  RentalControl.SelectedVehicle.VehicleID.ToString());
               carInfoPanel.Visible = true;
               searchPanel.Visible = false;
               FillInfo(features);
            }
         }
      }
   }
}
