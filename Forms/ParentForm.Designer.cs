namespace CarRentalSystem.Forms
{
    partial class ParentForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
         this.titleBar = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.btnRedo = new System.Windows.Forms.Button();
         this.btnUndo = new System.Windows.Forms.Button();
         this.adminReportsBtn = new System.Windows.Forms.Button();
         this.blacklistButton = new System.Windows.Forms.Button();
         this.deleteCarButton = new System.Windows.Forms.Button();
         this.modifyButton = new System.Windows.Forms.Button();
         this.reportButton = new System.Windows.Forms.Button();
         this.searchButton = new System.Windows.Forms.Button();
         this.loggedInSearchButton = new System.Windows.Forms.Button();
         this.logOutButton = new System.Windows.Forms.Button();
         this.signUpButton = new System.Windows.Forms.Button();
         this.returnButton = new System.Windows.Forms.Button();
         this.loginButton = new System.Windows.Forms.Button();
         this.addButton = new System.Windows.Forms.Button();
         this.loginPanel = new System.Windows.Forms.Panel();
         this.wrongLabel = new System.Windows.Forms.Label();
         this.usernameBox = new System.Windows.Forms.TextBox();
         this.enterButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.passwordBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.titleBar.SuspendLayout();
         this.loginPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // titleBar
         // 
         this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.titleBar.BackColor = System.Drawing.Color.WhiteSmoke;
         this.titleBar.Controls.Add(this.label3);
         this.titleBar.Controls.Add(this.btnRedo);
         this.titleBar.Controls.Add(this.btnUndo);
         this.titleBar.Controls.Add(this.adminReportsBtn);
         this.titleBar.Controls.Add(this.blacklistButton);
         this.titleBar.Controls.Add(this.deleteCarButton);
         this.titleBar.Controls.Add(this.modifyButton);
         this.titleBar.Controls.Add(this.reportButton);
         this.titleBar.Controls.Add(this.searchButton);
         this.titleBar.Controls.Add(this.loggedInSearchButton);
         this.titleBar.Controls.Add(this.logOutButton);
         this.titleBar.Controls.Add(this.signUpButton);
         this.titleBar.Controls.Add(this.returnButton);
         this.titleBar.Controls.Add(this.loginButton);
         this.titleBar.Controls.Add(this.addButton);
         this.titleBar.Location = new System.Drawing.Point(2, 0);
         this.titleBar.Name = "titleBar";
         this.titleBar.Size = new System.Drawing.Size(1036, 68);
         this.titleBar.TabIndex = 1;
         this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.SteelBlue;
         this.label3.Location = new System.Drawing.Point(10, 15);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(191, 36);
         this.label3.TabIndex = 14;
         this.label3.Text = "A++ Car Rental";
         // 
         // btnRedo
         // 
         this.btnRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnRedo.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnRedo.Enabled = false;
         this.btnRedo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRedo.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.btnRedo.Location = new System.Drawing.Point(200, 9);
         this.btnRedo.Name = "btnRedo";
         this.btnRedo.Size = new System.Drawing.Size(67, 51);
         this.btnRedo.TabIndex = 13;
         this.btnRedo.Text = "Redo";
         this.toolTip.SetToolTip(this.btnRedo, "Nothing to Redo");
         this.btnRedo.UseVisualStyleBackColor = false;
         this.btnRedo.Visible = false;
         this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
         // 
         // btnUndo
         // 
         this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnUndo.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnUndo.Enabled = false;
         this.btnUndo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUndo.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.btnUndo.Location = new System.Drawing.Point(127, 9);
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.Size = new System.Drawing.Size(67, 51);
         this.btnUndo.TabIndex = 5;
         this.btnUndo.Text = "Undo";
         this.toolTip.SetToolTip(this.btnUndo, "Nothing to Undo");
         this.btnUndo.UseVisualStyleBackColor = false;
         this.btnUndo.Visible = false;
         this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
         // 
         // adminReportsBtn
         // 
         this.adminReportsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.adminReportsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
         this.adminReportsBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.adminReportsBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.adminReportsBtn.Location = new System.Drawing.Point(273, 0);
         this.adminReportsBtn.Name = "adminReportsBtn";
         this.adminReportsBtn.Size = new System.Drawing.Size(83, 68);
         this.adminReportsBtn.TabIndex = 12;
         this.adminReportsBtn.Text = "Reports";
         this.adminReportsBtn.UseVisualStyleBackColor = false;
         this.adminReportsBtn.Visible = false;
         this.adminReportsBtn.Click += new System.EventHandler(this.adminReportsBtn_Click);
         // 
         // blacklistButton
         // 
         this.blacklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.blacklistButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.blacklistButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.blacklistButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.blacklistButton.Location = new System.Drawing.Point(353, 0);
         this.blacklistButton.Name = "blacklistButton";
         this.blacklistButton.Size = new System.Drawing.Size(83, 68);
         this.blacklistButton.TabIndex = 11;
         this.blacklistButton.Text = "Penalize";
         this.blacklistButton.UseVisualStyleBackColor = false;
         this.blacklistButton.Visible = false;
         this.blacklistButton.Click += new System.EventHandler(this.button1_Click_1);
         // 
         // deleteCarButton
         // 
         this.deleteCarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.deleteCarButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.deleteCarButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.deleteCarButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.deleteCarButton.Location = new System.Drawing.Point(589, 0);
         this.deleteCarButton.Name = "deleteCarButton";
         this.deleteCarButton.Size = new System.Drawing.Size(83, 68);
         this.deleteCarButton.TabIndex = 7;
         this.deleteCarButton.Text = "Delete";
         this.deleteCarButton.UseVisualStyleBackColor = false;
         this.deleteCarButton.Visible = false;
         this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
         // 
         // modifyButton
         // 
         this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.modifyButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.modifyButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.modifyButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.modifyButton.Location = new System.Drawing.Point(665, 0);
         this.modifyButton.Name = "modifyButton";
         this.modifyButton.Size = new System.Drawing.Size(83, 68);
         this.modifyButton.TabIndex = 8;
         this.modifyButton.Text = "Modify";
         this.modifyButton.UseVisualStyleBackColor = false;
         this.modifyButton.Visible = false;
         this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
         // 
         // reportButton
         // 
         this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.reportButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.reportButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.reportButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.reportButton.Location = new System.Drawing.Point(589, 0);
         this.reportButton.Name = "reportButton";
         this.reportButton.Size = new System.Drawing.Size(83, 68);
         this.reportButton.TabIndex = 5;
         this.reportButton.Text = "Report";
         this.reportButton.UseVisualStyleBackColor = false;
         this.reportButton.Visible = false;
         this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
         // 
         // searchButton
         // 
         this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.searchButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.searchButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.searchButton.Location = new System.Drawing.Point(665, 0);
         this.searchButton.Name = "searchButton";
         this.searchButton.Size = new System.Drawing.Size(83, 68);
         this.searchButton.TabIndex = 3;
         this.searchButton.Text = "Search";
         this.searchButton.UseVisualStyleBackColor = false;
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // loggedInSearchButton
         // 
         this.loggedInSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.loggedInSearchButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.loggedInSearchButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.loggedInSearchButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.loggedInSearchButton.Location = new System.Drawing.Point(665, 0);
         this.loggedInSearchButton.Name = "loggedInSearchButton";
         this.loggedInSearchButton.Size = new System.Drawing.Size(83, 68);
         this.loggedInSearchButton.TabIndex = 9;
         this.loggedInSearchButton.Text = "Search";
         this.loggedInSearchButton.UseVisualStyleBackColor = false;
         this.loggedInSearchButton.Visible = false;
         this.loggedInSearchButton.Click += new System.EventHandler(this.loggedInSearchButton_Click);
         // 
         // logOutButton
         // 
         this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.logOutButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.logOutButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.logOutButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.logOutButton.Location = new System.Drawing.Point(744, 0);
         this.logOutButton.Name = "logOutButton";
         this.logOutButton.Size = new System.Drawing.Size(83, 68);
         this.logOutButton.TabIndex = 10;
         this.logOutButton.Text = "Log Out";
         this.logOutButton.UseVisualStyleBackColor = false;
         this.logOutButton.Visible = false;
         this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
         // 
         // signUpButton
         // 
         this.signUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.signUpButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.signUpButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.signUpButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.signUpButton.Location = new System.Drawing.Point(823, 0);
         this.signUpButton.Name = "signUpButton";
         this.signUpButton.Size = new System.Drawing.Size(83, 68);
         this.signUpButton.TabIndex = 2;
         this.signUpButton.Text = "Sign Up";
         this.signUpButton.UseVisualStyleBackColor = false;
         this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
         // 
         // returnButton
         // 
         this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.returnButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.returnButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.returnButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.returnButton.Location = new System.Drawing.Point(432, 0);
         this.returnButton.Name = "returnButton";
         this.returnButton.Size = new System.Drawing.Size(83, 68);
         this.returnButton.TabIndex = 6;
         this.returnButton.Text = "Return";
         this.returnButton.UseVisualStyleBackColor = false;
         this.returnButton.Visible = false;
         this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
         // 
         // loginButton
         // 
         this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.loginButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.loginButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.loginButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.loginButton.Location = new System.Drawing.Point(744, 0);
         this.loginButton.Name = "loginButton";
         this.loginButton.Size = new System.Drawing.Size(83, 68);
         this.loginButton.TabIndex = 1;
         this.loginButton.Text = "Login";
         this.loginButton.UseVisualStyleBackColor = false;
         this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
         // 
         // addButton
         // 
         this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.addButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.addButton.Location = new System.Drawing.Point(513, 0);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(83, 68);
         this.addButton.TabIndex = 6;
         this.addButton.Text = "Add";
         this.addButton.UseVisualStyleBackColor = false;
         this.addButton.Visible = false;
         this.addButton.Click += new System.EventHandler(this.adminButton_Click);
         // 
         // loginPanel
         // 
         this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.loginPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.loginPanel.Controls.Add(this.wrongLabel);
         this.loginPanel.Controls.Add(this.usernameBox);
         this.loginPanel.Controls.Add(this.enterButton);
         this.loginPanel.Controls.Add(this.label1);
         this.loginPanel.Controls.Add(this.passwordBox);
         this.loginPanel.Controls.Add(this.label2);
         this.loginPanel.Location = new System.Drawing.Point(304, 213);
         this.loginPanel.Name = "loginPanel";
         this.loginPanel.Size = new System.Drawing.Size(580, 364);
         this.loginPanel.TabIndex = 3;
         // 
         // wrongLabel
         // 
         this.wrongLabel.AutoSize = true;
         this.wrongLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.wrongLabel.ForeColor = System.Drawing.Color.Crimson;
         this.wrongLabel.Location = new System.Drawing.Point(217, 145);
         this.wrongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.wrongLabel.Name = "wrongLabel";
         this.wrongLabel.Size = new System.Drawing.Size(190, 18);
         this.wrongLabel.TabIndex = 12;
         this.wrongLabel.Text = "Please enter a valid username.";
         this.wrongLabel.Visible = false;
         // 
         // usernameBox
         // 
         this.usernameBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.usernameBox.Location = new System.Drawing.Point(211, 101);
         this.usernameBox.Name = "usernameBox";
         this.usernameBox.Size = new System.Drawing.Size(208, 31);
         this.usernameBox.TabIndex = 7;
         // 
         // enterButton
         // 
         this.enterButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.enterButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.enterButton.Location = new System.Drawing.Point(211, 230);
         this.enterButton.Name = "enterButton";
         this.enterButton.Size = new System.Drawing.Size(208, 45);
         this.enterButton.TabIndex = 11;
         this.enterButton.Text = "Log in";
         this.enterButton.UseVisualStyleBackColor = true;
         this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
         this.enterButton.Enter += new System.EventHandler(this.enterButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label1.Location = new System.Drawing.Point(106, 101);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(95, 23);
         this.label1.TabIndex = 9;
         this.label1.Text = "Username:";
         // 
         // passwordBox
         // 
         this.passwordBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.passwordBox.Location = new System.Drawing.Point(211, 172);
         this.passwordBox.Name = "passwordBox";
         this.passwordBox.PasswordChar = '•';
         this.passwordBox.Size = new System.Drawing.Size(208, 31);
         this.passwordBox.TabIndex = 8;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label2.Location = new System.Drawing.Point(110, 169);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(91, 23);
         this.label2.TabIndex = 10;
         this.label2.Text = "Password:";
         // 
         // toolTip
         // 
         this.toolTip.ShowAlways = true;
         // 
         // ParentForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.ClientSize = new System.Drawing.Size(909, 445);
         this.Controls.Add(this.loginPanel);
         this.Controls.Add(this.titleBar);
         this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ForeColor = System.Drawing.SystemColors.ControlDark;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.IsMdiContainer = true;
         this.Name = "ParentForm";
         this.titleBar.ResumeLayout(false);
         this.titleBar.PerformLayout();
         this.loginPanel.ResumeLayout(false);
         this.loginPanel.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button loggedInSearchButton;
        private System.Windows.Forms.Button logOutButton;
      private System.Windows.Forms.Button blacklistButton;
        private System.Windows.Forms.Button adminReportsBtn;
      private System.Windows.Forms.Button btnRedo;
      private System.Windows.Forms.Button btnUndo;
      private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
    }
}