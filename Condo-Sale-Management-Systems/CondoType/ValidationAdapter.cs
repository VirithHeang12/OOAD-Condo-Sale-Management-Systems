using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public class ValidationAdapter : ErrorProviderAdaptee, IValidationService
    {
        public ValidationAdapter(Form containerForm) : base(containerForm) { }

        // IValidationService implementation
        public void ValidateAll()
        {
            ValidateAllControls();
        }

        // We're inheriting HasErrors() and ClearErrors() from the Adaptee

        public void RegisterValidatingHandler(Control control)
        {
            SetupValidatingHandler(control);
        }
    }
}
