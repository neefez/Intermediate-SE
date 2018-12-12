namespace CarRentalSystem.Forms
{
    partial class CreateUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserPage));
            this.nextButton = new System.Windows.Forms.Button();
            this.createAccLabel = new System.Windows.Forms.Label();
            this.password2unmatch = new System.Windows.Forms.Label();
            this.createAccPanel = new System.Windows.Forms.Panel();
            this.badIDlabel = new System.Windows.Forms.Label();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.reEnterTextBox = new System.Windows.Forms.TextBox();
            this.reEnterLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDfield = new System.Windows.Forms.NumericUpDown();
            this.createAccPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDfield)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nextButton.Location = new System.Drawing.Point(196, 438);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 40);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Create";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // createAccLabel
            // 
            this.createAccLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createAccLabel.Location = new System.Drawing.Point(30, 30);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new System.Drawing.Size(216, 33);
            this.createAccLabel.TabIndex = 7;
            this.createAccLabel.Text = "Create an Account";
            // 
            // password2unmatch
            // 
            this.password2unmatch.AutoSize = true;
            this.password2unmatch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2unmatch.ForeColor = System.Drawing.Color.Crimson;
            this.password2unmatch.Location = new System.Drawing.Point(99, 426);
            this.password2unmatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password2unmatch.Name = "password2unmatch";
            this.password2unmatch.Size = new System.Drawing.Size(217, 19);
            this.password2unmatch.TabIndex = 12;
            this.password2unmatch.Text = "Password entries do not match.";
            this.password2unmatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password2unmatch.Visible = false;
            // 
            // createAccPanel
            // 
            this.createAccPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createAccPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.createAccPanel.Controls.Add(this.badIDlabel);
            this.createAccPanel.Controls.Add(this.nextButton);
            this.createAccPanel.Controls.Add(this.employeeTextBox);
            this.createAccPanel.Controls.Add(this.employeeLabel);
            this.createAccPanel.Controls.Add(this.adminRadio);
            this.createAccPanel.Controls.Add(this.userRadio);
            this.createAccPanel.Controls.Add(this.label1);
            this.createAccPanel.Controls.Add(this.label2);
            this.createAccPanel.Controls.Add(this.lastNameBox);
            this.createAccPanel.Controls.Add(this.reEnterTextBox);
            this.createAccPanel.Controls.Add(this.reEnterLabel);
            this.createAccPanel.Controls.Add(this.firstNameBox);
            this.createAccPanel.Controls.Add(this.label3);
            this.createAccPanel.Controls.Add(this.passwordTextBox);
            this.createAccPanel.Controls.Add(this.userNameLabel);
            this.createAccPanel.Controls.Add(this.passwordLabel);
            this.createAccPanel.Controls.Add(this.userNameTextBox);
            this.createAccPanel.Controls.Add(this.createAccLabel);
            this.createAccPanel.Controls.Add(this.password2unmatch);
            this.createAccPanel.Location = new System.Drawing.Point(302, 117);
            this.createAccPanel.Name = "createAccPanel";
            this.createAccPanel.Size = new System.Drawing.Size(406, 516);
            this.createAccPanel.TabIndex = 13;
            // 
            // badIDlabel
            // 
            this.badIDlabel.AutoSize = true;
            this.badIDlabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badIDlabel.ForeColor = System.Drawing.Color.Crimson;
            this.badIDlabel.Location = new System.Drawing.Point(131, 474);
            this.badIDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.badIDlabel.Name = "badIDlabel";
            this.badIDlabel.Size = new System.Drawing.Size(203, 19);
            this.badIDlabel.TabIndex = 15;
            this.badIDlabel.Text = "Please enter a valid admin ID.";
            this.badIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.badIDlabel.Visible = false;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(-6, 427);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeTextBox.TabIndex = 30;
            this.employeeTextBox.Visible = false;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(42, 474);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(35, 13);
            this.employeeLabel.TabIndex = 29;
            this.employeeLabel.Text = "label4";
            this.employeeLabel.Visible = false;
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.adminRadio.Location = new System.Drawing.Point(275, 89);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(71, 23);
            this.adminRadio.TabIndex = 2;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            this.adminRadio.CheckedChanged += new System.EventHandler(this.adminRadio_CheckedChanged);
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Checked = true;
            this.userRadio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.userRadio.Location = new System.Drawing.Point(196, 89);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(57, 23);
            this.userRadio.TabIndex = 1;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "User";
            this.userRadio.UseVisualStyleBackColor = true;
            this.userRadio.CheckedChanged += new System.EventHandler(this.userRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(66, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(66, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(196, 199);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(150, 31);
            this.lastNameBox.TabIndex = 4;
            // 
            // reEnterTextBox
            // 
            this.reEnterTextBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterTextBox.Location = new System.Drawing.Point(196, 379);
            this.reEnterTextBox.Name = "reEnterTextBox";
            this.reEnterTextBox.PasswordChar = '•';
            this.reEnterTextBox.Size = new System.Drawing.Size(150, 31);
            this.reEnterTextBox.TabIndex = 7;
            // 
            // reEnterLabel
            // 
            this.reEnterLabel.AutoSize = true;
            this.reEnterLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.reEnterLabel.Location = new System.Drawing.Point(66, 379);
            this.reEnterLabel.Name = "reEnterLabel";
            this.reEnterLabel.Size = new System.Drawing.Size(82, 23);
            this.reEnterLabel.TabIndex = 23;
            this.reEnterLabel.Text = "Re-enter:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(196, 139);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(150, 31);
            this.firstNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(66, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(196, 319);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 31);
            this.passwordTextBox.TabIndex = 6;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.userNameLabel.Location = new System.Drawing.Point(66, 259);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 23);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passwordLabel.Location = new System.Drawing.Point(66, 319);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 23);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(196, 259);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.userNameTextBox.TabIndex = 5;
            // 
            // employeeIDfield
            // 
            this.employeeIDfield.Location = new System.Drawing.Point(658, 536);
            this.employeeIDfield.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIDfield.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.employeeIDfield.Name = "employeeIDfield";
            this.employeeIDfield.Size = new System.Drawing.Size(149, 20);
            this.employeeIDfield.TabIndex = 14;
            this.employeeIDfield.Visible = false;
            // 
            // CreateUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1034, 685);
            this.Controls.Add(this.employeeIDfield);
            this.Controls.Add(this.createAccPanel);
            this.Name = "CreateUserPage";
            this.Text = "CreateUser";
            this.createAccPanel.ResumeLayout(false);
            this.createAccPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDfield)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nextButton;
      private System.Windows.Forms.Label createAccLabel;
      private System.Windows.Forms.Label password2unmatch;
        private System.Windows.Forms.Panel createAccPanel;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox reEnterTextBox;
        private System.Windows.Forms.Label reEnterLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox employeeTextBox;
      private System.Windows.Forms.NumericUpDown employeeIDfield;
      private System.Windows.Forms.Label badIDlabel;
   }
}