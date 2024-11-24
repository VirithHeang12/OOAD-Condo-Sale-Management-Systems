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
            lblSearchStore = new Label();
            txtSearchStore = new TextBox();
            pnlLeftSide = new Panel();
            dgvStores = new DataGridView();
            StoreID = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            ElectricityLastRecord = new DataGridViewTextBoxColumn();
            WaterLastRecord = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            StoreTypeID = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbStoreInformation = new GroupBox();
            chbStatus = new CheckBox();
            cbStoreTypeID = new ComboBox();
            txtWaterLastRecord = new TextBox();
            lblStoreTypeID = new Label();
            lblStatus = new Label();
            pnlStoreManipulation = new Panel();
            btnCancelStore = new Button();
            btnNewStore = new Button();
            btnUpdateStore = new Button();
            btnInsertStore = new Button();
            lblWaterLastRecord = new Label();
            lblStoreID = new Label();
            txtFloorNumber = new TextBox();
            lblFloorNumber = new Label();
            txtStoreID = new TextBox();
            lblElectricityLastRecord = new Label();
            txtElectricityLastRecord = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).BeginInit();
            pnlRightSide.SuspendLayout();
            gbStoreInformation.SuspendLayout();
            pnlStoreManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានតូប";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStore
            // 
            lblSearchStore.AutoSize = true;
            lblSearchStore.Location = new Point(82, 29);
            lblSearchStore.Name = "lblSearchStore";
            lblSearchStore.Size = new Size(237, 36);
            lblSearchStore.TabIndex = 1;
            lblSearchStore.Text = "ស្វែងរក (លេខសម្គាល់តូប):";
            // 
            // txtSearchStore
            // 
            txtSearchStore.Location = new Point(369, 26);
            txtSearchStore.Name = "txtSearchStore";
            txtSearchStore.Size = new Size(334, 44);
            txtSearchStore.TabIndex = 6;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvStores);
            pnlLeftSide.Controls.Add(lblSearchStore);
            pnlLeftSide.Controls.Add(txtSearchStore);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvStores
            // 
            dgvStores.AllowUserToAddRows = false;
            dgvStores.AllowUserToDeleteRows = false;
            dgvStores.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStores.Columns.AddRange(new DataGridViewColumn[] { StoreID, FloorNumber, ElectricityLastRecord, WaterLastRecord, Status, StoreTypeID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStores.Location = new Point(82, 82);
            dgvStores.Name = "dgvStores";
            dgvStores.ReadOnly = true;
            dgvStores.RowHeadersWidth = 51;
            dgvStores.RowTemplate.Height = 29;
            dgvStores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStores.Size = new Size(1362, 325);
            dgvStores.TabIndex = 3;
            // 
            // StoreID
            // 
            StoreID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StoreID.DataPropertyName = "StoreID";
            StoreID.HeaderText = "លេខសម្គាល់តូប";
            StoreID.MinimumWidth = 6;
            StoreID.Name = "StoreID";
            StoreID.ReadOnly = true;
            StoreID.Width = 172;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FloorNumber.DataPropertyName = "FloorNumber";
            FloorNumber.HeaderText = "ជាន់";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            FloorNumber.Width = 78;
            // 
            // ElectricityLastRecord
            // 
            ElectricityLastRecord.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ElectricityLastRecord.DataPropertyName = "ElectricityLastRecord";
            ElectricityLastRecord.HeaderText = "នាឡិកាអគ្គិសនីចុងក្រោយ";
            ElectricityLastRecord.MinimumWidth = 6;
            ElectricityLastRecord.Name = "ElectricityLastRecord";
            ElectricityLastRecord.ReadOnly = true;
            ElectricityLastRecord.Width = 246;
            // 
            // WaterLastRecord
            // 
            WaterLastRecord.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            WaterLastRecord.DataPropertyName = "WaterLastRecord";
            WaterLastRecord.HeaderText = "នាឡិកាទឹកចុងក្រោយ";
            WaterLastRecord.MinimumWidth = 6;
            WaterLastRecord.Name = "WaterLastRecord";
            WaterLastRecord.ReadOnly = true;
            WaterLastRecord.Width = 212;
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
            // StoreTypeID
            // 
            StoreTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StoreTypeID.DataPropertyName = "StoreTypeID";
            StoreTypeID.HeaderText = "លេខសម្គាល់ប្រភេទតូប";
            StoreTypeID.MinimumWidth = 6;
            StoreTypeID.Name = "StoreTypeID";
            StoreTypeID.ReadOnly = true;
            StoreTypeID.Width = 226;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbStoreInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStoreInformation
            // 
            gbStoreInformation.Controls.Add(chbStatus);
            gbStoreInformation.Controls.Add(cbStoreTypeID);
            gbStoreInformation.Controls.Add(txtWaterLastRecord);
            gbStoreInformation.Controls.Add(lblStoreTypeID);
            gbStoreInformation.Controls.Add(lblStatus);
            gbStoreInformation.Controls.Add(pnlStoreManipulation);
            gbStoreInformation.Controls.Add(lblWaterLastRecord);
            gbStoreInformation.Controls.Add(lblStoreID);
            gbStoreInformation.Controls.Add(txtFloorNumber);
            gbStoreInformation.Controls.Add(lblFloorNumber);
            gbStoreInformation.Controls.Add(txtStoreID);
            gbStoreInformation.Controls.Add(lblElectricityLastRecord);
            gbStoreInformation.Controls.Add(txtElectricityLastRecord);
            gbStoreInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStoreInformation.Location = new Point(82, 12);
            gbStoreInformation.Name = "gbStoreInformation";
            gbStoreInformation.Size = new Size(1362, 335);
            gbStoreInformation.TabIndex = 25;
            gbStoreInformation.TabStop = false;
            gbStoreInformation.Text = "ព័ត៌មានតូប";
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
            // cbStoreTypeID
            // 
            cbStoreTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreTypeID.FormattingEnabled = true;
            cbStoreTypeID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreTypeID.Location = new Point(946, 174);
            cbStoreTypeID.MaxDropDownItems = 3;
            cbStoreTypeID.Name = "cbStoreTypeID";
            cbStoreTypeID.Size = new Size(373, 44);
            cbStoreTypeID.TabIndex = 5;
            // 
            // txtWaterLastRecord
            // 
            txtWaterLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWaterLastRecord.Location = new Point(946, 105);
            txtWaterLastRecord.Name = "txtWaterLastRecord";
            txtWaterLastRecord.Size = new Size(373, 44);
            txtWaterLastRecord.TabIndex = 3;
            // 
            // lblStoreTypeID
            // 
            lblStoreTypeID.AutoSize = true;
            lblStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreTypeID.Location = new Point(711, 177);
            lblStoreTypeID.Name = "lblStoreTypeID";
            lblStoreTypeID.Size = new Size(103, 36);
            lblStoreTypeID.TabIndex = 32;
            lblStoreTypeID.Text = "ប្រភេទតូប:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(18, 177);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 36);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "បានជួល:";
            // 
            // pnlStoreManipulation
            // 
            pnlStoreManipulation.Controls.Add(btnCancelStore);
            pnlStoreManipulation.Controls.Add(btnNewStore);
            pnlStoreManipulation.Controls.Add(btnUpdateStore);
            pnlStoreManipulation.Controls.Add(btnInsertStore);
            pnlStoreManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStoreManipulation.Location = new Point(18, 232);
            pnlStoreManipulation.Name = "pnlStoreManipulation";
            pnlStoreManipulation.Size = new Size(1301, 81);
            pnlStoreManipulation.TabIndex = 5;
            // 
            // btnCancelStore
            // 
            btnCancelStore.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelStore.ForeColor = Color.White;
            btnCancelStore.Location = new Point(1100, 20);
            btnCancelStore.Name = "btnCancelStore";
            btnCancelStore.Size = new Size(152, 52);
            btnCancelStore.TabIndex = 3;
            btnCancelStore.Text = "បោះបង់";
            btnCancelStore.UseVisualStyleBackColor = false;
            // 
            // btnNewStore
            // 
            btnNewStore.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStore.ForeColor = Color.White;
            btnNewStore.Location = new Point(740, 20);
            btnNewStore.Name = "btnNewStore";
            btnNewStore.Size = new Size(152, 52);
            btnNewStore.TabIndex = 2;
            btnNewStore.Text = "បង្កើតថ្មី";
            btnNewStore.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStore
            // 
            btnUpdateStore.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStore.ForeColor = Color.White;
            btnUpdateStore.Location = new Point(380, 20);
            btnUpdateStore.Name = "btnUpdateStore";
            btnUpdateStore.Size = new Size(152, 52);
            btnUpdateStore.TabIndex = 1;
            btnUpdateStore.Text = "កែប្រែ";
            btnUpdateStore.UseVisualStyleBackColor = false;
            // 
            // btnInsertStore
            // 
            btnInsertStore.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStore.ForeColor = Color.White;
            btnInsertStore.Location = new Point(20, 20);
            btnInsertStore.Name = "btnInsertStore";
            btnInsertStore.Size = new Size(152, 52);
            btnInsertStore.TabIndex = 0;
            btnInsertStore.Text = "បញ្ចូល";
            btnInsertStore.UseVisualStyleBackColor = false;
            // 
            // lblWaterLastRecord
            // 
            lblWaterLastRecord.AutoSize = true;
            lblWaterLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaterLastRecord.Location = new Point(711, 111);
            lblWaterLastRecord.Name = "lblWaterLastRecord";
            lblWaterLastRecord.Size = new Size(229, 36);
            lblWaterLastRecord.TabIndex = 27;
            lblWaterLastRecord.Text = "លេខនាឡិកាទឹកចុងក្រោយ:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(18, 41);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(149, 36);
            lblStoreID.TabIndex = 0;
            lblStoreID.Text = "លេខសម្គាល់តូប:";
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
            // txtStoreID
            // 
            txtStoreID.Enabled = false;
            txtStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreID.Location = new Point(287, 33);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(376, 44);
            txtStoreID.TabIndex = 3;
            // 
            // lblElectricityLastRecord
            // 
            lblElectricityLastRecord.AutoSize = true;
            lblElectricityLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblElectricityLastRecord.Location = new Point(18, 111);
            lblElectricityLastRecord.Name = "lblElectricityLastRecord";
            lblElectricityLastRecord.Size = new Size(263, 36);
            lblElectricityLastRecord.TabIndex = 6;
            lblElectricityLastRecord.Text = "លេខនាឡិកាអគ្គិសនីចុងក្រោយ:";
            // 
            // txtElectricityLastRecord
            // 
            txtElectricityLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtElectricityLastRecord.Location = new Point(287, 105);
            txtElectricityLastRecord.Name = "txtElectricityLastRecord";
            txtElectricityLastRecord.Size = new Size(376, 44);
            txtElectricityLastRecord.TabIndex = 2;
            // 
            // FrmStore
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmStore";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbStoreInformation.ResumeLayout(false);
            gbStoreInformation.PerformLayout();
            pnlStoreManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStore;
        private TextBox txtSearchStore;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblStoreID;
        private Label lblElectricityLastRecord;
        private TextBox txtFloorNumber;
        private Label lblFloorNumber;
        private TextBox txtStoreID;
        private TextBox txtElectricityLastRecord;
        private GroupBox gbStoreInformation;
        private Panel pnlStoreManipulation;
        private Button btnInsertStore;
        private Button btnCancelStore;
        private Button btnNewStore;
        private Button btnUpdateStore;
        private Label lblWaterLastRecord;
        private DataGridView dgvStores;
        private Label lblStatus;
        private Label lblStoreTypeID;
        private TextBox txtWaterLastRecord;
        private ComboBox cbStoreTypeID;
        private DataGridViewTextBoxColumn StoreID;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn ElectricityLastRecord;
        private DataGridViewTextBoxColumn WaterLastRecord;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn StoreTypeID;
        private CheckBox chbStatus;
    }
}