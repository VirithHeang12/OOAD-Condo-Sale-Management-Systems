using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public class ErrorProviderAdaptee
    {
        protected ErrorProvider ErrorProvider { get; private set; }
        protected List<Control> Controls { get; private set; }

        public ErrorProviderAdaptee(Form containerForm)
        {
            ErrorProvider = new ErrorProvider { ContainerControl = containerForm };
            Controls = new List<Control>();
        }

        public void AddControl(Control control)
        {
            Controls.Add(control);
        }

        public void ValidateControl(Control control)
        {
            if (control is TextBox textBox)
            {
                if (control.Tag != null && control.Tag.ToString() == "d")
                {
                    ErrorHelper.ValidateTextBoxNumber(textBox, ErrorProvider);
                }
                else
                {
                    ErrorHelper.ValidateTextBox(textBox, ErrorProvider);
                }
            }
            else if (control is MaskedTextBox maskedTextBox)
            {
                ErrorHelper.ValidateMaskedTextBox(maskedTextBox, ErrorProvider);
            }
        }

        public bool HasErrors()
        {
            return ErrorHelper.HasErrors(Controls, ErrorProvider);
        }

        public void ClearErrors()
        {
            ErrorProvider.Clear();
        }

        public void ValidateAllControls()
        {
            foreach (var control in Controls)
            {
                ValidateControl(control);
            }
        }

        public void SetupValidatingHandler(Control control)
        {
            if (control is TextBox textBox)
            {
                if (control.Tag != null && control.Tag.ToString() == "d")
                {
                    textBox.Validating += (s, e) => ValidateControl(textBox);
                }
                else
                {
                    textBox.Validating += (s, e) => ValidateControl(textBox);
                }
            }
        }
    }
}
