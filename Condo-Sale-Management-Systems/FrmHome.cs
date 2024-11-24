using CondoSaleManagementSystemsHelper;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmHome : Form
    {
        public static event EventHandler<FormEventArgs>? NavButtonClicked;
        public static event EventHandler? ButtonLogoutClicked;
        public FrmHome()
        {
            InitializeComponent();
            btnHome.Click += HandleShowFormHome;
            btnShowStaffForm.Click += HandleShowFormStaff;
            btnShowCustomerForm.Click += HandleShowFormCustomer;
            btnShowItemForm.Click += HandleShowFormItem;
            btnShowSupplierForm.Click += HandleShowFromSupplier;
            btnShowStoreTypeForm.Click += HandleShowFormStoreType;
            btnShowUserForm.Click += HandleShowFormUser;
            btnShowInsuranceForm.Click += HandleShowFormInsurance;
            btnShowExpenseTypeForm.Click += HandleShowFormExpenseType;
            btnShowSalaryPaymentForm.Click += HandleShowFormSalaryPayment;
            btnShowImportForm.Click += HandleShowFormImport;
            btnShowAppointmentForm.Click += HandleShowFormAppointment;
            btnShowMaintenanceForm.Click += HandleShowFormMaintenance;
            btnShowPaymentForm.Click += HandleShowFormPayment;
            btnShowContractForm.Click += HandleShowFormContract;
            btnShowStoreForm.Click += HandleShowFormStore;

            btnLogout.Click += HandleButtonLogoutClick;
        }

        private void HandleShowFormStore(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmStore);
        }

        private void HandleShowFormContract(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmContract);
        }

        private void HandleShowFormPayment(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmPayment);
        }

        private void HandleShowFormMaintenance(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmMaintenance);
        }

        private void HandleShowFormAppointment(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmAppointment);
        }

        private void HandleShowFormImport(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmImport);
        }

        private void HandleShowFormSalaryPayment(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmSalaryPayment);
        }

        private void HandleShowFormExpenseType(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmExpenseType);
        }

        private void HandleShowFormInsurance(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmInsurance);
        }

        private void HandleShowFormUser(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmUser);
        }

        private void HandleShowFormStoreType(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmStoreType);
        }

        private void HandleShowFromSupplier(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmSupplier);
        }

        private void HandleShowFormItem(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmItem);
        }

        private void HandleShowFormCustomer(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmCustomer);
        }

        private void HandleButtonLogoutClick(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("តើអ្នកពិតជាចង់ចាកចេញពីប្រព័ន្ធមែនឬទេ?", "ចាកចេញពីប្រព័ន្ធ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ButtonLogoutClicked?.Invoke(this, e);
            }

        }

        private void HandleShowFormHome(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmHome);
        }

        private void HandleShowFormStaff(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmStaff);
        }

        private void RaiseEvent(FormTypes ft)
        {
            NavButtonClicked?.Invoke(this, new FormEventArgs()
            {
                Form = ft,
            });
        }
    }



}
