namespace CarRentalSystem.Forms
{
    partial class ReturnCarPage
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnCarPage));
         this.label1 = new System.Windows.Forms.Label();
         this.returnButton = new System.Windows.Forms.Button();
         this.returnPanel = new System.Windows.Forms.Panel();
         this.returnCarID = new System.Windows.Forms.NumericUpDown();
         this.errorLabel = new System.Windows.Forms.Label();
         this.headerLabel = new System.Windows.Forms.Label();
         this.commentLabel = new System.Windows.Forms.Label();
         this.pickUpDate = new System.Windows.Forms.DateTimePicker();
         this.dateLabel = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.commentTB = new System.Windows.Forms.RichTextBox();
         this.returnPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.returnCarID)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label1.Location = new System.Drawing.Point(90, 128);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(142, 36);
         this.label1.TabIndex = 0;
         this.label1.Text = "Vehicle ID:";
         // 
         // returnButton
         // 
         this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.returnButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.returnButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.returnButton.Location = new System.Drawing.Point(758, 529);
         this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.returnButton.Name = "returnButton";
         this.returnButton.Size = new System.Drawing.Size(153, 62);
         this.returnButton.TabIndex = 2;
         this.returnButton.TabStop = false;
         this.returnButton.Text = "Return";
         this.returnButton.UseVisualStyleBackColor = true;
         this.returnButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // returnPanel
         // 
         this.returnPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.returnPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.returnPanel.Controls.Add(this.returnCarID);
         this.returnPanel.Controls.Add(this.errorLabel);
         this.returnPanel.Controls.Add(this.headerLabel);
         this.returnPanel.Controls.Add(this.commentLabel);
         this.returnPanel.Controls.Add(this.pickUpDate);
         this.returnPanel.Controls.Add(this.dateLabel);
         this.returnPanel.Controls.Add(this.returnButton);
         this.returnPanel.Controls.Add(this.label1);
         this.returnPanel.Controls.Add(this.panel1);
         this.returnPanel.Location = new System.Drawing.Point(322, 169);
         this.returnPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.returnPanel.Name = "returnPanel";
         this.returnPanel.Size = new System.Drawing.Size(964, 635);
         this.returnPanel.TabIndex = 4;
         // 
         // returnCarID
         // 
         this.returnCarID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.returnCarID.Location = new System.Drawing.Point(300, 128);
         this.returnCarID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.returnCarID.Name = "returnCarID";
         this.returnCarID.Size = new System.Drawing.Size(266, 42);
         this.returnCarID.TabIndex = 46;
         // 
         // errorLabel
         // 
         this.errorLabel.AutoSize = true;
         this.errorLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.errorLabel.ForeColor = System.Drawing.Color.Crimson;
         this.errorLabel.Location = new System.Drawing.Point(90, 548);
         this.errorLabel.Name = "errorLabel";
         this.errorLabel.Size = new System.Drawing.Size(118, 29);
         this.errorLabel.TabIndex = 45;
         this.errorLabel.Text = "errorLabel";
         this.errorLabel.Visible = false;
         // 
         // headerLabel
         // 
         this.headerLabel.AutoSize = true;
         this.headerLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headerLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.headerLabel.Location = new System.Drawing.Point(45, 46);
         this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.headerLabel.Name = "headerLabel";
         this.headerLabel.Size = new System.Drawing.Size(372, 50);
         this.headerLabel.TabIndex = 44;
         this.headerLabel.Text = "Return Customer Car";
         // 
         // commentLabel
         // 
         this.commentLabel.AutoSize = true;
         this.commentLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.commentLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.commentLabel.Location = new System.Drawing.Point(90, 292);
         this.commentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.commentLabel.Name = "commentLabel";
         this.commentLabel.Size = new System.Drawing.Size(160, 36);
         this.commentLabel.TabIndex = 42;
         this.commentLabel.Text = "Comments: ";
         // 
         // pickUpDate
         // 
         this.pickUpDate.CalendarFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickUpDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickUpDate.Location = new System.Drawing.Point(300, 208);
         this.pickUpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
         this.pickUpDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
         this.pickUpDate.Name = "pickUpDate";
         this.pickUpDate.Size = new System.Drawing.Size(266, 35);
         this.pickUpDate.TabIndex = 41;
         // 
         // dateLabel
         // 
         this.dateLabel.AutoSize = true;
         this.dateLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dateLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.dateLabel.Location = new System.Drawing.Point(90, 208);
         this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.dateLabel.Name = "dateLabel";
         this.dateLabel.Size = new System.Drawing.Size(196, 36);
         this.dateLabel.TabIndex = 5;
         this.dateLabel.Text = "Date Returned:";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.White;
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.commentTB);
         this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.panel1.Location = new System.Drawing.Point(300, 292);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(509, 213);
         this.panel1.TabIndex = 47;
         // 
         // commentTB
         // 
         this.commentTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.commentTB.Dock = System.Windows.Forms.DockStyle.Fill;
         this.commentTB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.commentTB.Location = new System.Drawing.Point(0, 0);
         this.commentTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(507, 211);
         this.commentTB.TabIndex = 43;
         this.commentTB.Text = "";
         // 
         // ReturnCarPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(1551, 865);
         this.Controls.Add(this.returnPanel);
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "ReturnCarPage";
         this.Text = "ReturnCar";
         this.returnPanel.ResumeLayout(false);
         this.returnPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.returnCarID)).EndInit();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel returnPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RichTextBox commentTB;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.DateTimePicker pickUpDate;
        private System.Windows.Forms.Label headerLabel;
      private System.Windows.Forms.Label errorLabel;
      private System.Windows.Forms.NumericUpDown returnCarID;
      private System.Windows.Forms.Panel panel1;
   }
}