using System.Runtime.InteropServices;

namespace CondoSaleManagementSystemsHelper
{
    public static class KeyboardLayoutHelper
    {
        // Constants for language IDs (LCIDs)
        private const uint LANG_ENGLISH_US = 0x0409;
        private const uint LANG_KHMER = 0x0453;

        // Import necessary functions from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern bool ActivateKeyboardLayout(IntPtr hkl, uint Flags);

        // Flags for ActivateKeyboardLayout
        private const uint KLF_ACTIVATE = 1;
        private const uint KLF_SUBSTITUTE_OK = 0x0002;

        public static void SwitchToEnglishKeyboard()
        {
            IntPtr englishLayout = LoadKeyboardLayout(LANG_ENGLISH_US.ToString("X8"), KLF_ACTIVATE | KLF_SUBSTITUTE_OK);
            ActivateKeyboardLayout(englishLayout, KLF_ACTIVATE | KLF_SUBSTITUTE_OK);
        }

        public static void SwitchToKhmerKeyboard()
        {
            IntPtr khmerLayout = LoadKeyboardLayout(LANG_KHMER.ToString("X8"), KLF_ACTIVATE | KLF_SUBSTITUTE_OK);
            ActivateKeyboardLayout(khmerLayout, KLF_ACTIVATE | KLF_SUBSTITUTE_OK);
        }
    }
}
