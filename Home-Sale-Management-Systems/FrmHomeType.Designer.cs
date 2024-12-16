namespace Home_Sale_Management_Systems
{
    partial class FrmHomeType
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSearchHomeType = new Label();
            txtSearchHomeType = new TextBox();
            pnlLeftSide = new Panel();
            dgvHomeTypes = new DataGridView();
            HomeTypeID = new DataGridViewTextBoxColumn();
            HomeTypeDescription = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbHomeTypeInformation = new GroupBox();
            label2 = new Label();
            txtHomeTypeDescription = new TextBox();
            pnlHomeTypeManipulation = new Panel();
            btnCancelHomeType = new Button();
            btnNewHomeType = new Button();
            btnUpdateHomeType = new Button();
            btnInsertHomeType = new Button();
            lblHomeTypeID = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtHomeTypeID = new TextBox();
            label1 = new Label();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHomeTypes).BeginInit();
            pnlRightSide.SuspendLayout();
            gbHomeTypeInformation.SuspendLayout();
            pnlHomeTypeManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានប្រភេទ ផ្ទះបុរី";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchHomeType
            // 
            lblSearchHomeType.AutoSize = true;
            lblSearchHomeType.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchHomeType.Location = new Point(82, 17);
            lblSearchHomeType.Name = "lblSearchHomeType";
            lblSearchHomeType.Size = new Size(247, 35);
            lblSearchHomeType.TabIndex = 1;
            lblSearchHomeType.Text = "ស្វែងរក (ពិព័ណ៌នាប្រភេទ ផ្ទះបុរី):";
            // 
            // txtSearchHomeType
            // 
            txtSearchHomeType.Location = new Point(469, 22);
            txtSearchHomeType.Name = "txtSearchHomeType";
            txtSearchHomeType.Size = new Size(445, 30);
            txtSearchHomeType.TabIndex = 7;
            txtSearchHomeType.TabStop = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvHomeTypes);
            pnlLeftSide.Controls.Add(lblSearchHomeType);
            pnlLeftSide.Controls.Add(txtSearchHomeType);
            pnlLeftSide.Location = new Point(290, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1510, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvHomeTypes
            // 
            dgvHomeTypes.AllowUserToAddRows = false;
            dgvHomeTypes.AllowUserToDeleteRows = false;
            dgvHomeTypes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHomeTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHomeTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHomeTypes.Columns.AddRange(new DataGridViewColumn[] { HomeTypeID, HomeTypeDescription, Price });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHomeTypes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHomeTypes.Location = new Point(82, 90);
            dgvHomeTypes.Name = "dgvHomeTypes";
            dgvHomeTypes.ReadOnly = true;
            dgvHomeTypes.RowHeadersWidth = 51;
            dgvHomeTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHomeTypes.Size = new Size(1397, 337);
            dgvHomeTypes.TabIndex = 3;
            dgvHomeTypes.TabStop = false;
            // 
            // HomeTypeID
            // 
            HomeTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HomeTypeID.DataPropertyName = "HomeTypeID";
            HomeTypeID.HeaderText = "លេខសម្គាល់ប្រភេទ Condo";
            HomeTypeID.MinimumWidth = 8;
            HomeTypeID.Name = "HomeTypeID";
            HomeTypeID.ReadOnly = true;
            // 
            // HomeTypeDescription
            // 
            HomeTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HomeTypeDescription.DataPropertyName = "HomeTypeDescription";
            HomeTypeDescription.HeaderText = "ពិពណ៌នាប្រភេទ Condo";
            HomeTypeDescription.MinimumWidth = 8;
            HomeTypeDescription.Name = "HomeTypeDescription";
            HomeTypeDescription.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "តម្លៃ($)";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbHomeTypeInformation);
            pnlRightSide.Location = new Point(290, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1510, 347);
            pnlRightSide.TabIndex = 4;
            // 
            // gbHomeTypeInformation
            // 
            gbHomeTypeInformation.Controls.Add(label2);
            gbHomeTypeInformation.Controls.Add(txtHomeTypeDescription);
            gbHomeTypeInformation.Controls.Add(pnlHomeTypeManipulation);
            gbHomeTypeInformation.Controls.Add(lblHomeTypeID);
            gbHomeTypeInformation.Controls.Add(txtPrice);
            gbHomeTypeInformation.Controls.Add(lblPrice);
            gbHomeTypeInformation.Controls.Add(txtHomeTypeID);
            gbHomeTypeInformation.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbHomeTypeInformation.Location = new Point(82, 12);
            gbHomeTypeInformation.Name = "gbHomeTypeInformation";
            gbHomeTypeInformation.Size = new Size(1397, 319);
            gbHomeTypeInformation.TabIndex = 25;
            gbHomeTypeInformation.TabStop = false;
            gbHomeTypeInformation.Text = "ព័ត៌មានប្រភេទ ផ្ទះបុរី";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(711, 31);
            label2.Name = "label2";
            label2.Size = new Size(172, 35);
            label2.TabIndex = 32;
            label2.Text = "ពិពណ៌នាប្រភេទ ផ្ទះបុរី:";
            // 
            // txtHomeTypeDescription
            // 
            txtHomeTypeDescription.Font = new Font("Microsoft Sans Serif", 12F);
            txtHomeTypeDescription.Location = new Point(1007, 33);
            txtHomeTypeDescription.Name = "txtHomeTypeDescription";
            txtHomeTypeDescription.Size = new Size(342, 30);
            txtHomeTypeDescription.TabIndex = 1;
            // 
            // pnlHomeTypeManipulation
            // 
            pnlHomeTypeManipulation.Controls.Add(btnCancelHomeType);
            pnlHomeTypeManipulation.Controls.Add(btnNewHomeType);
            pnlHomeTypeManipulation.Controls.Add(btnUpdateHomeType);
            pnlHomeTypeManipulation.Controls.Add(btnInsertHomeType);
            pnlHomeTypeManipulation.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHomeTypeManipulation.Location = new Point(18, 232);
            pnlHomeTypeManipulation.Name = "pnlHomeTypeManipulation";
            pnlHomeTypeManipulation.Size = new Size(1301, 81);
            pnlHomeTypeManipulation.TabIndex = 5;
            // 
            // btnCancelHomeType
            // 
            btnCancelHomeType.BackColor = Color.Cyan;
            btnCancelHomeType.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelHomeType.ForeColor = Color.WhiteSmoke;
            btnCancelHomeType.Location = new Point(1102, 20);
            btnCancelHomeType.Name = "btnCancelHomeType";
            btnCancelHomeType.Size = new Size(152, 52);
            btnCancelHomeType.TabIndex = 3;
            btnCancelHomeType.TabStop = false;
            btnCancelHomeType.Text = "បោះបង់";
            btnCancelHomeType.UseVisualStyleBackColor = false;
            // 
            // btnNewHomeType
            // 
            btnNewHomeType.BackColor = Color.Cyan;
            btnNewHomeType.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewHomeType.ForeColor = Color.White;
            btnNewHomeType.Location = new Point(774, 20);
            btnNewHomeType.Name = "btnNewHomeType";
            btnNewHomeType.Size = new Size(152, 52);
            btnNewHomeType.TabIndex = 6;
            btnNewHomeType.TabStop = false;
            btnNewHomeType.Text = "បង្កើតថ្មី";
            btnNewHomeType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateHomeType
            // 
            btnUpdateHomeType.BackColor = Color.Cyan;
            btnUpdateHomeType.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateHomeType.ForeColor = Color.White;
            btnUpdateHomeType.Location = new Point(411, 20);
            btnUpdateHomeType.Name = "btnUpdateHomeType";
            btnUpdateHomeType.Size = new Size(152, 52);
            btnUpdateHomeType.TabIndex = 1;
            btnUpdateHomeType.TabStop = false;
            btnUpdateHomeType.Text = "កែប្រែ";
            btnUpdateHomeType.UseVisualStyleBackColor = false;
            // 
            // btnInsertHomeType
            // 
            btnInsertHomeType.BackColor = Color.Cyan;
            btnInsertHomeType.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertHomeType.ForeColor = Color.White;
            btnInsertHomeType.Location = new Point(20, 20);
            btnInsertHomeType.Name = "btnInsertHomeType";
            btnInsertHomeType.Size = new Size(152, 52);
            btnInsertHomeType.TabIndex = 0;
            btnInsertHomeType.TabStop = false;
            btnInsertHomeType.Text = "បញ្ចូល";
            btnInsertHomeType.UseVisualStyleBackColor = false;
            // 
            // lblHomeTypeID
            // 
            lblHomeTypeID.AutoSize = true;
            lblHomeTypeID.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomeTypeID.Location = new Point(18, 31);
            lblHomeTypeID.Name = "lblHomeTypeID";
            lblHomeTypeID.Size = new Size(204, 35);
            lblHomeTypeID.TabIndex = 0;
            lblHomeTypeID.Text = "លេខសម្គាល់ប្រភេទ ផ្ទះបុរី:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtPrice.Location = new Point(309, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(354, 30);
            txtPrice.TabIndex = 2;
            txtPrice.Tag = "d";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Khmer OS Wat Phnom", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(18, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 35);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "តម្លៃ($):";
            // 
            // txtHomeTypeID
            // 
            txtHomeTypeID.Enabled = false;
            txtHomeTypeID.Font = new Font("Microsoft Sans Serif", 12F);
            txtHomeTypeID.Location = new Point(309, 33);
            txtHomeTypeID.Name = "txtHomeTypeID";
            txtHomeTypeID.Size = new Size(354, 30);
            txtHomeTypeID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(711, 41);
            label1.Name = "label1";
            label1.Size = new Size(178, 36);
            label1.TabIndex = 30;
            label1.Text = "ពិព័ណ៌នាប្រភេទតូប:";
            // 
            // FrmHomeType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmHomeType";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHomeTypes).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbHomeTypeInformation.ResumeLayout(false);
            gbHomeTypeInformation.PerformLayout();
            pnlHomeTypeManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchHomeType;
        private TextBox txtSearchHomeType;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblHomeTypeID;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtHomeTypeID;
        private GroupBox gbHomeTypeInformation;
        private Panel pnlHomeTypeManipulation;
        private Button btnInsertHomeType;
        private Button btnCancelHomeType;
        private Button btnNewHomeType;
        private Button btnUpdateHomeType;
        private DataGridView dgvHomeTypes;
        private TextBox txtHomeTypeDescription;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn HomeTypeID;
        private DataGridViewTextBoxColumn HomeTypeDescription;
        private DataGridViewTextBoxColumn Price;
    }
}