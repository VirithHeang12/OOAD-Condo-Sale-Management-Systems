using Microsoft.Data.SqlClient;
using HomeSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;


namespace Home_Sale_Management_Systems
{
    public partial class FrmHomeType : FrmLanding
    {

        private const string TABLE_NAME = "tblHomeType";
        private DataSet _homeSaleDataSet = new DataSet();
        private SqlDataAdapter _hometypeDataAdapter = new();
        private BindingSource _hometypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmHomeType() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _hometypeDataAdapter.SelectCommand = HomeTypeHelper.CreateGetAllHomeTypesCommand();
            _hometypeDataAdapter.InsertCommand = HomeTypeHelper.CreateInsertHomeTypeCommand();
            _hometypeDataAdapter.UpdateCommand = HomeTypeHelper.CreateUpdateHomeTypeCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtHomeTypeDescription);
            _validatingControls.Add(txtPrice);
            #endregion

            LoadAllHomeTypes();
            BindWithControls();


            #region Event Registrations
            btnNewHomeType.Click += HandleBtnNewHomeTypeClicked;
            btnInsertHomeType.Click += HandleBtnInsertHomeTypeClicked;
            btnUpdateHomeType.Click += HandleBtnUpdateHomeTypeClicked;
            btnCancelHomeType.Click += HandleBtnCancelHomeTypeClicked;

            txtHomeTypeDescription.Validating += ValidateTextBox;
            txtPrice.Validating += ValidateTextBoxNumber;

            dgvHomeTypes.SelectionChanged += HandleSelectionChanged;

            txtSearchHomeType.TextChanged += HandleSearchHomeType;
            txtHomeTypeDescription.GotFocus += HandleGotFocusKM;
            txtPrice.GotFocus += HandleGotFocusEN;
            txtSearchHomeType.GotFocus += HandleGotFocusEN;
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
            txtHomeTypeID.DataBindings.Add(new Binding("Text", _hometypeBindingSource, "HomeTypeID"));
            txtHomeTypeDescription.DataBindings.Add(new Binding("Text", _hometypeBindingSource, "HomeTypeDescription"));
            txtPrice.DataBindings.Add(new Binding("Text", _hometypeBindingSource, "Price"));
        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_homeSaleDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelHomeType.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchHomeType(object? sender, EventArgs e)
        {
            string searchText = txtSearchHomeType.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _hometypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _hometypeBindingSource.Filter = "HomeTypeDescription LIKE '%" + searchText + "%'";

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
        private void HandleBtnNewHomeTypeClicked(object? sender, EventArgs e)
        {
            try
            {
                _hometypeBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtHomeTypeDescription.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertHomeTypeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _hometypeBindingSource.EndEdit();
            try
            {
                _hometypeDataAdapter.Update(_homeSaleDataSet, TABLE_NAME);
                _hometypeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateHomeTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertHomeTypeClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelHomeTypeClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _homeSaleDataSet.RejectChanges();
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
        private void LoadAllHomeTypes()
        {
            _hometypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _hometypeDataAdapter.Fill(_homeSaleDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _hometypeBindingSource.DataSource = _homeSaleDataSet.Tables[TABLE_NAME];
            dgvHomeTypes.DataSource = _hometypeBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _homeSaleDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _hometypeDataAdapter.Fill(_homeSaleDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
