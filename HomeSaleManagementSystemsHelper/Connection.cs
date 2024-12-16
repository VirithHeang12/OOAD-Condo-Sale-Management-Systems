using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HomeSaleManagementSystemsHelper
{
    public static class Connection
    {
        public static string ConnectionStringKey { get; set; } = "ConnectionString";
        public static IConfiguration? Configuration { get; set; } = null;
        public static SqlConnection? Conn = default;
        public static void LoadConfiguration(string jsonFile)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }
        public static SqlConnection OpenConnection()
        {
            if (Conn?.State != null && Conn?.State != System.Data.ConnectionState.Closed)
                throw new Exception("The connection is currently not in closed state");
            try
            {
                string? connStr = Configuration?.GetRequiredSection(ConnectionStringKey).Value;
                var conn = new SqlConnection(connStr);
                conn.Open();
                Conn = conn;
                return conn;
            }
            catch (Exception ex)
            {
                Conn = null;
                throw new Exception($"Failed to connect to the server > {ex.Message}");
            }
        }

        public static void CloseConnnection()
        {
            if (Conn!.State != System.Data.ConnectionState.Closed)
                Conn.Close();
        }
    }

}