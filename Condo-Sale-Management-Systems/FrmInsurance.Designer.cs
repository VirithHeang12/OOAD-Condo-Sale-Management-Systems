namespace Condo_Sale_Management_Systems
{
    partial class FrmInsurance
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
            lblSearchInsurance = new Label();
            txtSearchInsurance = new TextBox();
            pnlLeftSide = new Panel();
            dgvInsurances = new DataGridView();
            InsuranceID = new DataGridViewTextBoxColumn();
            InsuranceName = new DataGridViewTextBoxColumn();
            InsuranceWebsite = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbInsuranceInformation = new GroupBox();
            pnlInsuranceManipulation = new Panel();
            btnCancelInsurance = new Button();
            btnNewInsurance = new Button();
            btnUpdateInsurance = new Button();
            btnInsertInsurance = new Button();
            lblInsuranceID = new Label();
            txtInsuranceName = new TextBox();
            lblInsuranceName = new Label();
            txtInsuranceID = new TextBox();
            lblInsuranceWebsite = new Label();
            txtInsuranceWebsite = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsurances).BeginInit();
            pnlRightSide.SuspendLayout();
            gbInsuranceInformation.SuspendLayout();
            pnlInsuranceManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានក្រុមហ៊ុនធានារ៉ាប់រង";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchInsurance
            // 
            lblSearchInsurance.AutoSize = true;
            lblSearchInsurance.Location = new Point(82, 19);
            lblSearchInsurance.Name = "lblSearchInsurance";
            lblSearchInsurance.Size = new Size(311, 36);
            lblSearchInsurance.TabIndex = 1;
            lblSearchInsurance.Text = "ស្វែងរក​ (ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង):";
            // 
            // txtSearchInsurance
            // 
            txtSearchInsurance.Location = new Point(480, 11);
            txtSearchInsurance.Name = "txtSearchInsurance";
            txtSearchInsurance.Size = new Size(512, 44);
            txtSearchInsurance.TabIndex = 2;
            txtSearchInsurance.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvInsurances);
            pnlLeftSide.Controls.Add(lblSearchInsurance);
            pnlLeftSide.Controls.Add(txtSearchInsurance);
            pnlLeftSide.Location = new Point(266, 509);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 491);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvInsurances
            // 
            dgvInsurances.AllowUserToAddRows = false;
            dgvInsurances.AllowUserToDeleteRows = false;
            dgvInsurances.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInsurances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInsurances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsurances.Columns.AddRange(new DataGridViewColumn[] { InsuranceID, InsuranceName, InsuranceWebsite });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInsurances.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInsurances.GridColor = Color.White;
            dgvInsurances.Location = new Point(82, 74);
            dgvInsurances.Name = "dgvInsurances";
            dgvInsurances.ReadOnly = true;
            dgvInsurances.RowHeadersWidth = 51;
            dgvInsurances.RowTemplate.Height = 29;
            dgvInsurances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsurances.Size = new Size(1362, 369);
            dgvInsurances.TabIndex = 3;
            dgvInsurances.TabStop = false;
            // 
            // InsuranceID
            // 
            InsuranceID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            InsuranceID.DataPropertyName = "InsuranceID";
            InsuranceID.HeaderText = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង";
            InsuranceID.MinimumWidth = 6;
            InsuranceID.Name = "InsuranceID";
            InsuranceID.ReadOnly = true;
            InsuranceID.Width = 299;
            // 
            // InsuranceName
            // 
            InsuranceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InsuranceName.DataPropertyName = "InsuranceName";
            InsuranceName.HeaderText = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង";
            InsuranceName.MinimumWidth = 6;
            InsuranceName.Name = "InsuranceName";
            InsuranceName.ReadOnly = true;
            // 
            // InsuranceWebsite
            // 
            InsuranceWebsite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InsuranceWebsite.DataPropertyName = "InsuranceWebsite";
            InsuranceWebsite.HeaderText = "គេហទំព័រក្រុមហ៊ុនធានារ៉ាប់រង";
            InsuranceWebsite.MinimumWidth = 6;
            InsuranceWebsite.Name = "InsuranceWebsite";
            InsuranceWebsite.ReadOnly = true;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbInsuranceInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 319);
            pnlRightSide.TabIndex = 4;
            // 
            // gbInsuranceInformation
            // 
            gbInsuranceInformation.Controls.Add(pnlInsuranceManipulation);
            gbInsuranceInformation.Controls.Add(lblInsuranceID);
            gbInsuranceInformation.Controls.Add(txtInsuranceName);
            gbInsuranceInformation.Controls.Add(lblInsuranceName);
            gbInsuranceInformation.Controls.Add(txtInsuranceID);
            gbInsuranceInformation.Controls.Add(lblInsuranceWebsite);
            gbInsuranceInformation.Controls.Add(txtInsuranceWebsite);
            gbInsuranceInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbInsuranceInformation.Location = new Point(82, 12);
            gbInsuranceInformation.Name = "gbInsuranceInformation";
            gbInsuranceInformation.Size = new Size(1362, 288);
            gbInsuranceInformation.TabIndex = 25;
            gbInsuranceInformation.TabStop = false;
            gbInsuranceInformation.Text = "ព័ត៌មានក្រុមហ៊ុនធានារ៉ាប់រង";
            // 
            // pnlInsuranceManipulation
            // 
            pnlInsuranceManipulation.Controls.Add(btnCancelInsurance);
            pnlInsuranceManipulation.Controls.Add(btnNewInsurance);
            pnlInsuranceManipulation.Controls.Add(btnUpdateInsurance);
            pnlInsuranceManipulation.Controls.Add(btnInsertInsurance);
            pnlInsuranceManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlInsuranceManipulation.Location = new Point(18, 175);
            pnlInsuranceManipulation.Name = "pnlInsuranceManipulation";
            pnlInsuranceManipulation.Size = new Size(1301, 81);
            pnlInsuranceManipulation.TabIndex = 5;
            // 
            // btnCancelInsurance
            // 
            btnCancelInsurance.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelInsurance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelInsurance.ForeColor = Color.White;
            btnCancelInsurance.Location = new Point(1100, 20);
            btnCancelInsurance.Name = "btnCancelInsurance";
            btnCancelInsurance.Size = new Size(152, 52);
            btnCancelInsurance.TabIndex = 3;
            btnCancelInsurance.TabStop = false;
            btnCancelInsurance.Text = "បោះបង់";
            btnCancelInsurance.UseVisualStyleBackColor = false;
            // 
            // btnNewInsurance
            // 
            btnNewInsurance.BackColor = Color.FromArgb(0, 28, 87);
            btnNewInsurance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewInsurance.ForeColor = Color.White;
            btnNewInsurance.Location = new Point(740, 20);
            btnNewInsurance.Name = "btnNewInsurance";
            btnNewInsurance.Size = new Size(152, 52);
            btnNewInsurance.TabIndex = 2;
            btnNewInsurance.TabStop = false;
            btnNewInsurance.Text = "បង្កើតថ្មី";
            btnNewInsurance.UseVisualStyleBackColor = false;
            // 
            // btnUpdateInsurance
            // 
            btnUpdateInsurance.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateInsurance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateInsurance.ForeColor = Color.White;
            btnUpdateInsurance.Location = new Point(380, 20);
            btnUpdateInsurance.Name = "btnUpdateInsurance";
            btnUpdateInsurance.Size = new Size(152, 52);
            btnUpdateInsurance.TabIndex = 1;
            btnUpdateInsurance.TabStop = false;
            btnUpdateInsurance.Text = "កែប្រែ";
            btnUpdateInsurance.UseVisualStyleBackColor = false;
            // 
            // btnInsertInsurance
            // 
            btnInsertInsurance.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertInsurance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertInsurance.ForeColor = Color.White;
            btnInsertInsurance.Location = new Point(20, 20);
            btnInsertInsurance.Name = "btnInsertInsurance";
            btnInsertInsurance.Size = new Size(152, 52);
            btnInsertInsurance.TabIndex = 0;
            btnInsertInsurance.TabStop = false;
            btnInsertInsurance.Text = "បញ្ចូល";
            btnInsertInsurance.UseVisualStyleBackColor = false;
            // 
            // lblInsuranceID
            // 
            lblInsuranceID.AutoSize = true;
            lblInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceID.Location = new Point(18, 41);
            lblInsuranceID.Name = "lblInsuranceID";
            lblInsuranceID.Size = new Size(276, 36);
            lblInsuranceID.TabIndex = 0;
            lblInsuranceID.Text = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceName
            // 
            txtInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceName.Location = new Point(940, 33);
            txtInsuranceName.Name = "txtInsuranceName";
            txtInsuranceName.Size = new Size(379, 44);
            txtInsuranceName.TabIndex = 5;
            // 
            // lblInsuranceName
            // 
            lblInsuranceName.AutoSize = true;
            lblInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceName.Location = new Point(711, 41);
            lblInsuranceName.Name = "lblInsuranceName";
            lblInsuranceName.Size = new Size(223, 36);
            lblInsuranceName.TabIndex = 4;
            lblInsuranceName.Text = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceID
            // 
            txtInsuranceID.Enabled = false;
            txtInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceID.Location = new Point(300, 33);
            txtInsuranceID.Name = "txtInsuranceID";
            txtInsuranceID.Size = new Size(363, 44);
            txtInsuranceID.TabIndex = 3;
            // 
            // lblInsuranceWebsite
            // 
            lblInsuranceWebsite.AutoSize = true;
            lblInsuranceWebsite.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceWebsite.Location = new Point(18, 111);
            lblInsuranceWebsite.Name = "lblInsuranceWebsite";
            lblInsuranceWebsite.Size = new Size(250, 36);
            lblInsuranceWebsite.TabIndex = 6;
            lblInsuranceWebsite.Text = "គេហទំព័រក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceWebsite
            // 
            txtInsuranceWebsite.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceWebsite.Location = new Point(300, 111);
            txtInsuranceWebsite.Name = "txtInsuranceWebsite";
            txtInsuranceWebsite.Size = new Size(1019, 44);
            txtInsuranceWebsite.TabIndex = 13;
            // 
            // FrmInsurance
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmInsurance";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsurances).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbInsuranceInformation.ResumeLayout(false);
            gbInsuranceInformation.PerformLayout();
            pnlInsuranceManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchInsurance;
        private TextBox txtSearchInsurance;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblInsuranceID;
        private Label lblInsuranceWebsite;
        private TextBox txtInsuranceName;
        private Label lblInsuranceName;
        private TextBox txtInsuranceID;
        private TextBox txtInsuranceWebsite;
        private GroupBox gbInsuranceInformation;
        private Panel pnlInsuranceManipulation;
        private Button btnInsertInsurance;
        private Button btnCancelInsurance;
        private Button btnNewInsurance;
        private Button btnUpdateInsurance;
        private DataGridView dgvInsurances;
        private DataGridViewTextBoxColumn InsuranceID;
        private DataGridViewTextBoxColumn InsuranceName;
        private DataGridViewTextBoxColumn InsuranceWebsite;
    }
}