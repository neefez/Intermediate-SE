namespace CarRentalSystem.Forms
{
   partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.lblRentRate = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPmtType = new System.Windows.Forms.Label();
            this.cboxPmtType = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.payPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.satNav = new System.Windows.Forms.CheckBox();
            this.babySeat = new System.Windows.Forms.CheckBox();
            this.payError = new System.Windows.Forms.Label();
            this.nullinfo2 = new System.Windows.Forms.Label();
            this.nullinfo1 = new System.Windows.Forms.Label();
            this.dropoffCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.Label();
            this.txtTotalDays = new System.Windows.Forms.Label();
            this.txtRentRate = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.payPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRentRate
            // 
            this.lblRentRate.AutoSize = true;
            this.lblRentRate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentRate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRentRate.Location = new System.Drawing.Point(41, 220);
            this.lblRentRate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRentRate.Name = "lblRentRate";
            this.lblRentRate.Size = new System.Drawing.Size(92, 23);
            this.lblRentRate.TabIndex = 0;
            this.lblRentRate.Text = "Rent Rate:";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalDays.Location = new System.Drawing.Point(41, 258);
            this.lblTotalDays.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(98, 23);
            this.lblTotalDays.TabIndex = 1;
            this.lblTotalDays.Text = "Total Days:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFees.Location = new System.Drawing.Point(43, 327);
            this.lblFees.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(135, 23);
            this.lblFees.TabIndex = 2;
            this.lblFees.Text = "Additional Fees:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCost.Location = new System.Drawing.Point(43, 363);
            this.lblCost.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(94, 23);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Total Cost:";
            // 
            // lblPmtType
            // 
            this.lblPmtType.AutoSize = true;
            this.lblPmtType.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmtType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPmtType.Location = new System.Drawing.Point(45, 80);
            this.lblPmtType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPmtType.Name = "lblPmtType";
            this.lblPmtType.Size = new System.Drawing.Size(127, 23);
            this.lblPmtType.TabIndex = 8;
            this.lblPmtType.Text = "Payment Type:";
            // 
            // cboxPmtType
            // 
            this.cboxPmtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPmtType.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPmtType.FormattingEnabled = true;
            this.cboxPmtType.Items.AddRange(new object[] {
            "Debit/Credit (online)",
            "Cash (in person)"});
            this.cboxPmtType.Location = new System.Drawing.Point(210, 80);
            this.cboxPmtType.Margin = new System.Windows.Forms.Padding(1);
            this.cboxPmtType.Name = "cboxPmtType";
            this.cboxPmtType.Size = new System.Drawing.Size(175, 31);
            this.cboxPmtType.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPay.Location = new System.Drawing.Point(320, 456);
            this.btnPay.Margin = new System.Windows.Forms.Padding(1);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(102, 40);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // payPanel
            // 
            this.payPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.payPanel.Controls.Add(this.label3);
            this.payPanel.Controls.Add(this.satNav);
            this.payPanel.Controls.Add(this.babySeat);
            this.payPanel.Controls.Add(this.payError);
            this.payPanel.Controls.Add(this.nullinfo2);
            this.payPanel.Controls.Add(this.nullinfo1);
            this.payPanel.Controls.Add(this.dropoffCB);
            this.payPanel.Controls.Add(this.label2);
            this.payPanel.Controls.Add(this.label1);
            this.payPanel.Controls.Add(this.infoLabel);
            this.payPanel.Controls.Add(this.txtCost);
            this.payPanel.Controls.Add(this.txtFees);
            this.payPanel.Controls.Add(this.txtTotalDays);
            this.payPanel.Controls.Add(this.txtRentRate);
            this.payPanel.Controls.Add(this.payLabel);
            this.payPanel.Controls.Add(this.lblRentRate);
            this.payPanel.Controls.Add(this.lblTotalDays);
            this.payPanel.Controls.Add(this.btnPay);
            this.payPanel.Controls.Add(this.lblFees);
            this.payPanel.Controls.Add(this.cboxPmtType);
            this.payPanel.Controls.Add(this.lblPmtType);
            this.payPanel.Controls.Add(this.lblCost);
            this.payPanel.Location = new System.Drawing.Point(235, 12);
            this.payPanel.Name = "payPanel";
            this.payPanel.Size = new System.Drawing.Size(449, 538);
            this.payPanel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(28, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Additional Options";
            // 
            // satNav
            // 
            this.satNav.AutoSize = true;
            this.satNav.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.satNav.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.satNav.Location = new System.Drawing.Point(44, 433);
            this.satNav.Margin = new System.Windows.Forms.Padding(2);
            this.satNav.Name = "satNav";
            this.satNav.Size = new System.Drawing.Size(172, 27);
            this.satNav.TabIndex = 25;
            this.satNav.Text = "Navigation System";
            this.satNav.UseVisualStyleBackColor = true;
            this.satNav.CheckedChanged += new System.EventHandler(this.satNav_CheckedChanged);
            // 
            // babySeat
            // 
            this.babySeat.AutoSize = true;
            this.babySeat.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.babySeat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.babySeat.Location = new System.Drawing.Point(44, 464);
            this.babySeat.Margin = new System.Windows.Forms.Padding(2);
            this.babySeat.Name = "babySeat";
            this.babySeat.Size = new System.Drawing.Size(104, 27);
            this.babySeat.TabIndex = 24;
            this.babySeat.Text = "Baby Seat";
            this.babySeat.UseVisualStyleBackColor = true;
            this.babySeat.CheckedChanged += new System.EventHandler(this.babySeat_CheckedChanged);
            // 
            // payError
            // 
            this.payError.AutoSize = true;
            this.payError.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payError.ForeColor = System.Drawing.Color.Crimson;
            this.payError.Location = new System.Drawing.Point(16, 500);
            this.payError.Name = "payError";
            this.payError.Size = new System.Drawing.Size(35, 15);
            this.payError.TabIndex = 23;
            this.payError.Text = "Sorry";
            this.payError.Visible = false;
            // 
            // nullinfo2
            // 
            this.nullinfo2.AutoSize = true;
            this.nullinfo2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullinfo2.ForeColor = System.Drawing.Color.Crimson;
            this.nullinfo2.Location = new System.Drawing.Point(210, 174);
            this.nullinfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nullinfo2.Name = "nullinfo2";
            this.nullinfo2.Size = new System.Drawing.Size(179, 15);
            this.nullinfo2.TabIndex = 22;
            this.nullinfo2.Text = "Please select a drop off location.";
            this.nullinfo2.Visible = false;
            // 
            // nullinfo1
            // 
            this.nullinfo1.AutoSize = true;
            this.nullinfo1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullinfo1.ForeColor = System.Drawing.Color.Crimson;
            this.nullinfo1.Location = new System.Drawing.Point(210, 112);
            this.nullinfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nullinfo1.Name = "nullinfo1";
            this.nullinfo1.Size = new System.Drawing.Size(164, 15);
            this.nullinfo1.TabIndex = 21;
            this.nullinfo1.Text = "Please select a payment type.";
            this.nullinfo1.Visible = false;
            // 
            // dropoffCB
            // 
            this.dropoffCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropoffCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropoffCB.FormattingEnabled = true;
            this.dropoffCB.Items.AddRange(new object[] {
            "Platteville",
            "Dubuque",
            "Madison"});
            this.dropoffCB.Location = new System.Drawing.Point(210, 137);
            this.dropoffCB.Margin = new System.Windows.Forms.Padding(1);
            this.dropoffCB.Name = "dropoffCB";
            this.dropoffCB.Size = new System.Drawing.Size(175, 31);
            this.dropoffCB.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drop Off Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cost Information";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.infoLabel.Location = new System.Drawing.Point(31, 189);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(185, 26);
            this.infoLabel.TabIndex = 17;
            this.infoLabel.Text = "General Information";
            // 
            // txtCost
            // 
            this.txtCost.AutoSize = true;
            this.txtCost.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCost.Location = new System.Drawing.Point(189, 363);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(42, 23);
            this.txtCost.TabIndex = 16;
            this.txtCost.Text = "cost";
            // 
            // txtFees
            // 
            this.txtFees.AutoSize = true;
            this.txtFees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFees.Location = new System.Drawing.Point(189, 327);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(42, 23);
            this.txtFees.TabIndex = 15;
            this.txtFees.Text = "fees";
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.AutoSize = true;
            this.txtTotalDays.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDays.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalDays.Location = new System.Drawing.Point(144, 258);
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.Size = new System.Drawing.Size(46, 23);
            this.txtTotalDays.TabIndex = 14;
            this.txtTotalDays.Text = "days";
            // 
            // txtRentRate
            // 
            this.txtRentRate.AutoSize = true;
            this.txtRentRate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentRate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRentRate.Location = new System.Drawing.Point(145, 222);
            this.txtRentRate.Name = "txtRentRate";
            this.txtRentRate.Size = new System.Drawing.Size(42, 23);
            this.txtRentRate.TabIndex = 13;
            this.txtRentRate.Text = "rent";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.payLabel.Location = new System.Drawing.Point(30, 30);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(195, 26);
            this.payLabel.TabIndex = 12;
            this.payLabel.Text = "Payment Information";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.payPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            this.payPanel.ResumeLayout(false);
            this.payPanel.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lblRentRate;
      private System.Windows.Forms.Label lblTotalDays;
      private System.Windows.Forms.Label lblFees;
      private System.Windows.Forms.Label lblCost;
      private System.Windows.Forms.Label lblPmtType;
      private System.Windows.Forms.ComboBox cboxPmtType;
      private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel payPanel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label txtRentRate;
        private System.Windows.Forms.Label txtCost;
        private System.Windows.Forms.Label txtFees;
        private System.Windows.Forms.Label txtTotalDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox dropoffCB;
        private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label nullinfo2;
      private System.Windows.Forms.Label nullinfo1;
      private System.Windows.Forms.CheckBox satNav;
      private System.Windows.Forms.CheckBox babySeat;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label payError;
   }
}