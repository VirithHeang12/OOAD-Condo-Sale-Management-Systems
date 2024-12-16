using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeSaleManagementSystemsHelper
{
    public class HomeDesignHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Function COUNT
        private const string COUNT_SOLD_HOMES = "dbo.fnCountSoldHomes";
        private const string COUNT_ALL_HOMES = "dbo.fnCountAllHomes";
        private const string COUNT_ALL_STAFFS = "dbo.fnCountAllStaffs";
        private const string COUNT_ALL_CUSTOMERS = "dbo.fnCountAllCustomers";
        private const string COUNT_ALL_PURCHASES = "dbo.fnCountAllPurchases";
        #endregion

        #region GetAllCountSoldHome
        public static string GetSoldHomeCount(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_SOLD_HOMES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0]!.Rows[0][0]!.ToString()!;
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllHomes
        public static string GetAllHomes(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_HOMES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0]!.Rows[0][0]!.ToString()!;
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllStaffs
        public static string GetAllStaffs(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_STAFFS}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0]!.Rows[0][0]!.ToString()!;
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllCustomers
        public static string GetAllCustomers(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_CUSTOMERS}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0]!.Rows[0][0]!.ToString()!;
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllPurchases
        public static string GetAllPurchases(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_PURCHASES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0]!.Rows[0][0]!.ToString()!;
            }

            return string.Empty;
        }

        #endregion
    }
}
