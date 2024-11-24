using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;



namespace Condo_Sale_Management_Systems
{
    public partial class FrmInsurance : FrmHome
    {
        private const string TABLE_NAME = "tblInsurance";
        private DataSet _storeRentalDataSet = new();
        private SqlDataAdapter _insuranceDataAdapter = new();
        private BindingSource _insuranceBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmInsurance() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _insuranceDataAdapter.SelectCommand = InsuranceHelper.CreateGetAllInsurancesCommand();
            _insuranceDataAdapter.InsertCommand = InsuranceHelper.CreateInsertInsuranceCommand();
            _insuranceDataAdapter.UpdateCommand = InsuranceHelper.CreateUpdateInsuranceCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtInsuranceName);
            _validatingControls.Add(txtInsuranceWebsite);
            #endregion

            LoadAllInsurances();
            BindWithControls();


            #region Event Registrations
            btnNewInsurance.Click += HandleBtnNewInsuranceClicked;
            btnInsertInsurance.Click += HandleBtnInsertInsuranceClicked;
            btnUpdateInsurance.Click += HandleBtnUpdateInsuranceClicked;
            btnCancelInsurance.Click += HandleBtnCancelInsuranceClicked;

            txtInsuranceName.Validating += ValidateTextBox;
            txtInsuranceWebsite.Validating += ValidateTextBox;

            dgvInsurances.SelectionChanged += HandleSelectionChanged;

            txtSearchInsurance.TextChanged += HandleSearchInsurance;

            txtInsuranceName.GotFocus += HandleGotFocusEN;
            txtInsuranceWebsite.GotFocus += HandleGotFocusEN;
            txtSearchInsurance.GotFocus += HandleGotFocusEN;

            #endregion
        }

        #region HandleGotFocus
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }

        #endregion

        #region Bind With Controls
        private void BindWithControls()
        {
            txtInsuranceID.DataBindings.Add(new Binding("Text", _insuranceBindingSource, "InsuranceID"));
            txtInsuranceName.DataBindings.Add(new Binding("Text", _insuranceBindingSource, "InsuranceName"));
            txtInsuranceWebsite.DataBindings.Add(new Binding("Text", _insuranceBindingSource, "InsuranceWebsite"));
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
                btnCancelInsurance.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }

        #endregion

        #region Handle Search
        private void HandleSearchInsurance(object? sender, EventArgs e)
        {
            string searchText = txtSearchInsurance.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _insuranceBindingSource.Filter = string.Empty;
            }
            else
            {
                _insuranceBindingSource.Filter = "InsuranceName LIKE '%" + searchText + "%'";
            }
        }
        #endregion

        #region Handle Validation

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        #endregion

        #region Handle New
        private void HandleBtnNewInsuranceClicked(object? sender, EventArgs e)
        {
            try
            {
                _insuranceBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtInsuranceName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertInsuranceClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _insuranceBindingSource.EndEdit();
            try
            {
                _insuranceDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _insuranceBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateInsuranceClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertInsuranceClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelInsuranceClicked(object? sender, EventArgs e)
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
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }
        }
        #endregion

        #region Load
        private void LoadAllInsurances()
        {
            _insuranceDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _insuranceDataAdapter.Fill(_storeRentalDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _insuranceBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvInsurances.DataSource = _insuranceBindingSource;

        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _insuranceDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
