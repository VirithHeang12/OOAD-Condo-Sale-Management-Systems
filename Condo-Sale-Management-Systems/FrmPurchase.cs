using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using System.ComponentModel;
using System.Data;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmPurchase : FrmHome
    {
        private const string TABLE_CONTRACT_NAME = "tblContract";
        private const string TABLE_STORE_NAME = "tblStore";
        private const string TABLE_CUSTOMER_NAME = "tblCustomer";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_INSURANCE_NAME = "tblInsurance";
        public DataSet _storeRentalDataSet { get; set; } = new DataSet();
        public SqlDataAdapter _contractDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _storeDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _customerDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _staffDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _insuranceDataAdapter { get; set; } = new SqlDataAdapter();

        private BindingSource _contractBindingSource { get; set; } = new BindingSource();
        private BindingSource _storeBindingSource { get; set; } = new BindingSource();
        private BindingSource _customerBindingSource { get; set; } = new BindingSource();
        private BindingSource _staffBindingSource { get; set; } = new BindingSource();
        private BindingSource _insuranceBindingSource { get; set; } = new BindingSource();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmPurchase() : base()
        {

            InitializeComponent();

            #region Init DataAdapter Commands
            InitCommands();
            #endregion

            #region Add controls for validations
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(dtpContractDate);
            #endregion

            LoadAllData();
            BindWithControls();

            #region Event Registration
            btnNewContract.Click += HandleBtnNewContractClicked;
            btnInsertContract.Click += HandleBtnInsertContractClicked;
            btnUpdateContract.Click += HandleBtnUpdateContractClicked;
            btnCancelContract.Click += HandleBtnCancelContractClicked;

            dtpContractDate.Validating += ValidatePresentOrPast;

            lbContract.SelectedValueChanged += HandleSelectedValueChanged;

            dtpContractDate.GotFocus += HandleGotFocusEN;
            dtpLeaseStartDate.GotFocus += HandleGotFocusEN;
            dtpLeaseEndDate.GotFocus += HandleGotFocusEN;
            cbStoreID.GotFocus += HandleGotFocusEN;
            cbCustomerID.GotFocus += HandleGotFocusEN;
            cbInsuranceID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;

            txtSearchContract.TextChanged += HandleSearchStaff;

            cbInsuranceID.SelectedIndexChanged += HandleCbInsuranceIDSelectedIndexChanged;
            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            #endregion

        }

        #region Init Commands
        private void InitCommands()
        {
            // Contract
            _contractDataAdapter.InsertCommand = ContractHelper.CreateInsertContractCommand();
            _contractDataAdapter.SelectCommand = ContractHelper.CreateGetAllContractsCommand();
            _contractDataAdapter.UpdateCommand = ContractHelper.CreateUpdateContractCommand();
            // Store
            _storeDataAdapter.SelectCommand = ContractHelper.CreateGetAllStoresForComboBoxCommand();
            // Customer
            _customerDataAdapter.SelectCommand = ContractHelper.CreateGetAllCustomersForComboBoxCommand();
            // Insurance
            _insuranceDataAdapter.SelectCommand = ContractHelper.CreateGetAllInsurancesForComboBoxCommand();
            // Staff
            _staffDataAdapter.SelectCommand = ContractHelper.CreateGetAllStaffsForComboBoxCommand();
        }
        #endregion

        #region Handle Combo Box SelectedIndexChanged
        private void HandleCbStaffIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbStaffID.SelectedItem as DataRowView;
            txtStaffName.Text = dataRowView?["StaffName"] as string ?? string.Empty;
            txtStaffPosition.Text = dataRowView?["StaffPosition"] as string ?? string.Empty;
        }

        private void HandleCbInsuranceIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbInsuranceID.SelectedItem as DataRowView;
            txtInsuranceName.Text = dataRowView?["InsuranceName"] as string ?? string.Empty;
        }
        #endregion

        #region HandleGotFocusKM
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }
        #endregion

        #region HandleGotFocusEN
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
        #endregion

        #region Bind With Controls
        private void BindWithControls()
        {
            if (txtContractID.DataBindings.Count == 0)
            {
                txtContractID.DataBindings.Add("Text", _contractBindingSource, "ContractID");
                dtpContractDate.DataBindings.Add("Value", _contractBindingSource, "ContractDate");
                dtpLeaseStartDate.DataBindings.Add("Value", _contractBindingSource, "LeaseStartDate");
                dtpLeaseEndDate.DataBindings.Add("Value", _contractBindingSource, "LeaseEndDate");
                dtpNextPaymentDate.DataBindings.Add("Value", _contractBindingSource, "NextPaymentDate");
                cbCustomerID.DataBindings.Add("SelectedValue", _contractBindingSource, "CustomerID");
                cbStoreID.DataBindings.Add("SelectedValue", _contractBindingSource, "StoreID");
                cbStaffID.DataBindings.Add("SelectedValue", _contractBindingSource, "StaffID");
                cbInsuranceID.DataBindings.Add("SelectedValue", _contractBindingSource, "InsuranceID");
                txtInsuranceName.DataBindings.Add("Text", _contractBindingSource, "InsuranceName");
                txtStaffName.DataBindings.Add("Text", _contractBindingSource, "StaffName");
                txtStaffPosition.DataBindings.Add("Text", _contractBindingSource, "StaffPosition");

            }
        }

        #endregion

        #region Unbind With Controls
        private void UnbindWithControls()
        {
            txtContractID.DataBindings.Clear();
            dtpContractDate.DataBindings.Clear();
            dtpLeaseStartDate.DataBindings.Clear();
            dtpLeaseEndDate.DataBindings.Clear();
            dtpNextPaymentDate.DataBindings.Clear();
            cbCustomerID.DataBindings.Clear();
            cbStoreID.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            cbInsuranceID.DataBindings.Clear();
            txtInsuranceName.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();
        }
        #endregion

        #region Handle ListBox SelectedValueChanged
        private void HandleSelectedValueChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_CONTRACT_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelContract.PerformClick();
            }
        }
        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchStaff(object? sender, EventArgs e)
        {
            UnbindWithControls();
            string searchText = txtSearchContract.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _contractBindingSource.Filter = string.Empty;
            }
            else
            {
                _contractBindingSource.Filter = "Convert(ContractID, 'System.String') LIKE '" + searchText + "%'";

            }
            BindWithControls();
        }
        #endregion

        #region Handle Validation
        private void ValidatePresentOrPast(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDtpNowOrPast((sender as DateTimePicker)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewContractClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbStoreID.Items.Count < 1)
            {
                MessageBox.Show("គ្មានតូបទំនេរសម្រាប់ជួល", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            if (cbCustomerID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលអតិថិជនជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (cbInsuranceID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលក្រុមហ៊ុនធានារ៉ាប់រងជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UnbindWithControls();
                _contractBindingSource.AddNew();

                var newRowView = (_contractBindingSource.Current as DataRowView)!;

                newRowView["ContractDate"] = DateTime.Now.AddHours(-1);
                newRowView["LeaseStartDate"] = DateTime.Now.AddDays(1);
                newRowView["LeaseEndDate"] = DateTime.Now.AddYears(1);
                newRowView["NextPaymentDate"] = DateTime.Now.AddMonths(1);
                cbStaffID.SelectedIndex = 0;
                newRowView["StaffID"] = cbStaffID.SelectedValue;

                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                newRowView["StaffName"] = dataRowView?["StaffName"];
                newRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                cbInsuranceID.SelectedIndex = 0;
                newRowView["InsuranceID"] = cbInsuranceID.SelectedValue;
                dataRowView = cbInsuranceID.SelectedItem as DataRowView;
                newRowView["InsuranceName"] = dataRowView?["InsuranceName"];

                cbCustomerID.SelectedIndex = 0;
                newRowView["CustomerID"] = cbCustomerID.SelectedValue;

                cbStoreID.SelectedIndex = 0;
                newRowView["StoreID"] = cbStoreID.SelectedValue;

                lbContract.DataSource = null;
                lbContract.DataSource = _contractBindingSource;
                lbContract.DisplayMember = "ContractID";
                lbContract.ValueMember = "ContractID";


                BindWithControls();

                int lastRowIndex = lbContract.Items.Count - 1;
                lbContract.SelectedIndex = lastRowIndex;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpContractDate.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertContractClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

            lbContract.SelectedValueChanged -= HandleSelectedValueChanged;

            _contractBindingSource.EndEdit();
            try
            {
                _contractDataAdapter.Update(_storeRentalDataSet, TABLE_CONTRACT_NAME);
                _contractBindingSource.ResetBindings(false);
            }
            catch (Exceptio​n)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshListBox();
            BindWithControls();
            lbContract.SelectedValueChanged += HandleSelectedValueChanged;
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateContractClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertContractClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelContractClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshListBox();
        }
        #endregion

        #region Cause Validation
        private void CauseValidation()
        {
            foreach (var control in _validatingControls)
            {
                if (control is DateTimePicker dtp)
                {
                    ErrorHelper.ValidateDtpNowOrPast(dtp, _errorProvider);
                }
            }
        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _contractDataAdapter.TableMappings.Add("Table", TABLE_CONTRACT_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            _insuranceDataAdapter.TableMappings.Add("Table", TABLE_INSURANCE_NAME);
            _storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);
            _customerDataAdapter.TableMappings.Add("Table", TABLE_CUSTOMER_NAME);

            try
            {
                _contractDataAdapter.Fill(_storeRentalDataSet, TABLE_CONTRACT_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _insuranceDataAdapter.Fill(_storeRentalDataSet, TABLE_INSURANCE_NAME);
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_CUSTOMER_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _contractBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_CONTRACT_NAME];
            lbContract.DataSource = _contractBindingSource;
            lbContract.DisplayMember = "ContractID";
            lbContract.ValueMember = "ContractID";

            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[] { _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]! };
            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.ValueMember = "StaffID";
            cbStaffID.DisplayMember = "StaffID";

            _storeRentalDataSet.Tables[TABLE_INSURANCE_NAME]!.PrimaryKey = new DataColumn[] { _storeRentalDataSet.Tables[TABLE_INSURANCE_NAME]!.Columns["InsuranceID"]! };
            _insuranceBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_INSURANCE_NAME]!.AsDataView();
            cbInsuranceID.DataSource = _insuranceBindingSource;
            cbInsuranceID.ValueMember = "InsuranceID";
            cbInsuranceID.DisplayMember = "InsuranceID";

            _storeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORE_NAME]!.AsDataView();
            cbStoreID.DataSource = _storeBindingSource;
            cbStoreID.ValueMember = "StoreID";
            cbStoreID.DisplayMember = "StoreID";

            _customerBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME];
            cbCustomerID.DataSource = _customerBindingSource;
            cbCustomerID.ValueMember = "CustomerID";
            cbCustomerID.DisplayMember = "CustomerID";

            HandleCbInsuranceIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);

        }
        #endregion

        #region Refresh
        private void RefreshListBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Tables[TABLE_CONTRACT_NAME]?.Clear();
            try
            {
                _contractDataAdapter.Fill(_storeRentalDataSet, TABLE_CONTRACT_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbContract.SelectedIndex = 0;

            BindWithControls();
            txtSearchContract.Text = string.Empty;
        }
        #endregion


    }
}
