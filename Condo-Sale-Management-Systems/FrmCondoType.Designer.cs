namespace Condo_Sale_Management_Systems
{
    partial class FrmCondoType
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
            lblSearchStoreType = new Label();
            txtSearchStoreType = new TextBox();
            pnlLeftSide = new Panel();
            dgvStoreTypes = new DataGridView();
            StoreTypeID = new DataGridViewTextBoxColumn();
            StoreTypeDescription = new DataGridViewTextBoxColumn();
            MonthlyLeasePrice = new DataGridViewTextBoxColumn();
            ThreeMonthPaymentDiscount = new DataGridViewTextBoxColumn();
            SixMonthPaymentDiscount = new DataGridViewTextBoxColumn();
            OneYearPaymentDiscount = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbStoreTypeInformation = new GroupBox();
            label2 = new Label();
            txtStoreTypeDescription = new TextBox();
            txtOneYearPaymentDiscount = new TextBox();
            lblOneYearPaymentDiscount = new Label();
            pnlStoreTypeManipulation = new Panel();
            btnCancelStoreType = new Button();
            btnNewStoreType = new Button();
            btnUpdateStoreType = new Button();
            btnInsertStoreType = new Button();
            lblSixMonthPaymentDiscount = new Label();
            lblStoreTypeID = new Label();
            txtMonthlyLeasePrice = new TextBox();
            lblMonthlyLeasePrice = new Label();
            txtStoreTypeID = new TextBox();
            lblThreeMonthPaymentDiscount = new Label();
            txtSixMonthPaymentDiscount = new TextBox();
            txtThreeMonthPaymentDiscount = new TextBox();
            label1 = new Label();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStoreTypes).BeginInit();
            pnlRightSide.SuspendLayout();
            gbStoreTypeInformation.SuspendLayout();
            pnlStoreTypeManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានប្រភេទតូប";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStoreType
            // 
            lblSearchStoreType.AutoSize = true;
            lblSearchStoreType.Location = new Point(82, 25);
            lblSearchStoreType.Name = "lblSearchStoreType";
            lblSearchStoreType.Size = new Size(266, 36);
            lblSearchStoreType.TabIndex = 1;
            lblSearchStoreType.Text = "ស្វែងរក (ពិព័ណ៌នាប្រភេទតូប):";
            // 
            // txtSearchStoreType
            // 
            txtSearchStoreType.Location = new Point(469, 22);
            txtSearchStoreType.Name = "txtSearchStoreType";
            txtSearchStoreType.Size = new Size(445, 44);
            txtSearchStoreType.TabIndex = 7;
            txtSearchStoreType.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvStoreTypes);
            pnlLeftSide.Controls.Add(lblSearchStoreType);
            pnlLeftSide.Controls.Add(txtSearchStoreType);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvStoreTypes
            // 
            dgvStoreTypes.AllowUserToAddRows = false;
            dgvStoreTypes.AllowUserToDeleteRows = false;
            dgvStoreTypes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStoreTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStoreTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStoreTypes.Columns.AddRange(new DataGridViewColumn[] { StoreTypeID, StoreTypeDescription, MonthlyLeasePrice, ThreeMonthPaymentDiscount, SixMonthPaymentDiscount, OneYearPaymentDiscount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStoreTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStoreTypes.Location = new Point(82, 90);
            dgvStoreTypes.Name = "dgvStoreTypes";
            dgvStoreTypes.ReadOnly = true;
            dgvStoreTypes.RowHeadersWidth = 51;
            dgvStoreTypes.RowTemplate.Height = 29;
            dgvStoreTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStoreTypes.Size = new Size(1397, 337);
            dgvStoreTypes.TabIndex = 3;
            dgvStoreTypes.TabStop = false;
            // 
            // StoreTypeID
            // 
            StoreTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StoreTypeID.DataPropertyName = "StoreTypeID";
            StoreTypeID.HeaderText = "លេខសម្គាល់ប្រភេទតូប";
            StoreTypeID.MinimumWidth = 8;
            StoreTypeID.Name = "StoreTypeID";
            StoreTypeID.ReadOnly = true;
            StoreTypeID.Width = 226;
            // 
            // StoreTypeDescription
            // 
            StoreTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StoreTypeDescription.DataPropertyName = "StoreTypeDescription";
            StoreTypeDescription.HeaderText = "ពិពណ៌នា";
            StoreTypeDescription.MinimumWidth = 8;
            StoreTypeDescription.Name = "StoreTypeDescription";
            StoreTypeDescription.ReadOnly = true;
            // 
            // MonthlyLeasePrice
            // 
            MonthlyLeasePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MonthlyLeasePrice.DataPropertyName = "MonthlyLeasePrice";
            MonthlyLeasePrice.HeaderText = "ថ្លៃជួលប្រចាំខែ";
            MonthlyLeasePrice.MinimumWidth = 8;
            MonthlyLeasePrice.Name = "MonthlyLeasePrice";
            MonthlyLeasePrice.ReadOnly = true;
            MonthlyLeasePrice.Width = 158;
            // 
            // ThreeMonthPaymentDiscount
            // 
            ThreeMonthPaymentDiscount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ThreeMonthPaymentDiscount.DataPropertyName = "ThreeMonthPaymentDiscount";
            ThreeMonthPaymentDiscount.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៣ខែ";
            ThreeMonthPaymentDiscount.MinimumWidth = 8;
            ThreeMonthPaymentDiscount.Name = "ThreeMonthPaymentDiscount";
            ThreeMonthPaymentDiscount.ReadOnly = true;
            ThreeMonthPaymentDiscount.Width = 255;
            // 
            // SixMonthPaymentDiscount
            // 
            SixMonthPaymentDiscount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SixMonthPaymentDiscount.DataPropertyName = "SixMonthPaymentDiscount";
            SixMonthPaymentDiscount.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៦ខែ";
            SixMonthPaymentDiscount.MinimumWidth = 8;
            SixMonthPaymentDiscount.Name = "SixMonthPaymentDiscount";
            SixMonthPaymentDiscount.ReadOnly = true;
            SixMonthPaymentDiscount.Width = 252;
            // 
            // OneYearPaymentDiscount
            // 
            OneYearPaymentDiscount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            OneYearPaymentDiscount.DataPropertyName = "OneYearPaymentDiscount";
            OneYearPaymentDiscount.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង១ឆ្នាំ";
            OneYearPaymentDiscount.MinimumWidth = 8;
            OneYearPaymentDiscount.Name = "OneYearPaymentDiscount";
            OneYearPaymentDiscount.ReadOnly = true;
            OneYearPaymentDiscount.Width = 252;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbStoreTypeInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 347);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStoreTypeInformation
            // 
            gbStoreTypeInformation.Controls.Add(label2);
            gbStoreTypeInformation.Controls.Add(txtStoreTypeDescription);
            gbStoreTypeInformation.Controls.Add(txtOneYearPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(lblOneYearPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(pnlStoreTypeManipulation);
            gbStoreTypeInformation.Controls.Add(lblSixMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(lblStoreTypeID);
            gbStoreTypeInformation.Controls.Add(txtMonthlyLeasePrice);
            gbStoreTypeInformation.Controls.Add(lblMonthlyLeasePrice);
            gbStoreTypeInformation.Controls.Add(txtStoreTypeID);
            gbStoreTypeInformation.Controls.Add(lblThreeMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(txtSixMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(txtThreeMonthPaymentDiscount);
            gbStoreTypeInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbStoreTypeInformation.Location = new Point(82, 12);
            gbStoreTypeInformation.Name = "gbStoreTypeInformation";
            gbStoreTypeInformation.Size = new Size(1397, 319);
            gbStoreTypeInformation.TabIndex = 25;
            gbStoreTypeInformation.TabStop = false;
            gbStoreTypeInformation.Text = "ព័ត៌មានប្រភេទតូប";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(711, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 36);
            label2.TabIndex = 32;
            label2.Text = "ពិពណ៌នា";
            // 
            // txtStoreTypeDescription
            // 
            txtStoreTypeDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreTypeDescription.Location = new Point(1007, 33);
            txtStoreTypeDescription.Name = "txtStoreTypeDescription";
            txtStoreTypeDescription.Size = new Size(342, 44);
            txtStoreTypeDescription.TabIndex = 1;
            // 
            // txtOneYearPaymentDiscount
            // 
            txtOneYearPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOneYearPaymentDiscount.Location = new Point(1007, 164);
            txtOneYearPaymentDiscount.Name = "txtOneYearPaymentDiscount";
            txtOneYearPaymentDiscount.Size = new Size(342, 44);
            txtOneYearPaymentDiscount.TabIndex = 5;
            txtOneYearPaymentDiscount.Tag = "n";
            // 
            // lblOneYearPaymentDiscount
            // 
            lblOneYearPaymentDiscount.AutoSize = true;
            lblOneYearPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOneYearPaymentDiscount.Location = new Point(711, 182);
            lblOneYearPaymentDiscount.Name = "lblOneYearPaymentDiscount";
            lblOneYearPaymentDiscount.Size = new Size(229, 36);
            lblOneYearPaymentDiscount.TabIndex = 28;
            lblOneYearPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង១ឆ្នាំ:";
            // 
            // pnlStoreTypeManipulation
            // 
            pnlStoreTypeManipulation.Controls.Add(btnCancelStoreType);
            pnlStoreTypeManipulation.Controls.Add(btnNewStoreType);
            pnlStoreTypeManipulation.Controls.Add(btnUpdateStoreType);
            pnlStoreTypeManipulation.Controls.Add(btnInsertStoreType);
            pnlStoreTypeManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStoreTypeManipulation.Location = new Point(18, 232);
            pnlStoreTypeManipulation.Name = "pnlStoreTypeManipulation";
            pnlStoreTypeManipulation.Size = new Size(1301, 81);
            pnlStoreTypeManipulation.TabIndex = 5;
            // 
            // btnCancelStoreType
            // 
            btnCancelStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelStoreType.ForeColor = Color.WhiteSmoke;
            btnCancelStoreType.Location = new Point(1102, 20);
            btnCancelStoreType.Name = "btnCancelStoreType";
            btnCancelStoreType.Size = new Size(152, 52);
            btnCancelStoreType.TabIndex = 3;
            btnCancelStoreType.TabStop = false;
            btnCancelStoreType.Text = "បោះបង់";
            btnCancelStoreType.UseVisualStyleBackColor = false;
            // 
            // btnNewStoreType
            // 
            btnNewStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStoreType.ForeColor = Color.White;
            btnNewStoreType.Location = new Point(774, 20);
            btnNewStoreType.Name = "btnNewStoreType";
            btnNewStoreType.Size = new Size(152, 52);
            btnNewStoreType.TabIndex = 6;
            btnNewStoreType.TabStop = false;
            btnNewStoreType.Text = "បង្កើតថ្មី";
            btnNewStoreType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStoreType
            // 
            btnUpdateStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStoreType.ForeColor = Color.White;
            btnUpdateStoreType.Location = new Point(411, 20);
            btnUpdateStoreType.Name = "btnUpdateStoreType";
            btnUpdateStoreType.Size = new Size(152, 52);
            btnUpdateStoreType.TabIndex = 1;
            btnUpdateStoreType.TabStop = false;
            btnUpdateStoreType.Text = "កែប្រែ";
            btnUpdateStoreType.UseVisualStyleBackColor = false;
            // 
            // btnInsertStoreType
            // 
            btnInsertStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStoreType.ForeColor = Color.White;
            btnInsertStoreType.Location = new Point(20, 20);
            btnInsertStoreType.Name = "btnInsertStoreType";
            btnInsertStoreType.Size = new Size(152, 52);
            btnInsertStoreType.TabIndex = 0;
            btnInsertStoreType.TabStop = false;
            btnInsertStoreType.Text = "បញ្ចូល";
            btnInsertStoreType.UseVisualStyleBackColor = false;
            // 
            // lblSixMonthPaymentDiscount
            // 
            lblSixMonthPaymentDiscount.AutoSize = true;
            lblSixMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSixMonthPaymentDiscount.Location = new Point(18, 182);
            lblSixMonthPaymentDiscount.Name = "lblSixMonthPaymentDiscount";
            lblSixMonthPaymentDiscount.Size = new Size(229, 36);
            lblSixMonthPaymentDiscount.TabIndex = 27;
            lblSixMonthPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៦ខែ:";
            // 
            // lblStoreTypeID
            // 
            lblStoreTypeID.AutoSize = true;
            lblStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreTypeID.Location = new Point(18, 41);
            lblStoreTypeID.Name = "lblStoreTypeID";
            lblStoreTypeID.Size = new Size(203, 36);
            lblStoreTypeID.TabIndex = 0;
            lblStoreTypeID.Text = "លេខសម្គាល់ប្រភេទតូប:";
            // 
            // txtMonthlyLeasePrice
            // 
            txtMonthlyLeasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonthlyLeasePrice.Location = new Point(309, 105);
            txtMonthlyLeasePrice.Name = "txtMonthlyLeasePrice";
            txtMonthlyLeasePrice.Size = new Size(354, 44);
            txtMonthlyLeasePrice.TabIndex = 2;
            txtMonthlyLeasePrice.Tag = "d";
            // 
            // lblMonthlyLeasePrice
            // 
            lblMonthlyLeasePrice.AutoSize = true;
            lblMonthlyLeasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonthlyLeasePrice.Location = new Point(18, 111);
            lblMonthlyLeasePrice.Name = "lblMonthlyLeasePrice";
            lblMonthlyLeasePrice.Size = new Size(135, 36);
            lblMonthlyLeasePrice.TabIndex = 4;
            lblMonthlyLeasePrice.Text = "ថ្លៃជួលប្រចាំខែ:";
            // 
            // txtStoreTypeID
            // 
            txtStoreTypeID.Enabled = false;
            txtStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreTypeID.Location = new Point(309, 33);
            txtStoreTypeID.Name = "txtStoreTypeID";
            txtStoreTypeID.Size = new Size(354, 44);
            txtStoreTypeID.TabIndex = 0;
            // 
            // lblThreeMonthPaymentDiscount
            // 
            lblThreeMonthPaymentDiscount.AutoSize = true;
            lblThreeMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThreeMonthPaymentDiscount.Location = new Point(711, 109);
            lblThreeMonthPaymentDiscount.Name = "lblThreeMonthPaymentDiscount";
            lblThreeMonthPaymentDiscount.Size = new Size(232, 36);
            lblThreeMonthPaymentDiscount.TabIndex = 6;
            lblThreeMonthPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៣ខែ:";
            // 
            // txtSixMonthPaymentDiscount
            // 
            txtSixMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSixMonthPaymentDiscount.Location = new Point(309, 174);
            txtSixMonthPaymentDiscount.Name = "txtSixMonthPaymentDiscount";
            txtSixMonthPaymentDiscount.Size = new Size(354, 44);
            txtSixMonthPaymentDiscount.TabIndex = 4;
            txtSixMonthPaymentDiscount.Tag = "n";
            // 
            // txtThreeMonthPaymentDiscount
            // 
            txtThreeMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtThreeMonthPaymentDiscount.Location = new Point(1007, 96);
            txtThreeMonthPaymentDiscount.Name = "txtThreeMonthPaymentDiscount";
            txtThreeMonthPaymentDiscount.Size = new Size(342, 44);
            txtThreeMonthPaymentDiscount.TabIndex = 3;
            txtThreeMonthPaymentDiscount.Tag = "n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(711, 41);
            label1.Name = "label1";
            label1.Size = new Size(178, 36);
            label1.TabIndex = 30;
            label1.Text = "ពិព័ណ៌នាប្រភេទតូប:";
            // 
            // FrmStoreType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmStoreType";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStoreTypes).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbStoreTypeInformation.ResumeLayout(false);
            gbStoreTypeInformation.PerformLayout();
            pnlStoreTypeManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStoreType;
        private TextBox txtSearchStoreType;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblStoreTypeID;
        private TextBox txtSixMonthPaymentDiscount;
        private Label lblThreeMonthPaymentDiscount;
        private TextBox txtMonthlyLeasePrice;
        private Label lblMonthlyLeasePrice;
        private TextBox txtStoreTypeID;
        private TextBox txtThreeMonthPaymentDiscount;
        private GroupBox gbStoreTypeInformation;
        private Panel pnlStoreTypeManipulation;
        private Button btnInsertStoreType;
        private Button btnCancelStoreType;
        private Button btnNewStoreType;
        private Button btnUpdateStoreType;
        private Label lblSixMonthPaymentDiscount;
        private DataGridView dgvStoreTypes;
        private TextBox txtOneYearPaymentDiscount;
        private Label lblOneYearPaymentDiscount;
        private TextBox txtStoreTypeDescription;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn StoreTypeID;
        private DataGridViewTextBoxColumn StoreTypeDescription;
        private DataGridViewTextBoxColumn MonthlyLeasePrice;
        private DataGridViewTextBoxColumn ThreeMonthPaymentDiscount;
        private DataGridViewTextBoxColumn SixMonthPaymentDiscount;
        private DataGridViewTextBoxColumn OneYearPaymentDiscount;
    }
}