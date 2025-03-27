using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems
{
    public class FormFactory
    {
        private Form _parentForm;

        public FormFactory(Form parentForm)
        {
            _parentForm = parentForm;
        }

        // The Factory Method
        public IForm CreateForm(FormTypes formType)
        {
            IForm form = formType switch
            {
                FormTypes.FrmHome           => new FrmHomeDesign(),
                FormTypes.FrmStaff          => new FrmStaff(),
                FormTypes.FrmCustomer       => new FrmCustomer(),
                FormTypes.FrmCondoType      => new FrmCondoType(),
                FormTypes.FrmUser           => new FrmUser(),
                FormTypes.FrmInsurance      => new FrmInsurance(),
                FormTypes.FrmPurchase       => new FrmPurchase(),
                FormTypes.FrmCondo          => new FrmCondo(),
                FormTypes.FrmLogin          => new FrmLogin(),
                _                           => throw new ArgumentException($"Unknown form type: {formType}"),
            };

            // Initialize the form
            Form actualForm = form.UnderlyingForm;
            actualForm.MdiParent = _parentForm;
            actualForm.StartPosition = FormStartPosition.Manual;
            actualForm.Location = new Point(0, 0);
            actualForm.Width = _parentForm.ClientSize.Width - 4;
            actualForm.Height = _parentForm.ClientSize.Height - 4;

            form.Initialize();
            return form;
        }
    }
}
