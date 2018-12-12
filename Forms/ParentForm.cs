//---------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lyn, Zack Neefe 
// Project: Car Rental System - SE Project 
// Purpose: This is the form that all of the panels in the program load in.
//---------------------------------------------------------------------
using CarRentalSystem.Commands;
using CarRentalSystem.DBObjects;
using FormAssistant;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
   public partial class ParentForm : Form
   {
      private const int RESIZE_OFFSET = 2;
      private const int FONT_SIZE_NINE = 9;
      private const int FONT_SIZE_FOURTEEN = 14;

      /// <summary>
      /// Creates a new instance of the <seealso cref="ParentForm"/>.
      /// </summary>
      public ParentForm()
      {
         InitializeComponent();
         WindowState = FormWindowState.Maximized;
         loginButton.BackColor = Color.Gainsboro;
         loginPanel.Location = new Point(
         ClientSize.Width / RESIZE_OFFSET - loginPanel.Size.Width / RESIZE_OFFSET,
         ClientSize.Height / RESIZE_OFFSET - loginPanel.Size.Height / RESIZE_OFFSET);
         loginPanel.Anchor = AnchorStyles.None;
         MakeButtonFlat();
         CommandHistory.StackChangedEvent += ChangeStateOfUndoRedoButtons;
         CommandHistory.StackChangedEvent += UpdateUndoRedoToolTip;
      }

      /// <summary>
      /// Makes all of the buttons on the nav-bar have a "flat" appearance.
      /// </summary>
      private void MakeButtonFlat()
      {
         loginButton.FlatStyle = FlatStyle.Flat;
         loginButton.FlatAppearance.BorderSize = 0;
         signUpButton.FlatStyle = FlatStyle.Flat;
         signUpButton.FlatAppearance.BorderSize = 0;
         searchButton.FlatStyle = FlatStyle.Flat;
         searchButton.FlatAppearance.BorderSize = 0;
         reportButton.FlatStyle = FlatStyle.Flat;
         reportButton.FlatAppearance.BorderSize = 0;
         blacklistButton.FlatStyle = FlatStyle.Flat;
         blacklistButton.FlatAppearance.BorderSize = 0;
         addButton.FlatStyle = FlatStyle.Flat;
         addButton.FlatAppearance.BorderSize = 0;
         modifyButton.FlatStyle = FlatStyle.Flat;
         modifyButton.FlatAppearance.BorderSize = 0;
         deleteCarButton.FlatStyle = FlatStyle.Flat;
         deleteCarButton.FlatAppearance.BorderSize = 0;
         returnButton.FlatStyle = FlatStyle.Flat;
         returnButton.FlatAppearance.BorderSize = 0;
         loggedInSearchButton.FlatStyle = FlatStyle.Flat;
         loggedInSearchButton.FlatAppearance.BorderSize = 0;
         logOutButton.FlatStyle = FlatStyle.Flat;
         logOutButton.FlatAppearance.BorderSize = 0;
         adminReportsBtn.FlatStyle = FlatStyle.Flat;
         adminReportsBtn.FlatAppearance.BorderSize = 0;
         btnUndo.FlatStyle = FlatStyle.Flat;
         btnUndo.FlatAppearance.BorderSize = 1;
         btnRedo.FlatStyle = FlatStyle.Flat;
         btnRedo.FlatAppearance.BorderSize = 1;
      }

      /// <summary>
      /// Shows all of the buttons that are visible to an 
      /// <seealso cref="Admin"/>.
      /// </summary>
      private void ShowAdminsAvailableButtons()
      {
         addButton.Visible = true;
         modifyButton.Visible = true;
         deleteCarButton.Visible = true;
         returnButton.Visible = true;
         blacklistButton.Visible = true;
         reportButton.Visible = false;
         searchButton.Visible = false;
         loggedInSearchButton.Visible = false;
         adminReportsBtn.Visible = true;
         btnRedo.Visible = true;
         btnUndo.Visible = true;
      }

      /// <summary>
      /// Shows all of the buttons that are visible to a
      /// <seealso cref="Customer"/>.
      /// </summary>
      private void ShowCustomersAvailableButtons()
      {
         reportButton.Visible = true;
         loggedInSearchButton.Visible = true;
         loggedInSearchButton.BringToFront();
         searchButton.Visible = false;
         adminReportsBtn.Visible = false;
         btnRedo.Visible = false;
         btnUndo.Visible = false;

      }

      /// <summary>
      /// Loads the form <paramref name="cf"/> passed in and displays it.
      /// </summary>
      /// <param name="cf">The form passed in to be displayed.</param>
      private void LoadNewForm(Form cf)
      {
         NoHighLightButtons();
         cf.MdiParent = this;
         cf.ClientSize = new Size();
         WindowState = FormWindowState.Maximized;
         cf.FormBorderStyle = FormBorderStyle.None;
         cf.Dock = DockStyle.Fill;
         loginButton.Visible = true;
         cf.Show();
      }

      /// <summary>
      /// Sets the backing color of all of this form's buttons to a 
      /// color that resembles the color of not being highlighted.
      /// </summary>
      private void NoHighLightButtons()
      {
         loginButton.BackColor = Color.WhiteSmoke;
         signUpButton.BackColor = Color.WhiteSmoke;
         searchButton.BackColor = Color.WhiteSmoke;
         reportButton.BackColor = Color.WhiteSmoke;
         addButton.BackColor = Color.WhiteSmoke;
         modifyButton.BackColor = Color.WhiteSmoke;
         deleteCarButton.BackColor = Color.WhiteSmoke;
         returnButton.BackColor = Color.WhiteSmoke;
         loggedInSearchButton.BackColor = Color.WhiteSmoke;
         logOutButton.BackColor = Color.WhiteSmoke;
         blacklistButton.BackColor = Color.WhiteSmoke;
         adminReportsBtn.BackColor = Color.WhiteSmoke;
      }

      /// <summary>
      /// Handles what happens when the sign up button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void signUpButton_Click(object sender, EventArgs e)
      {
         loginPanel.Visible = false;
         CreateUserPage cf = new CreateUserPage();
         LoadNewForm(cf);
         signUpButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the login button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void loginButton_Click(object sender, EventArgs e)
      {
         loginPanel.Visible = true;
         BlankForm cf = new BlankForm();
         LoadNewForm(cf);
         loginButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the search button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void searchButton_Click(object sender, EventArgs e)
      {
         GoToSearchPage();
      }

      /// <summary>
      /// Opens a new instance of the search page.
      /// </summary>
      private void GoToSearchPage()
      {
         loginPanel.Visible = false;
         SearchPage cf = new SearchPage(false);
         LoadNewForm(cf);
         searchButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the report button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void reportButton_Click(object sender, EventArgs e)
      {
         loginPanel.Visible = false;
         ReportPage cf = new ReportPage();
         LoadNewForm(cf);
         reportButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Changes the display of the GUI to reflect a logged in user.
      /// </summary>
      /// <param name="user">Name of the user whom is logging in.</param>
      public void LoggedInUIChange(string user)
      {
         loginPanel.Visible = false;
         signUpButton.Text = user;
         signUpButton.Font = new Font("Corbel", FONT_SIZE_NINE, FontStyle.Regular);
         signUpButton.Enabled = false;
         loginButton.Visible = false;
         logOutButton.Visible = true;

         bool isAdmin = TypeOfUser(user);
         if (isAdmin)
         {
            ShowAdminsAvailableButtons();
            GoToAdminPage();
         }
         else
         {
            ShowCustomersAvailableButtons();
            GoToLoggedInSearch();
         }
      }

      /// <summary>
      /// Gets the type of the user that is logging in.
      /// </summary>
      /// <param name="user">Name of the user thats logging in.</param>
      /// <returns>Type of the user that is logging in.</returns>
      public bool TypeOfUser(string user)
      {
         User loggedIn = Controllers.UserControl.FindUser(user);
         if (loggedIn is Admin)
            return true;
         return false;
      }

      /// <summary>
      /// Handles what happens when the enter button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void enterButton_Click(object sender, EventArgs e)
      {
         string user = usernameBox.Text;
         string pass = passwordBox.Text;
         if (user == "" || pass == "")
         {
            wrongLabel.Text = "Please enter a username and a password.";
            wrongLabel.Visible = true;
         }
         else
         {
            User loggedIn = Controllers.UserControl.FindUser(user);
            if (loggedIn == null)
            {
               wrongLabel.Text = "User not found in the system.";
               wrongLabel.Visible = true;
               usernameBox.Text = "";
               passwordBox.Text = "";
            }
            else if (loggedIn.Password != pass)
            {
               wrongLabel.Text = "Password does not match user.";
               wrongLabel.Visible = true;
               passwordBox.Text = "";
            }
            else
            {
               wrongLabel.Visible = false;
               LoggedInUIChange(user);
               Controllers.UserControl.CurrentUser = loggedIn;
            }
         }
      }

      /// <summary>
      /// Handles what happens when the admin button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void adminButton_Click(object sender, EventArgs e)
      {
         GoToAdminPage();
      }

      /// <summary>
      /// Creates and displays a new instance of the Admin Page.
      /// </summary>
      private void GoToAdminPage()
      {
         loginPanel.Visible = false;
         AdminPage cf = new AdminPage();
         LoadNewForm(cf);
         addButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the delete car button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void deleteCarButton_Click(object sender, EventArgs e)
      {
         SearchPage cf = new SearchPage(false);
         LoadNewForm(cf);
         cf.AdminView();
         deleteCarButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the return button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void returnButton_Click(object sender, EventArgs e)
      {
         ReturnCarPage cf = new ReturnCarPage();
         LoadNewForm(cf);
         returnButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the modify button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void modifyButton_Click(object sender, EventArgs e)
      {
         SearchPage cf = new SearchPage(true);
         LoadNewForm(cf);
         modifyButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the logged in search button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void loggedInSearchButton_Click(object sender, EventArgs e)
      {
         GoToLoggedInSearch();
      }

      /// <summary>
      /// Creates and displays a new instance of the search page.
      /// </summary>
      private void GoToLoggedInSearch()
      {
         SearchPage cf = new SearchPage(false);
         cf.UserView();
         LoadNewForm(cf);
         searchButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Hides the buttons visible to a user when they click sign out.
      /// </summary>
      private void NoUserButtons()
      {
         signUpButton.Visible = true;
         addButton.Visible = false;
         deleteCarButton.Visible = false;
         modifyButton.Visible = false;
         returnButton.Visible = false;
         signUpButton.Font = new Font("Corbel", FONT_SIZE_FOURTEEN, FontStyle.Regular);
         loginButton.Visible = true;
         loggedInSearchButton.Visible = false;
         searchButton.Visible = true;
         logOutButton.Visible = false;
         signUpButton.Text = "Sign Up";
         signUpButton.Enabled = true;
         blacklistButton.Visible = false;
         reportButton.Visible = false;
         adminReportsBtn.Visible = false;
         btnRedo.Visible = false;
         btnUndo.Visible = false;
      }

      /// <summary>
      /// Handles what happens when the log out button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void logOutButton_Click(object sender, EventArgs e)
      {
         BlankForm cf = new BlankForm();
         usernameBox.Text = "";
         passwordBox.Text = "";
         loginPanel.Visible = true;
         NoUserButtons();
         Controllers.UserControl.CurrentUser = null;
         LoadNewForm(cf);
         logOutButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the blacklist button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void button1_Click_1(object sender, EventArgs e)
      {
         BlacklistPage cf = new BlacklistPage();
         LoadNewForm(cf);
         blacklistButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what happens when the admin reports button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void adminReportsBtn_Click(object sender, EventArgs e)
      {
         AdminReportsPage arp = new AdminReportsPage();
         LoadNewForm(arp);
         adminReportsBtn.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Changes the state of the undo and redo buttons to be enabled or not.
      /// </summary>
      private void ChangeStateOfUndoRedoButtons()
      {
         foreach (CommandHistory.StackTypes stackType in Enum.GetValues(typeof(CommandHistory.StackTypes)))
         {
            string stackButtonName = $"btn{ConvertWordToTitleCase(stackType.ToString())}";
            Button stackButton = FormHelper.FindControlByName<Button, Panel>(stackButtonName, titleBar);
            if (CommandHistory.PeekInStack(stackType) == null)
               stackButton.Enabled = false;
            else
               stackButton.Enabled = true;
         }
      }

      /// <summary>
      /// Updates the message displayed for each undo/redo button.
      /// </summary>
      private void UpdateUndoRedoToolTip()
      {
         foreach (CommandHistory.StackTypes stackType in Enum.GetValues(typeof(CommandHistory.StackTypes)))
         {
            string stackTypeName = ConvertWordToTitleCase(stackType.ToString());
            string stackButtonName = $"btn{stackTypeName}";
            Button stackButton = FormHelper.FindControlByName<Button, Panel>(stackButtonName, titleBar);
            ICommand commandAtTopOfStack = CommandHistory.PeekInStack(stackType);
            if (commandAtTopOfStack == null)
               toolTip.SetToolTip(stackButton, $"Nothing to {stackTypeName}");
            else
               toolTip.SetToolTip(stackButton, $"{stackTypeName} {commandAtTopOfStack.CommandName}");
         }
      }

      /// <summary>
      /// Converts a <paramref name="word"/> to its corresponding title case.
      /// </summary>
      /// <param name="word">Word to convert to title case.</param>
      /// <returns>Title case version of the word.</returns>
      private string ConvertWordToTitleCase(string word)
      {
         word = word.ToLower();
         string firstLetter = word[0].ToString().ToUpper();
         string restOfWord = word.Substring(1);
         return $"{firstLetter}{restOfWord}";
      }

      /// <summary>
      /// Handles what occurs when either undo or redo button is clicked.
      /// </summary>
      /// <param name="stackType"></param>
      private void HandleUndoRedoClick(CommandHistory.StackTypes stackType)
      {
         string stackName = ConvertWordToTitleCase(stackType.ToString());
         MethodInfo undoRedoMethod = typeof(CommandHistory).GetMethod(stackName);
         undoRedoMethod.Invoke(this, null);
      }

      /// <summary>
      /// Handles what occurs when the undo button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void btnUndo_Click(object sender, EventArgs e)
      {
         HandleUndoRedoClick(CommandHistory.StackTypes.UNDO);
         SearchPage cf = new SearchPage(true);
         LoadNewForm(cf);
         modifyButton.BackColor = Color.Gainsboro;
      }

      /// <summary>
      /// Handles what occurs when the redo button is clicked.
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void btnRedo_Click(object sender, EventArgs e)
      {
         HandleUndoRedoClick(CommandHistory.StackTypes.REDO);
         SearchPage cf = new SearchPage(true);
         LoadNewForm(cf);
         modifyButton.BackColor = Color.Gainsboro;
      }


      /// <summary>
      /// Handles showing tooltip on a disabled button
      /// </summary>
      /// <param name="sender">Object that raised this event.</param>
      /// <param name="e">Contains the data for the event.</param>
      private void titleBar_MouseMove(object sender, MouseEventArgs e)
      {
         Control parent = sender as Control;
         if (parent != null)
         {
            var control = parent.GetChildAtPoint(e.Location);
            if (control != null && !control.Enabled)
            {
               if (control.Visible && toolTip.Tag == null)
               {
                  var tipstring = toolTip.GetToolTip(control);
                  toolTip.Show(tipstring, control, control.Width / RESIZE_OFFSET, control.Height / RESIZE_OFFSET);
                  toolTip.Tag = control;
               }
            }
            else
            {
               control = toolTip.Tag as Control;
               if (control != null)
               {
                  toolTip.Hide(control);
                  toolTip.Tag = null;
               }
            }
         }
      }

   }
}
