using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;
using Condo_Sale_Management_Systems.CondoType;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmCondoType : FrmHome
    {

        private const string TABLE_NAME = "tblCondoType";

        // Target interfaces
        private readonly ICondoTypeDataService _dataService;
        private readonly IValidationService _validationService;

        public FrmCondoType() : base()
        {
            InitializeComponent();

            // Create the adapters (which inherit from adaptees)
            _dataService = new CondoTypeDataAdapter(TABLE_NAME);
            _validationService = new ValidationAdapter(this);

            // Add controls for validation
            ((ValidationAdapter)_validationService).AddControl(txtCondoTypeDescription);
            ((ValidationAdapter)_validationService).AddControl(txtPrice);

            // Initialize form
            InitializeForm();
        }

        #region Initialization
        private void InitializeForm()
        {
            // Load data
            _dataService.LoadData();

            // Bind controls
            BindWithControls();

            // Register event handlers
            RegisterEventHandlers();
        }

        private void BindWithControls()
        {
            var bindingSource = _dataService.GetBindingSource();

            txtCondoTypeID.DataBindings.Add(new Binding("Text", bindingSource, "CondoTypeID"));
            txtCondoTypeDescription.DataBindings.Add(new Binding("Text", bindingSource, "CondoTypeDescription"));
            txtPrice.DataBindings.Add(new Binding("Text", bindingSource, "Price"));

            dgvCondoTypes.DataSource = bindingSource;
        }

        private void RegisterEventHandlers()
        {
            // Button events
            btnNewCondoType.Click += HandleBtnNewCondoTypeClicked;
            btnInsertCondoType.Click += HandleBtnInsertCondoTypeClicked;
            btnUpdateCondoType.Click += HandleBtnUpdateCondoTypeClicked;
            btnCancelCondoType.Click += HandleBtnCancelCondoTypeClicked;

            // Validation events
            _validationService.RegisterValidatingHandler(txtCondoTypeDescription);
            _validationService.RegisterValidatingHandler(txtPrice);

            // Selection and search events
            dgvCondoTypes.SelectionChanged += HandleSelectionChanged;
            txtSearchCondoType.TextChanged += HandleSearchCondoType;

            // Keyboard layout events
            KeyboardLayoutAdapter.RegisterKhmerControl(txtCondoTypeDescription);
            KeyboardLayoutAdapter.RegisterEnglishControl(txtPrice);
            KeyboardLayoutAdapter.RegisterEnglishControl(txtSearchCondoType);
        }
        #endregion

        #region Event Handlers
        private void HandleBtnNewCondoTypeClicked(object? sender, EventArgs e)
        {
            _dataService.AddNew();
            txtCondoTypeDescription.Focus();
        }

        private void HandleBtnInsertCondoTypeClicked(object? sender, EventArgs e)
        {
            _validationService.ValidateAll();

            if (!_validationService.HasErrors())
            {
                _dataService.SaveData();
            }
        }

        private void HandleBtnUpdateCondoTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertCondoTypeClicked(sender, e);
        }

        private void HandleBtnCancelCondoTypeClicked(object? sender, EventArgs e)
        {
            _validationService.ClearErrors();
            _dataService.CancelChanges();
        }

        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (_dataService.ContainsNewRow())
            {
                btnCancelCondoType.PerformClick();
            }
        }

        private void HandleSearchCondoType(object? sender, EventArgs e)
        {
            string searchText = txtSearchCondoType.Text.Trim().ToLower();
            _dataService.ApplyFilter(searchText);
        }
        #endregion

    }
}
