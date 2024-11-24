namespace Condo_Sale_Management_Systems
{
    partial class FrmCondo
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
            lblSearchCondo = new Label();
            txtSearchCondo = new TextBox();
            pnlLeftSide = new Panel();
            dgvCondos = new DataGridView();
            pnlRightSide = new Panel();
            gbCondoInformation = new GroupBox();
            chbStatus = new CheckBox();
            cbCondoTypeID = new ComboBox();
            txtWidth = new TextBox();
            lblCondoTypeID = new Label();
            lblStatus = new Label();
            pnlCondoManipulation = new Panel();
            btnCancelCondo = new Button();
            btnNewCondo = new Button();
            btnUpdateCondo = new Button();
            btnInsertCondo = new Button();
            lblWidth = new Label();
            lblCondoID = new Label();
            txtFloorNumber = new TextBox();
            lblFloorNumber = new Label();
            txtCondoID = new TextBox();
            lblLength = new Label();
            txtLength = new TextBox();
            CondoID = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            Length = new DataGridViewTextBoxColumn();
            Width = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CondoTypeDescription = new DataGridViewTextBoxColumn();
            CondoTypeID = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCondos).BeginInit();
            pnlRightSide.SuspendLayout();
            gbCondoInformation.SuspendLayout();
            pnlCondoManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មាន Condo";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchCondo
            // 
            lblSearchCondo.AutoSize = true;
            lblSearchCondo.Location = new Point(82, 29);
            lblSearchCondo.Name = "lblSearchCondo";
            lblSearchCondo.Size = new Size(272, 36);
            lblSearchCondo.TabIndex = 1;
            lblSearchCondo.Text = "ស្វែងរក (លេខសម្គាល់ Condo):";
            // 
            // txtSearchCondo
            // 
            txtSearchCondo.Location = new Point(369, 26);
            txtSearchCondo.Name = "txtSearchCondo";
            txtSearchCondo.Size = new Size(334, 44);
            txtSearchCondo.TabIndex = 6;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvCondos);
            pnlLeftSide.Controls.Add(lblSearchCondo);
            pnlLeftSide.Controls.Add(txtSearchCondo);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvCondos
            // 
            dgvCondos.AllowUserToAddRows = false;
            dgvCondos.AllowUserToDeleteRows = false;
            dgvCondos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCondos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCondos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCondos.Columns.AddRange(new DataGridViewColumn[] { CondoID, FloorNumber, Length, Width, Status, CondoTypeDescription, CondoTypeID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCondos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCondos.Location = new Point(82, 82);
            dgvCondos.Name = "dgvCondos";
            dgvCondos.ReadOnly = true;
            dgvCondos.RowHeadersWidth = 51;
            dgvCondos.RowTemplate.Height = 29;
            dgvCondos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCondos.Size = new Size(1362, 325);
            dgvCondos.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbCondoInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbCondoInformation
            // 
            gbCondoInformation.Controls.Add(chbStatus);
            gbCondoInformation.Controls.Add(cbCondoTypeID);
            gbCondoInformation.Controls.Add(txtWidth);
            gbCondoInformation.Controls.Add(lblCondoTypeID);
            gbCondoInformation.Controls.Add(lblStatus);
            gbCondoInformation.Controls.Add(pnlCondoManipulation);
            gbCondoInformation.Controls.Add(lblWidth);
            gbCondoInformation.Controls.Add(lblCondoID);
            gbCondoInformation.Controls.Add(txtFloorNumber);
            gbCondoInformation.Controls.Add(lblFloorNumber);
            gbCondoInformation.Controls.Add(txtCondoID);
            gbCondoInformation.Controls.Add(lblLength);
            gbCondoInformation.Controls.Add(txtLength);
            gbCondoInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbCondoInformation.Location = new Point(82, 12);
            gbCondoInformation.Name = "gbCondoInformation";
            gbCondoInformation.Size = new Size(1362, 335);
            gbCondoInformation.TabIndex = 25;
            gbCondoInformation.TabStop = false;
            gbCondoInformation.Text = "ព័ត៌មាន Condo";
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
            // cbCondoTypeID
            // 
            cbCondoTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCondoTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCondoTypeID.FormattingEnabled = true;
            cbCondoTypeID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbCondoTypeID.Location = new Point(946, 174);
            cbCondoTypeID.MaxDropDownItems = 3;
            cbCondoTypeID.Name = "cbCondoTypeID";
            cbCondoTypeID.Size = new Size(373, 44);
            cbCondoTypeID.TabIndex = 5;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWidth.Location = new Point(946, 105);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(373, 44);
            txtWidth.TabIndex = 3;
            // 
            // lblCondoTypeID
            // 
            lblCondoTypeID.AutoSize = true;
            lblCondoTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondoTypeID.Location = new Point(711, 177);
            lblCondoTypeID.Name = "lblCondoTypeID";
            lblCondoTypeID.Size = new Size(138, 36);
            lblCondoTypeID.TabIndex = 32;
            lblCondoTypeID.Text = "ប្រភេទ Condo:";
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
            // pnlCondoManipulation
            // 
            pnlCondoManipulation.Controls.Add(btnCancelCondo);
            pnlCondoManipulation.Controls.Add(btnNewCondo);
            pnlCondoManipulation.Controls.Add(btnUpdateCondo);
            pnlCondoManipulation.Controls.Add(btnInsertCondo);
            pnlCondoManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCondoManipulation.Location = new Point(18, 232);
            pnlCondoManipulation.Name = "pnlCondoManipulation";
            pnlCondoManipulation.Size = new Size(1301, 81);
            pnlCondoManipulation.TabIndex = 5;
            // 
            // btnCancelCondo
            // 
            btnCancelCondo.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelCondo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelCondo.ForeColor = Color.White;
            btnCancelCondo.Location = new Point(1100, 20);
            btnCancelCondo.Name = "btnCancelCondo";
            btnCancelCondo.Size = new Size(152, 52);
            btnCancelCondo.TabIndex = 3;
            btnCancelCondo.Text = "បោះបង់";
            btnCancelCondo.UseVisualStyleBackColor = false;
            // 
            // btnNewCondo
            // 
            btnNewCondo.BackColor = Color.FromArgb(0, 28, 87);
            btnNewCondo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewCondo.ForeColor = Color.White;
            btnNewCondo.Location = new Point(740, 20);
            btnNewCondo.Name = "btnNewCondo";
            btnNewCondo.Size = new Size(152, 52);
            btnNewCondo.TabIndex = 2;
            btnNewCondo.Text = "បង្កើតថ្មី";
            btnNewCondo.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCondo
            // 
            btnUpdateCondo.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateCondo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCondo.ForeColor = Color.White;
            btnUpdateCondo.Location = new Point(380, 20);
            btnUpdateCondo.Name = "btnUpdateCondo";
            btnUpdateCondo.Size = new Size(152, 52);
            btnUpdateCondo.TabIndex = 1;
            btnUpdateCondo.Text = "កែប្រែ";
            btnUpdateCondo.UseVisualStyleBackColor = false;
            // 
            // btnInsertCondo
            // 
            btnInsertCondo.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertCondo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertCondo.ForeColor = Color.White;
            btnInsertCondo.Location = new Point(20, 20);
            btnInsertCondo.Name = "btnInsertCondo";
            btnInsertCondo.Size = new Size(152, 52);
            btnInsertCondo.TabIndex = 0;
            btnInsertCondo.Text = "បញ្ចូល";
            btnInsertCondo.UseVisualStyleBackColor = false;
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
            // lblCondoID
            // 
            lblCondoID.AutoSize = true;
            lblCondoID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondoID.Location = new Point(18, 41);
            lblCondoID.Name = "lblCondoID";
            lblCondoID.Size = new Size(184, 36);
            lblCondoID.TabIndex = 0;
            lblCondoID.Text = "លេខសម្គាល់ Condo:";
            // 
            // txtFloorNumber
            // 
            txtFloorNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFloorNumber.Location = new Point(946, 33);
            txtFloorNumber.Name = "txtFloorNumber";
            txtFloorNumber.Size = new Size(373, 44);
            txtFloorNumber.TabIndex = 1;
            // 
            // lblFloorNumber
            // 
            lblFloorNumber.AutoSize = true;
            lblFloorNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFloorNumber.Location = new Point(711, 41);
            lblFloorNumber.Name = "lblFloorNumber";
            lblFloorNumber.Size = new Size(55, 36);
            lblFloorNumber.TabIndex = 4;
            lblFloorNumber.Text = "ជាន់:";
            // 
            // txtCondoID
            // 
            txtCondoID.Enabled = false;
            txtCondoID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondoID.Location = new Point(287, 33);
            txtCondoID.Name = "txtCondoID";
            txtCondoID.Size = new Size(376, 44);
            txtCondoID.TabIndex = 3;
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
            // CondoID
            // 
            CondoID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CondoID.DataPropertyName = "CondoID";
            CondoID.HeaderText = "លេខសម្គាល់ Condo";
            CondoID.MinimumWidth = 6;
            CondoID.Name = "CondoID";
            CondoID.ReadOnly = true;
            CondoID.Width = 207;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FloorNumber.DataPropertyName = "FloorNumber";
            FloorNumber.HeaderText = "ជាន់";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
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
            // CondoTypeDescription
            // 
            CondoTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CondoTypeDescription.DataPropertyName = "CondoTypeDescription";
            CondoTypeDescription.HeaderText = "ប្រភេទតូប";
            CondoTypeDescription.MinimumWidth = 6;
            CondoTypeDescription.Name = "CondoTypeDescription";
            CondoTypeDescription.ReadOnly = true;
            CondoTypeDescription.Width = 126;
            // 
            // CondoTypeID
            // 
            CondoTypeID.DataPropertyName = "CondoTypeID";
            CondoTypeID.HeaderText = "HiddenCondoTypeID";
            CondoTypeID.MinimumWidth = 6;
            CondoTypeID.Name = "CondoTypeID";
            CondoTypeID.ReadOnly = true;
            CondoTypeID.Visible = false;
            CondoTypeID.Width = 125;
            // 
            // FrmCondo
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmCondo";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCondos).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbCondoInformation.ResumeLayout(false);
            gbCondoInformation.PerformLayout();
            pnlCondoManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchCondo;
        private TextBox txtSearchCondo;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblCondoID;
        private Label lblLength;
        private TextBox txtFloorNumber;
        private Label lblFloorNumber;
        private TextBox txtCondoID;
        private TextBox txtLength;
        private GroupBox gbCondoInformation;
        private Panel pnlCondoManipulation;
        private Button btnInsertCondo;
        private Button btnCancelCondo;
        private Button btnNewCondo;
        private Button btnUpdateCondo;
        private Label lblWidth;
        private DataGridView dgvCondos;
        private Label lblStatus;
        private Label lblCondoTypeID;
        private TextBox txtWidth;
        private ComboBox cbCondoTypeID;
        private CheckBox chbStatus;
        private DataGridViewTextBoxColumn CondoID;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Width;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CondoTypeDescription;
        private DataGridViewTextBoxColumn CondoTypeID;
    }
}