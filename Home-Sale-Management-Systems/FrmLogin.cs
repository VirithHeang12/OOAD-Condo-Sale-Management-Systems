﻿using Microsoft.Data.SqlClient;
using HomeSaleManagementSystemsHelper;
using System.Data;

namespace Home_Sale_Management_Systems
{
    public partial class FrmLogin : Form
    {
        private const string TABLE_NAME = "tblUser";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _userDataAdapter = new();

        public static event EventHandler? LoggedIn;

        public FrmLogin()
        {
            InitializeComponent();

            InitCommands();
            LoadAllUsers();

            btnLogin.Click += handleBtnLoginClick;
            txtLoginPassword.KeyDown += HandleKeyDown;
            txtLoginUserName.KeyDown += HandleKeyDown;
        }

        private void HandleKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleBtnLoginClick(null, EventArgs.Empty);
            }

        }

        private void handleBtnLoginClick(object? sender, EventArgs e)
        {
            string userNameInput = txtLoginUserName.Text;
            string passwordInput = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(userNameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("សូមបញ្ចូលឈ្មោះនិងលេខសម្ងាត់", "ចូលក្នុងប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginUserName.Focus();
                return;
            }

            foreach (DataRow row in _storeRentalDataSet.Tables[TABLE_NAME]!.Rows)
            {
                if (userNameInput.Equals(row["UserName"]) && passwordInput.Equals(row["Password"]))
                {
                    LoggedIn?.Invoke(this, EventArgs.Empty);
                    return;
                }
            }
            MessageBox.Show("ឈ្មោះឬលេខសម្ងាត់មិនត្រឹមត្រូវ", "ចូលក្នុងប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtLoginUserName.Focus();
        }

        private void InitCommands()
        {
            _userDataAdapter.SelectCommand = LoginHelper.CreateGetAllUsersCommand();
        }
        private void LoadAllUsers()
        {
            _userDataAdapter.TableMappings.Add("Table", TABLE_NAME);

            try
            {
                _userDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_storeRentalDataSet.Tables[TABLE_NAME]!.Rows.Count == 0)
            {
                var newRow = _storeRentalDataSet.Tables[TABLE_NAME]!.NewRow();
                newRow["UserName"] = "abc";
                newRow["Password"] = "12345678";
                _storeRentalDataSet.Tables[TABLE_NAME]!.Rows.Add(newRow);
            }

        }
    }
}
