using CondoSaleManagementSystemsHelper;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmMain : Form
    {
        public Form? FrmActive { get; set; } = null;

        public FrmMain()
        {
            InitializeComponent();
            this.Resize += HandleFormResize;

            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;

            FrmLogin.LoggedIn += HandleLoggedIn;
            FrmHome.NavButtonClicked += HandleNavButtonClicked;
            FrmHome.ButtonLogoutClicked += HandleButtonLogoutClick;
            OpenChildForm(new FrmLogin());
        }

        private void HandleButtonLogoutClick(object? sender, EventArgs e)
        {
            OpenChildForm(new FrmLogin());
        }

        private void HandleNavButtonClicked(object? sender, FormEventArgs e)
        {
            switch (e.Form)
            {
                case FormTypes.FrmHome:
                    OpenChildForm(new FrmHomeDesign());
                    break;
                case FormTypes.FrmStaff:
                    OpenChildForm(new FrmStaff());
                    break;
                case FormTypes.FrmCustomer:
                    OpenChildForm(new FrmCustomer());
                    break;
                case FormTypes.FrmItem:
                    OpenChildForm(new FrmItem());
                    break;
                case FormTypes.FrmSupplier:
                    OpenChildForm(new FrmSupplier());
                    break;
                case FormTypes.FrmStoreType:
                    OpenChildForm(new FrmStoreType());
                    break;
                case FormTypes.FrmUser:
                    OpenChildForm(new FrmUser());
                    break;
                case FormTypes.FrmInsurance:
                    OpenChildForm(new FrmInsurance());
                    break;
                case FormTypes.FrmExpenseType:
                    OpenChildForm(new FrmExpenseType());
                    break;
                case FormTypes.FrmSalaryPayment:
                    OpenChildForm(new FrmSalaryPayment());
                    break;
                case FormTypes.FrmImport:
                    OpenChildForm(new FrmImport());
                    break;
                case FormTypes.FrmAppointment:
                    OpenChildForm(new FrmAppointment());
                    break;
                case FormTypes.FrmMaintenance:
                    OpenChildForm(new FrmMaintenance());
                    break;
                case FormTypes.FrmPayment:
                    OpenChildForm(new FrmPayment());
                    break;
                case FormTypes.FrmContract:
                    OpenChildForm(new FrmPurchase());
                    break;
                case FormTypes.FrmStore:
                    OpenChildForm(new FrmStore());
                    break;
                default: break;
            }
        }

        private void HandleLoggedIn(object? sender, EventArgs e)
        {
            OpenChildForm(new FrmHome());
        }

        private void HandleFormResize(object? sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                AdjustChildFormSize(this.MdiChildren[0]);
            }
        }

        private void AdjustChildFormSize(Form child)
        {
            child.Left = 0;
            child.Top = 0;
            child.Width = this.ClientSize.Width - 4;
            child.Height = this.ClientSize.Height - 4;
        }

        private async Task FadeIn(Form form)
        {
            form.Opacity = 0;
            form.Show();
            form.BringToFront();

            while (form.Opacity < 1.0)
            {

                await Task.Delay(1); // Adjust delay as needed
                form.Opacity += 0.05;
            }
        }

        private async Task FadeOut(Form form)
        {
            while (form.Opacity > 0.0)
            {

                await Task.Delay(1); // Adjust delay as needed
                form.Opacity -= 0.05;
            }
            form.Hide(); // Hide instead of closing immediately
        }

        private async void OpenChildForm(Form form)
        {
            if (FrmActive != null)
            {
                await FadeOut(FrmActive);
            }

            FrmActive = form;
            FrmActive.MdiParent = this;
            FrmActive.StartPosition = FormStartPosition.Manual;
            FrmActive.Location = new Point(0, 0);
            FrmActive.Width = this.ClientSize.Width - 4;
            FrmActive.Height = this.ClientSize.Height - 4;

            await FadeIn(FrmActive);
        }
    }

}


