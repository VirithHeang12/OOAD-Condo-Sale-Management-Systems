namespace Home_Sale_Management_Systems
{
    partial class FrmUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSearchUser = new Label();
            txtSearchUser = new TextBox();
            pnlLeftSide = new Panel();
            dgvUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            StaffID = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            StaffPosition = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbUserInformation = new GroupBox();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            cbStaffID = new ComboBox();
            pnlUserManipulation = new Panel();
            btnCancelFormUser = new Button();
            btnNewUser = new Button();
            btnUpdateUser = new Button();
            btnInsertUser = new Button();
            lblStaffID = new Label();
            lblUserID = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtUserID = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlRightSide.SuspendLayout();
            gbUserInformation.SuspendLayout();
            pnlUserManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchUser
            // 
            lblSearchUser.AutoSize = true;
            lblSearchUser.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchUser.Location = new Point(82, 21);
            lblSearchUser.Name = "lblSearchUser";
            lblSearchUser.Size = new Size(234, 35);
            lblSearchUser.TabIndex = 1;
            lblSearchUser.Text = "ស្វែងរក (ឈ្មោះអ្នកប្រើប្រាស់):";
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(411, 26);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(334, 30);
            txtSearchUser.TabIndex = 2;
            txtSearchUser.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvUsers);
            pnlLeftSide.Controls.Add(lblSearchUser);
            pnlLeftSide.Controls.Add(txtSearchUser);
            pnlLeftSide.Location = new Point(290, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1510, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Password, StaffID, StaffName, StaffPosition });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Location = new Point(82, 82);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1362, 325);
            dgvUsers.TabIndex = 3;
            dgvUsers.TabStop = false;
            // 
            // UserID
            // 
            UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "លេខសម្គាល់អ្នកប្រើប្រាស់";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 205;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "លេខសម្ងាត់";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // StaffID
            // 
            StaffID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StaffID.DataPropertyName = "StaffID";
            StaffID.HeaderText = "លេខសម្គាល់បុគ្គលិក";
            StaffID.MinimumWidth = 6;
            StaffID.Name = "StaffID";
            StaffID.ReadOnly = true;
            StaffID.Width = 173;
            // 
            // StaffName
            // 
            StaffName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffName.DataPropertyName = "StaffName";
            StaffName.HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            // 
            // StaffPosition
            // 
            StaffPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffPosition.DataPropertyName = "StaffPosition";
            StaffPosition.HeaderText = "តួនាទីអ្នកប្រើប្រាស់";
            StaffPosition.MinimumWidth = 6;
            StaffPosition.Name = "StaffPosition";
            StaffPosition.ReadOnly = true;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbUserInformation);
            pnlRightSide.Location = new Point(290, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1510, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbUserInformation
            // 
            gbUserInformation.Controls.Add(lblStaffPosition);
            gbUserInformation.Controls.Add(txtStaffPosition);
            gbUserInformation.Controls.Add(txtStaffName);
            gbUserInformation.Controls.Add(lblStaffName);
            gbUserInformation.Controls.Add(cbStaffID);
            gbUserInformation.Controls.Add(pnlUserManipulation);
            gbUserInformation.Controls.Add(lblStaffID);
            gbUserInformation.Controls.Add(lblUserID);
            gbUserInformation.Controls.Add(txtUserName);
            gbUserInformation.Controls.Add(lblUserName);
            gbUserInformation.Controls.Add(txtUserID);
            gbUserInformation.Controls.Add(lblPassword);
            gbUserInformation.Controls.Add(txtPassword);
            gbUserInformation.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbUserInformation.Location = new Point(82, 12);
            gbUserInformation.Name = "gbUserInformation";
            gbUserInformation.Size = new Size(1362, 335);
            gbUserInformation.TabIndex = 25;
            gbUserInformation.TabStop = false;
            gbUserInformation.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffPosition.Location = new Point(711, 172);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(112, 35);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("Microsoft Sans Serif", 12F);
            txtStaffPosition.Location = new Point(907, 177);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(412, 30);
            txtStaffPosition.TabIndex = 31;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("Microsoft Sans Serif", 12F);
            txtStaffName.Location = new Point(245, 182);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(418, 30);
            txtStaffName.TabIndex = 30;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(18, 177);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(119, 35);
            lblStaffName.TabIndex = 29;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("Microsoft Sans Serif", 12F);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(906, 108);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(412, 33);
            cbStaffID.TabIndex = 3;
            // 
            // pnlUserManipulation
            // 
            pnlUserManipulation.Controls.Add(btnCancelFormUser);
            pnlUserManipulation.Controls.Add(btnNewUser);
            pnlUserManipulation.Controls.Add(btnUpdateUser);
            pnlUserManipulation.Controls.Add(btnInsertUser);
            pnlUserManipulation.Font = new Font("Microsoft Sans Serif", 12F);
            pnlUserManipulation.Location = new Point(18, 232);
            pnlUserManipulation.Name = "pnlUserManipulation";
            pnlUserManipulation.Size = new Size(1301, 81);
            pnlUserManipulation.TabIndex = 5;
            // 
            // btnCancelFormUser
            // 
            btnCancelFormUser.BackColor = Color.Cyan;
            btnCancelFormUser.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelFormUser.ForeColor = Color.White;
            btnCancelFormUser.Location = new Point(1100, 20);
            btnCancelFormUser.Name = "btnCancelFormUser";
            btnCancelFormUser.Size = new Size(152, 52);
            btnCancelFormUser.TabIndex = 3;
            btnCancelFormUser.TabStop = false;
            btnCancelFormUser.Text = "បោះបង់";
            btnCancelFormUser.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.Cyan;
            btnNewUser.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(740, 20);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(152, 52);
            btnNewUser.TabIndex = 2;
            btnNewUser.TabStop = false;
            btnNewUser.Text = "បង្កើតថ្មី";
            btnNewUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.Cyan;
            btnUpdateUser.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(380, 20);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(152, 52);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.TabStop = false;
            btnUpdateUser.Text = "កែប្រែ";
            btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnInsertUser
            // 
            btnInsertUser.BackColor = Color.Cyan;
            btnInsertUser.Font = new Font("Khmer OS Wat Phnom", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertUser.ForeColor = Color.White;
            btnInsertUser.Location = new Point(20, 20);
            btnInsertUser.Name = "btnInsertUser";
            btnInsertUser.Size = new Size(152, 52);
            btnInsertUser.TabIndex = 0;
            btnInsertUser.TabStop = false;
            btnInsertUser.Text = "បញ្ចូល";
            btnInsertUser.UseVisualStyleBackColor = false;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(711, 106);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(165, 35);
            lblStaffID.TabIndex = 27;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(18, 31);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(205, 35);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "លេខសម្គាល់អ្នកប្រើប្រាស់:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 12F);
            txtUserName.Location = new Point(907, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(412, 30);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(711, 28);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(159, 35);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់:";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("Microsoft Sans Serif", 12F);
            txtUserID.Location = new Point(245, 33);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(418, 30);
            txtUserID.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(18, 108);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 35);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "លេខសម្ងាត់:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(245, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(418, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmUser";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbUserInformation.ResumeLayout(false);
            gbUserInformation.PerformLayout();
            pnlUserManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchUser;
        private TextBox txtSearchUser;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblUserID;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private GroupBox gbUserInformation;
        private Panel pnlUserManipulation;
        private Button btnInsertUser;
        private Button btnCancelFormUser;
        private Button btnNewUser;
        private Button btnUpdateUser;
        private Label lblStaffID;
        private DataGridView dgvUsers;
        private Label lblStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn StaffPosition;
    }
}