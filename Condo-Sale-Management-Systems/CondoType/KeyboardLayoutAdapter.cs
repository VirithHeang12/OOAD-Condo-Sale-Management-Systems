using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public class KeyboardLayoutAdapter
    {
        public static void RegisterKhmerControl(Control control)
        {
            control.GotFocus += (s, e) => KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }

        public static void RegisterEnglishControl(Control control)
        {
            control.GotFocus += (s, e) => KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
    }
}
