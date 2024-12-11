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
            TryConnectingToServer();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

        static void TryConnectingToServer()
        {
            CondoSaleManagementSystemsHelper.Connection.ConnectionStringKey = "ConnectionString";
            try
            {
            CondoSaleManagementSystemsHelper.Connection.LoadConfiguration("appsettings.json");
                CondoSaleManagementSystemsHelper.Connection.Conn = Connection;
                Connection = CondoSaleManagementSystemsHelper.Connection.OpenConnection();
                InitCommands();
                CondoSaleManagementSystemsHelper.Connection.CloseConnnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preparing a connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public static SqlConnection Connection = default!;
        private static void InitCommands()
        {
            StaffHelper.Connection = Connection;
            HomeTypeHelper.Connection = Connection;
            UserHelper.Connection = Connection;

            HomeHelper.Connection = Connection;
            LoginHelper.Connection = Connection;
            PurchaseHelper.Connection = Connection;
            CustomerHelper.Connection = Connection;
            HomeDesignHelper.Connection = Connection;

        }
    }
}