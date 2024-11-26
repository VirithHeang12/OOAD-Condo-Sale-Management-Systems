using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmPurchase : FrmHome
    {
        private const string TABLE_PURCHASE_NAME = "tblPurchase";
        private const string TABLE_CONDO_NAME = "tblCondo";
        private const string TABLE_CUSTOMER_NAME = "tblCustomer";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_INSURANCE_NAME = "tblInsurance";
        public DataSet _condoSaleDataSet { get; set; } = new DataSet();
        public SqlDataAdapter _purchaseDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _condoDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _customerDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _staffDataAdapter { get; set; } = new SqlDataAdapter();
        public SqlDataAdapter _insuranceDataAdapter { get; set; } = new SqlDataAdapter();

        private BindingSource _purchaseBindingSource { get; set; } = new BindingSource();
        private BindingSource _condoBindingSource { get; set; } = new BindingSource();
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
            _validatingControls.Add(dtpPurchaseDate);
            #endregion

            LoadAllData();
            BindWithControls();

            #region Event Registration
            btnNewPurchase.Click += HandleBtnNewPurchaseClicked;
            btnInsertPurchase.Click += HandleBtnInsertPurchaseClicked;
            btnUpdatePurchase.Click += HandleBtnUpdatePurchaseClicked;
            btnCancelPurchase.Click += HandleBtnCancelPurchaseClicked;

            dtpPurchaseDate.Validating += ValidatePresentOrPast;

            lbPurchase.SelectedValueChanged += HandleSelectedValueChanged;

            dtpPurchaseDate.GotFocus += HandleGotFocusEN;
            cbCondoID.GotFocus += HandleGotFocusEN;
            cbCustomerID.GotFocus += HandleGotFocusEN;
            cbInsuranceID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;

            txtSearchPurchase.TextChanged += HandleSearchStaff;

            cbInsuranceID.SelectedIndexChanged += HandleCbInsuranceIDSelectedIndexChanged;
            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            cbCondoID.SelectedIndexChanged += HandleCbCondoIDSelectedIndexChanged;
            #endregion

        }

        
        #region Init Commands
        private void InitCommands()
        {
            // Purchase
            _purchaseDataAdapter.InsertCommand = PurchaseHelper.CreateInsertPurchaseCommand();
            _purchaseDataAdapter.SelectCommand = PurchaseHelper.CreateGetAllPurchasesCommand();
            _purchaseDataAdapter.UpdateCommand = PurchaseHelper.CreateUpdatePurchaseCommand();
            // Store
            _condoDataAdapter.SelectCommand = PurchaseHelper.CreateGetAllCondosForComboBoxCommand();
            // Customer
            _customerDataAdapter.SelectCommand = PurchaseHelper.CreateGetAllCustomersForComboBoxCommand();
            // Insurance
            _insuranceDataAdapter.SelectCommand = PurchaseHelper.CreateGetAllInsurancesForComboBoxCommand();
            // Staff
            _staffDataAdapter.SelectCommand = PurchaseHelper.CreateGetAllStaffsForComboBoxCommand();
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

        private void HandleCbCondoIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbCondoID.SelectedItem as DataRowView;
            txtPurchasePrice.Text = dataRowView?["Price"]?.ToString() ?? string.Empty;
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
            if (txtPurchaseID.DataBindings.Count == 0)
            {
                txtPurchaseID.DataBindings.Add("Text", _purchaseBindingSource, "PurchaseID");
                dtpPurchaseDate.DataBindings.Add("Value", _purchaseBindingSource, "PurchaseDate");
                cbCustomerID.DataBindings.Add("SelectedValue", _purchaseBindingSource, "CustomerID");
                cbCondoID.DataBindings.Add("SelectedValue", _purchaseBindingSource, "CondoID");
                txtPurchasePrice.DataBindings.Add("Text", _purchaseBindingSource, "PurchasePrice");
                cbStaffID.DataBindings.Add("SelectedValue", _purchaseBindingSource, "StaffID");
                cbInsuranceID.DataBindings.Add("SelectedValue", _purchaseBindingSource, "InsuranceID");
                txtInsuranceName.DataBindings.Add("Text", _purchaseBindingSource, "InsuranceName");
                txtStaffName.DataBindings.Add("Text", _purchaseBindingSource, "StaffName");
                txtStaffPosition.DataBindings.Add("Text", _purchaseBindingSource, "StaffPosition");

            }
        }

        #endregion

        #region Unbind With Controls
        private void UnbindWithControls()
        {
            txtPurchaseID.DataBindings.Clear();
            dtpPurchaseDate.DataBindings.Clear();
            cbCustomerID.DataBindings.Clear();
            cbCondoID.DataBindings.Clear();
            txtPurchasePrice.DataBindings.Clear();
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
            if (!ContainsNewRow(_condoSaleDataSet.Tables[TABLE_PURCHASE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelPurchase.PerformClick();
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
            string searchText = txtSearchPurchase.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _purchaseBindingSource.Filter = string.Empty;
            }
            else
            {
                _purchaseBindingSource.Filter = "Convert(PurchaseID, 'System.String') LIKE '" + searchText + "%'";

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
        private void HandleBtnNewPurchaseClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbCondoID.Items.Count < 1)
            {
                MessageBox.Show("គ្មាន Condo សម្រាប់លក់", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _purchaseBindingSource.AddNew();

                var newRowView = (_purchaseBindingSource.Current as DataRowView)!;

                newRowView["PurchaseDate"] = DateTime.Now.AddHours(-1);
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
                
                cbCondoID.SelectedIndex = 0;
                newRowView["CondoID"] = cbCondoID.SelectedValue;
                dataRowView = cbCondoID.SelectedItem as DataRowView;
                newRowView["PurchasePrice"] = dataRowView?["Price"];

                lbPurchase.DataSource = null;
                lbPurchase.DataSource = _purchaseBindingSource;
                lbPurchase.DisplayMember = "PurchaseID";
                lbPurchase.ValueMember = "PurchaseID";


                BindWithControls();

                int lastRowIndex = lbPurchase.Items.Count - 1;
                lbPurchase.SelectedIndex = lastRowIndex;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpPurchaseDate.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertPurchaseClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

            lbPurchase.SelectedValueChanged -= HandleSelectedValueChanged;

            _purchaseBindingSource.EndEdit();
            try
            {
                _purchaseDataAdapter.Update(_condoSaleDataSet, TABLE_PURCHASE_NAME);
                _purchaseBindingSource.ResetBindings(false);
            }
            catch (Exceptio​n)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshListBox();
            BindWithControls();
            lbPurchase.SelectedValueChanged += HandleSelectedValueChanged;
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdatePurchaseClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertPurchaseClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelPurchaseClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _condoSaleDataSet.RejectChanges();
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
            _purchaseDataAdapter.TableMappings.Add("Table", TABLE_PURCHASE_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            _insuranceDataAdapter.TableMappings.Add("Table", TABLE_INSURANCE_NAME);
            _condoDataAdapter.TableMappings.Add("Table", TABLE_CONDO_NAME);
            _customerDataAdapter.TableMappings.Add("Table", TABLE_CUSTOMER_NAME);

            try
            {
                _purchaseDataAdapter.Fill(_condoSaleDataSet, TABLE_PURCHASE_NAME);
                _staffDataAdapter.Fill(_condoSaleDataSet, TABLE_STAFF_NAME);
                _insuranceDataAdapter.Fill(_condoSaleDataSet, TABLE_INSURANCE_NAME);
                _condoDataAdapter.Fill(_condoSaleDataSet, TABLE_CONDO_NAME);
                _customerDataAdapter.Fill(_condoSaleDataSet, TABLE_CUSTOMER_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _purchaseBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_PURCHASE_NAME];
            lbPurchase.DataSource = _purchaseBindingSource;
            lbPurchase.DisplayMember = "PurchaseID";
            lbPurchase.ValueMember = "PurchaseID";

            _condoSaleDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[] { _condoSaleDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]! };
            _staffBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.ValueMember = "StaffID";
            cbStaffID.DisplayMember = "StaffID";

            _condoSaleDataSet.Tables[TABLE_INSURANCE_NAME]!.PrimaryKey = new DataColumn[] { _condoSaleDataSet.Tables[TABLE_INSURANCE_NAME]!.Columns["InsuranceID"]! };
            _insuranceBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_INSURANCE_NAME]!.AsDataView();
            cbInsuranceID.DataSource = _insuranceBindingSource;
            cbInsuranceID.ValueMember = "InsuranceID";
            cbInsuranceID.DisplayMember = "InsuranceID";

            _condoBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_CONDO_NAME]!.AsDataView();
            cbCondoID.DataSource = _condoBindingSource;
            cbCondoID.ValueMember = "CondoID";
            cbCondoID.DisplayMember = "CondoID";

            _customerBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_CUSTOMER_NAME];
            cbCustomerID.DataSource = _customerBindingSource;
            cbCustomerID.ValueMember = "CustomerID";
            cbCustomerID.DisplayMember = "CustomerID";

            HandleCbInsuranceIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbCondoIDSelectedIndexChanged(null, EventArgs.Empty);

        }
        #endregion

        #region Refresh
        private void RefreshListBox()
        {
            UnbindWithControls();

            _condoSaleDataSet.Tables[TABLE_PURCHASE_NAME]?.Clear();
            try
            {
                _purchaseDataAdapter.Fill(_condoSaleDataSet, TABLE_PURCHASE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbPurchase.SelectedIndex = 0;

            BindWithControls();
            txtSearchPurchase.Text = string.Empty;
        }
        #endregion


    }
}
