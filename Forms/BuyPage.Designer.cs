namespace CarRentalSystem.Forms
{
    partial class BuyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyPage));
            this.buyPanel = new System.Windows.Forms.Panel();
            this.money = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carInfoLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.buyLabel = new System.Windows.Forms.Label();
            this.moneyAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyPanel
            // 
            this.buyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.buyPanel.Controls.Add(this.money);
            this.buyPanel.Controls.Add(this.label2);
            this.buyPanel.Controls.Add(this.carInfoLabel);
            this.buyPanel.Controls.Add(this.buyButton);
            this.buyPanel.Controls.Add(this.buyLabel);
            this.buyPanel.Controls.Add(this.moneyAmountLabel);
            this.buyPanel.Controls.Add(this.label1);
            this.buyPanel.Location = new System.Drawing.Point(241, 331);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(519, 213);
            this.buyPanel.TabIndex = 0;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(131, 110);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(20, 23);
            this.money.TabIndex = 6;
            this.money.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle:";
            // 
            // carInfoLabel
            // 
            this.carInfoLabel.AutoSize = true;
            this.carInfoLabel.Location = new System.Drawing.Point(131, 73);
            this.carInfoLabel.Name = "carInfoLabel";
            this.carInfoLabel.Size = new System.Drawing.Size(64, 23);
            this.carInfoLabel.TabIndex = 4;
            this.carInfoLabel.Text = "carInfo";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(194, 153);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(157, 40);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.buyLabel.Location = new System.Drawing.Point(30, 30);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(133, 29);
            this.buyLabel.TabIndex = 2;
            this.buyLabel.Text = "Buy Vehicle ";
            // 
            // moneyAmountLabel
            // 
            this.moneyAmountLabel.AutoSize = true;
            this.moneyAmountLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountLabel.Location = new System.Drawing.Point(146, 110);
            this.moneyAmountLabel.Name = "moneyAmountLabel";
            this.moneyAmountLabel.Size = new System.Drawing.Size(70, 23);
            this.moneyAmountLabel.TabIndex = 1;
            this.moneyAmountLabel.Text = "amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // BuyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(909, 445);
            this.Controls.Add(this.buyPanel);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BuyPage";
            this.Text = "BuyPage";
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.Label moneyAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label buyLabel;
      private System.Windows.Forms.Label carInfoLabel;
      private System.Windows.Forms.Button buyButton;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label money;
   }
}