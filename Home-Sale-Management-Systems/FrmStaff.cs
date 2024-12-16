using Microsoft.Data.SqlClient;
using HomeSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;


namespace Home_Sale_Management_Systems
{
    public partial class FrmStaff : FrmLanding
    {
        private const string TABLE_NAME = "tblStaff";
        public DataSet _storeRentalDataSet { get; set; } = new DataSet();
        public SqlDataAdapter _staffDataAdapter { get; set; } = new SqlDataAdapter();
        private BindingSource _staffBindingSource { get; set; } = new BindingSource();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmStaff() : base()
        {

            InitializeComponent();

            pbStaffPhoto.Visible = true;
            pbStaffPhoto.SizeMode = PictureBoxSizeMode.StretchImage;


            #region Init DataAdapter Commands
            _staffDataAdapter.SelectCommand = StaffHelper.CreateGetAllStaffsCommand();
            _staffDataAdapter.InsertCommand = StaffHelper.CreateInsertStaffCommand();
            _staffDataAdapter.UpdateCommand = StaffHelper.CreateUpdateStaffCommand();
            #endregion

            #region Add controls for validations
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtStaffFirstName);
            _validatingControls.Add(txtStaffLastName);
            _validatingControls.Add(dtpStaffBirthDate);
            _validatingControls.Add(txtStaffIdentityCardNumber);
            _validatingControls.Add(txtStaffSalary);
            _validatingControls.Add(dtpStaffHiredDate);
            _validatingControls.Add(mtxtStaffContactNumber);
            _validatingControls.Add(mtxtStaffPersonalNumber);
            _validatingControls.Add(txtStaffHouseNo);
            _validatingControls.Add(txtStaffStreetNo);
            _validatingControls.Add(txtStaffSangkat);
            _validatingControls.Add(txtStaffKhan);
            #endregion

            LoadAllStaffs();
            BindWithControls();

            #region Event Registration
            btnPickStaffPhoto.Click += HandleBtnStaffPhotoClicked;
            btnNewStaff.Click += HandleBtnNewStaffClicked;
            btnInsertStaff.Click += HandleBtnInsertStaffClicked;
            btnUpdateStaff.Click += HandleBtnUpdateStaffClicked;
            btnCancelStaff.Click += HandleBtnCancelStaffClicked;

            txtStaffFirstName.Validating += ValidateTextBox;
            txtStaffLastName.Validating += ValidateTextBox;
            dtpStaffBirthDate.Validating += ValidateDtpBirthDate;
            txtStaffIdentityCardNumber.Validating += ValidateIdentityCardNumber;
            txtStaffSalary.Validating += ValidateTextBoxNumber;
            dtpStaffHiredDate.Validating += ValidateDtpHiredDate;
            mtxtStaffContactNumber.Validating += ValidateMaskedTextBox;
            mtxtStaffPersonalNumber.Validating += ValidateMaskedTextBox;
            txtStaffHouseNo.Validating += ValidateTextBox;
            txtStaffStreetNo.Validating += ValidateTextBox;
            txtStaffSangkat.Validating += ValidateTextBox;
            txtStaffKhan.Validating += ValidateTextBox; ;

            lbStaff.SelectedValueChanged += HandleSelectedValueChanged;

            txtSearchStaff.TextChanged += HandleSearchStaff;
            txtStaffFirstName.GotFocus += HandleGotFocusKM;
            txtStaffLastName.GotFocus += HandleGotFocusKM;
            txtStaffIdentityCardNumber.GotFocus += HandleGotFocusEN;
            txtStaffSalary.GotFocus += HandleGotFocusEN;
            mtxtStaffContactNumber.GotFocus += HandleGotFocusEN;
            mtxtStaffPersonalNumber.GotFocus += HandleGotFocusEN;
            txtStaffHouseNo.GotFocus += HandleGotFocusEN;
            txtStaffStreetNo.GotFocus += HandleGotFocusEN;
            txtStaffSangkat.GotFocus += HandleGotFocusKM;
            txtStaffKhan.GotFocus += HandleGotFocusKM;
            txtSearchStaff.GotFocus += HandleGotFocusKM;

            rdbFemale.Click += HandleRdbFemaleClick;
            rdbMale.Click += HandleRdbMaleClick;

            _staffBindingSource.CurrentChanged += HandleCurrentChanged;
            #endregion

        }

        private void HandleCurrentChanged(object? sender, EventArgs e)
        {
            var rowView = (_staffBindingSource.Current as DataRowView);
            if (rowView != null)
            {
                byte[]? imageBytes = (rowView["Photo"] as byte[]);
                if (imageBytes != null)
                {
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        pbStaffPhoto.Image = image;
                    }
                }
                else
                {
                    pbStaffPhoto.Image = null;
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
            var newRowView = (_staffBindingSource.Current as DataRowView)!;
            if (newRowView != null)
            {
                newRowView["Sex"] = 'M';
            }
        }

        private void HandleRdbFemaleClick(object? sender, EventArgs e)
        {
            var newRowView = (_staffBindingSource.Current as DataRowView)!;
            if (newRowView != null)
            {
                newRowView["Sex"] = 'F';
            }
        }

        #region Bind With Controls
        private void BindWithControls()
        {
            if (txtStaffFirstName.DataBindings.Count == 0)
            {
                txtStaffID.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffID"));
                txtStaffFirstName.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffFirstName"));
                txtStaffLastName.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffLastName"));
                rdbFemale.DataBindings.Add(new Binding("Checked", _staffBindingSource, "IsFemale"));
                rdbMale.DataBindings.Add(new Binding("Checked", _staffBindingSource, "IsMale"));
                dtpStaffBirthDate.DataBindings.Add(new Binding("Value", _staffBindingSource, "BirthDate"));
                txtStaffIdentityCardNumber.DataBindings.Add(new Binding("Text", _staffBindingSource, "IdentityCardNumber"));
                cbStaffPosition.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffPosition"));
                txtStaffHouseNo.DataBindings.Add(new Binding("Text", _staffBindingSource, "HouseNo"));
                txtStaffStreetNo.DataBindings.Add(new Binding("Text", _staffBindingSource, "StreetNo"));
                txtStaffSangkat.DataBindings.Add(new Binding("Text", _staffBindingSource, "Sangkat"));
                txtStaffKhan.DataBindings.Add(new Binding("Text", _staffBindingSource, "Khan"));
                cbStaffCityOrProvince.DataBindings.Add(new Binding("Text", _staffBindingSource, "ProvinceOrCity"));
                mtxtStaffContactNumber.DataBindings.Add(new Binding("Text", _staffBindingSource, "ContactNumber"));
                mtxtStaffPersonalNumber.DataBindings.Add(new Binding("Text", _staffBindingSource, "PersonalNumber"));
                txtStaffSalary.DataBindings.Add(new Binding("Text", _staffBindingSource, "Salary"));
                dtpStaffHiredDate.DataBindings.Add(new Binding("Value", _staffBindingSource, "HiredDate"));
                chbStaffStoppedWork.DataBindings.Add(new Binding("Checked", _staffBindingSource, "StoppedWork"));
            }
        }

        #endregion

        #region Unbind With Controls
        private void UnbindWithControls()
        {
            txtStaffID.DataBindings.Clear();
            txtStaffFirstName.DataBindings.Clear();
            txtStaffLastName.DataBindings.Clear();
            rdbFemale.DataBindings.Clear();
            rdbMale.DataBindings.Clear();
            dtpStaffBirthDate.DataBindings.Clear();
            txtStaffIdentityCardNumber.DataBindings.Clear();
            cbStaffPosition.DataBindings.Clear();
            txtStaffHouseNo.DataBindings.Clear();
            txtStaffStreetNo.DataBindings.Clear();
            txtStaffSangkat.DataBindings.Clear();
            txtStaffKhan.DataBindings.Clear();
            cbStaffCityOrProvince.DataBindings.Clear();
            mtxtStaffContactNumber.DataBindings.Clear();
            mtxtStaffPersonalNumber.DataBindings.Clear();
            txtStaffSalary.DataBindings.Clear();
            dtpStaffHiredDate.DataBindings.Clear();
            chbStaffStoppedWork.DataBindings.Clear();
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
                btnCancelStaff.PerformClick();
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
            string searchText = txtSearchStaff.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _staffBindingSource.Filter = string.Empty;
            }
            else
            {
                _staffBindingSource.Filter = "StaffName LIKE '%" + searchText + "%'";

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

        private void ValidateDtpHiredDate(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDtpNowOrPast((sender as DateTimePicker)!, _errorProvider);
        }

        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
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
        private void HandleBtnNewStaffClicked(object? sender, EventArgs e)
        {
            try
            {
                UnbindWithControls();
                _staffBindingSource.AddNew();

                var newRowView = (_staffBindingSource.Current as DataRowView)!;

                newRowView["StoppedWork"] = 0;
                newRowView["IsFemale"] = 0;
                newRowView["IsMale"] = 1;
                newRowView["Sex"] = 'M';
                newRowView["BirthDate"] = DateTime.Parse("2005-01-01");
                cbStaffPosition.SelectedIndex = 0;
                newRowView["StaffPosition"] = cbStaffPosition.Text;
                newRowView["HiredDate"] = DateTime.Now;
                cbStaffCityOrProvince.SelectedIndex = 0;
                newRowView["ProvinceOrCity"] = cbStaffCityOrProvince.Text;
                Bitmap initialImage = Properties.Resources.account_search;
                newRowView["Photo"] = BitmapToByteArray(initialImage);

                lbStaff.DataSource = null;
                lbStaff.DataSource = _staffBindingSource;
                lbStaff.DisplayMember = "StaffName";
                lbStaff.ValueMember = "StaffID";

                Console.WriteLine(newRowView);

                RenderInitialPicture();

                BindWithControls();

                int lastRowIndex = lbStaff.Items.Count - 1;

                lbStaff.SelectedIndex = lastRowIndex;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtStaffFirstName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertStaffClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

            lbStaff.SelectedValueChanged -= HandleSelectedValueChanged;
            _staffBindingSource.EndEdit();
            try
            {
                _staffDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _staffBindingSource.ResetBindings(false);
            }
            catch (Exceptio​n)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshListBox();
            BindWithControls();
            lbStaff.SelectedValueChanged += HandleSelectedValueChanged;
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateStaffClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStaffClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelStaffClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshListBox();
        }
        #endregion

        #region Handle Staff Photo
        private void HandleBtnStaffPhotoClicked(object? sender, EventArgs e)
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
                pbStaffPhoto.Image = System.Drawing.Image.FromFile(selectedFilePath);
                pbStaffPhoto.SizeMode = PictureBoxSizeMode.StretchImage; //

                var newRowView = (_staffBindingSource.Current as DataRowView)!;
                newRowView["Photo"] = BitmapToByteArray(new Bitmap(pbStaffPhoto.Image));
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
                        else if (control.Tag.ToString()!.Equals("hire"))
                        {
                            ErrorHelper.ValidateDtpNowOrPast(dtp, _errorProvider);
                        }
                    }
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllStaffs()
        {
            _staffDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            lbStaff.DataSource = _staffBindingSource;
            lbStaff.DisplayMember = "StaffName";
            lbStaff.ValueMember = "StaffID";

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
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lbStaff.Items.Count > 0)
            {
                lbStaff.SelectedIndex = 0;
                
            }
            if (_staffBindingSource.Count > 0)
            {
                BindWithControls();
            }
            
            txtSearchStaff.Text = string.Empty;
        }
        #endregion

        #region Render initial picture
        private void RenderInitialPicture()
        {
            pbStaffPhoto.Visible = true;
            Bitmap initialImage = Properties.Resources.account_search;
            pbStaffPhoto.Image = initialImage;
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
