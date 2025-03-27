using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;

namespace Condo_Sale_Management_Systems
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            InitCommands();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

        public static SqlConnection Connection = default!;
        private static void InitCommands()
        {
            CondoSaleManagementSystemsHelper.Connection.LoadConfiguration("appsettings.json");
            Connection = CondoSaleManagementSystemsHelper.Connection.Instance.GetConnection();
            StaffHelper.Connection = Connection;
            InsuranceHelper.Connection = Connection;
            CondoTypeHelper.Connection = Connection;
            UserHelper.Connection = Connection;

            CondoHelper.Connection = Connection;
            LoginHelper.Connection = Connection;
            PurchaseHelper.Connection = Connection;
            CustomerHelper.Connection = Connection;
            HomeDesignHelper.Connection = Connection;

        }
    }
}