using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;

namespace Condo_Sale_Management_Systems
{

    public partial class FrmUser : FrmHome
    {
        private const string TABLE_NAME = "tblUser";
        private const string TABLE_STAFF_NAME = "tblStaff";

        private DataSet _storeRentalDataSet = new DataSet();

        private SqlDataAdapter _userDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();

        private BindingSource _userBindingSource = new();
        private BindingSource _staffBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmUser() : base()
        {
            InitializeComponent();
            _errorProvider.ContainerControl = this;

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtUserName);

            #endregion

            InitCommands();
            LoadAllData();
            BindWithControls();

            #region Event Registrations
            btnNewUser.Click += HandleBtnNewUserClicked;
            btnInsertUser.Click += HandleBtnInsertUserClicked;
            btnUpdateUser.Click += HandleBtnUpdateUserClicked;
            btnCancelFormUser.Click += HandleBtnCancelFormUserClicked;

            txtUserName.Validating += ValidateUserName;

            dgvUsers.SelectionChanged += HandleSelectionChanged;

            txtSearchUser.TextChanged += HandleSearchUser;

            cbStaffID.SelectedIndexChanged += HandleSelectedIndexChanged;

            txtUserName.GotFocus += HandleGotFocusEN;
            txtPassword.GotFocus += HandleGotFocusEN;
            txtSearchUser.GotFocus += HandleGotFocusEN;

            #endregion

        }
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }

        #region InitCommands
        private void InitCommands()
        {
            //user
            _userDataAdapter.SelectCommand = UserHelper.CreateGetAllUsersCommand();
            _userDataAdapter.InsertCommand = UserHelper.CreateInsertUserCommand();
            _userDataAdapter.UpdateCommand = UserHelper.CreateUpdateUserCommand();

            // staff
            _staffDataAdapter.SelectCommand = UserHelper.CreateGetAllStaffsForComboBoxCommand();
        }
        #endregion

        #region Unbind With Controls
        private void UnbindWithControls()
        {
            txtUserID.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();
        }
        #endregion

        #region BindWithControls
        private void BindWithControls()
        {
            // binding for searching user
            txtUserID.DataBindings.Add(new Binding("Text", _userBindingSource, "UserID"));
            txtUserName.DataBindings.Add(new Binding("Text", _userBindingSource, "UserName"));
            txtPassword.DataBindings.Add(new Binding("Text", _userBindingSource, "Password"));

            // binding for choosing staff
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _userBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _userBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _userBindingSource, "StaffPosition"));

        }
        #endregion

        #region Handle SelectedIndexChanged
        private void HandleSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbStaffID.SelectedItem as DataRowView;
            txtStaffName.Text = dataRowView?["StaffName"] as string ?? string.Empty;
            txtStaffPosition.Text = dataRowView?["StaffPosition"] as string ?? string.Empty;
        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelFormUser.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchUser(object? sender, EventArgs e)
        {
            UnbindWithControls();
            string searchText = txtSearchUser.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _userBindingSource.Filter = string.Empty;
            }
            else
            {
                _userBindingSource.Filter = "UserName LIKE '%" + searchText + "%'";

            }
            BindWithControls();
        }
        #endregion

        #region Handle Validate
        private void ValidateUserName(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewUserClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1) 
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UnbindWithControls();

                _userBindingSource.AddNew();

                var newRowView = (_userBindingSource.Current as DataRowView)!;
                if (newRowView == null) return;

                cbStaffID.SelectedIndex = 0;
                newRowView["StaffID"] = cbStaffID.SelectedValue;

                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                newRowView["StaffName"] = dataRowView?["StaffName"];
                newRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                BindWithControls();

                int lastRowIndex = dgvUsers.Rows.Count - 1;
                dgvUsers.CurrentCell = dgvUsers.Rows[lastRowIndex].Cells[0];
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertUserClicked(object? sender, EventArgs e)
        {

            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _userBindingSource.EndEdit();
            try
            {
                _userDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _userBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateUserClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertUserClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelFormUserClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshDataGridView();

        }
        #endregion

        #region Cause Validation
        private void CauseValidation()
        {
            foreach (var control in _validatingControls)
            {
                if (control is TextBox textBox)
                {
                    ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                }
            }
        }
        #endregion

        #region LoadAllData
        private void LoadAllData()
        {
            _userDataAdapter.TableMappings.Add("Table", TABLE_NAME);

            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            try
            {
                _userDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _userBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvUsers.DataSource = _userBindingSource;

            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[] { _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]! };

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.ValueMember = "StaffID";
            cbStaffID.DisplayMember = "StaffID";

            HandleSelectedIndexChanged(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            UnbindWithControls();
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _userDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindWithControls();
        }
        #endregion

    }
}
