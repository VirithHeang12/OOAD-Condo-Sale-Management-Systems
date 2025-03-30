namespace CondoSaleManagementSystemsHelper
{
    public class FormEventArgs: EventArgs
    {
        public FormTypes Form { get; set; } = FormTypes.FrmHome;
        
        public new static FormEventArgs Empty => new();
    }
}