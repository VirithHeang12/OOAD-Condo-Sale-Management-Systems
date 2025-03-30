using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CondoSaleManagementSystemsHelper
{
    public sealed class Connection
    {
        private static Connection? _instance;
        private SqlConnection? _conn;
        private static IConfiguration? _configuration;

        private Connection() { }

        public static Connection Instance
        {
            get
            {
                _instance ??= new Connection();
                return _instance;
            }
        }

        public static void LoadConfiguration(string jsonFile)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public SqlConnection GetConnection()
        {
            if (_conn == null || _conn.State == System.Data.ConnectionState.Closed || _conn.State == System.Data.ConnectionState.Broken)
            {
                try
                {
                    string? connStr = _configuration?.GetRequiredSection("ConnectionString").Value;
                    if (string.IsNullOrEmpty(connStr))
                        throw new Exception("Connection string is missing.");

                    _conn = new SqlConnection(connStr);
                    _conn.Open();
                }
                catch (Exception ex)
                {
                    _conn = null;
                    throw new Exception($"Failed to connect to the server > {ex.Message}");
                }
            }
            return _conn;
        }
    }

}