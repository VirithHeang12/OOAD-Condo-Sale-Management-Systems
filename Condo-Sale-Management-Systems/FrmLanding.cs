using HomeSaleManagementSystemsHelper;


namespace Home_Sale_Management_Systems
{
    public partial class FrmLanding : Form
    {
        public static event EventHandler<FormEventArgs>? NavButtonClicked;
        public static event EventHandler? ButtonLogoutClicked;
        public FrmLanding()
        {
            InitializeComponent();
            btnLanding.Click += HandleShowFormHome;
            btnShowStaffForm.Click += HandleShowFormStaff;
            btnShowCustomerForm.Click += HandleShowFormCustomer;
            btnShowHomeTypeForm.Click += HandleShowFormCondoType;
            btnShowUserForm.Click += HandleShowFormUser;
            btnShowPurchaseForm.Click += HandleShowFormPurchase;
            btnShowHomeForm.Click += HandleShowFormCondo;

            btnLogout.Click += HandleButtonLogoutClick;
        }

        private void HandleShowFormCondo(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmHome);
        }

        private void HandleShowFormPurchase(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmPurchase);
        }

        private void HandleShowFormUser(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmUser);
        }

        private void HandleShowFormCondoType(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmHomeType);
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
            RaiseEvent(FormTypes.FrmLanding);
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
