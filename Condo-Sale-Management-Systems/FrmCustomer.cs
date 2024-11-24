using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmCustomer : FrmHome
    {
        private const string TABLE_NAME = "tblCustomer";
        public DataSet _storeRentalDataSet { get; set; } = new DataSet();
        public SqlDataAdapter _customerDataAdapter { get; set; } = new SqlDataAdapter();
        private BindingSource _customerBindingSource { get; set; } = new BindingSource();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmCustomer() : base()
        {

            InitializeComponent();
            pbCustomerPhoto.Visible = true;
            pbCustomerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;


            #region Init DataAdapter Commands
            _customerDataAdapter.SelectCommand = CustomerHelper.CreateGetAllCustomersCommand();
            _customerDataAdapter.InsertCommand = CustomerHelper.CreateInsertCustomerCommand();
            _customerDataAdapter.UpdateCommand = CustomerHelper.CreateUpdateCustomerCommand();
            #endregion

            #region Add controls for validations
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtCustomerFirstName);
            _validatingControls.Add(txtCustomerLastName);
            _validatingControls.Add(dtpCustomerBirthDate);
            _validatingControls.Add(txtCustomerIdentityCardNumber);
            _validatingControls.Add(mtxtCustomerContactNumber);
            _validatingControls.Add(txtCustomerHouseNo);
            _validatingControls.Add(txtCustomerStreetNo);
            _validatingControls.Add(txtCustomerSangkat);
            _validatingControls.Add(txtCustomerKhan);
            #endregion

            LoadAllCustomers();
            BindWithControls();

            #region Event Registration
            btnPickCustomerPhoto.Click += HandleBtnCustomerPhotoClicked;
            btnNewCustomer.Click += HandleBtnNewCustomerClicked;
            btnInsertCustomer.Click += HandleBtnInsertCustomerClicked;
            btnUpdateCustomer.Click += HandleBtnUpdateCustomerClicked;
            btnCancelCustomer.Click += HandleBtnCancelCustomerClicked;

            txtCustomerFirstName.Validating += ValidateTextBox;
            txtCustomerLastName.Validating += ValidateTextBox;
            dtpCustomerBirthDate.Validating += ValidateDtpBirthDate;
            txtCustomerIdentityCardNumber.Validating += ValidateIdentityCardNumber;
            mtxtCustomerContactNumber.Validating += ValidateMaskedTextBox;
            txtCustomerHouseNo.Validating += ValidateTextBox;
            txtCustomerStreetNo.Validating += ValidateTextBox;
            txtCustomerSangkat.Validating += ValidateTextBox;
            txtCustomerKhan.Validating += ValidateTextBox; ;

            lbCustomer.SelectedValueChanged += HandleSelectedValueChanged;

            txtSearchCustomer.TextChanged += HandleSearchCustomer;
            txtCustomerFirstName.GotFocus += HandleGotFocusKM;
            txtCustomerLastName.GotFocus += HandleGotFocusKM;
            dtpCustomerBirthDate.GotFocus += HandleGotFocusEN;
            mtxtCustomerContactNumber.GotFocus += HandleGotFocusEN;
            txtCustomerIdentityCardNumber.GotFocus += HandleGotFocusEN;
            txtCustomerHouseNo.GotFocus += HandleGotFocusEN;
            txtCustomerStreetNo.GotFocus += HandleGotFocusEN;
            txtCustomerSangkat.GotFocus += HandleGotFocusKM;
            txtCustomerKhan.GotFocus += HandleGotFocusKM;
            cbCustomerCityOrProvince.GotFocus += HandleGotFocusKM;

            rdbFemale.Click += HandleRdbFemaleClick;
            rdbMale.Click += HandleRdbMaleClick;

            _customerBindingSource.CurrentChanged += HandleCurrentChanged;
            #endregion

        }
        private void HandleCurrentChanged(object? sender, EventArgs e)
        {
            var rowView = (_customerBindingSource.Current as DataRowView);
            if (rowView != null)
            {
                byte[]? imageBytes = (rowView["Photo"] as byte[]);
                if (imageBytes != null)
                {
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        pbCustomerPhoto.Image = image;
                    }
                }
                else
                {
                    pbCustomerPhoto.Image = null;
                }
            }
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

        private void HandleRdbMaleClick(object? sender, EventArgs e)
        {
            var newRowView = (_customerBindingSource.Current as DataRowView)!;
            if (newRowView != null)
            {
                newRowView["Sex"] = 'M';
            }
        }

        private void HandleRdbFemaleClick(object? sender, EventArgs e)
        {
            var newRowView = (_customerBindingSource.Current as DataRowView)!;
            if (newRowView != null)
            {
                newRowView["Sex"] = 'F';
            }
        }

        #region Bind With Controls
        private void BindWithControls()
        {
            if (txtCustomerFirstName.DataBindings.Count == 0)
            {
                txtCustomerID.DataBindings.Add(new Binding("Text", _customerBindingSource, "CustomerID"));
                txtCustomerFirstName.DataBindings.Add(new Binding("Text", _customerBindingSource, "CustomerFirstName"));
                txtCustomerLastName.DataBindings.Add(new Binding("Text", _customerBindingSource, "CustomerLastName"));
                rdbFemale.DataBindings.Add(new Binding("Checked", _customerBindingSource, "IsFemale"));
                rdbMale.DataBindings.Add(new Binding("Checked", _customerBindingSource, "IsMale"));
                dtpCustomerBirthDate.DataBindings.Add(new Binding("Value", _customerBindingSource, "BirthDate"));
                txtCustomerIdentityCardNumber.DataBindings.Add(new Binding("Text", _customerBindingSource, "IdentityCardNumber"));
                txtCustomerHouseNo.DataBindings.Add(new Binding("Text", _customerBindingSource, "HouseNo"));
                txtCustomerStreetNo.DataBindings.Add(new Binding("Text", _customerBindingSource, "StreetNo"));
                txtCustomerSangkat.DataBindings.Add(new Binding("Text", _customerBindingSource, "Sangkat"));
                txtCustomerKhan.DataBindings.Add(new Binding("Text", _customerBindingSource, "Khan"));
                cbCustomerCityOrProvince.DataBindings.Add(new Binding("Text", _customerBindingSource, "ProvinceOrCity"));
                mtxtCustomerContactNumber.DataBindings.Add(new Binding("Text", _customerBindingSource, "ContactNumber"));

            }
        }

        #endregion

        #region Unbind With Controls
        private void UnbindWithControls()
        {
            txtCustomerID.DataBindings.Clear();
            txtCustomerFirstName.DataBindings.Clear();
            txtCustomerLastName.DataBindings.Clear();
            rdbFemale.DataBindings.Clear();
            rdbMale.DataBindings.Clear();
            dtpCustomerBirthDate.DataBindings.Clear();
            txtCustomerIdentityCardNumber.DataBindings.Clear();
            txtCustomerHouseNo.DataBindings.Clear();
            txtCustomerStreetNo.DataBindings.Clear();
            txtCustomerSangkat.DataBindings.Clear();
            txtCustomerKhan.DataBindings.Clear();
            cbCustomerCityOrProvince.DataBindings.Clear();
            mtxtCustomerContactNumber.DataBindings.Clear();
        }
        #endregion

        #region Handle ListBox SelectedValueChanged
        private void HandleSelectedValueChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelCustomer.PerformClick();
            }
        }
        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchCustomer(object? sender, EventArgs e)
        {
            UnbindWithControls();
            string searchText = txtSearchCustomer.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _customerBindingSource.Filter = string.Empty;
            }
            else
            {
                _customerBindingSource.Filter = "CustomerName LIKE '%" + searchText + "%'";

            }
            BindWithControls();
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateMaskedTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateMaskedTextBox((sender as MaskedTextBox)!, _errorProvider);
        }
        private void ValidateIdentityCardNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateNineDigitNumber((sender as TextBox)!, _errorProvider);
        }

        private void ValidateDtpBirthDate(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDateBefore2005((sender as DateTimePicker)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewCustomerClicked(object? sender, EventArgs e)
        {
            try
            {
                UnbindWithControls();
                _customerBindingSource.AddNew();

                var newRowView = (_customerBindingSource.Current as DataRowView)!;

                newRowView["IsFemale"] = 0;
                newRowView["IsMale"] = 1;
                newRowView["Sex"] = 'M';
                newRowView["BirthDate"] = DateTime.Parse("2005-01-01");
                cbCustomerCityOrProvince.SelectedIndex = 0;
                newRowView["ProvinceOrCity"] = cbCustomerCityOrProvince.Text;
                Bitmap initialImage = Properties.Resources.account_search;
                newRowView["Photo"] = BitmapToByteArray(initialImage);

                lbCustomer.DataSource = null;
                lbCustomer.DataSource = _customerBindingSource;
                lbCustomer.DisplayMember = "CustomerName";
                lbCustomer.ValueMember = "CustomerID";

                Console.WriteLine(newRowView);

                RenderInitialPicture();

                BindWithControls();

                int lastRowIndex = lbCustomer.Items.Count - 1;
                lbCustomer.SelectedIndex = lastRowIndex;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCustomerFirstName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertCustomerClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

            lbCustomer.SelectedValueChanged -= HandleSelectedValueChanged;
            _customerBindingSource.EndEdit();
            try
            {
                _customerDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _customerBindingSource.ResetBindings(false);
            }
            catch (Exceptio​n)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshListBox();
            BindWithControls();
            lbCustomer.SelectedValueChanged += HandleSelectedValueChanged;
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateCustomerClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertCustomerClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelCustomerClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshListBox();
        }
        #endregion

        #region Handle Customer Photo
        private void HandleBtnCustomerPhotoClicked(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.svg";
            openFileDialog.FilterIndex = 1; // Default filter index
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string selectedFilePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                pbCustomerPhoto.Image = System.Drawing.Image.FromFile(selectedFilePath);
                pbCustomerPhoto.SizeMode = PictureBoxSizeMode.StretchImage; //

                var newRowView = (_customerBindingSource.Current as DataRowView)!;
                newRowView["Photo"] = BitmapToByteArray(new Bitmap(pbCustomerPhoto.Image));
            }
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
                            ErrorHelper.ValidateTextBoxIntegerOneToHundred(textBox, _errorProvider);
                        }
                        else if (control.Tag.ToString()!.Equals('n'))
                        {
                            ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                        }
                        else if (control.Tag.ToString()!.Equals("card"))
                        {
                            ErrorHelper.ValidateNineDigitNumber(textBox, _errorProvider);
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
                else if (control is DateTimePicker dtp)
                {
                    if (control.Tag != null)
                    {
                        if (control.Tag.ToString()!.Equals("bd"))
                        {
                            ErrorHelper.ValidateDateBefore2005(dtp, _errorProvider);
                        }
                    }
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllCustomers()
        {
            _customerDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _customerBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            lbCustomer.DataSource = _customerBindingSource;
            lbCustomer.DisplayMember = "CustomerName";
            lbCustomer.ValueMember = "CustomerID";

            HandleCurrentChanged(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshListBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lbCustomer.Items.Count > 0)
            {
                lbCustomer.SelectedIndex = 0;
            }
            

            if (_customerBindingSource.Count > 0)
            {
                BindWithControls();
            }      
            txtSearchCustomer.Text = string.Empty;
        }
        #endregion

        #region Render initial picture
        private void RenderInitialPicture()
        {
            pbCustomerPhoto.Visible = true;
            Bitmap initialImage = Properties.Resources.account_search;
            pbCustomerPhoto.Image = initialImage;
        }
        #endregion

        #region Convert image to byte[]
        static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                // Save the bitmap to the stream in the desired format
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                // Return the byte array from the stream
                return stream.ToArray();
            }
        }
        #endregion

    }
}
