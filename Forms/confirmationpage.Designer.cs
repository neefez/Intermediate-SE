using CarRentalSystem.DBObjects;

namespace CarRentalSystem.Forms
{
    partial class ConfirmationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationPage));
            this.conformationPanel = new System.Windows.Forms.Panel();
            this.numLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.conformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conformationPanel
            // 
            this.conformationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conformationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.conformationPanel.Controls.Add(this.numLabel);
            this.conformationPanel.Controls.Add(this.label1);
            this.conformationPanel.Controls.Add(this.payLabel);
            this.conformationPanel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformationPanel.Location = new System.Drawing.Point(347, 251);
            this.conformationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.conformationPanel.Name = "conformationPanel";
            this.conformationPanel.Size = new System.Drawing.Size(371, 156);
            this.conformationPanel.TabIndex = 0;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(257, 86);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(20, 23);
            this.numLabel.TabIndex = 15;
            this.numLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Order Number is :";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.payLabel.Location = new System.Drawing.Point(26, 32);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(320, 33);
            this.payLabel.TabIndex = 13;
            this.payLabel.Text = "Your payment is completed.";
            // 
            // ConfirmationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1014, 685);
            this.Controls.Add(this.conformationPanel);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "ConfirmationPage";
            this.Text = "BlankForm";
            this.conformationPanel.ResumeLayout(false);
            this.conformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.Panel conformationPanel;
      private System.Windows.Forms.Label payLabel;
      private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numLabel;
   }
}