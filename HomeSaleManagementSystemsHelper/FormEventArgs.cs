namespace HomeSaleManagementSystemsHelper
{
    public class FormEventArgs: EventArgs
    {
        public FormTypes Form { get; set; } = FormTypes.FrmLanding;
        
        public new static FormEventArgs Empty => new FormEventArgs();
    }
}