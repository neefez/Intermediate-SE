//------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This is the Form will add a customer or admin account.
//------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;
using System.Collections.Generic;

namespace CarRentalSystem.Forms
{
   /// <summary>
   /// This form provides the GUI for adding an admin or a customer
   /// to the database.
   /// </summary>
   public partial class CreateUserPage : Form
   {
      private Customer c1;
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;
      List<Customer> lc = Controllers.UserControl.GetAllCustomer();
      List<Admin> la = DBController.GetAllRecords<Admin>();
      /// <summary>
      /// This constructor will center the panel in the parent form,
      /// load the forms components, and set the error message to the 
      /// correct location.
      /// </summary>
      public CreateUserPage()
      {
         InitializeComponent();
         createAccPanel.Location = new Point(
            ClientSize.Width / CENTER_OFFSET 
            - createAccPanel.Size.Width / CENTER_OFFSET,
            (ClientSize.Height / CENTER_OFFSET
            - createAccPanel.Size.Height / CENTER_OFFSET) +
            BAR_OFF_SET);
         new ToolTip().SetToolTip(password2unmatch, "ERROR");
         password2unmatch.Location = new Point(170, 415);
      }

      /// <summary>
      /// Tells user if customer user name was taken.
      /// </summary>
      private void takenCustomerUsername()
      {
         password2unmatch.Text = "Sorry, but this username is taken.";
         password2unmatch.Visible = true;
         userNameTextBox.Text = "";
         passwordTextBox.Text = "";
         reEnterTextBox.Text = "";
      }

      /// <summary>
      /// Tells user if admin user name was taken.
      /// </summary>
      private void takenAdminUsername()
      {
         password2unmatch.Text = "Sorry, but this username is taken.";
         password2unmatch.Visible = true;
         userNameTextBox.Text = "";
         passwordTextBox.Text = "";
         reEnterTextBox.Text = "";
      }

      /// <summary>
      /// Tells user if they forgot to fill in a field.
      /// </summary>
      private void blankField()
      {
         password2unmatch.Text = "All fields must be filled.";
         password2unmatch.Visible = true;
         passwordTextBox.Text = "";
         reEnterTextBox.Text = "";
      }

      /// <summary>
      /// Tells user the two passwords they entered in do not match.
      /// </summary>
      private void passwordsDoNotMatch()
      {
         password2unmatch.Text = "Password entries do not match.";
         password2unmatch.Visible = true;
         passwordTextBox.Text = "";
         reEnterTextBox.Text = "";
      }

      /// <summary>
      /// Enters a user in as an Admin if they have the correct employee ID.
      /// </summary>
      /// <param name="firstName"></param>
      /// <param name="lastName"></param>
      /// <param name="username"></param>
      /// <param name="password"></param>
      private void setUpAdmin(string firstName, string lastName, 
                              string username, string password)
      {
         Admin newAdmin = new Admin(firstName, lastName, username, password);
         int adminIDentered = (Int32)employeeIDfield.Value;
         Admin enteredAdmin = DBController.GetByPrimaryKey<Admin>(
            adminIDentered);

         if (enteredAdmin != null)
         {
            Controllers.UserControl.AddAdmin(newAdmin);
            DisplaySearchPage();
         }
         else
            badIDlabel.Visible = true;
      }

      /// <summary>
      /// Enters user in as a customer.
      /// </summary>
      /// <param name="firstName"></param>
      /// <param name="lastName"></param>
      /// <param name="username"></param>
      /// <param name="password"></param>
      private void setUpCustomer(string firstName, string lastName,
                                 string username, string password)
      {
         c1 = new Customer(firstName, lastName, username, password);
         Controllers.UserControl.AddCustomer(c1);
         DisplaySearchPage();
      }

      /// <summary>
      /// Once the user is done with filling in the information, 
      /// this button sends it to the database.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void nextButton_Click(object sender, EventArgs e)
      {
         string firstName = firstNameBox.Text;
         string lastName = lastNameBox.Text;
         string username = userNameTextBox.Text;
         string password = passwordTextBox.Text;
         string password2 = reEnterTextBox.Text;
         checkInfo(firstName, lastName, username, password, password2);
         
      }

      /// <summary>
      /// Checks all the parameters to see if they are valid or not.
      /// </summary>
      /// <param name="firstName"></param>
      /// <param name="lastName"></param>
      /// <param name="username"></param>
      /// <param name="password"></param>
      /// <param name="password2"></param>
      private void checkInfo(string firstName, string lastName, 
         string username, string password, string password2)
      {
         foreach (var item in lc)
         {
            if (username == item.Username)
            {
               takenCustomerUsername();
               return;
            }
         }
         foreach (var item in la)
         {
            if (username == item.Username)
            {
               takenAdminUsername();
               return;
            }
         }
         if (password == "" || firstName == "" || lastName == "" || username == "")
            blankField();

         else if (password != password2)
            passwordsDoNotMatch();

         else
         {
            if (adminRadio.Checked)
               setUpAdmin(firstName, lastName, username, password);

            else
               setUpCustomer(firstName, lastName, username, password);
         }
      }
      
      /// <summary>
      /// Goes to search page after the user is done creating their account.
      /// </summary>
      private void DisplaySearchPage()
      {
         SearchPage c = new SearchPage(false)
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
      /// Sets up the page for creating an admin account.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void adminRadio_CheckedChanged(object sender, EventArgs e)
      {
         employeeIDfield.Visible = true;
         employeeIDfield.Location = new Point(196, 439);
         employeeIDfield.Font = new Font("Calibri", 14);
         employeeIDfield.ForeColor = Color.DarkSlateGray;
         employeeIDfield.Size = new Size(150, 31);
         employeeIDfield.Show();
         createAccPanel.Controls.Add(employeeIDfield);

         employeeLabel.Visible = true;
         employeeLabel.Location = new Point(66, 439);
         employeeLabel.Font = new Font("Corbel", 14);
         employeeLabel.ForeColor = Color.DarkSlateGray;
         employeeLabel.Text = "Work ID:";
         employeeLabel.Show();
         createAccPanel.Controls.Add(employeeLabel);

         createAccPanel.Size = new Size(437, 560);
         password2unmatch.Location = new Point(170, 470);
         nextButton.Location = new Point(196, 500);
         nextButton.Size = new Size(150, 40);
      }

      /// <summary>
      /// Sets up page for creating a user account.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void userRadio_CheckedChanged(object sender, EventArgs e)
      {
         createAccPanel.Size = new Size(437, 532);
         password2unmatch.Location = new Point(170, 415);
         nextButton.Location = new Point(196, 440);
         employeeLabel.Visible = false;
         employeeIDfield.Visible = false;
      }
   }
}