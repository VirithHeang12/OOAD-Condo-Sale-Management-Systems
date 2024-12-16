using System.Text.RegularExpressions;

namespace Home_Sale_Management_Systems
{
    public static class ErrorHelper
    {
        private const string NOT_EMPTY_MSG = "Cannot be empty!";
        private const string NOT_FUTURE_MSG = "Cannot be in the future!";

        #region Validate TextBox
        public static void ValidateTextBox(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
            }
        }
        #endregion

        #region Validate textbox number input fields
        public static bool ValidateTextBoxNumber(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only numbers are allowed!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!double.TryParse(txt.Text, out double n) || n <= 0 || n > 10000000)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }

        #endregion

        #region Validate textbox number input fields or zero
        public static bool ValidateTextBoxNumberOrZero(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only numbers are allowed!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!double.TryParse(txt.Text, out double n) || n < 0 || n > 100000)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }

        #endregion

        #region Validate textbox integer from 1 to 100 input fields
        public static bool ValidateTextBoxIntegerOneToHundred(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only integeter from 1 to 100!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!byte.TryParse(txt.Text, out byte x) || x < 0 || x > 100)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate textbox integer input fields
        public static bool ValidateTextBoxInteger(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only integeter from 1 to 100,000!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!int.TryParse(txt.Text, out int x) || x <= 0 || x > 100000)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate textbox integer input fields (accept 0)
        public static bool ValidateTextBoxIntegerOrZero(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only integeter from 1 to 100,000!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!int.TryParse(txt.Text, out int x) || x < 0 || x > 100000)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate MaskedTextBox
        public static bool ValidateMaskedTextBox(MaskedTextBox mtxt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(mtxt.Text))
            {
                errorProvider.SetError(mtxt, NOT_EMPTY_MSG);
                return false;
            }
            else
            {
                errorProvider.SetError(mtxt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate Dtp Now or Past
        public static bool ValidateDtpNowOrPast(DateTimePicker dtp, ErrorProvider errorProvider)
        {
            if (dtp.Value > DateTime.Now)
            {
                errorProvider.SetError(dtp, NOT_FUTURE_MSG);
                return false;
            }
            else
            {
                errorProvider.SetError(dtp, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate Dtp Present or Future
        public static bool ValidateDtpPresentOrFuture(DateTimePicker dtp, ErrorProvider errorProvider)
        {
            if (dtp.Value <= DateTime.Now)
            {
                errorProvider.SetError(dtp, NOT_FUTURE_MSG);
                return false;
            }
            else
            {
                errorProvider.SetError(dtp, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate Before 2005
        public static bool ValidateDateBefore2005(DateTimePicker dtp, ErrorProvider errorProvider)
        {
            if (dtp.Value > DateTime.Parse("2005-01-01"))
            {
                errorProvider.SetError(dtp, "You need to be born before 2005!");
                return false;
            }
            else
            {
                errorProvider.SetError(dtp, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate 9-digit Number
        public static bool ValidateNineDigitNumber(TextBox txt, ErrorProvider errorProvider)
        {
            if (!Regex.IsMatch(txt.Text, @"^\d{9}$"))
            {
                errorProvider.SetError(txt, "9-digit number only!");
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate
        public static bool HasErrors(List<Control> controls, ErrorProvider errorProvider)
        {
            foreach (Control control in controls)
            {
                control.Focus();
             
                var err = errorProvider.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
