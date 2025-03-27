using CondoSaleManagementSystemsHelper;

namespace Condo_Sale_Management_Systems
{
    public partial class FrmMain : Form
    {
        private IForm? _activeForm = null;
        private FormFactory _formFactory;

        public FrmMain()
        {
            InitializeComponent();

            // Initialize the form factory
            _formFactory = new FormFactory(this);

            this.Resize += HandleFormResize;
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;

            // Set up event handlers
            FrmLogin.LoggedIn += HandleLoggedIn;
            FrmHome.NavButtonClicked += HandleNavButtonClicked;
            FrmHome.ButtonLogoutClicked += HandleButtonLogoutClick;

            // Open the login form
            OpenChildForm(FormTypes.FrmLogin);
        }

        private void HandleButtonLogoutClick(object? sender, EventArgs e)
        {
            OpenChildForm(FormTypes.FrmLogin);
        }

        private void HandleNavButtonClicked(object? sender, FormEventArgs e)
        {
            OpenChildForm(e.Form);
        }

        private void HandleLoggedIn(object? sender, EventArgs e)
        {
            OpenChildForm(FormTypes.FrmHome);
        }

        private void HandleFormResize(object? sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                Form actualForm = _activeForm.UnderlyingForm;
                actualForm.Width = this.ClientSize.Width - 4;
                actualForm.Height = this.ClientSize.Height - 4;
            }
        }

        private async Task FadeIn(IForm form)
        {
            Form actualForm = form.UnderlyingForm;
            actualForm.Opacity = 0;
            form.Show();

            while (actualForm.Opacity < 1.0)
            {
                await Task.Delay(1);
                actualForm.Opacity += 0.05;
            }
        }

        private async Task FadeOut(IForm form)
        {
            Form actualForm = form.UnderlyingForm;

            while (actualForm.Opacity > 0.0)
            {
                await Task.Delay(1);
                actualForm.Opacity -= 0.05;
            }

            form.Hide();
        }

        private async void OpenChildForm(FormTypes formType)
        {
            // Factory Method pattern usage
            if (_activeForm != null)
            {
                await FadeOut(_activeForm);
            }

            // Create form using factory method
            IForm newForm = _formFactory.CreateForm(formType);
            _activeForm = newForm;

            await FadeIn(_activeForm);
        }
    }

}


