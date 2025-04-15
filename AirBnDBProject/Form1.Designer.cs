namespace AirBnDBProject
{
    partial class Form1
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
            this.Add = new System.Windows.Forms.Button();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.txtBox_UserFullName = new System.Windows.Forms.TextBox();
            this.label_UserFullName = new System.Windows.Forms.Label();
            this.txtBox_UserPhoneNumber = new System.Windows.Forms.TextBox();
            this.label_UserPhoneNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label_PageNameUser = new System.Windows.Forms.Label();
            this.label_ErrorResponseUser = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPageHost = new System.Windows.Forms.TabPage();
            this.label_ErrorResponseHost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_HostID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddHost = new System.Windows.Forms.Button();
            this.label_HostPhoneNumber = new System.Windows.Forms.Label();
            this.label_HostFullName = new System.Windows.Forms.Label();
            this.txtBox_HostPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBox_HostName = new System.Windows.Forms.TextBox();
            this.hostDataGrid = new System.Windows.Forms.DataGridView();
            this.TabPageProperty = new System.Windows.Forms.TabPage();
            this.label_ErrorResponseProperty = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_PropertyHost = new System.Windows.Forms.Label();
            this.label_PropertyCountry = new System.Windows.Forms.Label();
            this.label_PropertyType = new System.Windows.Forms.Label();
            this.label_PropertyPrice = new System.Windows.Forms.Label();
            this.label_PropertyAddress = new System.Windows.Forms.Label();
            this.comboBox_PropertyHostId = new System.Windows.Forms.ComboBox();
            this.txtBox_PropertyCountry = new System.Windows.Forms.TextBox();
            this.txtBox_PropertyType = new System.Windows.Forms.TextBox();
            this.txtBox_PropertyPrice = new System.Windows.Forms.TextBox();
            this.txtBox_PropertyAddress = new System.Windows.Forms.TextBox();
            this.propertyDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPageBooking = new System.Windows.Forms.TabPage();
            this.UpdateButtonBooking = new System.Windows.Forms.Button();
            this.label_ErrorResponseBooking = new System.Windows.Forms.Label();
            this.label_TbarPropertyRatingResult = new System.Windows.Forms.Label();
            this.tbar_PropertyRating = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_BookingRating = new System.Windows.Forms.Label();
            this.label_BookingEndDate = new System.Windows.Forms.Label();
            this.label_BookingStartDate = new System.Windows.Forms.Label();
            this.label_BookingPropertyAddress = new System.Windows.Forms.Label();
            this.label_BookingUserName = new System.Windows.Forms.Label();
            this.bookingDataGrid = new System.Windows.Forms.DataGridView();
            this.datePickerBookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerBookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_BookingAddress = new System.Windows.Forms.ComboBox();
            this.comboBox_BookingUsername = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.tabPageHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostDataGrid)).BeginInit();
            this.TabPageProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataGrid)).BeginInit();
            this.tabPageBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_PropertyRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 357);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 35);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Btn_AddUser);
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(608, 31);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowHeadersWidth = 62;
            this.usersDataGrid.RowTemplate.Height = 28;
            this.usersDataGrid.Size = new System.Drawing.Size(549, 454);
            this.usersDataGrid.TabIndex = 2;
            this.usersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGrid_CellContentClick);
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Location = new System.Drawing.Point(14, 286);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(162, 26);
            this.txtBox_UserName.TabIndex = 3;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(14, 260);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(87, 20);
            this.label_UserName.TabIndex = 4;
            this.label_UserName.Text = "Username:";
            // 
            // txtBox_UserFullName
            // 
            this.txtBox_UserFullName.Location = new System.Drawing.Point(220, 286);
            this.txtBox_UserFullName.Name = "txtBox_UserFullName";
            this.txtBox_UserFullName.Size = new System.Drawing.Size(162, 26);
            this.txtBox_UserFullName.TabIndex = 5;
            // 
            // label_UserFullName
            // 
            this.label_UserFullName.AutoSize = true;
            this.label_UserFullName.Location = new System.Drawing.Point(218, 260);
            this.label_UserFullName.Name = "label_UserFullName";
            this.label_UserFullName.Size = new System.Drawing.Size(84, 20);
            this.label_UserFullName.TabIndex = 6;
            this.label_UserFullName.Text = "Full Name:";
            // 
            // txtBox_UserPhoneNumber
            // 
            this.txtBox_UserPhoneNumber.Location = new System.Drawing.Point(435, 286);
            this.txtBox_UserPhoneNumber.Name = "txtBox_UserPhoneNumber";
            this.txtBox_UserPhoneNumber.Size = new System.Drawing.Size(162, 26);
            this.txtBox_UserPhoneNumber.TabIndex = 7;
            // 
            // label_UserPhoneNumber
            // 
            this.label_UserPhoneNumber.AutoSize = true;
            this.label_UserPhoneNumber.Location = new System.Drawing.Point(430, 260);
            this.label_UserPhoneNumber.Name = "label_UserPhoneNumber";
            this.label_UserPhoneNumber.Size = new System.Drawing.Size(113, 20);
            this.label_UserPhoneNumber.TabIndex = 8;
            this.label_UserPhoneNumber.Text = "Phonenumber:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_DeleteUser);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUser);
            this.tabControl.Controls.Add(this.tabPageHost);
            this.tabControl.Controls.Add(this.TabPageProperty);
            this.tabControl.Controls.Add(this.tabPageBooking);
            this.tabControl.Location = new System.Drawing.Point(0, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 660);
            this.tabControl.TabIndex = 10;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.label3);
            this.tabPageUser.Controls.Add(this.label_PageNameUser);
            this.tabPageUser.Controls.Add(this.label_ErrorResponseUser);
            this.tabPageUser.Controls.Add(this.button7);
            this.tabPageUser.Controls.Add(this.txtBox_UserPhoneNumber);
            this.tabPageUser.Controls.Add(this.button1);
            this.tabPageUser.Controls.Add(this.txtBox_UserName);
            this.tabPageUser.Controls.Add(this.Add);
            this.tabPageUser.Controls.Add(this.usersDataGrid);
            this.tabPageUser.Controls.Add(this.label_UserPhoneNumber);
            this.tabPageUser.Controls.Add(this.label_UserName);
            this.tabPageUser.Controls.Add(this.txtBox_UserFullName);
            this.tabPageUser.Controls.Add(this.label_UserFullName);
            this.tabPageUser.Location = new System.Drawing.Point(4, 29);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(1192, 627);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User Page";
            this.tabPageUser.UseVisualStyleBackColor = true;
            this.tabPageUser.Click += new System.EventHandler(this.tabPageUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 529);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // label_PageNameUser
            // 
            this.label_PageNameUser.AutoSize = true;
            this.label_PageNameUser.Location = new System.Drawing.Point(48, 57);
            this.label_PageNameUser.Name = "label_PageNameUser";
            this.label_PageNameUser.Size = new System.Drawing.Size(203, 20);
            this.label_PageNameUser.TabIndex = 12;
            this.label_PageNameUser.Text = "Welcome to the User Page!";
            // 
            // label_ErrorResponseUser
            // 
            this.label_ErrorResponseUser.AutoSize = true;
            this.label_ErrorResponseUser.Location = new System.Drawing.Point(220, 551);
            this.label_ErrorResponseUser.Name = "label_ErrorResponseUser";
            this.label_ErrorResponseUser.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorResponseUser.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 466);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn_UpdateUser);
            // 
            // tabPageHost
            // 
            this.tabPageHost.Controls.Add(this.label_ErrorResponseHost);
            this.tabPageHost.Controls.Add(this.label2);
            this.tabPageHost.Controls.Add(this.button8);
            this.tabPageHost.Controls.Add(this.label1);
            this.tabPageHost.Controls.Add(this.txtBox_HostID);
            this.tabPageHost.Controls.Add(this.button2);
            this.tabPageHost.Controls.Add(this.AddHost);
            this.tabPageHost.Controls.Add(this.label_HostPhoneNumber);
            this.tabPageHost.Controls.Add(this.label_HostFullName);
            this.tabPageHost.Controls.Add(this.txtBox_HostPhoneNumber);
            this.tabPageHost.Controls.Add(this.txtBox_HostName);
            this.tabPageHost.Controls.Add(this.hostDataGrid);
            this.tabPageHost.Location = new System.Drawing.Point(4, 29);
            this.tabPageHost.Name = "tabPageHost";
            this.tabPageHost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHost.Size = new System.Drawing.Size(1192, 627);
            this.tabPageHost.TabIndex = 1;
            this.tabPageHost.Text = "Host Page";
            this.tabPageHost.UseVisualStyleBackColor = true;
            this.tabPageHost.Click += new System.EventHandler(this.tabPageHost_Click);
            // 
            // label_ErrorResponseHost
            // 
            this.label_ErrorResponseHost.AutoSize = true;
            this.label_ErrorResponseHost.Location = new System.Drawing.Point(586, 545);
            this.label_ErrorResponseHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ErrorResponseHost.Name = "label_ErrorResponseHost";
            this.label_ErrorResponseHost.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorResponseHost.TabIndex = 14;
            this.label_ErrorResponseHost.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome to the Host page!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 485);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 35);
            this.button8.TabIndex = 11;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn_UpdateHost);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "HostId: (will be generated)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_HostID
            // 
            this.txtBox_HostID.Location = new System.Drawing.Point(14, 286);
            this.txtBox_HostID.Name = "txtBox_HostID";
            this.txtBox_HostID.ReadOnly = true;
            this.txtBox_HostID.Size = new System.Drawing.Size(168, 26);
            this.txtBox_HostID.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_DeleteHost);
            // 
            // AddHost
            // 
            this.AddHost.Location = new System.Drawing.Point(15, 357);
            this.AddHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddHost.Name = "AddHost";
            this.AddHost.Size = new System.Drawing.Size(112, 35);
            this.AddHost.TabIndex = 7;
            this.AddHost.Text = "Add";
            this.AddHost.UseVisualStyleBackColor = true;
            this.AddHost.Click += new System.EventHandler(this.Btn_AddHost);
            // 
            // label_HostPhoneNumber
            // 
            this.label_HostPhoneNumber.AutoSize = true;
            this.label_HostPhoneNumber.Location = new System.Drawing.Point(401, 263);
            this.label_HostPhoneNumber.Name = "label_HostPhoneNumber";
            this.label_HostPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.label_HostPhoneNumber.TabIndex = 6;
            this.label_HostPhoneNumber.Text = "Phone Number:";
            this.label_HostPhoneNumber.Click += new System.EventHandler(this.label_HostPhoneNumber_Click);
            // 
            // label_HostFullName
            // 
            this.label_HostFullName.AutoSize = true;
            this.label_HostFullName.Location = new System.Drawing.Point(221, 263);
            this.label_HostFullName.Name = "label_HostFullName";
            this.label_HostFullName.Size = new System.Drawing.Size(93, 20);
            this.label_HostFullName.TabIndex = 5;
            this.label_HostFullName.Text = "Host Name:";
            this.label_HostFullName.Click += new System.EventHandler(this.label_HostFullName_Click);
            // 
            // txtBox_HostPhoneNumber
            // 
            this.txtBox_HostPhoneNumber.Location = new System.Drawing.Point(405, 286);
            this.txtBox_HostPhoneNumber.Name = "txtBox_HostPhoneNumber";
            this.txtBox_HostPhoneNumber.Size = new System.Drawing.Size(160, 26);
            this.txtBox_HostPhoneNumber.TabIndex = 2;
            // 
            // txtBox_HostName
            // 
            this.txtBox_HostName.Location = new System.Drawing.Point(225, 286);
            this.txtBox_HostName.Name = "txtBox_HostName";
            this.txtBox_HostName.Size = new System.Drawing.Size(150, 26);
            this.txtBox_HostName.TabIndex = 1;
            // 
            // hostDataGrid
            // 
            this.hostDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostDataGrid.Location = new System.Drawing.Point(591, 108);
            this.hostDataGrid.Name = "hostDataGrid";
            this.hostDataGrid.RowHeadersWidth = 62;
            this.hostDataGrid.RowTemplate.Height = 28;
            this.hostDataGrid.Size = new System.Drawing.Size(555, 412);
            this.hostDataGrid.TabIndex = 0;
            this.hostDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HostDataGrid_CellContentClick);
            // 
            // TabPageProperty
            // 
            this.TabPageProperty.Controls.Add(this.label4);
            this.TabPageProperty.Controls.Add(this.label_ErrorResponseProperty);
            this.TabPageProperty.Controls.Add(this.button9);
            this.TabPageProperty.Controls.Add(this.button4);
            this.TabPageProperty.Controls.Add(this.button3);
            this.TabPageProperty.Controls.Add(this.label_PropertyHost);
            this.TabPageProperty.Controls.Add(this.label_PropertyCountry);
            this.TabPageProperty.Controls.Add(this.label_PropertyType);
            this.TabPageProperty.Controls.Add(this.label_PropertyPrice);
            this.TabPageProperty.Controls.Add(this.label_PropertyAddress);
            this.TabPageProperty.Controls.Add(this.comboBox_PropertyHostId);
            this.TabPageProperty.Controls.Add(this.txtBox_PropertyCountry);
            this.TabPageProperty.Controls.Add(this.txtBox_PropertyType);
            this.TabPageProperty.Controls.Add(this.txtBox_PropertyPrice);
            this.TabPageProperty.Controls.Add(this.txtBox_PropertyAddress);
            this.TabPageProperty.Controls.Add(this.propertyDataGrid);
            this.TabPageProperty.Location = new System.Drawing.Point(4, 29);
            this.TabPageProperty.Name = "TabPageProperty";
            this.TabPageProperty.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageProperty.Size = new System.Drawing.Size(1192, 627);
            this.TabPageProperty.TabIndex = 2;
            this.TabPageProperty.Text = "Property Page";
            this.TabPageProperty.UseVisualStyleBackColor = true;
            // 
            // label_ErrorResponseProperty
            // 
            this.label_ErrorResponseProperty.AutoSize = true;
            this.label_ErrorResponseProperty.Location = new System.Drawing.Point(418, 560);
            this.label_ErrorResponseProperty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ErrorResponseProperty.Name = "label_ErrorResponseProperty";
            this.label_ErrorResponseProperty.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorResponseProperty.TabIndex = 15;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(265, 231);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 49);
            this.button9.TabIndex = 14;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_UpdateProperty);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 49);
            this.button4.TabIndex = 13;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_DeleteProperty);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_AddProperty);
            // 
            // label_PropertyHost
            // 
            this.label_PropertyHost.AutoSize = true;
            this.label_PropertyHost.Location = new System.Drawing.Point(535, 114);
            this.label_PropertyHost.Name = "label_PropertyHost";
            this.label_PropertyHost.Size = new System.Drawing.Size(47, 20);
            this.label_PropertyHost.TabIndex = 11;
            this.label_PropertyHost.Text = "Host:";
            // 
            // label_PropertyCountry
            // 
            this.label_PropertyCountry.AutoSize = true;
            this.label_PropertyCountry.Location = new System.Drawing.Point(395, 114);
            this.label_PropertyCountry.Name = "label_PropertyCountry";
            this.label_PropertyCountry.Size = new System.Drawing.Size(68, 20);
            this.label_PropertyCountry.TabIndex = 10;
            this.label_PropertyCountry.Text = "Country:";
            // 
            // label_PropertyType
            // 
            this.label_PropertyType.AutoSize = true;
            this.label_PropertyType.Location = new System.Drawing.Point(275, 114);
            this.label_PropertyType.Name = "label_PropertyType";
            this.label_PropertyType.Size = new System.Drawing.Size(47, 20);
            this.label_PropertyType.TabIndex = 9;
            this.label_PropertyType.Text = "Type:";
            // 
            // label_PropertyPrice
            // 
            this.label_PropertyPrice.AutoSize = true;
            this.label_PropertyPrice.Location = new System.Drawing.Point(165, 114);
            this.label_PropertyPrice.Name = "label_PropertyPrice";
            this.label_PropertyPrice.Size = new System.Drawing.Size(44, 20);
            this.label_PropertyPrice.TabIndex = 8;
            this.label_PropertyPrice.Text = "Price";
            // 
            // label_PropertyAddress
            // 
            this.label_PropertyAddress.AutoSize = true;
            this.label_PropertyAddress.Location = new System.Drawing.Point(27, 114);
            this.label_PropertyAddress.Name = "label_PropertyAddress";
            this.label_PropertyAddress.Size = new System.Drawing.Size(72, 20);
            this.label_PropertyAddress.TabIndex = 7;
            this.label_PropertyAddress.Text = "Address:";
            // 
            // comboBox_PropertyHostId
            // 
            this.comboBox_PropertyHostId.FormattingEnabled = true;
            this.comboBox_PropertyHostId.Location = new System.Drawing.Point(525, 149);
            this.comboBox_PropertyHostId.Name = "comboBox_PropertyHostId";
            this.comboBox_PropertyHostId.Size = new System.Drawing.Size(193, 28);
            this.comboBox_PropertyHostId.TabIndex = 6;
            // 
            // txtBox_PropertyCountry
            // 
            this.txtBox_PropertyCountry.Location = new System.Drawing.Point(399, 151);
            this.txtBox_PropertyCountry.Name = "txtBox_PropertyCountry";
            this.txtBox_PropertyCountry.Size = new System.Drawing.Size(100, 26);
            this.txtBox_PropertyCountry.TabIndex = 5;
            // 
            // txtBox_PropertyType
            // 
            this.txtBox_PropertyType.Location = new System.Drawing.Point(279, 151);
            this.txtBox_PropertyType.Name = "txtBox_PropertyType";
            this.txtBox_PropertyType.Size = new System.Drawing.Size(100, 26);
            this.txtBox_PropertyType.TabIndex = 4;
            // 
            // txtBox_PropertyPrice
            // 
            this.txtBox_PropertyPrice.Location = new System.Drawing.Point(158, 151);
            this.txtBox_PropertyPrice.Name = "txtBox_PropertyPrice";
            this.txtBox_PropertyPrice.Size = new System.Drawing.Size(100, 26);
            this.txtBox_PropertyPrice.TabIndex = 3;
            // 
            // txtBox_PropertyAddress
            // 
            this.txtBox_PropertyAddress.Location = new System.Drawing.Point(32, 151);
            this.txtBox_PropertyAddress.Name = "txtBox_PropertyAddress";
            this.txtBox_PropertyAddress.Size = new System.Drawing.Size(100, 26);
            this.txtBox_PropertyAddress.TabIndex = 2;
            // 
            // propertyDataGrid
            // 
            this.propertyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyDataGrid.Location = new System.Drawing.Point(418, 268);
            this.propertyDataGrid.Name = "propertyDataGrid";
            this.propertyDataGrid.RowHeadersWidth = 62;
            this.propertyDataGrid.RowTemplate.Height = 28;
            this.propertyDataGrid.Size = new System.Drawing.Size(734, 265);
            this.propertyDataGrid.TabIndex = 0;
            this.propertyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertyDataGrid_CellContentClick);
            // 
            // tabPageBooking
            // 
            this.tabPageBooking.Controls.Add(this.UpdateButtonBooking);
            this.tabPageBooking.Controls.Add(this.label_ErrorResponseBooking);
            this.tabPageBooking.Controls.Add(this.label_TbarPropertyRatingResult);
            this.tabPageBooking.Controls.Add(this.tbar_PropertyRating);
            this.tabPageBooking.Controls.Add(this.button6);
            this.tabPageBooking.Controls.Add(this.button5);
            this.tabPageBooking.Controls.Add(this.label_BookingRating);
            this.tabPageBooking.Controls.Add(this.label_BookingEndDate);
            this.tabPageBooking.Controls.Add(this.label_BookingStartDate);
            this.tabPageBooking.Controls.Add(this.label_BookingPropertyAddress);
            this.tabPageBooking.Controls.Add(this.label_BookingUserName);
            this.tabPageBooking.Controls.Add(this.bookingDataGrid);
            this.tabPageBooking.Controls.Add(this.datePickerBookingEndDate);
            this.tabPageBooking.Controls.Add(this.datePickerBookingStartDate);
            this.tabPageBooking.Controls.Add(this.comboBox_BookingAddress);
            this.tabPageBooking.Controls.Add(this.comboBox_BookingUsername);
            this.tabPageBooking.Location = new System.Drawing.Point(4, 29);
            this.tabPageBooking.Name = "tabPageBooking";
            this.tabPageBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooking.Size = new System.Drawing.Size(1192, 627);
            this.tabPageBooking.TabIndex = 3;
            this.tabPageBooking.Text = "Booking Page";
            this.tabPageBooking.UseVisualStyleBackColor = true;
            // 
            // UpdateButtonBooking
            // 
            this.UpdateButtonBooking.Location = new System.Drawing.Point(8, 207);
            this.UpdateButtonBooking.Name = "UpdateButtonBooking";
            this.UpdateButtonBooking.Size = new System.Drawing.Size(75, 45);
            this.UpdateButtonBooking.TabIndex = 15;
            this.UpdateButtonBooking.Text = "Update";
            this.UpdateButtonBooking.UseVisualStyleBackColor = true;
            this.UpdateButtonBooking.Click += new System.EventHandler(this.Btn_UpdateBooking);
            // 
            // label_ErrorResponseBooking
            // 
            this.label_ErrorResponseBooking.AutoSize = true;
            this.label_ErrorResponseBooking.Location = new System.Drawing.Point(197, 219);
            this.label_ErrorResponseBooking.Name = "label_ErrorResponseBooking";
            this.label_ErrorResponseBooking.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorResponseBooking.TabIndex = 14;
            // 
            // label_TbarPropertyRatingResult
            // 
            this.label_TbarPropertyRatingResult.AutoSize = true;
            this.label_TbarPropertyRatingResult.Location = new System.Drawing.Point(1118, 37);
            this.label_TbarPropertyRatingResult.Name = "label_TbarPropertyRatingResult";
            this.label_TbarPropertyRatingResult.Size = new System.Drawing.Size(18, 20);
            this.label_TbarPropertyRatingResult.TabIndex = 13;
            this.label_TbarPropertyRatingResult.Text = "0";
            // 
            // tbar_PropertyRating
            // 
            this.tbar_PropertyRating.Location = new System.Drawing.Point(1055, 71);
            this.tbar_PropertyRating.Maximum = 5;
            this.tbar_PropertyRating.Name = "tbar_PropertyRating";
            this.tbar_PropertyRating.Size = new System.Drawing.Size(104, 69);
            this.tbar_PropertyRating.TabIndex = 12;
            this.tbar_PropertyRating.Scroll += new System.EventHandler(this.Tbar_PropertyRatingScroll);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_DeleteBooking);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_AddBooking);
            // 
            // label_BookingRating
            // 
            this.label_BookingRating.AutoSize = true;
            this.label_BookingRating.Location = new System.Drawing.Point(1051, 38);
            this.label_BookingRating.Name = "label_BookingRating";
            this.label_BookingRating.Size = new System.Drawing.Size(60, 20);
            this.label_BookingRating.TabIndex = 9;
            this.label_BookingRating.Text = "Rating:";
            // 
            // label_BookingEndDate
            // 
            this.label_BookingEndDate.AutoSize = true;
            this.label_BookingEndDate.Location = new System.Drawing.Point(828, 37);
            this.label_BookingEndDate.Name = "label_BookingEndDate";
            this.label_BookingEndDate.Size = new System.Drawing.Size(81, 20);
            this.label_BookingEndDate.TabIndex = 8;
            this.label_BookingEndDate.Text = "End Date:";
            // 
            // label_BookingStartDate
            // 
            this.label_BookingStartDate.AutoSize = true;
            this.label_BookingStartDate.Location = new System.Drawing.Point(601, 37);
            this.label_BookingStartDate.Name = "label_BookingStartDate";
            this.label_BookingStartDate.Size = new System.Drawing.Size(87, 20);
            this.label_BookingStartDate.TabIndex = 7;
            this.label_BookingStartDate.Text = "Start Date:";
            // 
            // label_BookingPropertyAddress
            // 
            this.label_BookingPropertyAddress.AutoSize = true;
            this.label_BookingPropertyAddress.Location = new System.Drawing.Point(292, 37);
            this.label_BookingPropertyAddress.Name = "label_BookingPropertyAddress";
            this.label_BookingPropertyAddress.Size = new System.Drawing.Size(72, 20);
            this.label_BookingPropertyAddress.TabIndex = 6;
            this.label_BookingPropertyAddress.Text = "Property:";
            // 
            // label_BookingUserName
            // 
            this.label_BookingUserName.AutoSize = true;
            this.label_BookingUserName.Location = new System.Drawing.Point(34, 38);
            this.label_BookingUserName.Name = "label_BookingUserName";
            this.label_BookingUserName.Size = new System.Drawing.Size(47, 20);
            this.label_BookingUserName.TabIndex = 5;
            this.label_BookingUserName.Text = "User:";
            // 
            // bookingDataGrid
            // 
            this.bookingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGrid.Location = new System.Drawing.Point(39, 272);
            this.bookingDataGrid.Name = "bookingDataGrid";
            this.bookingDataGrid.RowHeadersWidth = 62;
            this.bookingDataGrid.RowTemplate.Height = 28;
            this.bookingDataGrid.Size = new System.Drawing.Size(1136, 282);
            this.bookingDataGrid.TabIndex = 4;
            this.bookingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingDataGrid_CellContentClick);
            // 
            // datePickerBookingEndDate
            // 
            this.datePickerBookingEndDate.Location = new System.Drawing.Point(832, 69);
            this.datePickerBookingEndDate.Name = "datePickerBookingEndDate";
            this.datePickerBookingEndDate.Size = new System.Drawing.Size(200, 26);
            this.datePickerBookingEndDate.TabIndex = 3;
            this.datePickerBookingEndDate.Value = new System.DateTime(2022, 10, 24, 13, 19, 11, 0);
            // 
            // datePickerBookingStartDate
            // 
            this.datePickerBookingStartDate.Location = new System.Drawing.Point(605, 69);
            this.datePickerBookingStartDate.Name = "datePickerBookingStartDate";
            this.datePickerBookingStartDate.Size = new System.Drawing.Size(200, 26);
            this.datePickerBookingStartDate.TabIndex = 2;
            this.datePickerBookingStartDate.Value = new System.DateTime(2022, 10, 24, 13, 19, 11, 0);
            // 
            // comboBox_BookingAddress
            // 
            this.comboBox_BookingAddress.FormattingEnabled = true;
            this.comboBox_BookingAddress.Location = new System.Drawing.Point(296, 67);
            this.comboBox_BookingAddress.Name = "comboBox_BookingAddress";
            this.comboBox_BookingAddress.Size = new System.Drawing.Size(288, 28);
            this.comboBox_BookingAddress.TabIndex = 1;
            // 
            // comboBox_BookingUsername
            // 
            this.comboBox_BookingUsername.FormattingEnabled = true;
            this.comboBox_BookingUsername.Location = new System.Drawing.Point(3, 67);
            this.comboBox_BookingUsername.Name = "comboBox_BookingUsername";
            this.comboBox_BookingUsername.Size = new System.Drawing.Size(284, 28);
            this.comboBox_BookingUsername.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Welcome to the Property page!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.tabPageHost.ResumeLayout(false);
            this.tabPageHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostDataGrid)).EndInit();
            this.TabPageProperty.ResumeLayout(false);
            this.TabPageProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataGrid)).EndInit();
            this.tabPageBooking.ResumeLayout(false);
            this.tabPageBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_PropertyRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox txtBox_UserFullName;
        private System.Windows.Forms.Label label_UserFullName;
        private System.Windows.Forms.TextBox txtBox_UserPhoneNumber;
        private System.Windows.Forms.Label label_UserPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageHost;
        private System.Windows.Forms.Button AddHost;
        private System.Windows.Forms.Label label_HostPhoneNumber;
        private System.Windows.Forms.Label label_HostFullName;
        private System.Windows.Forms.TextBox txtBox_HostPhoneNumber;
        private System.Windows.Forms.TextBox txtBox_HostName;
        private System.Windows.Forms.DataGridView hostDataGrid;
        private System.Windows.Forms.TabPage TabPageProperty;
        private System.Windows.Forms.TabPage tabPageBooking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_PropertyHost;
        private System.Windows.Forms.Label label_PropertyCountry;
        private System.Windows.Forms.Label label_PropertyType;
        private System.Windows.Forms.Label label_PropertyPrice;
        private System.Windows.Forms.Label label_PropertyAddress;
        private System.Windows.Forms.ComboBox comboBox_PropertyHostId;
        private System.Windows.Forms.TextBox txtBox_PropertyCountry;
        private System.Windows.Forms.TextBox txtBox_PropertyType;
        private System.Windows.Forms.TextBox txtBox_PropertyPrice;
        private System.Windows.Forms.TextBox txtBox_PropertyAddress;
        private System.Windows.Forms.DataGridView propertyDataGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_BookingRating;
        private System.Windows.Forms.Label label_BookingEndDate;
        private System.Windows.Forms.Label label_BookingStartDate;
        private System.Windows.Forms.Label label_BookingPropertyAddress;
        private System.Windows.Forms.Label label_BookingUserName;
        private System.Windows.Forms.DataGridView bookingDataGrid;
        private System.Windows.Forms.DateTimePicker datePickerBookingEndDate;
        private System.Windows.Forms.DateTimePicker datePickerBookingStartDate;
        private System.Windows.Forms.ComboBox comboBox_BookingAddress;
        private System.Windows.Forms.ComboBox comboBox_BookingUsername;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label_PageNameUser;
        private System.Windows.Forms.Label label_ErrorResponseUser;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ErrorResponseHost;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label_ErrorResponseProperty;
        private System.Windows.Forms.TrackBar tbar_PropertyRating;
        private System.Windows.Forms.Label label_TbarPropertyRatingResult;
        private System.Windows.Forms.Label label_ErrorResponseBooking;
        private System.Windows.Forms.Button UpdateButtonBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_HostID;
        private System.Windows.Forms.Label label4;
    }
}

