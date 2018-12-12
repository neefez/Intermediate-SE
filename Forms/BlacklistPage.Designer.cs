namespace CarRentalSystem.Forms
{
   partial class BlacklistPage
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlacklistPage));
         this.Customerlist = new System.Windows.Forms.ListBox();
         this.label5 = new System.Windows.Forms.Label();
         this.blackListPanel = new System.Windows.Forms.Panel();
         this.sendBtn = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.blackListTxtBox = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.feeAdded = new System.Windows.Forms.Label();
         this.confirmFeeButton = new System.Windows.Forms.Button();
         this.feeAmount = new System.Windows.Forms.NumericUpDown();
         this.feeLabel = new System.Windows.Forms.Label();
         this.BlackListCB = new System.Windows.Forms.CheckBox();
         this.blackListPanel.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.feeAmount)).BeginInit();
         this.SuspendLayout();
         // 
         // Customerlist
         // 
         this.Customerlist.BackColor = System.Drawing.Color.WhiteSmoke;
         this.Customerlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Customerlist.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Customerlist.ForeColor = System.Drawing.SystemColors.WindowText;
         this.Customerlist.FormattingEnabled = true;
         this.Customerlist.ItemHeight = 23;
         this.Customerlist.Location = new System.Drawing.Point(36, 83);
         this.Customerlist.Name = "Customerlist";
         this.Customerlist.Size = new System.Drawing.Size(359, 439);
         this.Customerlist.TabIndex = 28;
         this.Customerlist.SelectedIndexChanged += new System.EventHandler(this.Customerlist_SelectedIndexChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.SteelBlue;
         this.label5.Location = new System.Drawing.Point(30, 30);
         this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(168, 33);
         this.label5.TabIndex = 29;
         this.label5.Text = "Customer List";
         // 
         // blackListPanel
         // 
         this.blackListPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.blackListPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.blackListPanel.Controls.Add(this.sendBtn);
         this.blackListPanel.Controls.Add(this.panel1);
         this.blackListPanel.Controls.Add(this.label1);
         this.blackListPanel.Controls.Add(this.feeAdded);
         this.blackListPanel.Controls.Add(this.confirmFeeButton);
         this.blackListPanel.Controls.Add(this.feeAmount);
         this.blackListPanel.Controls.Add(this.feeLabel);
         this.blackListPanel.Controls.Add(this.BlackListCB);
         this.blackListPanel.Controls.Add(this.label5);
         this.blackListPanel.Controls.Add(this.Customerlist);
         this.blackListPanel.Location = new System.Drawing.Point(48, 49);
         this.blackListPanel.Margin = new System.Windows.Forms.Padding(2);
         this.blackListPanel.Name = "blackListPanel";
         this.blackListPanel.Size = new System.Drawing.Size(649, 563);
         this.blackListPanel.TabIndex = 30;
         // 
         // sendBtn
         // 
         this.sendBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.sendBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.sendBtn.Location = new System.Drawing.Point(418, 344);
         this.sendBtn.Name = "sendBtn";
         this.sendBtn.Size = new System.Drawing.Size(200, 39);
         this.sendBtn.TabIndex = 42;
         this.sendBtn.Text = "Send";
         this.sendBtn.UseVisualStyleBackColor = true;
         this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.White;
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.blackListTxtBox);
         this.panel1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.panel1.Location = new System.Drawing.Point(419, 142);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(200, 196);
         this.panel1.TabIndex = 41;
         // 
         // blackListTxtBox
         // 
         this.blackListTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.blackListTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.blackListTxtBox.Enabled = false;
         this.blackListTxtBox.Location = new System.Drawing.Point(0, 0);
         this.blackListTxtBox.Name = "blackListTxtBox";
         this.blackListTxtBox.Size = new System.Drawing.Size(198, 194);
         this.blackListTxtBox.TabIndex = 0;
         this.blackListTxtBox.Text = "";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.SteelBlue;
         this.label1.Location = new System.Drawing.Point(414, 84);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(93, 26);
         this.label1.TabIndex = 40;
         this.label1.Text = "Ban User:";
         // 
         // feeAdded
         // 
         this.feeAdded.AutoSize = true;
         this.feeAdded.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.feeAdded.ForeColor = System.Drawing.Color.Green;
         this.feeAdded.Location = new System.Drawing.Point(418, 529);
         this.feeAdded.Name = "feeAdded";
         this.feeAdded.Size = new System.Drawing.Size(83, 19);
         this.feeAdded.TabIndex = 39;
         this.feeAdded.Text = "Fee added.";
         this.feeAdded.Visible = false;
         // 
         // confirmFeeButton
         // 
         this.confirmFeeButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.confirmFeeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.confirmFeeButton.Location = new System.Drawing.Point(418, 475);
         this.confirmFeeButton.Name = "confirmFeeButton";
         this.confirmFeeButton.Size = new System.Drawing.Size(200, 39);
         this.confirmFeeButton.TabIndex = 38;
         this.confirmFeeButton.Text = "Apply";
         this.confirmFeeButton.UseVisualStyleBackColor = true;
         this.confirmFeeButton.Click += new System.EventHandler(this.confirmFeeButton_Click);
         // 
         // feeAmount
         // 
         this.feeAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.feeAmount.Location = new System.Drawing.Point(418, 438);
         this.feeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.feeAmount.Name = "feeAmount";
         this.feeAmount.Size = new System.Drawing.Size(83, 31);
         this.feeAmount.TabIndex = 37;
         this.feeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // feeLabel
         // 
         this.feeLabel.AutoSize = true;
         this.feeLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.feeLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.feeLabel.Location = new System.Drawing.Point(413, 409);
         this.feeLabel.Name = "feeLabel";
         this.feeLabel.Size = new System.Drawing.Size(88, 26);
         this.feeLabel.TabIndex = 36;
         this.feeLabel.Text = "Add Fee:";
         // 
         // BlackListCB
         // 
         this.BlackListCB.AutoSize = true;
         this.BlackListCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BlackListCB.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.BlackListCB.Location = new System.Drawing.Point(419, 111);
         this.BlackListCB.Margin = new System.Windows.Forms.Padding(1);
         this.BlackListCB.Name = "BlackListCB";
         this.BlackListCB.Size = new System.Drawing.Size(93, 27);
         this.BlackListCB.TabIndex = 34;
         this.BlackListCB.Text = "Blacklist";
         this.BlackListCB.UseVisualStyleBackColor = true;
         this.BlackListCB.CheckedChanged += new System.EventHandler(this.RightHandControl_CheckedChanged);
         // 
         // BlacklistPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(1034, 636);
         this.Controls.Add(this.blackListPanel);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "BlacklistPage";
         this.Text = "BlacklistPage";
         this.blackListPanel.ResumeLayout(false);
         this.blackListPanel.PerformLayout();
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.feeAmount)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListBox Customerlist;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel blackListPanel;
      private System.Windows.Forms.CheckBox BlackListCB;
      private System.Windows.Forms.Button confirmFeeButton;
      private System.Windows.Forms.NumericUpDown feeAmount;
      private System.Windows.Forms.Label feeLabel;
      private System.Windows.Forms.Label feeAdded;
        private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.RichTextBox blackListTxtBox;
      private System.Windows.Forms.Button sendBtn;
   }
}