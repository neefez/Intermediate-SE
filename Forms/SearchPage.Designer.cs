namespace CarRentalSystem.Forms
{
   partial class SearchPage
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPage));
         this.label4 = new System.Windows.Forms.Label();
         this.colorCB = new System.Windows.Forms.ComboBox();
         this.carTypeCB = new System.Windows.Forms.ComboBox();
         this.ManualTransmission = new System.Windows.Forms.CheckBox();
         this.RightHandControl = new System.Windows.Forms.CheckBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.yearBoxFirst = new System.Windows.Forms.NumericUpDown();
         this.yearBoxSecond = new System.Windows.Forms.NumericUpDown();
         this.label6 = new System.Windows.Forms.Label();
         this.searchPanel = new System.Windows.Forms.Panel();
         this.listView1 = new System.Windows.Forms.ListView();
         this.label21 = new System.Windows.Forms.Label();
         this.makeComboBox = new System.Windows.Forms.ComboBox();
         this.toLabel = new System.Windows.Forms.Label();
         this.fromLabel = new System.Windows.Forms.Label();
         this.dropOffDate = new System.Windows.Forms.DateTimePicker();
         this.pickUpDate = new System.Windows.Forms.DateTimePicker();
         this.PickUpBox = new System.Windows.Forms.ComboBox();
         this.datesLabel = new System.Windows.Forms.Label();
         this.locationLabel = new System.Windows.Forms.Label();
         this.pickUpLabel = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.carInfoPanel = new System.Windows.Forms.Panel();
         this.disclamerLabel = new System.Windows.Forms.Label();
         this.deleteButton = new System.Windows.Forms.Button();
         this.whichTransmissionLabel = new System.Windows.Forms.Label();
         this.whichRightLabel = new System.Windows.Forms.Label();
         this.whichNavLabel = new System.Windows.Forms.Label();
         this.whichBabyLabel = new System.Windows.Forms.Label();
         this.whichColorLabel = new System.Windows.Forms.Label();
         this.whichYearLabel = new System.Windows.Forms.Label();
         this.whichTypeLabel = new System.Windows.Forms.Label();
         this.whichModelLabel = new System.Windows.Forms.Label();
         this.whichMakeLabel = new System.Windows.Forms.Label();
         this.optionsLabel = new System.Windows.Forms.Label();
         this.attributesLabel = new System.Windows.Forms.Label();
         this.rightLabel = new System.Windows.Forms.Label();
         this.navLabel = new System.Windows.Forms.Label();
         this.transmissonLabel = new System.Windows.Forms.Label();
         this.babyLabel = new System.Windows.Forms.Label();
         this.typeLabel = new System.Windows.Forms.Label();
         this.colorLabel = new System.Windows.Forms.Label();
         this.yearLabel = new System.Windows.Forms.Label();
         this.modelLabel = new System.Windows.Forms.Label();
         this.makeLabel = new System.Windows.Forms.Label();
         this.backButton = new System.Windows.Forms.Button();
         this.buyButton = new System.Windows.Forms.Button();
         this.rentButton = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.modifyPanel = new System.Windows.Forms.Panel();
         this.savedLabel = new System.Windows.Forms.Label();
         this.saveButton = new System.Windows.Forms.Button();
         this.transmissionM = new System.Windows.Forms.CheckBox();
         this.rightM = new System.Windows.Forms.CheckBox();
         this.colorM = new System.Windows.Forms.ComboBox();
         this.yearM = new System.Windows.Forms.NumericUpDown();
         this.typeM = new System.Windows.Forms.ComboBox();
         this.makeM = new System.Windows.Forms.ComboBox();
         this.modelM = new System.Windows.Forms.TextBox();
         this.label13 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.label16 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.label19 = new System.Windows.Forms.Label();
         this.label20 = new System.Windows.Forms.Label();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.yearBoxFirst)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearBoxSecond)).BeginInit();
         this.searchPanel.SuspendLayout();
         this.carInfoPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.modifyPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.yearM)).BeginInit();
         this.SuspendLayout();
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label4.Location = new System.Drawing.Point(88, 237);
         this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(57, 23);
         this.label4.TabIndex = 24;
         this.label4.Text = "From:";
         // 
         // colorCB
         // 
         this.colorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.colorCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.colorCB.FormattingEnabled = true;
         this.colorCB.Items.AddRange(new object[] {
            "None",
            "Black",
            "Red",
            "Blue",
            "White",
            "Silver",
            "Grey",
            "Brown",
            "Green"});
         this.colorCB.Location = new System.Drawing.Point(130, 120);
         this.colorCB.Margin = new System.Windows.Forms.Padding(1);
         this.colorCB.Name = "colorCB";
         this.colorCB.Size = new System.Drawing.Size(118, 31);
         this.colorCB.TabIndex = 22;
         this.colorCB.SelectedIndexChanged += new System.EventHandler(this.colorCB_SelectedIndexChanged);
         // 
         // carTypeCB
         // 
         this.carTypeCB.BackColor = System.Drawing.SystemColors.Window;
         this.carTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.carTypeCB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carTypeCB.FormattingEnabled = true;
         this.carTypeCB.Items.AddRange(new object[] {
            "None",
            "Sedan",
            "Luxury",
            "Sports Car",
            "SUV",
            "Van",
            "Truck",
            "Hatchback"});
         this.carTypeCB.Location = new System.Drawing.Point(130, 70);
         this.carTypeCB.Margin = new System.Windows.Forms.Padding(1);
         this.carTypeCB.Name = "carTypeCB";
         this.carTypeCB.Size = new System.Drawing.Size(118, 31);
         this.carTypeCB.TabIndex = 21;
         this.carTypeCB.SelectedIndexChanged += new System.EventHandler(this.carTypyCB_SelectedIndexChanged);
         // 
         // ManualTransmission
         // 
         this.ManualTransmission.AutoSize = true;
         this.ManualTransmission.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ManualTransmission.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.ManualTransmission.Location = new System.Drawing.Point(67, 335);
         this.ManualTransmission.Margin = new System.Windows.Forms.Padding(1);
         this.ManualTransmission.Name = "ManualTransmission";
         this.ManualTransmission.Size = new System.Drawing.Size(193, 27);
         this.ManualTransmission.TabIndex = 19;
         this.ManualTransmission.Text = "Manual Transmission";
         this.ManualTransmission.UseVisualStyleBackColor = true;
         this.ManualTransmission.CheckedChanged += new System.EventHandler(this.ManualTransmission_CheckedChanged);
         // 
         // RightHandControl
         // 
         this.RightHandControl.AutoSize = true;
         this.RightHandControl.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RightHandControl.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.RightHandControl.Location = new System.Drawing.Point(67, 370);
         this.RightHandControl.Margin = new System.Windows.Forms.Padding(1);
         this.RightHandControl.Name = "RightHandControl";
         this.RightHandControl.Size = new System.Drawing.Size(177, 27);
         this.RightHandControl.TabIndex = 17;
         this.RightHandControl.Text = "Right-hand Control";
         this.RightHandControl.UseVisualStyleBackColor = true;
         this.RightHandControl.CheckedChanged += new System.EventHandler(this.RightHandControl_CheckedChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label2.Location = new System.Drawing.Point(60, 120);
         this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 23);
         this.label2.TabIndex = 14;
         this.label2.Text = "Color:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label1.Location = new System.Drawing.Point(63, 70);
         this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(53, 23);
         this.label1.TabIndex = 13;
         this.label1.Text = "Type:";
         // 
         // yearBoxFirst
         // 
         this.yearBoxFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.yearBoxFirst.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.yearBoxFirst.Location = new System.Drawing.Point(161, 240);
         this.yearBoxFirst.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.yearBoxFirst.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
         this.yearBoxFirst.Name = "yearBoxFirst";
         this.yearBoxFirst.Size = new System.Drawing.Size(87, 31);
         this.yearBoxFirst.TabIndex = 28;
         this.yearBoxFirst.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
         this.yearBoxFirst.ValueChanged += new System.EventHandler(this.yearBoxFirst_ValueChanged);
         // 
         // yearBoxSecond
         // 
         this.yearBoxSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.yearBoxSecond.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.yearBoxSecond.Location = new System.Drawing.Point(161, 285);
         this.yearBoxSecond.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.yearBoxSecond.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
         this.yearBoxSecond.Name = "yearBoxSecond";
         this.yearBoxSecond.Size = new System.Drawing.Size(87, 31);
         this.yearBoxSecond.TabIndex = 30;
         this.yearBoxSecond.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.yearBoxSecond.ValueChanged += new System.EventHandler(this.yearBoxSecond_ValueChanged);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label6.Location = new System.Drawing.Point(88, 285);
         this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(35, 23);
         this.label6.TabIndex = 29;
         this.label6.Text = "To:";
         // 
         // searchPanel
         // 
         this.searchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.searchPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.searchPanel.Controls.Add(this.listView1);
         this.searchPanel.Controls.Add(this.label21);
         this.searchPanel.Controls.Add(this.makeComboBox);
         this.searchPanel.Controls.Add(this.toLabel);
         this.searchPanel.Controls.Add(this.fromLabel);
         this.searchPanel.Controls.Add(this.dropOffDate);
         this.searchPanel.Controls.Add(this.pickUpDate);
         this.searchPanel.Controls.Add(this.PickUpBox);
         this.searchPanel.Controls.Add(this.datesLabel);
         this.searchPanel.Controls.Add(this.locationLabel);
         this.searchPanel.Controls.Add(this.pickUpLabel);
         this.searchPanel.Controls.Add(this.label8);
         this.searchPanel.Controls.Add(this.label7);
         this.searchPanel.Controls.Add(this.yearBoxSecond);
         this.searchPanel.Controls.Add(this.label5);
         this.searchPanel.Controls.Add(this.label6);
         this.searchPanel.Controls.Add(this.label1);
         this.searchPanel.Controls.Add(this.yearBoxFirst);
         this.searchPanel.Controls.Add(this.label2);
         this.searchPanel.Controls.Add(this.label4);
         this.searchPanel.Controls.Add(this.colorCB);
         this.searchPanel.Controls.Add(this.carTypeCB);
         this.searchPanel.Controls.Add(this.RightHandControl);
         this.searchPanel.Controls.Add(this.ManualTransmission);
         this.searchPanel.Location = new System.Drawing.Point(194, 30);
         this.searchPanel.Name = "searchPanel";
         this.searchPanel.Size = new System.Drawing.Size(754, 603);
         this.searchPanel.TabIndex = 31;
         // 
         // listView1
         // 
         this.listView1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.listView1.Location = new System.Drawing.Point(359, 70);
         this.listView1.MultiSelect = false;
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(352, 462);
         this.listView1.TabIndex = 46;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
         // 
         // label21
         // 
         this.label21.AutoSize = true;
         this.label21.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label21.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label21.Location = new System.Drawing.Point(60, 173);
         this.label21.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(58, 23);
         this.label21.TabIndex = 44;
         this.label21.Text = "Make:";
         // 
         // makeComboBox
         // 
         this.makeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.makeComboBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.makeComboBox.FormattingEnabled = true;
         this.makeComboBox.Items.AddRange(new object[] {
            "None",
            "Ford",
            "BMW",
            "GMC"});
         this.makeComboBox.Location = new System.Drawing.Point(130, 173);
         this.makeComboBox.Margin = new System.Windows.Forms.Padding(1);
         this.makeComboBox.Name = "makeComboBox";
         this.makeComboBox.Size = new System.Drawing.Size(118, 31);
         this.makeComboBox.TabIndex = 45;
         this.makeComboBox.SelectedIndexChanged += new System.EventHandler(this.makeComboBox_SelectedIndexChanged);
         // 
         // toLabel
         // 
         this.toLabel.AutoSize = true;
         this.toLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.toLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.toLabel.Location = new System.Drawing.Point(88, 561);
         this.toLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.toLabel.Name = "toLabel";
         this.toLabel.Size = new System.Drawing.Size(35, 23);
         this.toLabel.TabIndex = 43;
         this.toLabel.Text = "To:";
         // 
         // fromLabel
         // 
         this.fromLabel.AutoSize = true;
         this.fromLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fromLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.fromLabel.Location = new System.Drawing.Point(84, 521);
         this.fromLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.fromLabel.Name = "fromLabel";
         this.fromLabel.Size = new System.Drawing.Size(57, 23);
         this.fromLabel.TabIndex = 42;
         this.fromLabel.Text = "From:";
         // 
         // dropOffDate
         // 
         this.dropOffDate.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
         this.dropOffDate.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
         this.dropOffDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dropOffDate.Location = new System.Drawing.Point(152, 561);
         this.dropOffDate.Margin = new System.Windows.Forms.Padding(2);
         this.dropOffDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
         this.dropOffDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
         this.dropOffDate.Name = "dropOffDate";
         this.dropOffDate.Size = new System.Drawing.Size(179, 21);
         this.dropOffDate.TabIndex = 41;
         this.dropOffDate.ValueChanged += new System.EventHandler(this.dropOffDate_ValueChanged);
         // 
         // pickUpDate
         // 
         this.pickUpDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickUpDate.Location = new System.Drawing.Point(152, 521);
         this.pickUpDate.Margin = new System.Windows.Forms.Padding(2);
         this.pickUpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
         this.pickUpDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
         this.pickUpDate.Name = "pickUpDate";
         this.pickUpDate.Size = new System.Drawing.Size(179, 21);
         this.pickUpDate.TabIndex = 40;
         this.pickUpDate.ValueChanged += new System.EventHandler(this.pickUpDate_ValueChanged);
         // 
         // PickUpBox
         // 
         this.PickUpBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.PickUpBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.PickUpBox.FormattingEnabled = true;
         this.PickUpBox.Items.AddRange(new object[] {
            "None",
            "Platteville",
            "Dubuque",
            "Madison"});
         this.PickUpBox.Location = new System.Drawing.Point(145, 452);
         this.PickUpBox.Name = "PickUpBox";
         this.PickUpBox.Size = new System.Drawing.Size(103, 31);
         this.PickUpBox.TabIndex = 38;
         this.PickUpBox.SelectedIndexChanged += new System.EventHandler(this.PickUpBox_SelectedIndexChanged);
         // 
         // datesLabel
         // 
         this.datesLabel.AutoSize = true;
         this.datesLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.datesLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.datesLabel.Location = new System.Drawing.Point(58, 493);
         this.datesLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.datesLabel.Name = "datesLabel";
         this.datesLabel.Size = new System.Drawing.Size(65, 23);
         this.datesLabel.TabIndex = 36;
         this.datesLabel.Text = " Dates:";
         // 
         // locationLabel
         // 
         this.locationLabel.AutoSize = true;
         this.locationLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.locationLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.locationLabel.Location = new System.Drawing.Point(58, 455);
         this.locationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.locationLabel.Name = "locationLabel";
         this.locationLabel.Size = new System.Drawing.Size(83, 23);
         this.locationLabel.TabIndex = 34;
         this.locationLabel.Text = "Location:";
         // 
         // pickUpLabel
         // 
         this.pickUpLabel.AutoSize = true;
         this.pickUpLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickUpLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.pickUpLabel.Location = new System.Drawing.Point(26, 409);
         this.pickUpLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.pickUpLabel.Name = "pickUpLabel";
         this.pickUpLabel.Size = new System.Drawing.Size(190, 26);
         this.pickUpLabel.TabIndex = 33;
         this.pickUpLabel.Text = "Pick Up and Drop Off";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label8.Location = new System.Drawing.Point(60, 212);
         this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(49, 23);
         this.label8.TabIndex = 32;
         this.label8.Text = "Year:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.SteelBlue;
         this.label7.Location = new System.Drawing.Point(30, 30);
         this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(124, 26);
         this.label7.TabIndex = 31;
         this.label7.Text = "Car Selection";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.SteelBlue;
         this.label5.Location = new System.Drawing.Point(353, 30);
         this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(94, 33);
         this.label5.TabIndex = 26;
         this.label5.Text = "Results";
         // 
         // carInfoPanel
         // 
         this.carInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.carInfoPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.carInfoPanel.Controls.Add(this.disclamerLabel);
         this.carInfoPanel.Controls.Add(this.deleteButton);
         this.carInfoPanel.Controls.Add(this.whichTransmissionLabel);
         this.carInfoPanel.Controls.Add(this.whichRightLabel);
         this.carInfoPanel.Controls.Add(this.whichNavLabel);
         this.carInfoPanel.Controls.Add(this.whichBabyLabel);
         this.carInfoPanel.Controls.Add(this.whichColorLabel);
         this.carInfoPanel.Controls.Add(this.whichYearLabel);
         this.carInfoPanel.Controls.Add(this.whichTypeLabel);
         this.carInfoPanel.Controls.Add(this.whichModelLabel);
         this.carInfoPanel.Controls.Add(this.whichMakeLabel);
         this.carInfoPanel.Controls.Add(this.optionsLabel);
         this.carInfoPanel.Controls.Add(this.attributesLabel);
         this.carInfoPanel.Controls.Add(this.rightLabel);
         this.carInfoPanel.Controls.Add(this.navLabel);
         this.carInfoPanel.Controls.Add(this.transmissonLabel);
         this.carInfoPanel.Controls.Add(this.babyLabel);
         this.carInfoPanel.Controls.Add(this.typeLabel);
         this.carInfoPanel.Controls.Add(this.colorLabel);
         this.carInfoPanel.Controls.Add(this.yearLabel);
         this.carInfoPanel.Controls.Add(this.modelLabel);
         this.carInfoPanel.Controls.Add(this.makeLabel);
         this.carInfoPanel.Controls.Add(this.backButton);
         this.carInfoPanel.Controls.Add(this.buyButton);
         this.carInfoPanel.Controls.Add(this.rentButton);
         this.carInfoPanel.Controls.Add(this.pictureBox1);
         this.carInfoPanel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.carInfoPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.carInfoPanel.Location = new System.Drawing.Point(175, 164);
         this.carInfoPanel.Name = "carInfoPanel";
         this.carInfoPanel.Size = new System.Drawing.Size(760, 549);
         this.carInfoPanel.TabIndex = 33;
         this.carInfoPanel.Visible = false;
         // 
         // disclamerLabel
         // 
         this.disclamerLabel.AutoSize = true;
         this.disclamerLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.disclamerLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.disclamerLabel.Location = new System.Drawing.Point(35, 355);
         this.disclamerLabel.Name = "disclamerLabel";
         this.disclamerLabel.Size = new System.Drawing.Size(402, 57);
         this.disclamerLabel.TabIndex = 38;
         this.disclamerLabel.Text = "*If you would like to purchase or rent a vehicle please login.\r\n  If you do not h" +
    "ave an account you must create an account\r\n  in order to login. Thank you for yo" +
    "ur patience.";
         // 
         // deleteButton
         // 
         this.deleteButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.deleteButton.Location = new System.Drawing.Point(178, 403);
         this.deleteButton.Margin = new System.Windows.Forms.Padding(1);
         this.deleteButton.Name = "deleteButton";
         this.deleteButton.Size = new System.Drawing.Size(85, 52);
         this.deleteButton.TabIndex = 37;
         this.deleteButton.Text = "Delete";
         this.deleteButton.UseVisualStyleBackColor = true;
         this.deleteButton.Visible = false;
         this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
         // 
         // whichTransmissionLabel
         // 
         this.whichTransmissionLabel.AutoSize = true;
         this.whichTransmissionLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichTransmissionLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichTransmissionLabel.Location = new System.Drawing.Point(667, 460);
         this.whichTransmissionLabel.Name = "whichTransmissionLabel";
         this.whichTransmissionLabel.Size = new System.Drawing.Size(37, 23);
         this.whichTransmissionLabel.TabIndex = 36;
         this.whichTransmissionLabel.Text = "Yes";
         // 
         // whichRightLabel
         // 
         this.whichRightLabel.AutoSize = true;
         this.whichRightLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichRightLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichRightLabel.Location = new System.Drawing.Point(667, 425);
         this.whichRightLabel.Name = "whichRightLabel";
         this.whichRightLabel.Size = new System.Drawing.Size(37, 23);
         this.whichRightLabel.TabIndex = 35;
         this.whichRightLabel.Text = "Yes";
         // 
         // whichNavLabel
         // 
         this.whichNavLabel.AutoSize = true;
         this.whichNavLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichNavLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichNavLabel.Location = new System.Drawing.Point(667, 390);
         this.whichNavLabel.Name = "whichNavLabel";
         this.whichNavLabel.Size = new System.Drawing.Size(37, 23);
         this.whichNavLabel.TabIndex = 34;
         this.whichNavLabel.Text = "Yes";
         // 
         // whichBabyLabel
         // 
         this.whichBabyLabel.AutoSize = true;
         this.whichBabyLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichBabyLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichBabyLabel.Location = new System.Drawing.Point(667, 355);
         this.whichBabyLabel.Name = "whichBabyLabel";
         this.whichBabyLabel.Size = new System.Drawing.Size(37, 23);
         this.whichBabyLabel.TabIndex = 33;
         this.whichBabyLabel.Text = "Yes";
         // 
         // whichColorLabel
         // 
         this.whichColorLabel.AutoSize = true;
         this.whichColorLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichColorLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichColorLabel.Location = new System.Drawing.Point(557, 275);
         this.whichColorLabel.Name = "whichColorLabel";
         this.whichColorLabel.Size = new System.Drawing.Size(48, 23);
         this.whichColorLabel.TabIndex = 32;
         this.whichColorLabel.Text = "color";
         // 
         // whichYearLabel
         // 
         this.whichYearLabel.AutoSize = true;
         this.whichYearLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichYearLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichYearLabel.Location = new System.Drawing.Point(557, 240);
         this.whichYearLabel.Name = "whichYearLabel";
         this.whichYearLabel.Size = new System.Drawing.Size(43, 23);
         this.whichYearLabel.TabIndex = 31;
         this.whichYearLabel.Text = "year";
         // 
         // whichTypeLabel
         // 
         this.whichTypeLabel.AutoSize = true;
         this.whichTypeLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichTypeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichTypeLabel.Location = new System.Drawing.Point(557, 205);
         this.whichTypeLabel.Name = "whichTypeLabel";
         this.whichTypeLabel.Size = new System.Drawing.Size(45, 23);
         this.whichTypeLabel.TabIndex = 30;
         this.whichTypeLabel.Text = "type";
         // 
         // whichModelLabel
         // 
         this.whichModelLabel.AutoSize = true;
         this.whichModelLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichModelLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichModelLabel.Location = new System.Drawing.Point(557, 170);
         this.whichModelLabel.Name = "whichModelLabel";
         this.whichModelLabel.Size = new System.Drawing.Size(59, 23);
         this.whichModelLabel.TabIndex = 29;
         this.whichModelLabel.Text = "model";
         // 
         // whichMakeLabel
         // 
         this.whichMakeLabel.AutoSize = true;
         this.whichMakeLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.whichMakeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.whichMakeLabel.Location = new System.Drawing.Point(557, 135);
         this.whichMakeLabel.Name = "whichMakeLabel";
         this.whichMakeLabel.Size = new System.Drawing.Size(53, 23);
         this.whichMakeLabel.TabIndex = 28;
         this.whichMakeLabel.Text = "make";
         // 
         // optionsLabel
         // 
         this.optionsLabel.AutoSize = true;
         this.optionsLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionsLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.optionsLabel.Location = new System.Drawing.Point(457, 315);
         this.optionsLabel.Name = "optionsLabel";
         this.optionsLabel.Size = new System.Drawing.Size(94, 29);
         this.optionsLabel.TabIndex = 27;
         this.optionsLabel.Text = "Options";
         // 
         // attributesLabel
         // 
         this.attributesLabel.AutoSize = true;
         this.attributesLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.attributesLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.attributesLabel.Location = new System.Drawing.Point(457, 95);
         this.attributesLabel.Name = "attributesLabel";
         this.attributesLabel.Size = new System.Drawing.Size(113, 29);
         this.attributesLabel.TabIndex = 26;
         this.attributesLabel.Text = "Attributes";
         // 
         // rightLabel
         // 
         this.rightLabel.AutoSize = true;
         this.rightLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rightLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.rightLabel.Location = new System.Drawing.Point(482, 425);
         this.rightLabel.Name = "rightLabel";
         this.rightLabel.Size = new System.Drawing.Size(164, 23);
         this.rightLabel.TabIndex = 25;
         this.rightLabel.Text = "Right Hand Control:";
         // 
         // navLabel
         // 
         this.navLabel.AutoSize = true;
         this.navLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.navLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.navLabel.Location = new System.Drawing.Point(482, 390);
         this.navLabel.Name = "navLabel";
         this.navLabel.Size = new System.Drawing.Size(163, 23);
         this.navLabel.TabIndex = 24;
         this.navLabel.Text = "Navigation System:";
         // 
         // transmissonLabel
         // 
         this.transmissonLabel.AutoSize = true;
         this.transmissonLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.transmissonLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.transmissonLabel.Location = new System.Drawing.Point(482, 460);
         this.transmissonLabel.Name = "transmissonLabel";
         this.transmissonLabel.Size = new System.Drawing.Size(179, 23);
         this.transmissonLabel.TabIndex = 23;
         this.transmissonLabel.Text = "Manual Transmission:";
         // 
         // babyLabel
         // 
         this.babyLabel.AutoSize = true;
         this.babyLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.babyLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.babyLabel.Location = new System.Drawing.Point(482, 355);
         this.babyLabel.Name = "babyLabel";
         this.babyLabel.Size = new System.Drawing.Size(101, 23);
         this.babyLabel.TabIndex = 22;
         this.babyLabel.Text = "Baby Seats:";
         // 
         // typeLabel
         // 
         this.typeLabel.AutoSize = true;
         this.typeLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.typeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.typeLabel.Location = new System.Drawing.Point(482, 205);
         this.typeLabel.Name = "typeLabel";
         this.typeLabel.Size = new System.Drawing.Size(53, 23);
         this.typeLabel.TabIndex = 21;
         this.typeLabel.Text = "Type:";
         // 
         // colorLabel
         // 
         this.colorLabel.AutoSize = true;
         this.colorLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.colorLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.colorLabel.Location = new System.Drawing.Point(482, 275);
         this.colorLabel.Name = "colorLabel";
         this.colorLabel.Size = new System.Drawing.Size(56, 23);
         this.colorLabel.TabIndex = 20;
         this.colorLabel.Text = "Color:";
         // 
         // yearLabel
         // 
         this.yearLabel.AutoSize = true;
         this.yearLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.yearLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.yearLabel.Location = new System.Drawing.Point(482, 240);
         this.yearLabel.Name = "yearLabel";
         this.yearLabel.Size = new System.Drawing.Size(49, 23);
         this.yearLabel.TabIndex = 19;
         this.yearLabel.Text = "Year:";
         // 
         // modelLabel
         // 
         this.modelLabel.AutoSize = true;
         this.modelLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.modelLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.modelLabel.Location = new System.Drawing.Point(482, 170);
         this.modelLabel.Name = "modelLabel";
         this.modelLabel.Size = new System.Drawing.Size(64, 23);
         this.modelLabel.TabIndex = 18;
         this.modelLabel.Text = "Model:";
         // 
         // makeLabel
         // 
         this.makeLabel.AutoSize = true;
         this.makeLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.makeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.makeLabel.Location = new System.Drawing.Point(482, 135);
         this.makeLabel.Name = "makeLabel";
         this.makeLabel.Size = new System.Drawing.Size(58, 23);
         this.makeLabel.TabIndex = 17;
         this.makeLabel.Text = "Make:";
         // 
         // backButton
         // 
         this.backButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.backButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.backButton.Location = new System.Drawing.Point(486, 27);
         this.backButton.Margin = new System.Windows.Forms.Padding(1);
         this.backButton.Name = "backButton";
         this.backButton.Size = new System.Drawing.Size(221, 52);
         this.backButton.TabIndex = 14;
         this.backButton.Text = "Back to Search Results";
         this.backButton.UseVisualStyleBackColor = true;
         this.backButton.Click += new System.EventHandler(this.backButton_Click);
         // 
         // buyButton
         // 
         this.buyButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buyButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.buyButton.Location = new System.Drawing.Point(91, 405);
         this.buyButton.Margin = new System.Windows.Forms.Padding(1);
         this.buyButton.Name = "buyButton";
         this.buyButton.Size = new System.Drawing.Size(85, 52);
         this.buyButton.TabIndex = 13;
         this.buyButton.Text = "Buy";
         this.buyButton.UseVisualStyleBackColor = true;
         this.buyButton.Visible = false;
         this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
         // 
         // rentButton
         // 
         this.rentButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rentButton.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.rentButton.Location = new System.Drawing.Point(263, 403);
         this.rentButton.Margin = new System.Windows.Forms.Padding(1);
         this.rentButton.Name = "rentButton";
         this.rentButton.Size = new System.Drawing.Size(87, 54);
         this.rentButton.TabIndex = 12;
         this.rentButton.Text = "Rent";
         this.rentButton.UseVisualStyleBackColor = true;
         this.rentButton.Visible = false;
         this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.pictureBox1.Location = new System.Drawing.Point(39, 27);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(398, 304);
         this.pictureBox1.TabIndex = 10;
         this.pictureBox1.TabStop = false;
         // 
         // modifyPanel
         // 
         this.modifyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.modifyPanel.BackColor = System.Drawing.Color.Gainsboro;
         this.modifyPanel.Controls.Add(this.savedLabel);
         this.modifyPanel.Controls.Add(this.saveButton);
         this.modifyPanel.Controls.Add(this.transmissionM);
         this.modifyPanel.Controls.Add(this.rightM);
         this.modifyPanel.Controls.Add(this.colorM);
         this.modifyPanel.Controls.Add(this.yearM);
         this.modifyPanel.Controls.Add(this.typeM);
         this.modifyPanel.Controls.Add(this.makeM);
         this.modifyPanel.Controls.Add(this.modelM);
         this.modifyPanel.Controls.Add(this.label13);
         this.modifyPanel.Controls.Add(this.label14);
         this.modifyPanel.Controls.Add(this.label15);
         this.modifyPanel.Controls.Add(this.label16);
         this.modifyPanel.Controls.Add(this.label17);
         this.modifyPanel.Controls.Add(this.label18);
         this.modifyPanel.Controls.Add(this.label19);
         this.modifyPanel.Controls.Add(this.label20);
         this.modifyPanel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.modifyPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.modifyPanel.Location = new System.Drawing.Point(314, 149);
         this.modifyPanel.Name = "modifyPanel";
         this.modifyPanel.Size = new System.Drawing.Size(407, 563);
         this.modifyPanel.TabIndex = 34;
         this.modifyPanel.Visible = false;
         // 
         // savedLabel
         // 
         this.savedLabel.AutoSize = true;
         this.savedLabel.ForeColor = System.Drawing.Color.SeaGreen;
         this.savedLabel.Location = new System.Drawing.Point(70, 499);
         this.savedLabel.Name = "savedLabel";
         this.savedLabel.Size = new System.Drawing.Size(170, 23);
         this.savedLabel.TabIndex = 68;
         this.savedLabel.Text = "Save was successful.";
         this.savedLabel.Visible = false;
         // 
         // saveButton
         // 
         this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.saveButton.Location = new System.Drawing.Point(271, 490);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(102, 40);
         this.saveButton.TabIndex = 67;
         this.saveButton.Text = "Save";
         this.saveButton.UseVisualStyleBackColor = true;
         this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
         // 
         // transmissionM
         // 
         this.transmissionM.AutoSize = true;
         this.transmissionM.Location = new System.Drawing.Point(92, 449);
         this.transmissionM.Name = "transmissionM";
         this.transmissionM.Size = new System.Drawing.Size(197, 27);
         this.transmissionM.TabIndex = 66;
         this.transmissionM.Text = "Manual Transmission ";
         this.transmissionM.UseVisualStyleBackColor = true;
         // 
         // rightM
         // 
         this.rightM.AutoSize = true;
         this.rightM.Location = new System.Drawing.Point(92, 401);
         this.rightM.Name = "rightM";
         this.rightM.Size = new System.Drawing.Size(178, 27);
         this.rightM.TabIndex = 65;
         this.rightM.Text = "Right Hand Control";
         this.rightM.UseVisualStyleBackColor = true;
         // 
         // colorM
         // 
         this.colorM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.colorM.FormattingEnabled = true;
         this.colorM.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "White",
            "Silver",
            "Grey",
            "Brown",
            "Green"});
         this.colorM.Location = new System.Drawing.Point(179, 305);
         this.colorM.Name = "colorM";
         this.colorM.Size = new System.Drawing.Size(121, 31);
         this.colorM.TabIndex = 62;
         // 
         // yearM
         // 
         this.yearM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.yearM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.yearM.Location = new System.Drawing.Point(179, 255);
         this.yearM.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.yearM.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
         this.yearM.Name = "yearM";
         this.yearM.Size = new System.Drawing.Size(121, 31);
         this.yearM.TabIndex = 61;
         this.yearM.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
         // 
         // typeM
         // 
         this.typeM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.typeM.FormattingEnabled = true;
         this.typeM.Items.AddRange(new object[] {
            "Sedan",
            "Luxury",
            "Sports Car",
            "SUV",
            "Van",
            "Truck",
            "Hatchback"});
         this.typeM.Location = new System.Drawing.Point(179, 205);
         this.typeM.Name = "typeM";
         this.typeM.Size = new System.Drawing.Size(121, 31);
         this.typeM.TabIndex = 60;
         // 
         // makeM
         // 
         this.makeM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.makeM.FormattingEnabled = true;
         this.makeM.Items.AddRange(new object[] {
            "Ford",
            "GMC",
            "BMW"});
         this.makeM.Location = new System.Drawing.Point(179, 108);
         this.makeM.Name = "makeM";
         this.makeM.Size = new System.Drawing.Size(121, 31);
         this.makeM.TabIndex = 59;
         // 
         // modelM
         // 
         this.modelM.Location = new System.Drawing.Point(179, 152);
         this.modelM.Name = "modelM";
         this.modelM.Size = new System.Drawing.Size(119, 31);
         this.modelM.TabIndex = 69;
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label13.Location = new System.Drawing.Point(60, 358);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(80, 26);
         this.label13.TabIndex = 47;
         this.label13.Text = "Options";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label14.Location = new System.Drawing.Point(60, 69);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(98, 26);
         this.label14.TabIndex = 46;
         this.label14.Text = "Attributes";
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label15.Location = new System.Drawing.Point(100, 205);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(53, 23);
         this.label15.TabIndex = 41;
         this.label15.Text = "Type:";
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label16.Location = new System.Drawing.Point(100, 305);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(56, 23);
         this.label16.TabIndex = 40;
         this.label16.Text = "Color:";
         // 
         // label17
         // 
         this.label17.AutoSize = true;
         this.label17.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label17.Location = new System.Drawing.Point(100, 255);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(49, 23);
         this.label17.TabIndex = 39;
         this.label17.Text = "Year:";
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label18.Location = new System.Drawing.Point(100, 155);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(64, 23);
         this.label18.TabIndex = 38;
         this.label18.Text = "Model:";
         // 
         // label19
         // 
         this.label19.AutoSize = true;
         this.label19.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label19.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.label19.Location = new System.Drawing.Point(100, 108);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(58, 23);
         this.label19.TabIndex = 37;
         this.label19.Text = "Make:";
         // 
         // label20
         // 
         this.label20.AutoSize = true;
         this.label20.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label20.ForeColor = System.Drawing.Color.SteelBlue;
         this.label20.Location = new System.Drawing.Point(30, 30);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(135, 33);
         this.label20.TabIndex = 0;
         this.label20.Text = "Modify Car";
         // 
         // imageList1
         // 
         this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList1.Images.SetKeyName(0, "Sedan.png");
         this.imageList1.Images.SetKeyName(1, "Hatchback.png");
         this.imageList1.Images.SetKeyName(2, "Luxury.bmp");
         this.imageList1.Images.SetKeyName(3, "Sports Car.bmp");
         this.imageList1.Images.SetKeyName(4, "SportsCar.png");
         this.imageList1.Images.SetKeyName(5, "SUV.bmp");
         this.imageList1.Images.SetKeyName(6, "Truck.jpg");
         this.imageList1.Images.SetKeyName(7, "Van.png");
         // 
         // SearchPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(1012, 685);
         this.Controls.Add(this.searchPanel);
         this.Controls.Add(this.modifyPanel);
         this.Controls.Add(this.carInfoPanel);
         this.Margin = new System.Windows.Forms.Padding(1);
         this.Name = "SearchPage";
         this.Text = "SearchPage";
         ((System.ComponentModel.ISupportInitialize)(this.yearBoxFirst)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearBoxSecond)).EndInit();
         this.searchPanel.ResumeLayout(false);
         this.searchPanel.PerformLayout();
         this.carInfoPanel.ResumeLayout(false);
         this.carInfoPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.modifyPanel.ResumeLayout(false);
         this.modifyPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.yearM)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox colorCB;
      private System.Windows.Forms.ComboBox carTypeCB;
      private System.Windows.Forms.CheckBox ManualTransmission;
      private System.Windows.Forms.CheckBox RightHandControl;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown yearBoxFirst;
      private System.Windows.Forms.NumericUpDown yearBoxSecond;
      private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel carInfoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Label transmissonLabel;
        private System.Windows.Forms.Label babyLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label whichTransmissionLabel;
        private System.Windows.Forms.Label whichRightLabel;
        private System.Windows.Forms.Label whichNavLabel;
        private System.Windows.Forms.Label whichBabyLabel;
        private System.Windows.Forms.Label whichColorLabel;
        private System.Windows.Forms.Label whichYearLabel;
        private System.Windows.Forms.Label whichTypeLabel;
        private System.Windows.Forms.Label whichModelLabel;
        private System.Windows.Forms.Label whichMakeLabel;
        private System.Windows.Forms.Label pickUpLabel;
        private System.Windows.Forms.DateTimePicker dropOffDate;
        private System.Windows.Forms.DateTimePicker pickUpDate;
        private System.Windows.Forms.ComboBox PickUpBox;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel modifyPanel;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox transmissionM;
        private System.Windows.Forms.CheckBox rightM;
        private System.Windows.Forms.ComboBox colorM;
        private System.Windows.Forms.NumericUpDown yearM;
        private System.Windows.Forms.ComboBox typeM;
        private System.Windows.Forms.ComboBox makeM;
        private System.Windows.Forms.TextBox modelM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.Label disclamerLabel;
      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ImageList imageList1;
   }
}