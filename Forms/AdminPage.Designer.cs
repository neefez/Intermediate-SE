namespace CarRentalSystem.Forms
{
   partial class AdminPage
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.rightHandCheck = new System.Windows.Forms.CheckBox();
         this.manualCheck = new System.Windows.Forms.CheckBox();
         this.bntAddVehicle = new System.Windows.Forms.Button();
         this.carTypeCB = new System.Windows.Forms.ComboBox();
         this.carColorCB = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.carMakeCB = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.rateBox = new System.Windows.Forms.NumericUpDown();
         this.carLocationCB = new System.Windows.Forms.ComboBox();
         this.label8 = new System.Windows.Forms.Label();
         this.addPanel = new System.Windows.Forms.Panel();
         this.lblResponseMessage = new System.Windows.Forms.Label();
         this.carModelCB = new System.Windows.Forms.TextBox();
         this.carYearCB = new System.Windows.Forms.NumericUpDown();
         this.addCarLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.rateBox)).BeginInit();
         this.addPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.carYearCB)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label1.Location = new System.Drawing.Point(60, 73);
         this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(53, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Type:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label2.Location = new System.Drawing.Point(60, 127);
         this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Color:";
         // 
         // rightHandCheck
         // 
         this.rightHandCheck.AutoSize = true;
         this.rightHandCheck.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rightHandCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.rightHandCheck.Location = new System.Drawing.Point(322, 173);
         this.rightHandCheck.Margin = new System.Windows.Forms.Padding(1);
         this.rightHandCheck.Name = "rightHandCheck";
         this.rightHandCheck.Size = new System.Drawing.Size(177, 27);
         this.rightHandCheck.TabIndex = 4;
         this.rightHandCheck.Text = "Right-hand Control";
         this.rightHandCheck.UseVisualStyleBackColor = true;
         // 
         // manualCheck
         // 
         this.manualCheck.AutoSize = true;
         this.manualCheck.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.manualCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.manualCheck.Location = new System.Drawing.Point(322, 228);
         this.manualCheck.Margin = new System.Windows.Forms.Padding(1);
         this.manualCheck.Name = "manualCheck";
         this.manualCheck.Size = new System.Drawing.Size(193, 27);
         this.manualCheck.TabIndex = 6;
         this.manualCheck.Text = "Manual Transmission";
         this.manualCheck.UseVisualStyleBackColor = true;
         // 
         // bntAddVehicle
         // 
         this.bntAddVehicle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.bntAddVehicle.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.bntAddVehicle.Location = new System.Drawing.Point(322, 278);
         this.bntAddVehicle.Margin = new System.Windows.Forms.Padding(1);
         this.bntAddVehicle.Name = "bntAddVehicle";
         this.bntAddVehicle.Size = new System.Drawing.Size(216, 40);
         this.bntAddVehicle.TabIndex = 7;
         this.bntAddVehicle.Text = "Add Vehicle";
         this.bntAddVehicle.UseVisualStyleBackColor = true;
         this.bntAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
         // 
         // carTypeCB
         // 
         this.carTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.carTypeCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carTypeCB.FormattingEnabled = true;
         this.carTypeCB.Items.AddRange(new object[] {
            "Sedan",
            "Luxury",
            "Sports Car",
            "SUV",
            "Van",
            "Truck",
            "Hatchback"});
         this.carTypeCB.Location = new System.Drawing.Point(154, 73);
         this.carTypeCB.Margin = new System.Windows.Forms.Padding(1);
         this.carTypeCB.Name = "carTypeCB";
         this.carTypeCB.Size = new System.Drawing.Size(122, 31);
         this.carTypeCB.TabIndex = 9;
         // 
         // carColorCB
         // 
         this.carColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.carColorCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carColorCB.FormattingEnabled = true;
         this.carColorCB.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "White",
            "Silver",
            "Grey",
            "Brown",
            "Green"});
         this.carColorCB.Location = new System.Drawing.Point(154, 127);
         this.carColorCB.Margin = new System.Windows.Forms.Padding(1);
         this.carColorCB.Name = "carColorCB";
         this.carColorCB.Size = new System.Drawing.Size(122, 31);
         this.carColorCB.TabIndex = 10;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label4.Location = new System.Drawing.Point(60, 172);
         this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(49, 23);
         this.label4.TabIndex = 12;
         this.label4.Text = "Year:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label5.Location = new System.Drawing.Point(60, 226);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(68, 23);
         this.label5.TabIndex = 14;
         this.label5.Text = " Model:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label6.Location = new System.Drawing.Point(60, 278);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(58, 23);
         this.label6.TabIndex = 15;
         this.label6.Text = "Make:";
         // 
         // carMakeCB
         // 
         this.carMakeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.carMakeCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carMakeCB.FormattingEnabled = true;
         this.carMakeCB.Items.AddRange(new object[] {
            "Ford",
            "GMC",
            "BMW"});
         this.carMakeCB.Location = new System.Drawing.Point(154, 278);
         this.carMakeCB.Name = "carMakeCB";
         this.carMakeCB.Size = new System.Drawing.Size(122, 31);
         this.carMakeCB.TabIndex = 16;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label7.Location = new System.Drawing.Point(318, 127);
         this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(51, 23);
         this.label7.TabIndex = 19;
         this.label7.Text = "Rate:";
         // 
         // rateBox
         // 
         this.rateBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rateBox.Location = new System.Drawing.Point(416, 127);
         this.rateBox.Margin = new System.Windows.Forms.Padding(2);
         this.rateBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.rateBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.rateBox.Name = "rateBox";
         this.rateBox.Size = new System.Drawing.Size(122, 31);
         this.rateBox.TabIndex = 20;
         this.rateBox.ThousandsSeparator = true;
         this.rateBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
         // 
         // carLocationCB
         // 
         this.carLocationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.carLocationCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carLocationCB.FormattingEnabled = true;
         this.carLocationCB.Items.AddRange(new object[] {
            "Platteville",
            "Madison",
            "Dubuque"});
         this.carLocationCB.Location = new System.Drawing.Point(416, 73);
         this.carLocationCB.Name = "carLocationCB";
         this.carLocationCB.Size = new System.Drawing.Size(122, 31);
         this.carLocationCB.TabIndex = 23;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label8.Location = new System.Drawing.Point(318, 73);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(83, 23);
         this.label8.TabIndex = 22;
         this.label8.Text = "Location:";
         // 
         // addPanel
         // 
         this.addPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.addPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.addPanel.Controls.Add(this.lblResponseMessage);
         this.addPanel.Controls.Add(this.carModelCB);
         this.addPanel.Controls.Add(this.carYearCB);
         this.addPanel.Controls.Add(this.addCarLabel);
         this.addPanel.Controls.Add(this.carLocationCB);
         this.addPanel.Controls.Add(this.label1);
         this.addPanel.Controls.Add(this.label8);
         this.addPanel.Controls.Add(this.label2);
         this.addPanel.Controls.Add(this.rateBox);
         this.addPanel.Controls.Add(this.label7);
         this.addPanel.Controls.Add(this.rightHandCheck);
         this.addPanel.Controls.Add(this.carMakeCB);
         this.addPanel.Controls.Add(this.manualCheck);
         this.addPanel.Controls.Add(this.label6);
         this.addPanel.Controls.Add(this.bntAddVehicle);
         this.addPanel.Controls.Add(this.label5);
         this.addPanel.Controls.Add(this.carTypeCB);
         this.addPanel.Controls.Add(this.carColorCB);
         this.addPanel.Controls.Add(this.label4);
         this.addPanel.Location = new System.Drawing.Point(179, 66);
         this.addPanel.Name = "addPanel";
         this.addPanel.Size = new System.Drawing.Size(582, 376);
         this.addPanel.TabIndex = 24;
         // 
         // lblResponseMessage
         // 
         this.lblResponseMessage.AutoSize = true;
         this.lblResponseMessage.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblResponseMessage.ForeColor = System.Drawing.Color.Green;
         this.lblResponseMessage.Location = new System.Drawing.Point(330, 332);
         this.lblResponseMessage.Name = "lblResponseMessage";
         this.lblResponseMessage.Size = new System.Drawing.Size(199, 18);
         this.lblResponseMessage.TabIndex = 28;
         this.lblResponseMessage.Text = "Vehicle was successfully added.";
         this.lblResponseMessage.Visible = false;
         // 
         // carModelCB
         // 
         this.carModelCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carModelCB.Location = new System.Drawing.Point(154, 226);
         this.carModelCB.Name = "carModelCB";
         this.carModelCB.Size = new System.Drawing.Size(122, 31);
         this.carModelCB.TabIndex = 27;
         // 
         // carYearCB
         // 
         this.carYearCB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carYearCB.Location = new System.Drawing.Point(154, 172);
         this.carYearCB.Margin = new System.Windows.Forms.Padding(2);
         this.carYearCB.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.carYearCB.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
         this.carYearCB.Name = "carYearCB";
         this.carYearCB.Size = new System.Drawing.Size(122, 31);
         this.carYearCB.TabIndex = 26;
         this.carYearCB.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
         // 
         // addCarLabel
         // 
         this.addCarLabel.AutoSize = true;
         this.addCarLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addCarLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.addCarLabel.Location = new System.Drawing.Point(30, 30);
         this.addCarLabel.Name = "addCarLabel";
         this.addCarLabel.Size = new System.Drawing.Size(102, 33);
         this.addCarLabel.TabIndex = 24;
         this.addCarLabel.Text = "Add Car";
         // 
         // AdminPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(1034, 561);
         this.Controls.Add(this.addPanel);
         this.Margin = new System.Windows.Forms.Padding(1);
         this.Name = "AdminPage";
         this.Text = "Form2";
         ((System.ComponentModel.ISupportInitialize)(this.rateBox)).EndInit();
         this.addPanel.ResumeLayout(false);
         this.addPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.carYearCB)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.CheckBox babySeatCheck;
      private System.Windows.Forms.CheckBox rightHandCheck;
      private System.Windows.Forms.CheckBox navigationSystemCheck;
      private System.Windows.Forms.CheckBox manualCheck;
      private System.Windows.Forms.Button bntAddVehicle;
      private System.Windows.Forms.ComboBox carTypeCB;
      private System.Windows.Forms.ComboBox carColorCB;
      private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox carMakeCB;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.NumericUpDown rateBox;
      private System.Windows.Forms.ComboBox carLocationCB;
      private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label addCarLabel;
        private System.Windows.Forms.TextBox carModelCB;
        private System.Windows.Forms.NumericUpDown carYearCB;
      private System.Windows.Forms.Label lblResponseMessage;
   }
}