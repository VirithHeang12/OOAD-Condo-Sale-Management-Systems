using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmCondoType : FrmHome
    {

        private const string TABLE_NAME = "tblCondoType";
        private DataSet _condoSaleDataSet = new DataSet();
        private SqlDataAdapter _condotypeDataAdapter = new();
        private BindingSource _condotypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmCondoType() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _condotypeDataAdapter.SelectCommand = HomeTypeHelper.CreateGetAllCondoTypesCommand();
            _condotypeDataAdapter.InsertCommand = HomeTypeHelper.CreateInsertCondoTypeCommand();
            _condotypeDataAdapter.UpdateCommand = HomeTypeHelper.CreateUpdateCondoTypeCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtCondoTypeDescription);
            _validatingControls.Add(txtPrice);
            #endregion

            LoadAllCondoTypes();
            BindWithControls();


            #region Event Registrations
            btnNewCondoType.Click += HandleBtnNewCondoTypeClicked;
            btnInsertCondoType.Click += HandleBtnInsertCondoTypeClicked;
            btnUpdateCondoType.Click += HandleBtnUpdateCondoTypeClicked;
            btnCancelCondoType.Click += HandleBtnCancelCondoTypeClicked;

            txtCondoTypeDescription.Validating += ValidateTextBox;
            txtPrice.Validating += ValidateTextBoxNumber;

            dgvCondoTypes.SelectionChanged += HandleSelectionChanged;

            txtSearchCondoType.TextChanged += HandleSearchCondoType;
            txtCondoTypeDescription.GotFocus += HandleGotFocusKM;
            txtPrice.GotFocus += HandleGotFocusEN;
            txtSearchCondoType.GotFocus += HandleGotFocusEN;
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
            txtCondoTypeID.DataBindings.Add(new Binding("Text", _condotypeBindingSource, "CondoTypeID"));
            txtCondoTypeDescription.DataBindings.Add(new Binding("Text", _condotypeBindingSource, "CondoTypeDescription"));
            txtPrice.DataBindings.Add(new Binding("Text", _condotypeBindingSource, "Price"));
        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_condoSaleDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelCondoType.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchCondoType(object? sender, EventArgs e)
        {
            string searchText = txtSearchCondoType.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _condotypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _condotypeBindingSource.Filter = "CondoTypeDescription LIKE '%" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation

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
        private void HandleBtnNewCondoTypeClicked(object? sender, EventArgs e)
        {
            try
            {
                _condotypeBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCondoTypeDescription.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertCondoTypeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _condotypeBindingSource.EndEdit();
            try
            {
                _condotypeDataAdapter.Update(_condoSaleDataSet, TABLE_NAME);
                _condotypeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateCondoTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertCondoTypeClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelCondoTypeClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _condoSaleDataSet.RejectChanges();
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
                        if (control.Tag.ToString()!.Equals('d'))
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
        private void LoadAllCondoTypes()
        {
            _condotypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _condotypeDataAdapter.Fill(_condoSaleDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _condotypeBindingSource.DataSource = _condoSaleDataSet.Tables[TABLE_NAME];
            dgvCondoTypes.DataSource = _condotypeBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _condoSaleDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _condotypeDataAdapter.Fill(_condoSaleDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
