namespace Condo_Sale_Management_Systems
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
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchUser
            // 
            lblSearchUser.AutoSize = true;
            lblSearchUser.Location = new Point(82, 29);
            lblSearchUser.Name = "lblSearchUser";
            lblSearchUser.Size = new Size(256, 36);
            lblSearchUser.TabIndex = 1;
            lblSearchUser.Text = "ស្វែងរក (ឈ្មោះអ្នកប្រើប្រាស់):";
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(411, 26);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(334, 44);
            txtSearchUser.TabIndex = 2;
            txtSearchUser.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvUsers);
            pnlLeftSide.Controls.Add(lblSearchUser);
            pnlLeftSide.Controls.Add(txtSearchUser);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Password, StaffID, StaffName, StaffPosition });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Location = new Point(82, 82);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
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
            UserID.Width = 244;
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
            StaffID.Width = 206;
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
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
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
            gbUserInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
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
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(711, 185);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(907, 177);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(412, 44);
            txtStaffPosition.TabIndex = 31;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(245, 182);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(418, 44);
            txtStaffName.TabIndex = 30;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 185);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 29;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(906, 108);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(412, 44);
            cbStaffID.TabIndex = 3;
            // 
            // pnlUserManipulation
            // 
            pnlUserManipulation.Controls.Add(btnCancelFormUser);
            pnlUserManipulation.Controls.Add(btnNewUser);
            pnlUserManipulation.Controls.Add(btnUpdateUser);
            pnlUserManipulation.Controls.Add(btnInsertUser);
            pnlUserManipulation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlUserManipulation.Location = new Point(18, 232);
            pnlUserManipulation.Name = "pnlUserManipulation";
            pnlUserManipulation.Size = new Size(1301, 81);
            pnlUserManipulation.TabIndex = 5;
            // 
            // btnCancelFormUser
            // 
            btnCancelFormUser.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelFormUser.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnNewUser.BackColor = Color.FromArgb(0, 28, 87);
            btnNewUser.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnUpdateUser.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateUser.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnInsertUser.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertUser.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(711, 111);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 27;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.Location = new Point(18, 41);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(221, 36);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "លេខសម្គាល់អ្នកប្រើប្រាស់:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(907, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(412, 44);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(711, 41);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(168, 36);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់:";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(245, 33);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(418, 44);
            txtUserID.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(18, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 36);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "លេខសម្ងាត់:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(245, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(418, 44);
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