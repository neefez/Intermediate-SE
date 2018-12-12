//-----------------------------------------------------------------------------
// Name:  Michael Serino, Noah Moss, Sarah Higgens, Xinyi Lynu, Zack Neefe 
// Project: Car Rental System - SE Project
// Purpose: This form will display all user reports from the database to admins
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.DBObjects;
using CarRentalSystem.Controllers;
using AccessAssistant;

namespace CarRentalSystem.Forms
{
   public partial class AdminReportsPage : Form
   {
      private const int BAR_OFF_SET = 34;
      private const int CENTER_OFFSET = 2;
      private VehicleIssue selected;  //This is the currently selected issue

      /// <summary>
      /// The contructor will properly fit the form to the screen, and
      /// update the list of reports.
      /// </summary>
      public AdminReportsPage()
      {
         InitializeComponent();
         reportsPanel.Location = new Point(
         ClientSize.Width / CENTER_OFFSET 
         - reportsPanel.Size.Width / CENTER_OFFSET,
         (ClientSize.Height / CENTER_OFFSET
         - reportsPanel.Size.Height / CENTER_OFFSET) + BAR_OFF_SET);
         UpdateList();
      }

      /// <summary>
      /// The UpdateList method will grab all the vehicleissues and display
      /// them on the listbox in the form.
      /// </summary>
      private void UpdateList()
      {
         List<VehicleIssue> il = 
            DBController.GetAllRecords<VehicleIssue>().Where(report => 
            !report.IsFixed).ToList();

         reportList.Items.Clear();
         foreach (VehicleIssue item in il)
         {
            reportList.Items.Add(item);
         }
         reportDetails.Text = "";
      }

      /// <summary>
      /// The ReportList_SelectedINdexChanged method will update the currently
      /// selected vehicle issue and display its properties.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void reportList_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (reportList.SelectedItem != null)
         {
            selected = (VehicleIssue)reportList.SelectedItem;
            reportDetails.Text = selected.Issue;
         }
      }

      /// <summary>
      /// The denyButton_Click method will updated the selected issue as
      /// denied and update the list.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void denyButton_Click(object sender, EventArgs e)
      {
         if (selected == null)
            return;
         VehicleIssueControl.Deny(selected);
         UpdateList();
      }

      /// <summary>
      /// The fixedButton_Click method will update the selected issue as
      /// being fixed and update the list.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void fixedButton_Click(object sender, EventArgs e)
      {
         if (selected == null)
            return;
         VehicleIssueControl.Fix(selected);
         UpdateList();
      } 
   }
}