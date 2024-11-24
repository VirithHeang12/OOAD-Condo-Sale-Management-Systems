using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmCondoType : FrmHome
    {

        private const string TABLE_NAME = "tblStoreType";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _storetypeDataAdapter = new();
        private BindingSource _storetypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmCondoType() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _storetypeDataAdapter.SelectCommand = CondoTypeHelper.CreateGetAllStoreTypesCommand();
            _storetypeDataAdapter.InsertCommand = CondoTypeHelper.CreateInsertStoreTypeCommand();
            _storetypeDataAdapter.UpdateCommand = CondoTypeHelper.CreateUpdateStoreTypeCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtStoreTypeDescription);
            _validatingControls.Add(txtMonthlyLeasePrice);
            _validatingControls.Add(txtThreeMonthPaymentDiscount);
            _validatingControls.Add(txtSixMonthPaymentDiscount);
            _validatingControls.Add(txtOneYearPaymentDiscount);
            #endregion

            LoadAllStoreTypes();
            BindWithControls();


            #region Event Registrations
            btnNewStoreType.Click += HandleBtnNewStoreTypeClicked;
            btnInsertStoreType.Click += HandleBtnInsertStoreTypeClicked;
            btnUpdateStoreType.Click += HandleBtnUpdateStoreTypeClicked;
            btnCancelStoreType.Click += HandleBtnCancelStoreTypeClicked;

            txtStoreTypeDescription.Validating += ValidateTextBox;
            txtMonthlyLeasePrice.Validating += ValidateTextBoxNumber;
            txtThreeMonthPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;
            txtSixMonthPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;
            txtOneYearPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;

            dgvStoreTypes.SelectionChanged += HandleSelectionChanged;

            txtSearchStoreType.TextChanged += HandleSearchStoreType;
            txtStoreTypeDescription.GotFocus += HandleGotFocusKM;
            txtMonthlyLeasePrice.GotFocus += HandleGotFocusEN;
            txtThreeMonthPaymentDiscount.GotFocus += HandleGotFocusEN;
            txtSixMonthPaymentDiscount.GotFocus += HandleGotFocusEN;
            txtOneYearPaymentDiscount.GotFocus += HandleGotFocusEN;
            txtSearchStoreType.GotFocus += HandleGotFocusEN;
            #endregion

        }

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
            txtStoreTypeID.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeID"));
            txtStoreTypeDescription.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeDescription"));
            txtMonthlyLeasePrice.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "MonthlyLeasePrice"));
            txtThreeMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "ThreeMonthPaymentDiscount"));
            txtSixMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "SixMonthPaymentDiscount"));
            txtOneYearPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "OneYearPaymentDiscount"));
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
                btnCancelStoreType.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchStoreType(object? sender, EventArgs e)
        {
            string searchText = txtSearchStoreType.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _storetypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _storetypeBindingSource.Filter = "StoreTypeDescription LIKE '%" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBoxIntegerOneToHundred(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxIntegerOneToHundred((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBoxNumber(object? sender, EventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewStoreTypeClicked(object? sender, EventArgs e)
        {
            try
            {
                _storetypeBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtStoreTypeDescription.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertStoreTypeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _storetypeBindingSource.EndEdit();
            try
            {
                _storetypeDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _storetypeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateStoreTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStoreTypeClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelStoreTypeClicked(object? sender, EventArgs e)
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
                    if (control.Tag != null)
                    {
                        if (control.Tag.ToString()!.Equals('n'))
                        {
                            ErrorHelper.ValidateTextBoxIntegerOneToHundred(textBox, _errorProvider);
                        }
                        else if (control.Tag.ToString()!.Equals('d'))
                        {
                            ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                        }
                    }
                    else
                    {
                        ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                    }
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    ErrorHelper.ValidateMaskedTextBox(maskedTextBox, _errorProvider);
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllStoreTypes()
        {
            _storetypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvStoreTypes.DataSource = _storetypeBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
