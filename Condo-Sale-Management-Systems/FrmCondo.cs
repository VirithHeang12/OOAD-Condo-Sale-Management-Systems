using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmCondo : FrmHome
    {
        private const string TABLE_CONDO_NAME = "tblCondo";
        private const string TABLE_CONDOTYPE_NAME = "tblCondoType";

        private DataSet _condoRentalDataSet = new();

        private SqlDataAdapter _condoDataAdapter = new();
        private SqlDataAdapter _condotypeDataAdapter = new();

        private BindingSource _condoBindingSource = new();
        private BindingSource _condotypeBindingSource = new();

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
            btnNewCondo.Click += HandleBtnNewCondoClicked;
            btnInsertCondo.Click += HandleBtnInsertCondoClicked;
            btnUpdateCondo.Click += HandleBtnUpdateCondoClicked;
            btnCancelCondo.Click += HandleBtnCancelCondoClicked;

            txtFloorNumber.Validating += ValidateTextBoxInteger;
            txtLength.Validating += ValidateTextBoxNumber;
            txtWidth.Validating += ValidateTextBoxNumber;

            dgvCondos.SelectionChanged += HandleSelectionChanged;
            dgvCondos.CellFormatting += HandleCellFormatting;


            txtSearchCondo.TextChanged += HandleSearchCondo;
            txtFloorNumber.GotFocus += HandleGotFocusEN;
            txtLength.GotFocus += HandleGotFocusEN;
            txtWidth.GotFocus += HandleGotFocusEN;
            txtSearchCondo.GotFocus += HandleGotFocusEN;
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
            // condo
            _condoDataAdapter.SelectCommand = HomeHelper.CreateGetAllCondosCommand();
            _condoDataAdapter.InsertCommand = HomeHelper.CreateInsertCondoCommand();
            _condoDataAdapter.UpdateCommand = HomeHelper.CreateUpdateCondoCommand();

            // condotype
            _condotypeDataAdapter.SelectCommand = HomeHelper.CreateGetAllCondoTypesForComboBoxCommand();

        }
        #endregion

        #region BindToControls
        private void BindToControls()
        {
            txtCondoID.DataBindings.Add(new Binding("Text", _condoBindingSource, "CondoID"));
            txtFloorNumber.DataBindings.Add(new Binding("Text", _condoBindingSource, "FloorNumber"));
            txtLength.DataBindings.Add(new Binding("Text", _condoBindingSource, "Length"));
            txtWidth.DataBindings.Add(new Binding("Text", _condoBindingSource, "Width"));

            cbCondoTypeID.DataBindings.Add(new Binding("SelectedValue", _condoBindingSource, "CondoTypeID"));
            chbStatus.DataBindings.Add("Checked", _condoBindingSource, "Status");

        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_condoRentalDataSet.Tables[TABLE_CONDO_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelCondo.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchCondo(object? sender, EventArgs e)
        {
            string searchText = txtSearchCondo.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _condoBindingSource.Filter = string.Empty;
            }
            else
            {
                _condoBindingSource.Filter = "CONVERT(CondoID, 'System.String') LIKE '%" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBoxInteger(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxInteger((sender as TextBox)!, _errorProvider);
        }

        #endregion

        #region Handle New
        private void HandleBtnNewCondoClicked(object? sender, EventArgs e)
        {
            if (cbCondoTypeID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលប្រភេទតូបជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (cbCondoTypeID.DataBindings.Count != 0)
                {
                    cbCondoTypeID.DataBindings.Clear();
                }

                if (chbStatus.DataBindings.Count != 0)
                {
                    chbStatus.DataBindings.Clear();
                }

                _condoBindingSource.AddNew();
                var newRowView = (_condoBindingSource.Current as DataRowView)!;
                newRowView["Status"] = 0;
                cbCondoTypeID.SelectedIndex = 0;
                newRowView["CondoTypeID"] = cbCondoTypeID.SelectedValue;

                if (cbCondoTypeID.DataBindings.Count == 0)
                {
                    cbCondoTypeID.DataBindings.Add(new Binding("SelectedValue", _condoBindingSource, "CondoTypeID"));
                }

                if (chbStatus.DataBindings.Count == 0)
                {
                    chbStatus.DataBindings.Add("Checked", _condoBindingSource, "Status");
                }

                int lastRowIndex = dgvCondos.Rows.Count - 1;
                dgvCondos.CurrentCell = dgvCondos.Rows[lastRowIndex].Cells[0];

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtFloorNumber.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertCondoClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _condoBindingSource.EndEdit();
            try
            {
                _condoDataAdapter.Update(_condoRentalDataSet, TABLE_CONDO_NAME);
                _condoBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateCondoClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertCondoClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelCondoClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _condoRentalDataSet.RejectChanges();
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
            _condoDataAdapter.TableMappings.Add("Table", TABLE_CONDO_NAME);
            _condotypeDataAdapter.TableMappings.Add("Table", TABLE_CONDOTYPE_NAME);

            try
            {
                _condoDataAdapter.Fill(_condoRentalDataSet, TABLE_CONDO_NAME);
                _condotypeDataAdapter.Fill(_condoRentalDataSet, TABLE_CONDOTYPE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _condoBindingSource.DataSource = _condoRentalDataSet.Tables[TABLE_CONDO_NAME];
            dgvCondos.DataSource = _condoBindingSource;

            // bind to CondoTypeID combo box
            _condotypeBindingSource.DataSource = _condoRentalDataSet.Tables[TABLE_CONDOTYPE_NAME]!.AsDataView();

            cbCondoTypeID.DataSource = _condotypeBindingSource;
            cbCondoTypeID.DisplayMember = "CondoTypeDescription";
            cbCondoTypeID.ValueMember = "CondoTypeID";


        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _condoRentalDataSet.Tables[TABLE_CONDO_NAME]?.Clear();
            try
            {
                _condoDataAdapter.Fill(_condoRentalDataSet, TABLE_CONDO_NAME);
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
            if (e.ColumnIndex >= 0 && dgvCondos.Columns[e.ColumnIndex].Name == "Status" && e.Value != null && e.Value != DBNull.Value)
            {
                bool status = Convert.ToBoolean(e.Value);
                e.Value = status ? "បានលក់" : "ទំនេរ";
                e.FormattingApplied = true;
            }
        }
        #endregion



    }
}
