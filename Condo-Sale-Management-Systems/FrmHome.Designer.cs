namespace Home_Sale_Management_Systems
{
    partial class FrmHome
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
            lblSearchHome = new Label();
            txtSearchHome = new TextBox();
            pnlLeftSide = new Panel();
            dgvHomes = new DataGridView();
            pnlRightSide = new Panel();
            gbHomeInformation = new GroupBox();
            chbStatus = new CheckBox();
            cbHomeTypeID = new ComboBox();
            txtWidth = new TextBox();
            lblHomeTypeID = new Label();
            lblStatus = new Label();
            pnlHomeManipulation = new Panel();
            btnCancelHome = new Button();
            btnNewHome = new Button();
            btnUpdateHome = new Button();
            btnInsertHome = new Button();
            lblWidth = new Label();
            lblHomeID = new Label();
            txtHomeID = new TextBox();
            lblLength = new Label();
            txtLength = new TextBox();
            HomeID = new DataGridViewTextBoxColumn();
            Length = new DataGridViewTextBoxColumn();
            Width = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            HomeTypeDescription = new DataGridViewTextBoxColumn();
            HomeTypeID = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHomes).BeginInit();
            pnlRightSide.SuspendLayout();
            gbHomeInformation.SuspendLayout();
            pnlHomeManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មាន Home";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchHome
            // 
            lblSearchHome.AutoSize = true;
            lblSearchHome.Location = new Point(82, 29);
            lblSearchHome.Name = "lblSearchHome";
            lblSearchHome.Size = new Size(272, 36);
            lblSearchHome.TabIndex = 1;
            lblSearchHome.Text = "ស្វែងរក (លេខសម្គាល់ Home):";
            // 
            // txtSearchHome
            // 
            txtSearchHome.Location = new Point(369, 26);
            txtSearchHome.Name = "txtSearchHome";
            txtSearchHome.Size = new Size(334, 44);
            txtSearchHome.TabIndex = 6;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvHomes);
            pnlLeftSide.Controls.Add(lblSearchHome);
            pnlLeftSide.Controls.Add(txtSearchHome);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvHomes
            // 
            dgvHomes.AllowUserToAddRows = false;
            dgvHomes.AllowUserToDeleteRows = false;
            dgvHomes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHomes.Columns.AddRange(new DataGridViewColumn[] { HomeID, Length, Width, Status, HomeTypeDescription, HomeTypeID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHomes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHomes.Location = new Point(82, 82);
            dgvHomes.Name = "dgvHomes";
            dgvHomes.ReadOnly = true;
            dgvHomes.RowHeadersWidth = 51;
            dgvHomes.RowTemplate.Height = 29;
            dgvHomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHomes.Size = new Size(1362, 325);
            dgvHomes.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbHomeInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbHomeInformation
            // 
            gbHomeInformation.Controls.Add(chbStatus);
            gbHomeInformation.Controls.Add(cbHomeTypeID);
            gbHomeInformation.Controls.Add(txtWidth);
            gbHomeInformation.Controls.Add(lblHomeTypeID);
            gbHomeInformation.Controls.Add(lblStatus);
            gbHomeInformation.Controls.Add(pnlHomeManipulation);
            gbHomeInformation.Controls.Add(lblWidth);
            gbHomeInformation.Controls.Add(lblHomeID);
            gbHomeInformation.Controls.Add(txtHomeID);
            gbHomeInformation.Controls.Add(lblLength);
            gbHomeInformation.Controls.Add(txtLength);
            gbHomeInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbHomeInformation.Location = new Point(82, 12);
            gbHomeInformation.Name = "gbHomeInformation";
            gbHomeInformation.Size = new Size(1362, 335);
            gbHomeInformation.TabIndex = 25;
            gbHomeInformation.TabStop = false;
            gbHomeInformation.Text = "ព័ត៌មាន Home";
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(287, 188);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(18, 17);
            chbStatus.TabIndex = 4;
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // cbHomeTypeID
            // 
            cbHomeTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHomeTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbHomeTypeID.FormattingEnabled = true;
            cbHomeTypeID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbHomeTypeID.Location = new Point(946, 174);
            cbHomeTypeID.MaxDropDownItems = 3;
            cbHomeTypeID.Name = "cbHomeTypeID";
            cbHomeTypeID.Size = new Size(373, 44);
            cbHomeTypeID.TabIndex = 5;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWidth.Location = new Point(946, 105);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(373, 44);
            txtWidth.TabIndex = 3;
            // 
            // lblHomeTypeID
            // 
            lblHomeTypeID.AutoSize = true;
            lblHomeTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHomeTypeID.Location = new Point(711, 177);
            lblHomeTypeID.Name = "lblHomeTypeID";
            lblHomeTypeID.Size = new Size(138, 36);
            lblHomeTypeID.TabIndex = 32;
            lblHomeTypeID.Text = "ប្រភេទ Home:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(18, 177);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 36);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "បានលក់:";
            // 
            // pnlHomeManipulation
            // 
            pnlHomeManipulation.Controls.Add(btnCancelHome);
            pnlHomeManipulation.Controls.Add(btnNewHome);
            pnlHomeManipulation.Controls.Add(btnUpdateHome);
            pnlHomeManipulation.Controls.Add(btnInsertHome);
            pnlHomeManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlHomeManipulation.Location = new Point(18, 232);
            pnlHomeManipulation.Name = "pnlHomeManipulation";
            pnlHomeManipulation.Size = new Size(1301, 81);
            pnlHomeManipulation.TabIndex = 5;
            // 
            // btnCancelHome
            // 
            btnCancelHome.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelHome.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelHome.ForeColor = Color.White;
            btnCancelHome.Location = new Point(1100, 20);
            btnCancelHome.Name = "btnCancelHome";
            btnCancelHome.Size = new Size(152, 52);
            btnCancelHome.TabIndex = 3;
            btnCancelHome.Text = "បោះបង់";
            btnCancelHome.UseVisualStyleBackColor = false;
            // 
            // btnNewHome
            // 
            btnNewHome.BackColor = Color.FromArgb(0, 28, 87);
            btnNewHome.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewHome.ForeColor = Color.White;
            btnNewHome.Location = new Point(740, 20);
            btnNewHome.Name = "btnNewHome";
            btnNewHome.Size = new Size(152, 52);
            btnNewHome.TabIndex = 2;
            btnNewHome.Text = "បង្កើតថ្មី";
            btnNewHome.UseVisualStyleBackColor = false;
            // 
            // btnUpdateHome
            // 
            btnUpdateHome.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateHome.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateHome.ForeColor = Color.White;
            btnUpdateHome.Location = new Point(380, 20);
            btnUpdateHome.Name = "btnUpdateHome";
            btnUpdateHome.Size = new Size(152, 52);
            btnUpdateHome.TabIndex = 1;
            btnUpdateHome.Text = "កែប្រែ";
            btnUpdateHome.UseVisualStyleBackColor = false;
            // 
            // btnInsertHome
            // 
            btnInsertHome.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertHome.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertHome.ForeColor = Color.White;
            btnInsertHome.Location = new Point(20, 20);
            btnInsertHome.Name = "btnInsertHome";
            btnInsertHome.Size = new Size(152, 52);
            btnInsertHome.TabIndex = 0;
            btnInsertHome.Text = "បញ្ចូល";
            btnInsertHome.UseVisualStyleBackColor = false;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWidth.Location = new Point(711, 111);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(63, 36);
            lblWidth.TabIndex = 27;
            lblWidth.Text = "ទទឹង:";
            // 
            // lblHomeID
            // 
            lblHomeID.AutoSize = true;
            lblHomeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHomeID.Location = new Point(18, 41);
            lblHomeID.Name = "lblHomeID";
            lblHomeID.Size = new Size(184, 36);
            lblHomeID.TabIndex = 0;
            lblHomeID.Text = "លេខសម្គាល់ Home:";
            // 
            // txtHomeID
            // 
            txtHomeID.Enabled = false;
            txtHomeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHomeID.Location = new Point(287, 33);
            txtHomeID.Name = "txtHomeID";
            txtHomeID.Size = new Size(376, 44);
            txtHomeID.TabIndex = 3;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.Location = new Point(18, 111);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(95, 36);
            lblLength.TabIndex = 6;
            lblLength.Text = "បណ្ដោយ:";
            // 
            // txtLength
            // 
            txtLength.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLength.Location = new Point(287, 105);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(376, 44);
            txtLength.TabIndex = 2;
            // 
            // HomeID
            // 
            HomeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HomeID.DataPropertyName = "HomeID";
            HomeID.HeaderText = "លេខសម្គាល់ Home";
            HomeID.MinimumWidth = 6;
            HomeID.Name = "HomeID";
            HomeID.ReadOnly = true;
            HomeID.Width = 207;
            // 
            // Length
            // 
            Length.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Length.DataPropertyName = "Length";
            Length.HeaderText = "បណ្ដោយ";
            Length.MinimumWidth = 6;
            Length.Name = "Length";
            Length.ReadOnly = true;
            // 
            // Width
            // 
            Width.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Width.DataPropertyName = "Width";
            Width.HeaderText = "ទទឹង";
            Width.MinimumWidth = 6;
            Width.Name = "Width";
            Width.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "ស្ថានភាព";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // HomeTypeDescription
            // 
            HomeTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HomeTypeDescription.DataPropertyName = "HomeTypeDescription";
            HomeTypeDescription.HeaderText = "ប្រភេទ Home";
            HomeTypeDescription.MinimumWidth = 6;
            HomeTypeDescription.Name = "HomeTypeDescription";
            HomeTypeDescription.ReadOnly = true;
            HomeTypeDescription.Width = 161;
            // 
            // HomeTypeID
            // 
            HomeTypeID.DataPropertyName = "HomeTypeID";
            HomeTypeID.HeaderText = "HiddenHomeTypeID";
            HomeTypeID.MinimumWidth = 6;
            HomeTypeID.Name = "HomeTypeID";
            HomeTypeID.ReadOnly = true;
            HomeTypeID.Visible = false;
            HomeTypeID.Width = 125;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmHome";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHomes).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbHomeInformation.ResumeLayout(false);
            gbHomeInformation.PerformLayout();
            pnlHomeManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchHome;
        private TextBox txtSearchHome;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblHomeID;
        private Label lblLength;
        private TextBox txtHomeID;
        private TextBox txtLength;
        private GroupBox gbHomeInformation;
        private Panel pnlHomeManipulation;
        private Button btnInsertHome;
        private Button btnCancelHome;
        private Button btnNewHome;
        private Button btnUpdateHome;
        private Label lblWidth;
        private DataGridView dgvHomes;
        private Label lblStatus;
        private Label lblHomeTypeID;
        private TextBox txtWidth;
        private ComboBox cbHomeTypeID;
        private CheckBox chbStatus;
        private DataGridViewTextBoxColumn HomeID;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Width;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn HomeTypeDescription;
        private DataGridViewTextBoxColumn HomeTypeID;
    }
}