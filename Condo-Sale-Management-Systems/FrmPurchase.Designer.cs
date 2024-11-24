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
            lblSearchPurchase = new Label();
            txtSearchPurchase = new TextBox();
            pnlLeftSide = new Panel();
            lbPurchase = new ListBox();
            pnlRightSide = new Panel();
            pnlPurchaseManipulation = new Panel();
            btnCancelPurchase = new Button();
            btnNewPurchase = new Button();
            btnUpdatePurchase = new Button();
            btnInsertPurchase = new Button();
            gbPurchaseInformation = new GroupBox();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            cbStaffID = new ComboBox();
            lblStaffID = new Label();
            cbInsuranceID = new ComboBox();
            lblInsuranceID = new Label();
            cbCustomerID = new ComboBox();
            lblStaffPosition = new Label();
            lblStaffName = new Label();
            txtInsuranceName = new TextBox();
            lblInsuranceName = new Label();
            cbCondoID = new ComboBox();
            lblPurchaseID = new Label();
            lblCondoID = new Label();
            txtPurchaseID = new TextBox();
            lblPurchaseDate = new Label();
            dtpPurchaseDate = new DateTimePicker();
            lblCustomerID = new Label();
            lblPurchasePrice = new Label();
            txtPurchasePrice = new TextBox();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            pnlPurchaseManipulation.SuspendLayout();
            gbPurchaseInformation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានការទិញលក់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchPurchase
            // 
            lblSearchPurchase.AutoSize = true;
            lblSearchPurchase.Location = new Point(21, 11);
            lblSearchPurchase.Name = "lblSearchPurchase";
            lblSearchPurchase.Size = new Size(303, 36);
            lblSearchPurchase.TabIndex = 1;
            lblSearchPurchase.Text = "ស្វែងរក (លេខសម្គាល់ការទិញលក់):";
            // 
            // txtSearchPurchase
            // 
            txtSearchPurchase.Location = new Point(21, 50);
            txtSearchPurchase.Name = "txtSearchPurchase";
            txtSearchPurchase.Size = new Size(319, 44);
            txtSearchPurchase.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbPurchase);
            pnlLeftSide.Controls.Add(lblSearchPurchase);
            pnlLeftSide.Controls.Add(txtSearchPurchase);
            pnlLeftSide.Location = new Point(272, 272);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbPurchase
            // 
            lbPurchase.FormattingEnabled = true;
            lbPurchase.ItemHeight = 36;
            lbPurchase.Location = new Point(21, 110);
            lbPurchase.Name = "lbPurchase";
            lbPurchase.Size = new Size(319, 400);
            lbPurchase.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(pnlPurchaseManipulation);
            pnlRightSide.Controls.Add(gbPurchaseInformation);
            pnlRightSide.Location = new Point(662, 272);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 636);
            pnlRightSide.TabIndex = 4;
            // 
            // pnlPurchaseManipulation
            // 
            pnlPurchaseManipulation.Controls.Add(btnCancelPurchase);
            pnlPurchaseManipulation.Controls.Add(btnNewPurchase);
            pnlPurchaseManipulation.Controls.Add(btnUpdatePurchase);
            pnlPurchaseManipulation.Controls.Add(btnInsertPurchase);
            pnlPurchaseManipulation.Location = new Point(45, 481);
            pnlPurchaseManipulation.Name = "pnlPurchaseManipulation";
            pnlPurchaseManipulation.Size = new Size(1069, 101);
            pnlPurchaseManipulation.TabIndex = 5;
            // 
            // btnCancelPurchase
            // 
            btnCancelPurchase.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelPurchase.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelPurchase.ForeColor = Color.White;
            btnCancelPurchase.Location = new Point(871, 20);
            btnCancelPurchase.Name = "btnCancelPurchase";
            btnCancelPurchase.Size = new Size(152, 52);
            btnCancelPurchase.TabIndex = 3;
            btnCancelPurchase.Text = "បោះបង់";
            btnCancelPurchase.UseVisualStyleBackColor = false;
            // 
            // btnNewPurchase
            // 
            btnNewPurchase.BackColor = Color.FromArgb(0, 28, 87);
            btnNewPurchase.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewPurchase.ForeColor = Color.White;
            btnNewPurchase.Location = new Point(587, 20);
            btnNewPurchase.Name = "btnNewPurchase";
            btnNewPurchase.Size = new Size(152, 52);
            btnNewPurchase.TabIndex = 2;
            btnNewPurchase.Text = "បង្កើតថ្មី";
            btnNewPurchase.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePurchase
            // 
            btnUpdatePurchase.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdatePurchase.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePurchase.ForeColor = Color.White;
            btnUpdatePurchase.Location = new Point(303, 20);
            btnUpdatePurchase.Name = "btnUpdatePurchase";
            btnUpdatePurchase.Size = new Size(152, 52);
            btnUpdatePurchase.TabIndex = 1;
            btnUpdatePurchase.Text = "កែប្រែ";
            btnUpdatePurchase.UseVisualStyleBackColor = false;
            // 
            // btnInsertPurchase
            // 
            btnInsertPurchase.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertPurchase.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertPurchase.ForeColor = Color.White;
            btnInsertPurchase.Location = new Point(19, 20);
            btnInsertPurchase.Name = "btnInsertPurchase";
            btnInsertPurchase.Size = new Size(152, 52);
            btnInsertPurchase.TabIndex = 0;
            btnInsertPurchase.Text = "បញ្ចូល";
            btnInsertPurchase.UseVisualStyleBackColor = false;
            // 
            // gbPurchaseInformation
            // 
            gbPurchaseInformation.Controls.Add(txtPurchasePrice);
            gbPurchaseInformation.Controls.Add(lblPurchasePrice);
            gbPurchaseInformation.Controls.Add(txtStaffPosition);
            gbPurchaseInformation.Controls.Add(txtStaffName);
            gbPurchaseInformation.Controls.Add(cbStaffID);
            gbPurchaseInformation.Controls.Add(lblStaffID);
            gbPurchaseInformation.Controls.Add(cbInsuranceID);
            gbPurchaseInformation.Controls.Add(lblInsuranceID);
            gbPurchaseInformation.Controls.Add(cbCustomerID);
            gbPurchaseInformation.Controls.Add(lblStaffPosition);
            gbPurchaseInformation.Controls.Add(lblStaffName);
            gbPurchaseInformation.Controls.Add(txtInsuranceName);
            gbPurchaseInformation.Controls.Add(lblInsuranceName);
            gbPurchaseInformation.Controls.Add(cbCondoID);
            gbPurchaseInformation.Controls.Add(lblPurchaseID);
            gbPurchaseInformation.Controls.Add(lblCondoID);
            gbPurchaseInformation.Controls.Add(txtPurchaseID);
            gbPurchaseInformation.Controls.Add(lblPurchaseDate);
            gbPurchaseInformation.Controls.Add(dtpPurchaseDate);
            gbPurchaseInformation.Controls.Add(lblCustomerID);
            gbPurchaseInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbPurchaseInformation.Location = new Point(45, 32);
            gbPurchaseInformation.Name = "gbPurchaseInformation";
            gbPurchaseInformation.Size = new Size(1069, 409);
            gbPurchaseInformation.TabIndex = 25;
            gbPurchaseInformation.TabStop = false;
            gbPurchaseInformation.Text = "ព័ត៌មានការទិញលក់";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(805, 318);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(220, 44);
            txtStaffPosition.TabIndex = 39;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(256, 318);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(242, 44);
            txtStaffName.TabIndex = 38;
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(805, 250);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(218, 44);
            cbStaffID.TabIndex = 37;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(513, 253);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 36;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbInsuranceID
            // 
            cbInsuranceID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbInsuranceID.FormattingEnabled = true;
            cbInsuranceID.Location = new Point(805, 187);
            cbInsuranceID.Name = "cbInsuranceID";
            cbInsuranceID.Size = new Size(220, 44);
            cbInsuranceID.TabIndex = 35;
            // 
            // lblInsuranceID
            // 
            lblInsuranceID.AutoSize = true;
            lblInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceID.Location = new Point(513, 187);
            lblInsuranceID.Name = "lblInsuranceID";
            lblInsuranceID.Size = new Size(276, 36);
            lblInsuranceID.TabIndex = 34;
            lblInsuranceID.Text = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbCustomerID
            // 
            cbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Location = new Point(256, 179);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(242, 44);
            cbCustomerID.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(513, 321);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 23;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 321);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 21;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtInsuranceName
            // 
            txtInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceName.Location = new Point(256, 245);
            txtInsuranceName.Name = "txtInsuranceName";
            txtInsuranceName.ReadOnly = true;
            txtInsuranceName.Size = new Size(242, 44);
            txtInsuranceName.TabIndex = 17;
            // 
            // lblInsuranceName
            // 
            lblInsuranceName.AutoSize = true;
            lblInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceName.Location = new Point(19, 248);
            lblInsuranceName.Name = "lblInsuranceName";
            lblInsuranceName.Size = new Size(223, 36);
            lblInsuranceName.TabIndex = 16;
            lblInsuranceName.Text = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbCondoID
            // 
            cbCondoID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCondoID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCondoID.FormattingEnabled = true;
            cbCondoID.Location = new Point(256, 106);
            cbCondoID.Name = "cbCondoID";
            cbCondoID.Size = new Size(242, 44);
            cbCondoID.TabIndex = 15;
            // 
            // lblPurchaseID
            // 
            lblPurchaseID.AutoSize = true;
            lblPurchaseID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPurchaseID.Location = new Point(18, 41);
            lblPurchaseID.Name = "lblPurchaseID";
            lblPurchaseID.Size = new Size(215, 36);
            lblPurchaseID.TabIndex = 0;
            lblPurchaseID.Text = "លេខសម្គាល់ការទិញលក់:";
            // 
            // lblCondoID
            // 
            lblCondoID.AutoSize = true;
            lblCondoID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondoID.Location = new Point(18, 114);
            lblCondoID.Name = "lblCondoID";
            lblCondoID.Size = new Size(184, 36);
            lblCondoID.TabIndex = 14;
            lblCondoID.Text = "លេខសម្គាល់ Condo:";
            // 
            // txtPurchaseID
            // 
            txtPurchaseID.Enabled = false;
            txtPurchaseID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPurchaseID.Location = new Point(256, 38);
            txtPurchaseID.Name = "txtPurchaseID";
            txtPurchaseID.Size = new Size(242, 44);
            txtPurchaseID.TabIndex = 3;
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPurchaseDate.Location = new Point(513, 41);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(183, 36);
            lblPurchaseDate.TabIndex = 10;
            lblPurchaseDate.Text = "កាលបរិច្ឆេទទិញលក់:";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPurchaseDate.Format = DateTimePickerFormat.Short;
            dtpPurchaseDate.Location = new Point(805, 35);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(220, 44);
            dtpPurchaseDate.TabIndex = 11;
            dtpPurchaseDate.Tag = "pop";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(18, 187);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(191, 36);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPurchasePrice.Location = new Point(513, 114);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(123, 36);
            lblPurchasePrice.TabIndex = 40;
            lblPurchasePrice.Text = "តម្លៃទិញលក់:";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPurchasePrice.Location = new Point(805, 106);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.ReadOnly = true;
            txtPurchasePrice.Size = new Size(220, 44);
            txtPurchasePrice.TabIndex = 41;
            // 
            // FrmPurchase
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmPurchase";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            pnlPurchaseManipulation.ResumeLayout(false);
            gbPurchaseInformation.ResumeLayout(false);
            gbPurchaseInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchPurchase;
        private TextBox txtSearchPurchase;
        private Panel pnlLeftSide;
        private ListBox lbPurchase;
        private Panel pnlRightSide;
        private Label lblPurchaseID;
        private TextBox txtPurchaseID;
        private DateTimePicker dtpPurchaseDate;
        private Label lblStaffPosition;
        private Label lblCustomerID;
        private GroupBox gbPurchaseInformation;
        private TextBox txtInsuranceName;
        private Label lblInsuranceName;
        private Label lblStaffName;
        private Panel pnlPurchaseManipulation;
        private Button btnInsertPurchase;
        private Button btnCancelPurchase;
        private Button btnNewPurchase;
        private Button btnUpdatePurchase;
        private DateTimePicker dtpPurchaseEndDate;
        private ComboBox cbCustomerID;
        private Label lblInsuranceID;
        private ComboBox cbInsuranceID;
        private TextBox txtStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffID;
        private TextBox txtStaffPosition;
        private Label lblPurchaseDate;
        private Label lblCondoID;
        private ComboBox cbCondoID;
        private TextBox txtPurchasePrice;
        private Label lblPurchasePrice;
    }
}