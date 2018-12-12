namespace CarRentalSystem.Forms
{
   partial class ReportPage
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rentalID = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.problemDate = new System.Windows.Forms.DateTimePicker();
            this.reportLabel = new System.Windows.Forms.Label();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.noRentalLabel = new System.Windows.Forms.Label();
            this.reportPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(52, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description of Problem:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(543, 215);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Gainsboro;
            this.sendButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sendButton.Location = new System.Drawing.Point(499, 404);
            this.sendButton.Margin = new System.Windows.Forms.Padding(1);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(102, 40);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.reportPanel.Controls.Add(this.noRentalLabel);
            this.reportPanel.Controls.Add(this.panel1);
            this.reportPanel.Controls.Add(this.flowLayoutPanel1);
            this.reportPanel.Controls.Add(this.rentalID);
            this.reportPanel.Controls.Add(this.messageLabel);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Controls.Add(this.problemDate);
            this.reportPanel.Controls.Add(this.reportLabel);
            this.reportPanel.Controls.Add(this.carIDLabel);
            this.reportPanel.Controls.Add(this.sendButton);
            this.reportPanel.Controls.Add(this.label2);
            this.reportPanel.Location = new System.Drawing.Point(241, 137);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(651, 474);
            this.reportPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Location = new System.Drawing.Point(56, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 217);
            this.panel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(605, 425);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 19);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // rentalID
            // 
            this.rentalID.AutoSize = true;
            this.rentalID.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalID.Location = new System.Drawing.Point(141, 78);
            this.rentalID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rentalID.Name = "rentalID";
            this.rentalID.Size = new System.Drawing.Size(52, 23);
            this.rentalID.TabIndex = 12;
            this.rentalID.Text = "None";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.messageLabel.Location = new System.Drawing.Point(78, 416);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(104, 19);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "messageLabel";
            this.messageLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(254, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date of Problem:";
            // 
            // problemDate
            // 
            this.problemDate.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDate.Location = new System.Drawing.Point(401, 81);
            this.problemDate.Name = "problemDate";
            this.problemDate.Size = new System.Drawing.Size(200, 23);
            this.problemDate.TabIndex = 9;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.reportLabel.Location = new System.Drawing.Point(30, 30);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(406, 33);
            this.reportLabel.TabIndex = 8;
            this.reportLabel.Text = "Report Car Damage or Malfunctions";
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.carIDLabel.Location = new System.Drawing.Point(52, 78);
            this.carIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(87, 23);
            this.carIDLabel.TabIndex = 0;
            this.carIDLabel.Text = "Rental ID:";
            // 
            // noRentalLabel
            // 
            this.noRentalLabel.AutoSize = true;
            this.noRentalLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRentalLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.noRentalLabel.Location = new System.Drawing.Point(52, 416);
            this.noRentalLabel.Name = "noRentalLabel";
            this.noRentalLabel.Size = new System.Drawing.Size(427, 19);
            this.noRentalLabel.TabIndex = 15;
            this.noRentalLabel.Text = "*Sorry, but you must have a rental in order to report a problem.";
            this.noRentalLabel.Visible = false;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.reportPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ReportPage";
            this.Text = "ReportPage";
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.RichTextBox descriptionTextBox;
      private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Label reportLabel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DateTimePicker problemDate;
      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Label carIDLabel;
      private System.Windows.Forms.Label rentalID;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label noRentalLabel;
    }
}