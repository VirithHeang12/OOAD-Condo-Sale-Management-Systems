namespace Store_Rental_Management_Systems
{
    partial class FrmCustomer
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
            lblTitle = new Label();
            lblSearchCustomer = new Label();
            txtSearchCustomer = new TextBox();
            pnlLeftSide = new Panel();
            lbCustomer = new ListBox();
            pnlRightSide = new Panel();
            btnPickCustomerPhoto = new Button();
            pbCustomerPhoto = new PictureBox();
            gbCustomerAddress = new GroupBox();
            cbCustomerCityOrProvince = new ComboBox();
            lblCustomerStreetNo = new Label();
            txtCustomerStreetNo = new TextBox();
            txtCustomerHouseNo = new TextBox();
            lblCustomerProvinceOrCity = new Label();
            lblCustomerHouseNo = new Label();
            lblCustomerSangkat = new Label();
            txtCustomerKhan = new TextBox();
            txtCustomerSangkat = new TextBox();
            lblCustomerKhan = new Label();
            gbCustomerInformation = new GroupBox();
            mtxtCustomerContactNumber = new MaskedTextBox();
            lblCustomerContactNumber = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            lblCustomerID = new Label();
            txtCustomerFirstName = new TextBox();
            lblCustomerFirstName = new Label();
            txtCustomerID = new TextBox();
            lblCustomerLastName = new Label();
            txtCustomerLastName = new TextBox();
            lblCustomerSex = new Label();
            lblCustomerBirthDate = new Label();
            dtpCustomerBirthDate = new DateTimePicker();
            lblCustomerIdentityCardNumber = new Label();
            txtCustomerIdentityCardNumber = new TextBox();
            pnlCustomerManipulation = new Panel();
            btnCancelCustomer = new Button();
            btnNewCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnInsertCustomer = new Button();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomerPhoto).BeginInit();
            gbCustomerAddress.SuspendLayout();
            gbCustomerInformation.SuspendLayout();
            pnlCustomerManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានអតិថិជន";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(21, 11);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(226, 36);
            lblSearchCustomer.TabIndex = 1;
            lblSearchCustomer.Text = "ស្វែងរក (ឈ្មោះអតិថិជន):";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(21, 50);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(319, 44);
            txtSearchCustomer.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbCustomer);
            pnlLeftSide.Controls.Add(lblSearchCustomer);
            pnlLeftSide.Controls.Add(txtSearchCustomer);
            pnlLeftSide.Location = new Point(266, 184);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbCustomer
            // 
            lbCustomer.FormattingEnabled = true;
            lbCustomer.ItemHeight = 36;
            lbCustomer.Location = new Point(21, 127);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(319, 400);
            lbCustomer.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(btnPickCustomerPhoto);
            pnlRightSide.Controls.Add(pbCustomerPhoto);
            pnlRightSide.Controls.Add(gbCustomerAddress);
            pnlRightSide.Controls.Add(gbCustomerInformation);
            pnlRightSide.Location = new Point(653, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 636);
            pnlRightSide.TabIndex = 4;
            // 
            // btnPickCustomerPhoto
            // 
            btnPickCustomerPhoto.BackColor = Color.FromArgb(0, 28, 87);
            btnPickCustomerPhoto.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPickCustomerPhoto.ForeColor = Color.White;
            btnPickCustomerPhoto.Location = new Point(888, 331);
            btnPickCustomerPhoto.Name = "btnPickCustomerPhoto";
            btnPickCustomerPhoto.Size = new Size(211, 63);
            btnPickCustomerPhoto.TabIndex = 28;
            btnPickCustomerPhoto.Text = "ជ្រើសរើសរូបភាព";
            btnPickCustomerPhoto.UseVisualStyleBackColor = false;
            // 
            // pbCustomerPhoto
            // 
            pbCustomerPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbCustomerPhoto.InitialImage = null;
            pbCustomerPhoto.Location = new Point(856, 32);
            pbCustomerPhoto.Name = "pbCustomerPhoto";
            pbCustomerPhoto.Size = new Size(258, 282);
            pbCustomerPhoto.TabIndex = 27;
            pbCustomerPhoto.TabStop = false;
            // 
            // gbCustomerAddress
            // 
            gbCustomerAddress.Controls.Add(cbCustomerCityOrProvince);
            gbCustomerAddress.Controls.Add(lblCustomerStreetNo);
            gbCustomerAddress.Controls.Add(txtCustomerStreetNo);
            gbCustomerAddress.Controls.Add(txtCustomerHouseNo);
            gbCustomerAddress.Controls.Add(lblCustomerProvinceOrCity);
            gbCustomerAddress.Controls.Add(lblCustomerHouseNo);
            gbCustomerAddress.Controls.Add(lblCustomerSangkat);
            gbCustomerAddress.Controls.Add(txtCustomerKhan);
            gbCustomerAddress.Controls.Add(txtCustomerSangkat);
            gbCustomerAddress.Controls.Add(lblCustomerKhan);
            gbCustomerAddress.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbCustomerAddress.Location = new Point(45, 331);
            gbCustomerAddress.Name = "gbCustomerAddress";
            gbCustomerAddress.Size = new Size(776, 233);
            gbCustomerAddress.TabIndex = 26;
            gbCustomerAddress.TabStop = false;
            gbCustomerAddress.Text = "អាសយដ្ឋាន";
            // 
            // cbCustomerCityOrProvince
            // 
            cbCustomerCityOrProvince.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerCityOrProvince.FormattingEnabled = true;
            cbCustomerCityOrProvince.Items.AddRange(new object[] { "ខេត្តបាត់ដំបង", "ខេត្តកំពង់ចាម", "ខេត្តកំពង់ឆ្នាំង", "ខេត្តព្រះសីហនុ (កំពង់សោម)", "ខេត្តកំពង់ស្ពឺ", "ខេត្តកំពង់ធំ", "ខេត្តកំពត", "ខេត្តកោះកុង", "ខេត្តក្រចេះ", "ខេត្តប៉ៃលិន", "រាជធានីភ្នំពេញ", "ខេត្តតាកែវ", "ខេត្តព្រៃវែង", "ខេត្តពោធិ៍សាត់", "ខេត្តសៀមរាប", "ខេត្តស្ទឹងត្រែង", "ខេត្តស្វាយរៀង", "ខេត្តឧត្ដរមានជ័យ", "ខេត្តព្រះវិហារ", "ខេត្តបន្ទាយមានជ័យ", "ខេត្តកណ្តាល", "ខេត្តរតនៈគិរី", "ខេត្តមណ្ឌលគិរី", "ខេត្តត្បូងឃ្មុំ", "ខេត្តកែប" });
            cbCustomerCityOrProvince.Location = new Point(154, 174);
            cbCustomerCityOrProvince.MaxDropDownItems = 2;
            cbCustomerCityOrProvince.Name = "cbCustomerCityOrProvince";
            cbCustomerCityOrProvince.Size = new Size(198, 44);
            cbCustomerCityOrProvince.TabIndex = 25;
            // 
            // lblCustomerStreetNo
            // 
            lblCustomerStreetNo.AutoSize = true;
            lblCustomerStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerStreetNo.Location = new Point(428, 46);
            lblCustomerStreetNo.Name = "lblCustomerStreetNo";
            lblCustomerStreetNo.Size = new Size(81, 36);
            lblCustomerStreetNo.TabIndex = 18;
            lblCustomerStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtCustomerStreetNo
            // 
            txtCustomerStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerStreetNo.Location = new Point(531, 38);
            txtCustomerStreetNo.Name = "txtCustomerStreetNo";
            txtCustomerStreetNo.Size = new Size(219, 44);
            txtCustomerStreetNo.TabIndex = 19;
            // 
            // txtCustomerHouseNo
            // 
            txtCustomerHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerHouseNo.Location = new Point(154, 43);
            txtCustomerHouseNo.Name = "txtCustomerHouseNo";
            txtCustomerHouseNo.Size = new Size(198, 44);
            txtCustomerHouseNo.TabIndex = 17;
            // 
            // lblCustomerProvinceOrCity
            // 
            lblCustomerProvinceOrCity.AutoSize = true;
            lblCustomerProvinceOrCity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerProvinceOrCity.Location = new Point(18, 177);
            lblCustomerProvinceOrCity.Name = "lblCustomerProvinceOrCity";
            lblCustomerProvinceOrCity.Size = new Size(95, 36);
            lblCustomerProvinceOrCity.TabIndex = 24;
            lblCustomerProvinceOrCity.Text = "ខេត្ត/ក្រុង:";
            // 
            // lblCustomerHouseNo
            // 
            lblCustomerHouseNo.AutoSize = true;
            lblCustomerHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerHouseNo.Location = new Point(18, 46);
            lblCustomerHouseNo.Name = "lblCustomerHouseNo";
            lblCustomerHouseNo.Size = new Size(84, 36);
            lblCustomerHouseNo.TabIndex = 16;
            lblCustomerHouseNo.Text = "លេខផ្ទះ:";
            // 
            // lblCustomerSangkat
            // 
            lblCustomerSangkat.AutoSize = true;
            lblCustomerSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerSangkat.Location = new Point(18, 108);
            lblCustomerSangkat.Name = "lblCustomerSangkat";
            lblCustomerSangkat.Size = new Size(75, 36);
            lblCustomerSangkat.TabIndex = 20;
            lblCustomerSangkat.Text = "សង្កាត់:";
            // 
            // txtCustomerKhan
            // 
            txtCustomerKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerKhan.Location = new Point(531, 105);
            txtCustomerKhan.Name = "txtCustomerKhan";
            txtCustomerKhan.Size = new Size(219, 44);
            txtCustomerKhan.TabIndex = 23;
            // 
            // txtCustomerSangkat
            // 
            txtCustomerSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerSangkat.Location = new Point(154, 105);
            txtCustomerSangkat.Name = "txtCustomerSangkat";
            txtCustomerSangkat.Size = new Size(196, 44);
            txtCustomerSangkat.TabIndex = 21;
            // 
            // lblCustomerKhan
            // 
            lblCustomerKhan.AutoSize = true;
            lblCustomerKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerKhan.Location = new Point(428, 108);
            lblCustomerKhan.Name = "lblCustomerKhan";
            lblCustomerKhan.Size = new Size(62, 36);
            lblCustomerKhan.TabIndex = 22;
            lblCustomerKhan.Text = "ខណ្ឌ:";
            // 
            // gbCustomerInformation
            // 
            gbCustomerInformation.Controls.Add(mtxtCustomerContactNumber);
            gbCustomerInformation.Controls.Add(lblCustomerContactNumber);
            gbCustomerInformation.Controls.Add(rdbFemale);
            gbCustomerInformation.Controls.Add(rdbMale);
            gbCustomerInformation.Controls.Add(lblCustomerID);
            gbCustomerInformation.Controls.Add(txtCustomerFirstName);
            gbCustomerInformation.Controls.Add(lblCustomerFirstName);
            gbCustomerInformation.Controls.Add(txtCustomerID);
            gbCustomerInformation.Controls.Add(lblCustomerLastName);
            gbCustomerInformation.Controls.Add(txtCustomerLastName);
            gbCustomerInformation.Controls.Add(lblCustomerSex);
            gbCustomerInformation.Controls.Add(lblCustomerBirthDate);
            gbCustomerInformation.Controls.Add(dtpCustomerBirthDate);
            gbCustomerInformation.Controls.Add(lblCustomerIdentityCardNumber);
            gbCustomerInformation.Controls.Add(txtCustomerIdentityCardNumber);
            gbCustomerInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbCustomerInformation.Location = new Point(45, 32);
            gbCustomerInformation.Name = "gbCustomerInformation";
            gbCustomerInformation.Size = new Size(776, 282);
            gbCustomerInformation.TabIndex = 25;
            gbCustomerInformation.TabStop = false;
            gbCustomerInformation.Text = "ព័ត៌មានអតិថិជន";
            // 
            // mtxtCustomerContactNumber
            // 
            mtxtCustomerContactNumber.Location = new Point(535, 162);
            mtxtCustomerContactNumber.Mask = "(999) 00-000-0000";
            mtxtCustomerContactNumber.Name = "mtxtCustomerContactNumber";
            mtxtCustomerContactNumber.Size = new Size(215, 39);
            mtxtCustomerContactNumber.TabIndex = 25;
            // 
            // lblCustomerContactNumber
            // 
            lblCustomerContactNumber.AutoSize = true;
            lblCustomerContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerContactNumber.Location = new Point(374, 166);
            lblCustomerContactNumber.Name = "lblCustomerContactNumber";
            lblCustomerContactNumber.Size = new Size(151, 36);
            lblCustomerContactNumber.TabIndex = 21;
            lblCustomerContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemale.Location = new Point(683, 34);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(62, 40);
            rdbFemale.TabIndex = 10;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Checked = true;
            rdbMale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMale.Location = new Point(601, 34);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(76, 40);
            rdbMale.TabIndex = 9;
            rdbMale.TabStop = true;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(18, 41);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(191, 36);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // txtCustomerFirstName
            // 
            txtCustomerFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerFirstName.Location = new Point(166, 103);
            txtCustomerFirstName.Name = "txtCustomerFirstName";
            txtCustomerFirstName.Size = new Size(184, 44);
            txtCustomerFirstName.TabIndex = 5;
            // 
            // lblCustomerFirstName
            // 
            lblCustomerFirstName.AutoSize = true;
            lblCustomerFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerFirstName.Location = new Point(18, 106);
            lblCustomerFirstName.Name = "lblCustomerFirstName";
            lblCustomerFirstName.Size = new Size(109, 36);
            lblCustomerFirstName.TabIndex = 4;
            lblCustomerFirstName.Text = "នាមត្រកូល:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.Location = new Point(228, 33);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(205, 44);
            txtCustomerID.TabIndex = 3;
            // 
            // lblCustomerLastName
            // 
            lblCustomerLastName.AutoSize = true;
            lblCustomerLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerLastName.Location = new Point(378, 106);
            lblCustomerLastName.Name = "lblCustomerLastName";
            lblCustomerLastName.Size = new Size(83, 36);
            lblCustomerLastName.TabIndex = 6;
            lblCustomerLastName.Text = "នាមខ្លួន:";
            // 
            // txtCustomerLastName
            // 
            txtCustomerLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerLastName.Location = new Point(535, 103);
            txtCustomerLastName.Name = "txtCustomerLastName";
            txtCustomerLastName.Size = new Size(215, 44);
            txtCustomerLastName.TabIndex = 7;
            // 
            // lblCustomerSex
            // 
            lblCustomerSex.AutoSize = true;
            lblCustomerSex.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerSex.Location = new Point(540, 38);
            lblCustomerSex.Name = "lblCustomerSex";
            lblCustomerSex.Size = new Size(55, 36);
            lblCustomerSex.TabIndex = 8;
            lblCustomerSex.Text = "ភេទ:";
            // 
            // lblCustomerBirthDate
            // 
            lblCustomerBirthDate.AutoSize = true;
            lblCustomerBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerBirthDate.Location = new Point(18, 166);
            lblCustomerBirthDate.Name = "lblCustomerBirthDate";
            lblCustomerBirthDate.Size = new Size(142, 36);
            lblCustomerBirthDate.TabIndex = 10;
            lblCustomerBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // dtpCustomerBirthDate
            // 
            dtpCustomerBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCustomerBirthDate.Format = DateTimePickerFormat.Short;
            dtpCustomerBirthDate.Location = new Point(166, 158);
            dtpCustomerBirthDate.Name = "dtpCustomerBirthDate";
            dtpCustomerBirthDate.Size = new Size(184, 44);
            dtpCustomerBirthDate.TabIndex = 11;
            dtpCustomerBirthDate.Value = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // lblCustomerIdentityCardNumber
            // 
            lblCustomerIdentityCardNumber.AutoSize = true;
            lblCustomerIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerIdentityCardNumber.Location = new Point(18, 227);
            lblCustomerIdentityCardNumber.Name = "lblCustomerIdentityCardNumber";
            lblCustomerIdentityCardNumber.Size = new Size(203, 36);
            lblCustomerIdentityCardNumber.TabIndex = 12;
            lblCustomerIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // txtCustomerIdentityCardNumber
            // 
            txtCustomerIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerIdentityCardNumber.Location = new Point(228, 224);
            txtCustomerIdentityCardNumber.Name = "txtCustomerIdentityCardNumber";
            txtCustomerIdentityCardNumber.Size = new Size(205, 44);
            txtCustomerIdentityCardNumber.TabIndex = 13;
            // 
            // pnlCustomerManipulation
            // 
            pnlCustomerManipulation.Controls.Add(btnCancelCustomer);
            pnlCustomerManipulation.Controls.Add(btnNewCustomer);
            pnlCustomerManipulation.Controls.Add(btnUpdateCustomer);
            pnlCustomerManipulation.Controls.Add(btnInsertCustomer);
            pnlCustomerManipulation.Location = new Point(653, 856);
            pnlCustomerManipulation.Name = "pnlCustomerManipulation";
            pnlCustomerManipulation.Size = new Size(876, 101);
            pnlCustomerManipulation.TabIndex = 5;
            // 
            // btnCancelCustomer
            // 
            btnCancelCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelCustomer.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelCustomer.ForeColor = Color.White;
            btnCancelCustomer.Location = new Point(669, 20);
            btnCancelCustomer.Name = "btnCancelCustomer";
            btnCancelCustomer.Size = new Size(152, 52);
            btnCancelCustomer.TabIndex = 3;
            btnCancelCustomer.Text = "បោះបង់";
            btnCancelCustomer.UseVisualStyleBackColor = false;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnNewCustomer.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Location = new Point(461, 20);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(152, 52);
            btnNewCustomer.TabIndex = 2;
            btnNewCustomer.Text = "បង្កើតថ្មី";
            btnNewCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateCustomer.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(253, 20);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(152, 52);
            btnUpdateCustomer.TabIndex = 1;
            btnUpdateCustomer.Text = "កែប្រែ";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnInsertCustomer
            // 
            btnInsertCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertCustomer.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertCustomer.ForeColor = Color.White;
            btnInsertCustomer.Location = new Point(45, 20);
            btnInsertCustomer.Name = "btnInsertCustomer";
            btnInsertCustomer.Size = new Size(152, 52);
            btnInsertCustomer.TabIndex = 0;
            btnInsertCustomer.Text = "បញ្ចូល";
            btnInsertCustomer.UseVisualStyleBackColor = false;
            // 
            // FrmCustomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlCustomerManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmCustomer";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlCustomerManipulation, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCustomerPhoto).EndInit();
            gbCustomerAddress.ResumeLayout(false);
            gbCustomerAddress.PerformLayout();
            gbCustomerInformation.ResumeLayout(false);
            gbCustomerInformation.PerformLayout();
            pnlCustomerManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchCustomer;
        private TextBox txtSearchCustomer;
        private Panel pnlLeftSide;
        private ListBox lbCustomer;
        private Panel pnlRightSide;
        private Label lblCustomerID;
        private Label lblCustomerSex;
        private TextBox txtCustomerLastName;
        private Label lblCustomerLastName;
        private TextBox txtCustomerFirstName;
        private Label lblCustomerFirstName;
        private TextBox txtCustomerID;
        private Label lblCustomerBirthDate;
        private DateTimePicker dtpCustomerBirthDate;
        private TextBox txtCustomerIdentityCardNumber;
        private Label lblCustomerIdentityCardNumber;
        private TextBox txtCustomerStreetNo;
        private Label lblCustomerStreetNo;
        private TextBox txtCustomerHouseNo;
        private Label lblCustomerHouseNo;
        private Label lblCustomerProvinceOrCity;
        private Label lblCustomerKhan;
        private TextBox txtCustomerSangkat;
        private Label lblCustomerSangkat;
        private TextBox txtCustomerKhan;
        private GroupBox gbCustomerInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbCustomerAddress;
        private PictureBox pbCustomerPhoto;
        private ComboBox cbCustomerCityOrProvince;
        private Button btnPickCustomerPhoto;
        private Label lblCustomerContactNumber;
        private Panel pnlCustomerManipulation;
        private Button btnInsertCustomer;
        private Button btnCancelCustomer;
        private Button btnNewCustomer;
        private Button btnUpdateCustomer;
        private MaskedTextBox mtxtCustomerContactNumber;
    }
}