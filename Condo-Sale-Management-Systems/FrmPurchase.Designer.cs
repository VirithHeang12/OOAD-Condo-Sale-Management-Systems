namespace Condo_Sale_Management_Systems
{
    partial class FrmPurchase
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
            lblSearchContract = new Label();
            txtSearchContract = new TextBox();
            pnlLeftSide = new Panel();
            lbContract = new ListBox();
            pnlRightSide = new Panel();
            pnlContractManipulation = new Panel();
            btnCancelContract = new Button();
            btnNewContract = new Button();
            btnUpdateContract = new Button();
            btnInsertContract = new Button();
            gbContractInformation = new GroupBox();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            cbStaffID = new ComboBox();
            lblStaffID = new Label();
            cbInsuranceID = new ComboBox();
            lblInsuranceID = new Label();
            cbCustomerID = new ComboBox();
            dtpNextPaymentDate = new DateTimePicker();
            lblNextPaymentDate = new Label();
            dtpLeaseEndDate = new DateTimePicker();
            lblLeaseEndDate = new Label();
            dtpLeaseStartDate = new DateTimePicker();
            lblLeaseStartDate = new Label();
            lblStaffPosition = new Label();
            lblStaffName = new Label();
            txtInsuranceName = new TextBox();
            lblInsuranceName = new Label();
            cbStoreID = new ComboBox();
            lblContractID = new Label();
            lblStoreID = new Label();
            txtContractID = new TextBox();
            lblContractDate = new Label();
            dtpContractDate = new DateTimePicker();
            lblCustomerID = new Label();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            pnlContractManipulation.SuspendLayout();
            gbContractInformation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានកិច្ចសន្យា";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchContract
            // 
            lblSearchContract.AutoSize = true;
            lblSearchContract.Location = new Point(21, 11);
            lblSearchContract.Name = "lblSearchContract";
            lblSearchContract.Size = new Size(333, 43);
            lblSearchContract.TabIndex = 1;
            lblSearchContract.Text = "ស្វែងរក (លេខសម្គាល់កិច្ចសន្យា):";
            // 
            // txtSearchContract
            // 
            txtSearchContract.Location = new Point(21, 50);
            txtSearchContract.Name = "txtSearchContract";
            txtSearchContract.Size = new Size(319, 51);
            txtSearchContract.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbContract);
            pnlLeftSide.Controls.Add(lblSearchContract);
            pnlLeftSide.Controls.Add(txtSearchContract);
            pnlLeftSide.Location = new Point(272, 272);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbContract
            // 
            lbContract.FormattingEnabled = true;
            lbContract.ItemHeight = 43;
            lbContract.Location = new Point(21, 110);
            lbContract.Name = "lbContract";
            lbContract.Size = new Size(319, 434);
            lbContract.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(pnlContractManipulation);
            pnlRightSide.Controls.Add(gbContractInformation);
            pnlRightSide.Location = new Point(662, 272);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 636);
            pnlRightSide.TabIndex = 4;
            // 
            // pnlContractManipulation
            // 
            pnlContractManipulation.Controls.Add(btnCancelContract);
            pnlContractManipulation.Controls.Add(btnNewContract);
            pnlContractManipulation.Controls.Add(btnUpdateContract);
            pnlContractManipulation.Controls.Add(btnInsertContract);
            pnlContractManipulation.Location = new Point(45, 481);
            pnlContractManipulation.Name = "pnlContractManipulation";
            pnlContractManipulation.Size = new Size(1069, 101);
            pnlContractManipulation.TabIndex = 5;
            // 
            // btnCancelContract
            // 
            btnCancelContract.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelContract.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelContract.ForeColor = Color.White;
            btnCancelContract.Location = new Point(871, 20);
            btnCancelContract.Name = "btnCancelContract";
            btnCancelContract.Size = new Size(152, 52);
            btnCancelContract.TabIndex = 3;
            btnCancelContract.Text = "បោះបង់";
            btnCancelContract.UseVisualStyleBackColor = false;
            // 
            // btnNewContract
            // 
            btnNewContract.BackColor = Color.FromArgb(0, 28, 87);
            btnNewContract.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewContract.ForeColor = Color.White;
            btnNewContract.Location = new Point(587, 20);
            btnNewContract.Name = "btnNewContract";
            btnNewContract.Size = new Size(152, 52);
            btnNewContract.TabIndex = 2;
            btnNewContract.Text = "បង្កើតថ្មី";
            btnNewContract.UseVisualStyleBackColor = false;
            // 
            // btnUpdateContract
            // 
            btnUpdateContract.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateContract.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateContract.ForeColor = Color.White;
            btnUpdateContract.Location = new Point(303, 20);
            btnUpdateContract.Name = "btnUpdateContract";
            btnUpdateContract.Size = new Size(152, 52);
            btnUpdateContract.TabIndex = 1;
            btnUpdateContract.Text = "កែប្រែ";
            btnUpdateContract.UseVisualStyleBackColor = false;
            // 
            // btnInsertContract
            // 
            btnInsertContract.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertContract.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertContract.ForeColor = Color.White;
            btnInsertContract.Location = new Point(19, 20);
            btnInsertContract.Name = "btnInsertContract";
            btnInsertContract.Size = new Size(152, 52);
            btnInsertContract.TabIndex = 0;
            btnInsertContract.Text = "បញ្ចូល";
            btnInsertContract.UseVisualStyleBackColor = false;
            // 
            // gbContractInformation
            // 
            gbContractInformation.Controls.Add(txtStaffPosition);
            gbContractInformation.Controls.Add(txtStaffName);
            gbContractInformation.Controls.Add(cbStaffID);
            gbContractInformation.Controls.Add(lblStaffID);
            gbContractInformation.Controls.Add(cbInsuranceID);
            gbContractInformation.Controls.Add(lblInsuranceID);
            gbContractInformation.Controls.Add(cbCustomerID);
            gbContractInformation.Controls.Add(dtpNextPaymentDate);
            gbContractInformation.Controls.Add(lblNextPaymentDate);
            gbContractInformation.Controls.Add(dtpLeaseEndDate);
            gbContractInformation.Controls.Add(lblLeaseEndDate);
            gbContractInformation.Controls.Add(dtpLeaseStartDate);
            gbContractInformation.Controls.Add(lblLeaseStartDate);
            gbContractInformation.Controls.Add(lblStaffPosition);
            gbContractInformation.Controls.Add(lblStaffName);
            gbContractInformation.Controls.Add(txtInsuranceName);
            gbContractInformation.Controls.Add(lblInsuranceName);
            gbContractInformation.Controls.Add(cbStoreID);
            gbContractInformation.Controls.Add(lblContractID);
            gbContractInformation.Controls.Add(lblStoreID);
            gbContractInformation.Controls.Add(txtContractID);
            gbContractInformation.Controls.Add(lblContractDate);
            gbContractInformation.Controls.Add(dtpContractDate);
            gbContractInformation.Controls.Add(lblCustomerID);
            gbContractInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbContractInformation.Location = new Point(45, 32);
            gbContractInformation.Name = "gbContractInformation";
            gbContractInformation.Size = new Size(1069, 409);
            gbContractInformation.TabIndex = 25;
            gbContractInformation.TabStop = false;
            gbContractInformation.Text = "ព័ត៌មានកិច្ចសន្យា";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(805, 338);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(220, 51);
            txtStaffPosition.TabIndex = 39;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(256, 338);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(242, 51);
            txtStaffName.TabIndex = 38;
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(805, 276);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(220, 51);
            cbStaffID.TabIndex = 37;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(513, 276);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(214, 43);
            lblStaffID.TabIndex = 36;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbInsuranceID
            // 
            cbInsuranceID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbInsuranceID.FormattingEnabled = true;
            cbInsuranceID.Location = new Point(805, 215);
            cbInsuranceID.Name = "cbInsuranceID";
            cbInsuranceID.Size = new Size(220, 51);
            cbInsuranceID.TabIndex = 35;
            // 
            // lblInsuranceID
            // 
            lblInsuranceID.AutoSize = true;
            lblInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceID.Location = new Point(513, 218);
            lblInsuranceID.Name = "lblInsuranceID";
            lblInsuranceID.Size = new Size(326, 43);
            lblInsuranceID.TabIndex = 34;
            lblInsuranceID.Text = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbCustomerID
            // 
            cbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Location = new Point(256, 215);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(242, 51);
            cbCustomerID.TabIndex = 33;
            // 
            // dtpNextPaymentDate
            // 
            dtpNextPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNextPaymentDate.Format = DateTimePickerFormat.Short;
            dtpNextPaymentDate.Location = new Point(256, 151);
            dtpNextPaymentDate.Name = "dtpNextPaymentDate";
            dtpNextPaymentDate.Size = new Size(242, 51);
            dtpNextPaymentDate.TabIndex = 32;
            dtpNextPaymentDate.Tag = "pof";
            // 
            // lblNextPaymentDate
            // 
            lblNextPaymentDate.AutoSize = true;
            lblNextPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextPaymentDate.Location = new Point(18, 157);
            lblNextPaymentDate.Name = "lblNextPaymentDate";
            lblNextPaymentDate.Size = new Size(273, 43);
            lblNextPaymentDate.TabIndex = 31;
            lblNextPaymentDate.Text = "កាលបរិច្ឆេទបង់ប្រាក់បន្ទាប់:";
            // 
            // dtpLeaseEndDate
            // 
            dtpLeaseEndDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLeaseEndDate.Format = DateTimePickerFormat.Short;
            dtpLeaseEndDate.Location = new Point(805, 92);
            dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            dtpLeaseEndDate.Size = new Size(220, 51);
            dtpLeaseEndDate.TabIndex = 30;
            dtpLeaseEndDate.Tag = "pof";
            // 
            // lblLeaseEndDate
            // 
            lblLeaseEndDate.AutoSize = true;
            lblLeaseEndDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeaseEndDate.Location = new Point(513, 98);
            lblLeaseEndDate.Name = "lblLeaseEndDate";
            lblLeaseEndDate.Size = new Size(264, 43);
            lblLeaseEndDate.TabIndex = 29;
            lblLeaseEndDate.Text = "កាលបរិច្ឆេទបញ្ចប់ការជួល:";
            // 
            // dtpLeaseStartDate
            // 
            dtpLeaseStartDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLeaseStartDate.Format = DateTimePickerFormat.Short;
            dtpLeaseStartDate.Location = new Point(256, 92);
            dtpLeaseStartDate.Name = "dtpLeaseStartDate";
            dtpLeaseStartDate.Size = new Size(242, 51);
            dtpLeaseStartDate.TabIndex = 28;
            dtpLeaseStartDate.Tag = "pof";
            // 
            // lblLeaseStartDate
            // 
            lblLeaseStartDate.AutoSize = true;
            lblLeaseStartDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeaseStartDate.Location = new Point(19, 98);
            lblLeaseStartDate.Name = "lblLeaseStartDate";
            lblLeaseStartDate.Size = new Size(256, 43);
            lblLeaseStartDate.TabIndex = 27;
            lblLeaseStartDate.Text = "កាលបរិច្ឆេទចាប់ផ្ដើមជួល:";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(513, 341);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 23;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 341);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(155, 43);
            lblStaffName.TabIndex = 21;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtInsuranceName
            // 
            txtInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceName.Location = new Point(256, 276);
            txtInsuranceName.Name = "txtInsuranceName";
            txtInsuranceName.ReadOnly = true;
            txtInsuranceName.Size = new Size(242, 51);
            txtInsuranceName.TabIndex = 17;
            // 
            // lblInsuranceName
            // 
            lblInsuranceName.AutoSize = true;
            lblInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceName.Location = new Point(19, 279);
            lblInsuranceName.Name = "lblInsuranceName";
            lblInsuranceName.Size = new Size(267, 43);
            lblInsuranceName.TabIndex = 16;
            lblInsuranceName.Text = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbStoreID
            // 
            cbStoreID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Location = new Point(805, 154);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(220, 51);
            cbStoreID.TabIndex = 15;
            // 
            // lblContractID
            // 
            lblContractID.AutoSize = true;
            lblContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractID.Location = new Point(18, 41);
            lblContractID.Name = "lblContractID";
            lblContractID.Size = new Size(229, 43);
            lblContractID.TabIndex = 0;
            lblContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(513, 157);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(175, 43);
            lblStoreID.TabIndex = 14;
            lblStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // txtContractID
            // 
            txtContractID.Enabled = false;
            txtContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContractID.Location = new Point(256, 38);
            txtContractID.Name = "txtContractID";
            txtContractID.Size = new Size(242, 51);
            txtContractID.TabIndex = 3;
            // 
            // lblContractDate
            // 
            lblContractDate.AutoSize = true;
            lblContractDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractDate.Location = new Point(513, 41);
            lblContractDate.Name = "lblContractDate";
            lblContractDate.Size = new Size(250, 43);
            lblContractDate.TabIndex = 10;
            lblContractDate.Text = "កាលបរិច្ឆេទចុះកិច្ចសន្យា:";
            // 
            // dtpContractDate
            // 
            dtpContractDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpContractDate.Format = DateTimePickerFormat.Short;
            dtpContractDate.Location = new Point(805, 35);
            dtpContractDate.Name = "dtpContractDate";
            dtpContractDate.Size = new Size(220, 51);
            dtpContractDate.TabIndex = 11;
            dtpContractDate.Tag = "pop";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(18, 218);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(223, 43);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // FrmContract
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmContract";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            pnlContractManipulation.ResumeLayout(false);
            gbContractInformation.ResumeLayout(false);
            gbContractInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchContract;
        private TextBox txtSearchContract;
        private Panel pnlLeftSide;
        private ListBox lbContract;
        private Panel pnlRightSide;
        private Label lblContractID;
        private TextBox txtContractID;
        private DateTimePicker dtpContractDate;
        private Label lblStaffPosition;
        private Label lblCustomerID;
        private GroupBox gbContractInformation;
        private TextBox txtInsuranceName;
        private Label lblInsuranceName;
        private Label lblStaffName;
        private Panel pnlContractManipulation;
        private Button btnInsertContract;
        private Button btnCancelContract;
        private Button btnNewContract;
        private Button btnUpdateContract;
        private Label lblContractStartDate;
        private DateTimePicker dtpContractEndDate;
        private Label lblContractEndDate;
        private DateTimePicker dtpLeaseStartDate;
        private DateTimePicker dtpNextPaymentDate;
        private Label lblNextPaymentDate;
        private ComboBox cbCustomerID;
        private Label lblInsuranceID;
        private ComboBox cbInsuranceID;
        private TextBox txtStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffID;
        private TextBox txtStaffPosition;
        private Label lblLeaseEndDate;
        private DateTimePicker dtpLeaseEndDate;
        private Label lblLeaseStartDate;
        private Label lblContractDate;
        private Label lblStoreID;
        private ComboBox cbStoreID;
    }
}