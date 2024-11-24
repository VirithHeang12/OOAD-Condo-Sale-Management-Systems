using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmCondo : FrmHome
    {
        private const string TABLE_STORE_NAME = "tblStore";
        private const string TABLE_STORETYPE_NAME = "tblStoreType";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _storeDataAdapter = new();
        private SqlDataAdapter _storetypeDataAdapter = new();

        private BindingSource _storeBindingSource = new();
        private BindingSource _storetypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmCondo() : base()
        {
            InitializeComponent();

            _errorProvider.ContainerControl = this;

            InitCommands();
            LoadAllData();
            BindToControls();


            #region Event Registrations
            btnNewStore.Click += HandleBtnNewStoreClicked;
            btnInsertStore.Click += HandleBtnInsertStoreClicked;
            btnUpdateStore.Click += HandleBtnUpdateStoreClicked;
            btnCancelStore.Click += HandleBtnCancelStoreClicked;

            txtFloorNumber.Validating += ValidateTextBoxInteger;
            txtElectricityLastRecord.Validating += ValidateTextBoxNumber;
            txtWaterLastRecord.Validating += ValidateTextBoxNumber;

            dgvStores.SelectionChanged += HandleSelectionChanged;
            dgvStores.CellFormatting += HandleCellFormatting;


            txtSearchStore.TextChanged += HandleSearchStore;
            txtFloorNumber.GotFocus += HandleGotFocusEN;
            txtElectricityLastRecord.GotFocus += HandleGotFocusEN;
            txtWaterLastRecord.GotFocus += HandleGotFocusEN;
            txtSearchStore.GotFocus += HandleGotFocusEN;
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

        #region InitCommands
        private void InitCommands()
        {
            // store
            _storeDataAdapter.SelectCommand = CondoHelper.CreateGetAllStoresCommand();
            _storeDataAdapter.InsertCommand = CondoHelper.CreateInsertStoreCommand();
            _storeDataAdapter.UpdateCommand = CondoHelper.CreateUpdateStoreCommand();

            // storetype
            _storetypeDataAdapter.SelectCommand = CondoHelper.CreateGetAllStoreTypesForComboBoxCommand();

        }
        #endregion

        #region BindToControls
        private void BindToControls()
        {
            txtStoreID.DataBindings.Add(new Binding("Text", _storeBindingSource, "StoreID"));
            txtFloorNumber.DataBindings.Add(new Binding("Text", _storeBindingSource, "FloorNumber"));
            txtElectricityLastRecord.DataBindings.Add(new Binding("Text", _storeBindingSource, "ElectricityLastRecord"));
            txtWaterLastRecord.DataBindings.Add(new Binding("Text", _storeBindingSource, "WaterLastRecord"));

            cbStoreTypeID.DataBindings.Add(new Binding("SelectedValue", _storeBindingSource, "StoreTypeID"));
            chbStatus.DataBindings.Add("Checked", _storeBindingSource, "Status");

        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_STORE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelStore.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchStore(object? sender, EventArgs e)
        {
            string searchText = txtSearchStore.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _storeBindingSource.Filter = string.Empty;
            }
            else
            {
                _storeBindingSource.Filter = "CONVERT(StoreID, 'System.String') LIKE '%" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumberOrZero((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBoxInteger(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxInteger((sender as TextBox)!, _errorProvider);
        }

        #endregion

        #region Handle New
        private void HandleBtnNewStoreClicked(object? sender, EventArgs e)
        {
            if (cbStoreTypeID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលប្រភេទតូបជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (cbStoreTypeID.DataBindings.Count != 0)
                {
                    cbStoreTypeID.DataBindings.Clear();
                }

                if (chbStatus.DataBindings.Count != 0)
                {
                    chbStatus.DataBindings.Clear();
                }

                _storeBindingSource.AddNew();
                var newRowView = (_storeBindingSource.Current as DataRowView)!;
                newRowView["Status"] = 0;
                cbStoreTypeID.SelectedIndex = 0;
                newRowView["StoreTypeID"] = cbStoreTypeID.SelectedValue;

                if (cbStoreTypeID.DataBindings.Count == 0)
                {
                    cbStoreTypeID.DataBindings.Add(new Binding("SelectedValue", _storeBindingSource, "StoreTypeID"));
                }

                if (chbStatus.DataBindings.Count == 0)
                {
                    chbStatus.DataBindings.Add("Checked", _storeBindingSource, "Status");
                }

                int lastRowIndex = dgvStores.Rows.Count - 1;
                dgvStores.CurrentCell = dgvStores.Rows[lastRowIndex].Cells[0];

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtFloorNumber.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertStoreClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _storeBindingSource.EndEdit();
            try
            {
                _storeDataAdapter.Update(_storeRentalDataSet, TABLE_STORE_NAME);
                _storeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateStoreClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStoreClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelStoreClicked(object? sender, EventArgs e)
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
                    ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                }
            }
        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);
            _storetypeDataAdapter.TableMappings.Add("Table", TABLE_STORETYPE_NAME);

            try
            {
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
                _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORETYPE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _storeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORE_NAME];
            dgvStores.DataSource = _storeBindingSource;

            // bind to StoreTypeID combo box
            _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORETYPE_NAME]!.AsDataView();

            cbStoreTypeID.DataSource = _storetypeBindingSource;
            cbStoreTypeID.DisplayMember = "StoreTypeDescription";
            cbStoreTypeID.ValueMember = "StoreTypeID";


        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_STORE_NAME]?.Clear();
            try
            {
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Handle Checkbox CellFormatting
        private void HandleCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvStores.Columns[e.ColumnIndex].Name == "Status" && e.Value != null && e.Value != DBNull.Value)
            {
                bool status = Convert.ToBoolean(e.Value);
                e.Value = status ? "បានជួល" : "ទំនេរ";
                e.FormattingApplied = true;
            }
        }
        #endregion



    }
}
