using CondoSaleManagementSystemsHelper;


namespace Condo_Sale_Management_Systems
{
    public partial class FrmHome : Form, IForm
    {
        public static event EventHandler<FormEventArgs>? NavButtonClicked;
        public static event EventHandler? ButtonLogoutClicked;

        public Form UnderlyingForm => this;

        public FrmHome()
        {
            InitializeComponent();
            btnHome.Click += HandleShowFormHome;
            btnShowStaffForm.Click += HandleShowFormStaff;
            btnShowCustomerForm.Click += HandleShowFormCustomer;
            btnShowCondoTypeForm.Click += HandleShowFormCondoType;
            btnShowUserForm.Click += HandleShowFormUser;
            btnShowInsuranceForm.Click += HandleShowFormInsurance;
            btnShowPurchaseForm.Click += HandleShowFormPurchase;
            btnShowCondoForm.Click += HandleShowFormCondo;

            btnLogout.Click += HandleButtonLogoutClicked;
        }

        public virtual void Initialize()
        {
            // Common initialization logic
        }


        private void HandleShowFormCondo(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmCondo);
        }

        private void HandleShowFormPurchase(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmPurchase);
        }

        private void HandleShowFormInsurance(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmInsurance);
        }

        private void HandleShowFormUser(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmUser);
        }

        private void HandleShowFormCondoType(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmCondoType);
        }

        private void HandleShowFormCustomer(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmCustomer);
        }

        private void HandleButtonLogoutClicked(object? sender, EventArgs e)
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

        private void RaiseEvent(FormTypes formType)
        {
            NavButtonClicked?.Invoke(this, new FormEventArgs()
            {
                Form = formType,
            });
        }
    }



}
