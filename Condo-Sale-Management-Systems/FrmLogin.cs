using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.Data;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmLogin : Form, IForm
    {
        private const string TABLE_NAME = "tblUser";
        private DataSet _condoSaleDataSet = new DataSet();
        private SqlDataAdapter _userDataAdapter = new();

        public static event EventHandler? LoggedIn;

        public Form UnderlyingForm => this;

        public FrmLogin()
        {
            InitializeComponent();

            InitCommands();
            LoadAllUsers();

            btnLogin.Click += HandleBtnLoginClicked;
            txtLoginPassword.KeyDown += HandleKeyDown;
            txtLoginUserName.KeyDown += HandleKeyDown;
        }

        public void Initialize()
        {
            // Common initialization logic
        }

        private void HandleKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleBtnLoginClicked(null, EventArgs.Empty);
            }

        }

        private void HandleBtnLoginClicked(object? sender, EventArgs e)
        {
            string userNameInput = txtLoginUserName.Text;
            string passwordInput = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(userNameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("សូមបញ្ចូលឈ្មោះនិងលេខសម្ងាត់", "ចូលក្នុងប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginUserName.Focus();
                return;
            }

            foreach (DataRow row in _condoSaleDataSet.Tables[TABLE_NAME]!.Rows)
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
                _userDataAdapter.Fill(_condoSaleDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_condoSaleDataSet.Tables[TABLE_NAME]!.Rows.Count == 0)
            {
                var newRow = _condoSaleDataSet.Tables[TABLE_NAME]!.NewRow();
                newRow["UserName"] = "abc";
                newRow["Password"] = "12345678";
                _condoSaleDataSet.Tables[TABLE_NAME]!.Rows.Add(newRow);
            }

        }
    }
}
