namespace Home_Sale_Management_Systems
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            lblTitle = new Label();
            lblSearchStaff = new Label();
            txtSearchStaff = new TextBox();
            pnlLeftSide = new Panel();
            lbStaff = new ListBox();
            pnlRightSide = new Panel();
            btnPickStaffPhoto = new Button();
            pbStaffPhoto = new PictureBox();
            gbStaffAddress = new GroupBox();
            cbStaffCityOrProvince = new ComboBox();
            lblStaffStreetNo = new Label();
            txtStaffStreetNo = new TextBox();
            txtStaffHouseNo = new TextBox();
            lblStaffProvinceOrCity = new Label();
            lblStaffHouseNo = new Label();
            lblStaffSangkat = new Label();
            txtStaffKhan = new TextBox();
            txtStaffSangkat = new TextBox();
            lblStaffKhan = new Label();
            gbStaffInformation = new GroupBox();
            mtxtStaffPersonalNumber = new MaskedTextBox();
            mtxtStaffContactNumber = new MaskedTextBox();
            lblStaffPersonalNumber = new Label();
            lblStaffContactNumber = new Label();
            dtpStaffHiredDate = new DateTimePicker();
            lblStaffHiredDate = new Label();
            chbStaffStoppedWork = new CheckBox();
            txtStaffSalary = new TextBox();
            lblStaffSalary = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            cbStaffPosition = new ComboBox();
            lblStaffID = new Label();
            lblStaffPosition = new Label();
            txtStaffFirstName = new TextBox();
            lblStaffFirstName = new Label();
            txtStaffID = new TextBox();
            lblStaffLastName = new Label();
            txtStaffLastName = new TextBox();
            lblStaffSex = new Label();
            lblStaffBirthDate = new Label();
            dtpStaffBirthDate = new DateTimePicker();
            lblStaffIdentityCardNumber = new Label();
            txtStaffIdentityCardNumber = new TextBox();
            pnlStaffManipulation = new Panel();
            btnCancelStaff = new Button();
            btnNewStaff = new Button();
            btnUpdateStaff = new Button();
            btnInsertStaff = new Button();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).BeginInit();
            gbStaffAddress.SuspendLayout();
            gbStaffInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានបុគ្គលិក";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Location = new Point(21, 24);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(212, 36);
            lblSearchStaff.TabIndex = 1;
            lblSearchStaff.Text = "ស្វែងរក​(ឈ្មោះបុគ្គលិក):";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Location = new Point(21, 70);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(319, 44);
            txtSearchStaff.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbStaff);
            pnlLeftSide.Controls.Add(lblSearchStaff);
            pnlLeftSide.Controls.Add(txtSearchStaff);
            pnlLeftSide.Location = new Point(266, 184);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbStaff
            // 
            lbStaff.FormattingEnabled = true;
            lbStaff.ItemHeight = 36;
            lbStaff.Location = new Point(21, 146);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(319, 400);
            lbStaff.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(btnPickStaffPhoto);
            pnlRightSide.Controls.Add(pbStaffPhoto);
            pnlRightSide.Controls.Add(gbStaffAddress);
            pnlRightSide.Controls.Add(gbStaffInformation);
            pnlRightSide.Location = new Point(653, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 636);
            pnlRightSide.TabIndex = 4;
            // 
            // btnPickStaffPhoto
            // 
            btnPickStaffPhoto.BackColor = Color.FromArgb(0, 28, 87);
            btnPickStaffPhoto.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPickStaffPhoto.ForeColor = Color.White;
            btnPickStaffPhoto.Location = new Point(882, 365);
            btnPickStaffPhoto.Name = "btnPickStaffPhoto";
            btnPickStaffPhoto.Size = new Size(211, 63);
            btnPickStaffPhoto.TabIndex = 28;
            btnPickStaffPhoto.Text = "ជ្រើសរើសរូបភាព";
            btnPickStaffPhoto.UseVisualStyleBackColor = false;
            // 
            // pbStaffPhoto
            // 
            pbStaffPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbStaffPhoto.InitialImage = (Image)resources.GetObject("pbStaffPhoto.InitialImage");
            pbStaffPhoto.Location = new Point(856, 50);
            pbStaffPhoto.Name = "pbStaffPhoto";
            pbStaffPhoto.Size = new Size(258, 281);
            pbStaffPhoto.TabIndex = 27;
            pbStaffPhoto.TabStop = false;
            // 
            // gbStaffAddress
            // 
            gbStaffAddress.Controls.Add(cbStaffCityOrProvince);
            gbStaffAddress.Controls.Add(lblStaffStreetNo);
            gbStaffAddress.Controls.Add(txtStaffStreetNo);
            gbStaffAddress.Controls.Add(txtStaffHouseNo);
            gbStaffAddress.Controls.Add(lblStaffProvinceOrCity);
            gbStaffAddress.Controls.Add(lblStaffHouseNo);
            gbStaffAddress.Controls.Add(lblStaffSangkat);
            gbStaffAddress.Controls.Add(txtStaffKhan);
            gbStaffAddress.Controls.Add(txtStaffSangkat);
            gbStaffAddress.Controls.Add(lblStaffKhan);
            gbStaffAddress.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffAddress.Location = new Point(45, 449);
            gbStaffAddress.Name = "gbStaffAddress";
            gbStaffAddress.Size = new Size(1069, 167);
            gbStaffAddress.TabIndex = 26;
            gbStaffAddress.TabStop = false;
            gbStaffAddress.Text = "អាសយដ្ឋាន";
            // 
            // cbStaffCityOrProvince
            // 
            cbStaffCityOrProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffCityOrProvince.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffCityOrProvince.FormattingEnabled = true;
            cbStaffCityOrProvince.Items.AddRange(new object[] { "ខេត្តបាត់ដំបង", "ខេត្តកំពង់ចាម", "ខេត្តកំពង់ឆ្នាំង", "ខេត្តព្រះសីហនុ (កំពង់សោម)", "ខេត្តកំពង់ស្ពឺ", "ខេត្តកំពង់ធំ", "ខេត្តកំពត", "ខេត្តកោះកុង", "ខេត្តក្រចេះ", "ខេត្តប៉ៃលិន", "រាជធានីភ្នំពេញ", "ខេត្តតាកែវ", "ខេត្តព្រៃវែង", "ខេត្តពោធិ៍សាត់", "ខេត្តសៀមរាប", "ខេត្តស្ទឹងត្រែង", "ខេត្តស្វាយរៀង", "ខេត្តឧត្ដរមានជ័យ", "ខេត្តព្រះវិហារ", "ខេត្តបន្ទាយមានជ័យ", "ខេត្តកណ្តាល", "ខេត្តរតនៈគិរី", "ខេត្តមណ្ឌលគិរី", "ខេត្តត្បូងឃ្មុំ", "ខេត្តកែប" });
            cbStaffCityOrProvince.Location = new Point(485, 100);
            cbStaffCityOrProvince.MaxDropDownItems = 3;
            cbStaffCityOrProvince.MaxLength = 3;
            cbStaffCityOrProvince.Name = "cbStaffCityOrProvince";
            cbStaffCityOrProvince.Size = new Size(219, 44);
            cbStaffCityOrProvince.TabIndex = 16;
            // 
            // lblStaffStreetNo
            // 
            lblStaffStreetNo.AutoSize = true;
            lblStaffStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffStreetNo.Location = new Point(368, 46);
            lblStaffStreetNo.Name = "lblStaffStreetNo";
            lblStaffStreetNo.Size = new Size(81, 36);
            lblStaffStreetNo.TabIndex = 18;
            lblStaffStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtStaffStreetNo
            // 
            txtStaffStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffStreetNo.Location = new Point(485, 38);
            txtStaffStreetNo.Name = "txtStaffStreetNo";
            txtStaffStreetNo.Size = new Size(219, 44);
            txtStaffStreetNo.TabIndex = 13;
            // 
            // txtStaffHouseNo
            // 
            txtStaffHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffHouseNo.Location = new Point(108, 38);
            txtStaffHouseNo.Name = "txtStaffHouseNo";
            txtStaffHouseNo.Size = new Size(242, 44);
            txtStaffHouseNo.TabIndex = 12;
            // 
            // lblStaffProvinceOrCity
            // 
            lblStaffProvinceOrCity.AutoSize = true;
            lblStaffProvinceOrCity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffProvinceOrCity.Location = new Point(368, 108);
            lblStaffProvinceOrCity.Name = "lblStaffProvinceOrCity";
            lblStaffProvinceOrCity.Size = new Size(95, 36);
            lblStaffProvinceOrCity.TabIndex = 24;
            lblStaffProvinceOrCity.Text = "ខេត្ត/ក្រុង:";
            // 
            // lblStaffHouseNo
            // 
            lblStaffHouseNo.AutoSize = true;
            lblStaffHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHouseNo.Location = new Point(18, 46);
            lblStaffHouseNo.Name = "lblStaffHouseNo";
            lblStaffHouseNo.Size = new Size(84, 36);
            lblStaffHouseNo.TabIndex = 16;
            lblStaffHouseNo.Text = "លេខផ្ទះ:";
            // 
            // lblStaffSangkat
            // 
            lblStaffSangkat.AutoSize = true;
            lblStaffSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSangkat.Location = new Point(724, 46);
            lblStaffSangkat.Name = "lblStaffSangkat";
            lblStaffSangkat.Size = new Size(75, 36);
            lblStaffSangkat.TabIndex = 20;
            lblStaffSangkat.Text = "សង្កាត់:";
            // 
            // txtStaffKhan
            // 
            txtStaffKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffKhan.Location = new Point(108, 100);
            txtStaffKhan.Name = "txtStaffKhan";
            txtStaffKhan.Size = new Size(242, 44);
            txtStaffKhan.TabIndex = 15;
            // 
            // txtStaffSangkat
            // 
            txtStaffSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSangkat.Location = new Point(805, 38);
            txtStaffSangkat.Name = "txtStaffSangkat";
            txtStaffSangkat.Size = new Size(243, 44);
            txtStaffSangkat.TabIndex = 14;
            // 
            // lblStaffKhan
            // 
            lblStaffKhan.AutoSize = true;
            lblStaffKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffKhan.Location = new Point(18, 108);
            lblStaffKhan.Name = "lblStaffKhan";
            lblStaffKhan.Size = new Size(62, 36);
            lblStaffKhan.TabIndex = 22;
            lblStaffKhan.Text = "ខណ្ឌ:";
            // 
            // gbStaffInformation
            // 
            gbStaffInformation.Controls.Add(mtxtStaffPersonalNumber);
            gbStaffInformation.Controls.Add(mtxtStaffContactNumber);
            gbStaffInformation.Controls.Add(lblStaffPersonalNumber);
            gbStaffInformation.Controls.Add(lblStaffContactNumber);
            gbStaffInformation.Controls.Add(dtpStaffHiredDate);
            gbStaffInformation.Controls.Add(lblStaffHiredDate);
            gbStaffInformation.Controls.Add(chbStaffStoppedWork);
            gbStaffInformation.Controls.Add(txtStaffSalary);
            gbStaffInformation.Controls.Add(lblStaffSalary);
            gbStaffInformation.Controls.Add(rdbFemale);
            gbStaffInformation.Controls.Add(rdbMale);
            gbStaffInformation.Controls.Add(cbStaffPosition);
            gbStaffInformation.Controls.Add(lblStaffID);
            gbStaffInformation.Controls.Add(lblStaffPosition);
            gbStaffInformation.Controls.Add(txtStaffFirstName);
            gbStaffInformation.Controls.Add(lblStaffFirstName);
            gbStaffInformation.Controls.Add(txtStaffID);
            gbStaffInformation.Controls.Add(lblStaffLastName);
            gbStaffInformation.Controls.Add(txtStaffLastName);
            gbStaffInformation.Controls.Add(lblStaffSex);
            gbStaffInformation.Controls.Add(lblStaffBirthDate);
            gbStaffInformation.Controls.Add(dtpStaffBirthDate);
            gbStaffInformation.Controls.Add(lblStaffIdentityCardNumber);
            gbStaffInformation.Controls.Add(txtStaffIdentityCardNumber);
            gbStaffInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffInformation.Location = new Point(45, 32);
            gbStaffInformation.Name = "gbStaffInformation";
            gbStaffInformation.Size = new Size(776, 411);
            gbStaffInformation.TabIndex = 25;
            gbStaffInformation.TabStop = false;
            gbStaffInformation.Text = "ព័ត៌មានបុគ្គលិក";
            // 
            // mtxtStaffPersonalNumber
            // 
            mtxtStaffPersonalNumber.Location = new Point(531, 351);
            mtxtStaffPersonalNumber.Mask = "(999) 00-000-0000";
            mtxtStaffPersonalNumber.Name = "mtxtStaffPersonalNumber";
            mtxtStaffPersonalNumber.Size = new Size(219, 39);
            mtxtStaffPersonalNumber.TabIndex = 11;
            // 
            // mtxtStaffContactNumber
            // 
            mtxtStaffContactNumber.Location = new Point(175, 351);
            mtxtStaffContactNumber.Mask = "(999) 00-000-0000";
            mtxtStaffContactNumber.Name = "mtxtStaffContactNumber";
            mtxtStaffContactNumber.Size = new Size(215, 39);
            mtxtStaffContactNumber.TabIndex = 10;
            // 
            // lblStaffPersonalNumber
            // 
            lblStaffPersonalNumber.AutoSize = true;
            lblStaffPersonalNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPersonalNumber.Location = new Point(396, 354);
            lblStaffPersonalNumber.Name = "lblStaffPersonalNumber";
            lblStaffPersonalNumber.Size = new Size(129, 36);
            lblStaffPersonalNumber.TabIndex = 23;
            lblStaffPersonalNumber.Text = "លេខផ្ទាល់ខ្លួន:";
            // 
            // lblStaffContactNumber
            // 
            lblStaffContactNumber.AutoSize = true;
            lblStaffContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffContactNumber.Location = new Point(18, 354);
            lblStaffContactNumber.Name = "lblStaffContactNumber";
            lblStaffContactNumber.Size = new Size(151, 36);
            lblStaffContactNumber.TabIndex = 21;
            lblStaffContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // dtpStaffHiredDate
            // 
            dtpStaffHiredDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffHiredDate.Format = DateTimePickerFormat.Short;
            dtpStaffHiredDate.Location = new Point(531, 286);
            dtpStaffHiredDate.Name = "dtpStaffHiredDate";
            dtpStaffHiredDate.Size = new Size(219, 44);
            dtpStaffHiredDate.TabIndex = 9;
            dtpStaffHiredDate.Tag = "hire";
            // 
            // lblStaffHiredDate
            // 
            lblStaffHiredDate.AutoSize = true;
            lblStaffHiredDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHiredDate.Location = new Point(284, 292);
            lblStaffHiredDate.Name = "lblStaffHiredDate";
            lblStaffHiredDate.Size = new Size(241, 36);
            lblStaffHiredDate.TabIndex = 19;
            lblStaffHiredDate.Text = "កាលបរិច្ឆេទចូលបម្រើការងារ:";
            // 
            // chbStaffStoppedWork
            // 
            chbStaffStoppedWork.AutoSize = true;
            chbStaffStoppedWork.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbStaffStoppedWork.Location = new Point(485, 40);
            chbStaffStoppedWork.Name = "chbStaffStoppedWork";
            chbStaffStoppedWork.Size = new Size(157, 40);
            chbStaffStoppedWork.TabIndex = 1;
            chbStaffStoppedWork.Text = "បានឈប់ធ្វើការ";
            chbStaffStoppedWork.UseVisualStyleBackColor = true;
            // 
            // txtStaffSalary
            // 
            txtStaffSalary.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSalary.Location = new Point(108, 284);
            txtStaffSalary.Name = "txtStaffSalary";
            txtStaffSalary.Size = new Size(164, 44);
            txtStaffSalary.TabIndex = 8;
            txtStaffSalary.Tag = "n";
            // 
            // lblStaffSalary
            // 
            lblStaffSalary.AutoSize = true;
            lblStaffSalary.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSalary.Location = new Point(18, 292);
            lblStaffSalary.Name = "lblStaffSalary";
            lblStaffSalary.Size = new Size(81, 36);
            lblStaffSalary.TabIndex = 16;
            lblStaffSalary.Text = "ប្រាក់ខែ:";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemale.Location = new Point(170, 160);
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
            rdbMale.Location = new Point(88, 160);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(76, 40);
            rdbMale.TabIndex = 9;
            rdbMale.TabStop = true;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនេយ្យករ", "រដ្ឋបាល", "អ្នកទទួលភ្ញៀវ", "អ្នកទីផ្សារ", "អ្នកពិគ្រោះយោបល់" });
            cbStaffPosition.Location = new Point(531, 218);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(219, 44);
            cbStaffPosition.TabIndex = 7;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(18, 41);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 0;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(456, 226);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(69, 36);
            lblStaffPosition.TabIndex = 14;
            lblStaffPosition.Text = "តួនាទី:";
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffFirstName.Location = new Point(133, 103);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new Size(217, 44);
            txtStaffFirstName.TabIndex = 2;
            // 
            // lblStaffFirstName
            // 
            lblStaffFirstName.AutoSize = true;
            lblStaffFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffFirstName.Location = new Point(18, 106);
            lblStaffFirstName.Name = "lblStaffFirstName";
            lblStaffFirstName.Size = new Size(109, 36);
            lblStaffFirstName.TabIndex = 4;
            lblStaffFirstName.Text = "នាមត្រកូល:";
            // 
            // txtStaffID
            // 
            txtStaffID.Enabled = false;
            txtStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(209, 33);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(207, 44);
            txtStaffID.TabIndex = 3;
            // 
            // lblStaffLastName
            // 
            lblStaffLastName.AutoSize = true;
            lblStaffLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffLastName.Location = new Point(378, 106);
            lblStaffLastName.Name = "lblStaffLastName";
            lblStaffLastName.Size = new Size(83, 36);
            lblStaffLastName.TabIndex = 6;
            lblStaffLastName.Text = "នាមខ្លួន:";
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffLastName.Location = new Point(469, 103);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new Size(281, 44);
            txtStaffLastName.TabIndex = 3;
            // 
            // lblStaffSex
            // 
            lblStaffSex.AutoSize = true;
            lblStaffSex.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSex.Location = new Point(18, 164);
            lblStaffSex.Name = "lblStaffSex";
            lblStaffSex.Size = new Size(55, 36);
            lblStaffSex.TabIndex = 4;
            lblStaffSex.Text = "ភេទ:";
            // 
            // lblStaffBirthDate
            // 
            lblStaffBirthDate.AutoSize = true;
            lblStaffBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffBirthDate.Location = new Point(274, 164);
            lblStaffBirthDate.Name = "lblStaffBirthDate";
            lblStaffBirthDate.Size = new Size(142, 36);
            lblStaffBirthDate.TabIndex = 10;
            lblStaffBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // dtpStaffBirthDate
            // 
            dtpStaffBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffBirthDate.Format = DateTimePickerFormat.Short;
            dtpStaffBirthDate.Location = new Point(438, 158);
            dtpStaffBirthDate.Name = "dtpStaffBirthDate";
            dtpStaffBirthDate.Size = new Size(312, 44);
            dtpStaffBirthDate.TabIndex = 5;
            dtpStaffBirthDate.Tag = "bd";
            // 
            // lblStaffIdentityCardNumber
            // 
            lblStaffIdentityCardNumber.AutoSize = true;
            lblStaffIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffIdentityCardNumber.Location = new Point(18, 226);
            lblStaffIdentityCardNumber.Name = "lblStaffIdentityCardNumber";
            lblStaffIdentityCardNumber.Size = new Size(203, 36);
            lblStaffIdentityCardNumber.TabIndex = 12;
            lblStaffIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // txtStaffIdentityCardNumber
            // 
            txtStaffIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffIdentityCardNumber.Location = new Point(227, 218);
            txtStaffIdentityCardNumber.Name = "txtStaffIdentityCardNumber";
            txtStaffIdentityCardNumber.Size = new Size(205, 44);
            txtStaffIdentityCardNumber.TabIndex = 6;
            txtStaffIdentityCardNumber.Tag = "card";
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCancelStaff);
            pnlStaffManipulation.Controls.Add(btnNewStaff);
            pnlStaffManipulation.Controls.Add(btnUpdateStaff);
            pnlStaffManipulation.Controls.Add(btnInsertStaff);
            pnlStaffManipulation.Location = new Point(653, 854);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(925, 101);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCancelStaff
            // 
            btnCancelStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelStaff.ForeColor = Color.White;
            btnCancelStaff.Location = new Point(705, 20);
            btnCancelStaff.Name = "btnCancelStaff";
            btnCancelStaff.Size = new Size(152, 52);
            btnCancelStaff.TabIndex = 3;
            btnCancelStaff.Text = "បោះបង់";
            btnCancelStaff.UseVisualStyleBackColor = false;
            // 
            // btnNewStaff
            // 
            btnNewStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStaff.ForeColor = Color.White;
            btnNewStaff.Location = new Point(485, 20);
            btnNewStaff.Name = "btnNewStaff";
            btnNewStaff.Size = new Size(152, 52);
            btnNewStaff.TabIndex = 2;
            btnNewStaff.Text = "បង្កើតថ្មី";
            btnNewStaff.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStaff.ForeColor = Color.White;
            btnUpdateStaff.Location = new Point(265, 20);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(152, 52);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "កែប្រែ";
            btnUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btnInsertStaff
            // 
            btnInsertStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStaff.ForeColor = Color.White;
            btnInsertStaff.Location = new Point(45, 20);
            btnInsertStaff.Name = "btnInsertStaff";
            btnInsertStaff.Size = new Size(152, 52);
            btnInsertStaff.TabIndex = 0;
            btnInsertStaff.Text = "បញ្ចូល";
            btnInsertStaff.UseVisualStyleBackColor = false;
            // 
            // FrmStaff
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmStaff";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlStaffManipulation, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).EndInit();
            gbStaffAddress.ResumeLayout(false);
            gbStaffAddress.PerformLayout();
            gbStaffInformation.ResumeLayout(false);
            gbStaffInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStaff;
        private TextBox txtSearchStaff;
        private Panel pnlLeftSide;
        private ListBox lbStaff;
        private Panel pnlRightSide;
        private Label lblStaffID;
        private Label lblStaffSex;
        private TextBox txtStaffLastName;
        private Label lblStaffLastName;
        private TextBox txtStaffFirstName;
        private Label lblStaffFirstName;
        private TextBox txtStaffID;
        private Label lblStaffBirthDate;
        private DateTimePicker dtpStaffBirthDate;
        private ComboBox cbStaffPosition;
        private Label lblStaffPosition;
        private TextBox txtStaffIdentityCardNumber;
        private Label lblStaffIdentityCardNumber;
        private TextBox txtStaffStreetNo;
        private Label lblStaffStreetNo;
        private TextBox txtStaffHouseNo;
        private Label lblStaffHouseNo;
        private Label lblStaffProvinceOrCity;
        private Label lblStaffKhan;
        private TextBox txtStaffSangkat;
        private Label lblStaffSangkat;
        private TextBox txtStaffKhan;
        private GroupBox gbStaffInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbStaffAddress;
        private PictureBox pbStaffPhoto;
        private ComboBox cbStaffCityOrProvince;
        private Button btnPickStaffPhoto;
        private CheckBox chbStaffStoppedWork;
        private TextBox txtStaffSalary;
        private Label lblStaffSalary;
        private DateTimePicker dtpStaffHiredDate;
        private Label lblStaffHiredDate;
        private Label lblStaffContactNumber;
        private Label lblStaffPersonalNumber;
        private Panel pnlStaffManipulation;
        private Button btnInsertStaff;
        private Button btnCancelStaff;
        private Button btnNewStaff;
        private Button btnUpdateStaff;
        private MaskedTextBox mtxtStaffPersonalNumber;
        private MaskedTextBox mtxtStaffContactNumber;
    }
}