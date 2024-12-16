namespace Home_Sale_Management_Systems
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
            txtPurchasePrice = new TextBox();
            lblPurchasePrice = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            cbStaffID = new ComboBox();
            lblStaffID = new Label();
            cbCustomerID = new ComboBox();
            lblStaffPosition = new Label();
            lblStaffName = new Label();
            cbHomeID = new ComboBox();
            lblPurchaseID = new Label();
            lblHomeID = new Label();
            txtPurchaseID = new TextBox();
            lblPurchaseDate = new Label();
            dtpPurchaseDate = new DateTimePicker();
            lblCustomerID = new Label();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            pnlPurchaseManipulation.SuspendLayout();
            gbPurchaseInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Cyan;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Khmer OS Wat Phnom", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(290, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1510, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានការទិញលក់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchPurchase
            // 
            lblSearchPurchase.AutoSize = true;
            lblSearchPurchase.Location = new Point(21, 11);
            lblSearchPurchase.Name = "lblSearchPurchase";
            lblSearchPurchase.Size = new Size(268, 35);
            lblSearchPurchase.TabIndex = 1;
            lblSearchPurchase.Text = "ស្វែងរក (លេខសម្គាល់ការទិញលក់):";
            // 
            // txtSearchPurchase
            // 
            txtSearchPurchase.Location = new Point(21, 50);
            txtSearchPurchase.Name = "txtSearchPurchase";
            txtSearchPurchase.Size = new Size(319, 43);
            txtSearchPurchase.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbPurchase);
            pnlLeftSide.Controls.Add(lblSearchPurchase);
            pnlLeftSide.Controls.Add(txtSearchPurchase);
            pnlLeftSide.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlLeftSide.Location = new Point(290, 272);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(346, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbPurchase
            // 
            lbPurchase.FormattingEnabled = true;
            lbPurchase.ItemHeight = 35;
            lbPurchase.Location = new Point(21, 110);
            lbPurchase.Name = "lbPurchase";
            lbPurchase.Size = new Size(319, 389);
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
            btnCancelPurchase.BackColor = Color.Cyan;
            btnCancelPurchase.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnNewPurchase.BackColor = Color.Cyan;
            btnNewPurchase.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnUpdatePurchase.BackColor = Color.Cyan;
            btnUpdatePurchase.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnInsertPurchase.BackColor = Color.Cyan;
            btnInsertPurchase.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            gbPurchaseInformation.Controls.Add(cbCustomerID);
            gbPurchaseInformation.Controls.Add(lblStaffPosition);
            gbPurchaseInformation.Controls.Add(lblStaffName);
            gbPurchaseInformation.Controls.Add(cbHomeID);
            gbPurchaseInformation.Controls.Add(lblPurchaseID);
            gbPurchaseInformation.Controls.Add(lblHomeID);
            gbPurchaseInformation.Controls.Add(txtPurchaseID);
            gbPurchaseInformation.Controls.Add(lblPurchaseDate);
            gbPurchaseInformation.Controls.Add(dtpPurchaseDate);
            gbPurchaseInformation.Controls.Add(lblCustomerID);
            gbPurchaseInformation.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPurchaseInformation.Location = new Point(45, 32);
            gbPurchaseInformation.Name = "gbPurchaseInformation";
            gbPurchaseInformation.Size = new Size(1069, 409);
            gbPurchaseInformation.TabIndex = 25;
            gbPurchaseInformation.TabStop = false;
            gbPurchaseInformation.Text = "ព័ត៌មានការទិញលក់";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtPurchasePrice.Location = new Point(805, 106);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.ReadOnly = true;
            txtPurchasePrice.Size = new Size(220, 30);
            txtPurchasePrice.TabIndex = 41;
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchasePrice.Location = new Point(515, 101);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(108, 35);
            lblPurchasePrice.TabIndex = 40;
            lblPurchasePrice.Text = "តម្លៃទិញលក់:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Microsoft Sans Serif", 12F);
            txtStaffPosition.Location = new Point(805, 318);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(220, 30);
            txtStaffPosition.TabIndex = 39;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Microsoft Sans Serif", 12F);
            txtStaffName.Location = new Point(256, 318);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(242, 30);
            txtStaffName.TabIndex = 38;
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("Microsoft Sans Serif", 12F);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(805, 250);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(218, 33);
            cbStaffID.TabIndex = 37;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(513, 248);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(165, 35);
            lblStaffID.TabIndex = 36;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbCustomerID
            // 
            cbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerID.Font = new Font("Microsoft Sans Serif", 12F);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Location = new Point(256, 179);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(242, 33);
            cbCustomerID.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffPosition.Location = new Point(513, 313);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(112, 35);
            lblStaffPosition.TabIndex = 23;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(19, 313);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(119, 35);
            lblStaffName.TabIndex = 21;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbHomeID
            // 
            cbHomeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHomeID.Font = new Font("Microsoft Sans Serif", 12F);
            cbHomeID.FormattingEnabled = true;
            cbHomeID.Location = new Point(256, 106);
            cbHomeID.Name = "cbHomeID";
            cbHomeID.Size = new Size(242, 33);
            cbHomeID.TabIndex = 15;
            // 
            // lblPurchaseID
            // 
            lblPurchaseID.AutoSize = true;
            lblPurchaseID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseID.Location = new Point(18, 35);
            lblPurchaseID.Name = "lblPurchaseID";
            lblPurchaseID.Size = new Size(193, 35);
            lblPurchaseID.TabIndex = 0;
            lblPurchaseID.Text = "លេខសម្គាល់ការទិញលក់:";
            // 
            // lblHomeID
            // 
            lblHomeID.AutoSize = true;
            lblHomeID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomeID.Location = new Point(18, 106);
            lblHomeID.Name = "lblHomeID";
            lblHomeID.Size = new Size(157, 35);
            lblHomeID.TabIndex = 14;
            lblHomeID.Text = "លេខសម្គាល់ ផ្ទះបុរី:";
            // 
            // txtPurchaseID
            // 
            txtPurchaseID.Enabled = false;
            txtPurchaseID.Font = new Font("Microsoft Sans Serif", 12F);
            txtPurchaseID.Location = new Point(256, 38);
            txtPurchaseID.Name = "txtPurchaseID";
            txtPurchaseID.Size = new Size(242, 30);
            txtPurchaseID.TabIndex = 3;
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseDate.Location = new Point(513, 35);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(162, 35);
            lblPurchaseDate.TabIndex = 10;
            lblPurchaseDate.Text = "កាលបរិច្ឆេទទិញលក់:";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Font = new Font("Microsoft Sans Serif", 12F);
            dtpPurchaseDate.Format = DateTimePickerFormat.Short;
            dtpPurchaseDate.Location = new Point(805, 35);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(220, 30);
            dtpPurchaseDate.TabIndex = 11;
            dtpPurchaseDate.Tag = "pop";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(18, 179);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(173, 35);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
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
        private Label lblStaffName;
        private Panel pnlPurchaseManipulation;
        private Button btnInsertPurchase;
        private Button btnCancelPurchase;
        private Button btnNewPurchase;
        private Button btnUpdatePurchase;
        private ComboBox cbCustomerID;
        private TextBox txtStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffID;
        private TextBox txtStaffPosition;
        private Label lblPurchaseDate;
        private Label lblHomeID;
        private ComboBox cbHomeID;
        private TextBox txtPurchasePrice;
        private Label lblPurchasePrice;
    }
}