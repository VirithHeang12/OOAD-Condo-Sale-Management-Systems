using Microsoft.Data.SqlClient;
using HomeSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;

namespace Home_Sale_Management_Systems
{
    public partial class FrmHome : FrmLanding
    {
        private const string TABLE_HOME_NAME = "tblHome";
        private const string TABLE_HOMETYPE_NAME = "tblHomeType";

        private DataSet _homeSaleDataSet = new();

        private SqlDataAdapter _homeDataAdapter = new();
        private SqlDataAdapter _hometypeDataAdapter = new();

        private BindingSource _homeBindingSource = new();
        private BindingSource _hometypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmHome() : base()
        {
            InitializeComponent();

            _errorProvider.ContainerControl = this;

            InitCommands();
            LoadAllData();
            BindToControls();


            #region Event Registrations
            btnNewHome.Click += HandleBtnNewHomeClicked;
            btnInsertHome.Click += HandleBtnInsertHomeClicked;
            btnUpdateHome.Click += HandleBtnUpdateHomeClicked;
            btnCancelHome.Click += HandleBtnCancelHomeClicked;

            txtLength.Validating += ValidateTextBoxNumber;
            txtWidth.Validating += ValidateTextBoxNumber;

            dgvHomes.SelectionChanged += HandleSelectionChanged;
            dgvHomes.CellFormatting += HandleCellFormatting;


            txtSearchHome.TextChanged += HandleSearchHome;
            txtLength.GotFocus += HandleGotFocusEN;
            txtWidth.GotFocus += HandleGotFocusEN;
            txtSearchHome.GotFocus += HandleGotFocusEN;
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
            // home
            _homeDataAdapter.SelectCommand = HomeHelper.CreateGetAllHomesCommand();
            _homeDataAdapter.InsertCommand = HomeHelper.CreateInsertHomeCommand();
            _homeDataAdapter.UpdateCommand = HomeHelper.CreateUpdateHomeCommand();

            // hometype
            _hometypeDataAdapter.SelectCommand = HomeHelper.CreateGetAllHomeTypesForComboBoxCommand();

        }
        #endregion

        #region BindToControls
        private void BindToControls()
        {
            txtHomeID.DataBindings.Add(new Binding("Text", _homeBindingSource, "HomeID"));
            txtLength.DataBindings.Add(new Binding("Text", _homeBindingSource, "Length"));
            txtWidth.DataBindings.Add(new Binding("Text", _homeBindingSource, "Width"));
            cbHomeTypeID.DataBindings.Add(new Binding("SelectedValue", _homeBindingSource, "HomeTypeID"));
            chbStatus.DataBindings.Add("Checked", _homeBindingSource, "Status");

        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_homeSaleDataSet.Tables[TABLE_HOME_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelHome.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchHome(object? sender, EventArgs e)
        {
            string searchText = txtSearchHome.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _homeBindingSource.Filter = string.Empty;
            }
            else
            {
                _homeBindingSource.Filter = "CONVERT(HomeID, 'System.String') LIKE '%" + searchText + "%'";

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
        private void HandleBtnNewHomeClicked(object? sender, EventArgs e)
        {
            if (cbHomeTypeID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលប្រភេទតូបជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (cbHomeTypeID.DataBindings.Count != 0)
                {
                    cbHomeTypeID.DataBindings.Clear();
                }

                if (chbStatus.DataBindings.Count != 0)
                {
                    chbStatus.DataBindings.Clear();
                }

                _homeBindingSource.AddNew();
                var newRowView = (_homeBindingSource.Current as DataRowView)!;
                newRowView["Status"] = 0;
                cbHomeTypeID.SelectedIndex = 0;
                newRowView["HomeTypeID"] = cbHomeTypeID.SelectedValue;

                if (cbHomeTypeID.DataBindings.Count == 0)
                {
                    cbHomeTypeID.DataBindings.Add(new Binding("SelectedValue", _homeBindingSource, "HomeTypeID"));
                }

                if (chbStatus.DataBindings.Count == 0)
                {
                    chbStatus.DataBindings.Add("Checked", _homeBindingSource, "Status");
                }

                int lastRowIndex = dgvHomes.Rows.Count - 1;
                dgvHomes.CurrentCell = dgvHomes.Rows[lastRowIndex].Cells[0];

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertHomeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _homeBindingSource.EndEdit();
            try
            {
                _homeDataAdapter.Update(_homeSaleDataSet, TABLE_HOME_NAME);
                _homeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateHomeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertHomeClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelHomeClicked(object? sender, EventArgs e)
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
                    ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                }
            }
        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _homeDataAdapter.TableMappings.Add("Table", TABLE_HOME_NAME);
            _hometypeDataAdapter.TableMappings.Add("Table", TABLE_HOMETYPE_NAME);

            try
            {
                _homeDataAdapter.Fill(_homeSaleDataSet, TABLE_HOME_NAME);
                _hometypeDataAdapter.Fill(_homeSaleDataSet, TABLE_HOMETYPE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _homeBindingSource.DataSource = _homeSaleDataSet.Tables[TABLE_HOME_NAME];
            dgvHomes.DataSource = _homeBindingSource;

            // bind to HomeTypeID combo box
            _hometypeBindingSource.DataSource = _homeSaleDataSet.Tables[TABLE_HOMETYPE_NAME]!.AsDataView();

            cbHomeTypeID.DataSource = _hometypeBindingSource;
            cbHomeTypeID.DisplayMember = "HomeTypeDescription";
            cbHomeTypeID.ValueMember = "HomeTypeID";


        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _homeSaleDataSet.Tables[TABLE_HOME_NAME]?.Clear();
            try
            {
                _homeDataAdapter.Fill(_homeSaleDataSet, TABLE_HOME_NAME);
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
            if (e.ColumnIndex >= 0 && dgvHomes.Columns[e.ColumnIndex].Name == "Status" && e.Value != null && e.Value != DBNull.Value)
            {
                bool status = Convert.ToBoolean(e.Value);
                e.Value = status ? "បានលក់" : "ទំនេរ";
                e.FormattingApplied = true;
            }
        }
        #endregion



    }
}
