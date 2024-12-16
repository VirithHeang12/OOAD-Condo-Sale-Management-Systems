namespace Home_Sale_Management_Systems
{
    partial class FrmLogin
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUserName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 1000);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Khmer OS Siemreap", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(201, 938);
            label3.Name = "label3";
            label3.Size = new Size(527, 43);
            label3.TabIndex = 3;
            label3.Text = "Copyright © 2024 - OOAD SLS. All Rights Reserved.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 389);
            label2.Name = "label2";
            label2.Size = new Size(485, 67);
            label2.TabIndex = 2;
            label2.Text = "ប្រព័ន្ធគ្រប់គ្រងការលក់ Condo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(201, 250);
            label1.Name = "label1";
            label1.Size = new Size(425, 85);
            label1.TabIndex = 1;
            label1.Text = "សូមស្វាគមន៍មកកាន់";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 238, 238);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtLoginPassword);
            panel2.Controls.Add(txtLoginUserName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(802, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 1000);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(0, 28, 87);
            btnLogin.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(602, 524);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 71);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ចូលក្នុងប្រព័ន្ធ";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(219, 450);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(423, 44);
            txtLoginPassword.TabIndex = 4;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUserName
            // 
            txtLoginUserName.BorderStyle = BorderStyle.None;
            txtLoginUserName.Location = new Point(219, 333);
            txtLoginUserName.Name = "txtLoginUserName";
            txtLoginUserName.Size = new Size(423, 37);
            txtLoginUserName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 28, 87);
            label6.Location = new Point(219, 389);
            label6.Name = "label6";
            label6.Size = new Size(124, 36);
            label6.TabIndex = 2;
            label6.Text = "លេខសម្ងាត់ៈ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 28, 87);
            label5.Location = new Point(219, 283);
            label5.Name = "label5";
            label5.Size = new Size(182, 36);
            label5.TabIndex = 1;
            label5.Text = "ឈ្មោះអ្នកប្រើប្រាស់ៈ";
            // 
            // label4
            // 
            label4.BackColor = Color.MediumOrchid;
            label4.Font = new Font("Khmer OS Siemreap", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 157);
            label4.Name = "label4";
            label4.Size = new Size(798, 74);
            label4.TabIndex = 0;
            label4.Text = "សូមបញ្ចូលឈ្មោះ និង លេខសម្ងាត់ដើម្បីចូលក្នុងប្រព័ន្ធ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUserName;
        private Label label6;
        private Label label5;
        private Button btnLogin;
    }
}