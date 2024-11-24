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
            lblSearchCondoType = new Label();
            txtSearchCondoType = new TextBox();
            pnlLeftSide = new Panel();
            dgvCondoTypes = new DataGridView();
            CondoTypeID = new DataGridViewTextBoxColumn();
            CondoTypeDescription = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbCondoTypeInformation = new GroupBox();
            label2 = new Label();
            txtCondoTypeDescription = new TextBox();
            pnlCondoTypeManipulation = new Panel();
            btnCancelCondoType = new Button();
            btnNewCondoType = new Button();
            btnUpdateCondoType = new Button();
            btnInsertCondoType = new Button();
            lblCondoTypeID = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtCondoTypeID = new TextBox();
            label1 = new Label();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCondoTypes).BeginInit();
            pnlRightSide.SuspendLayout();
            gbCondoTypeInformation.SuspendLayout();
            pnlCondoTypeManipulation.SuspendLayout();
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
            // lblSearchCondoType
            // 
            lblSearchCondoType.AutoSize = true;
            lblSearchCondoType.Location = new Point(82, 25);
            lblSearchCondoType.Name = "lblSearchCondoType";
            lblSearchCondoType.Size = new Size(266, 36);
            lblSearchCondoType.TabIndex = 1;
            lblSearchCondoType.Text = "ស្វែងរក (ពិព័ណ៌នាប្រភេទតូប):";
            // 
            // txtSearchCondoType
            // 
            txtSearchCondoType.Location = new Point(469, 22);
            txtSearchCondoType.Name = "txtSearchCondoType";
            txtSearchCondoType.Size = new Size(445, 44);
            txtSearchCondoType.TabIndex = 7;
            txtSearchCondoType.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvCondoTypes);
            pnlLeftSide.Controls.Add(lblSearchCondoType);
            pnlLeftSide.Controls.Add(txtSearchCondoType);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvCondoTypes
            // 
            dgvCondoTypes.AllowUserToAddRows = false;
            dgvCondoTypes.AllowUserToDeleteRows = false;
            dgvCondoTypes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCondoTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCondoTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCondoTypes.Columns.AddRange(new DataGridViewColumn[] { CondoTypeID, CondoTypeDescription, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCondoTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCondoTypes.Location = new Point(82, 90);
            dgvCondoTypes.Name = "dgvCondoTypes";
            dgvCondoTypes.ReadOnly = true;
            dgvCondoTypes.RowHeadersWidth = 51;
            dgvCondoTypes.RowTemplate.Height = 29;
            dgvCondoTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCondoTypes.Size = new Size(1397, 337);
            dgvCondoTypes.TabIndex = 3;
            dgvCondoTypes.TabStop = false;
            // 
            // CondoTypeID
            // 
            CondoTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CondoTypeID.DataPropertyName = "CondoTypeID";
            CondoTypeID.HeaderText = "លេខសម្គាល់ប្រភេទតូប";
            CondoTypeID.MinimumWidth = 8;
            CondoTypeID.Name = "CondoTypeID";
            CondoTypeID.ReadOnly = true;
            CondoTypeID.Width = 226;
            // 
            // CondoTypeDescription
            // 
            CondoTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CondoTypeDescription.DataPropertyName = "CondoTypeDescription";
            CondoTypeDescription.HeaderText = "ពិពណ៌នា";
            CondoTypeDescription.MinimumWidth = 8;
            CondoTypeDescription.Name = "CondoTypeDescription";
            CondoTypeDescription.ReadOnly = true;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbCondoTypeInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 347);
            pnlRightSide.TabIndex = 4;
            // 
            // gbCondoTypeInformation
            // 
            gbCondoTypeInformation.Controls.Add(label2);
            gbCondoTypeInformation.Controls.Add(txtCondoTypeDescription);
            gbCondoTypeInformation.Controls.Add(pnlCondoTypeManipulation);
            gbCondoTypeInformation.Controls.Add(lblCondoTypeID);
            gbCondoTypeInformation.Controls.Add(txtPrice);
            gbCondoTypeInformation.Controls.Add(lblPrice);
            gbCondoTypeInformation.Controls.Add(txtCondoTypeID);
            gbCondoTypeInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbCondoTypeInformation.Location = new Point(82, 12);
            gbCondoTypeInformation.Name = "gbCondoTypeInformation";
            gbCondoTypeInformation.Size = new Size(1397, 319);
            gbCondoTypeInformation.TabIndex = 25;
            gbCondoTypeInformation.TabStop = false;
            gbCondoTypeInformation.Text = "ព័ត៌មានប្រភេទតូប";
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
            // txtCondoTypeDescription
            // 
            txtCondoTypeDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondoTypeDescription.Location = new Point(1007, 33);
            txtCondoTypeDescription.Name = "txtCondoTypeDescription";
            txtCondoTypeDescription.Size = new Size(342, 44);
            txtCondoTypeDescription.TabIndex = 1;
            // 
            // pnlCondoTypeManipulation
            // 
            pnlCondoTypeManipulation.Controls.Add(btnCancelCondoType);
            pnlCondoTypeManipulation.Controls.Add(btnNewCondoType);
            pnlCondoTypeManipulation.Controls.Add(btnUpdateCondoType);
            pnlCondoTypeManipulation.Controls.Add(btnInsertCondoType);
            pnlCondoTypeManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCondoTypeManipulation.Location = new Point(18, 232);
            pnlCondoTypeManipulation.Name = "pnlCondoTypeManipulation";
            pnlCondoTypeManipulation.Size = new Size(1301, 81);
            pnlCondoTypeManipulation.TabIndex = 5;
            // 
            // btnCancelCondoType
            // 
            btnCancelCondoType.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelCondoType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelCondoType.ForeColor = Color.WhiteSmoke;
            btnCancelCondoType.Location = new Point(1102, 20);
            btnCancelCondoType.Name = "btnCancelCondoType";
            btnCancelCondoType.Size = new Size(152, 52);
            btnCancelCondoType.TabIndex = 3;
            btnCancelCondoType.TabStop = false;
            btnCancelCondoType.Text = "បោះបង់";
            btnCancelCondoType.UseVisualStyleBackColor = false;
            // 
            // btnNewCondoType
            // 
            btnNewCondoType.BackColor = Color.FromArgb(0, 28, 87);
            btnNewCondoType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewCondoType.ForeColor = Color.White;
            btnNewCondoType.Location = new Point(774, 20);
            btnNewCondoType.Name = "btnNewCondoType";
            btnNewCondoType.Size = new Size(152, 52);
            btnNewCondoType.TabIndex = 6;
            btnNewCondoType.TabStop = false;
            btnNewCondoType.Text = "បង្កើតថ្មី";
            btnNewCondoType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCondoType
            // 
            btnUpdateCondoType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateCondoType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCondoType.ForeColor = Color.White;
            btnUpdateCondoType.Location = new Point(411, 20);
            btnUpdateCondoType.Name = "btnUpdateCondoType";
            btnUpdateCondoType.Size = new Size(152, 52);
            btnUpdateCondoType.TabIndex = 1;
            btnUpdateCondoType.TabStop = false;
            btnUpdateCondoType.Text = "កែប្រែ";
            btnUpdateCondoType.UseVisualStyleBackColor = false;
            // 
            // btnInsertCondoType
            // 
            btnInsertCondoType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertCondoType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertCondoType.ForeColor = Color.White;
            btnInsertCondoType.Location = new Point(20, 20);
            btnInsertCondoType.Name = "btnInsertCondoType";
            btnInsertCondoType.Size = new Size(152, 52);
            btnInsertCondoType.TabIndex = 0;
            btnInsertCondoType.TabStop = false;
            btnInsertCondoType.Text = "បញ្ចូល";
            btnInsertCondoType.UseVisualStyleBackColor = false;
            // 
            // lblCondoTypeID
            // 
            lblCondoTypeID.AutoSize = true;
            lblCondoTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondoTypeID.Location = new Point(18, 41);
            lblCondoTypeID.Name = "lblCondoTypeID";
            lblCondoTypeID.Size = new Size(203, 36);
            lblCondoTypeID.TabIndex = 0;
            lblCondoTypeID.Text = "លេខសម្គាល់ប្រភេទតូប:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(309, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(354, 44);
            txtPrice.TabIndex = 2;
            txtPrice.Tag = "d";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(18, 111);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(135, 36);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "ថ្លៃជួលប្រចាំខែ:";
            // 
            // txtCondoTypeID
            // 
            txtCondoTypeID.Enabled = false;
            txtCondoTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondoTypeID.Location = new Point(309, 33);
            txtCondoTypeID.Name = "txtCondoTypeID";
            txtCondoTypeID.Size = new Size(354, 44);
            txtCondoTypeID.TabIndex = 0;
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
            // FrmCondoType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmCondoType";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCondoTypes).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbCondoTypeInformation.ResumeLayout(false);
            gbCondoTypeInformation.PerformLayout();
            pnlCondoTypeManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchCondoType;
        private TextBox txtSearchCondoType;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblCondoTypeID;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtCondoTypeID;
        private GroupBox gbCondoTypeInformation;
        private Panel pnlCondoTypeManipulation;
        private Button btnInsertCondoType;
        private Button btnCancelCondoType;
        private Button btnNewCondoType;
        private Button btnUpdateCondoType;
        private DataGridView dgvCondoTypes;
        private TextBox txtCondoTypeDescription;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn CondoTypeID;
        private DataGridViewTextBoxColumn CondoTypeDescription;
        private DataGridViewTextBoxColumn Price;
    }
}