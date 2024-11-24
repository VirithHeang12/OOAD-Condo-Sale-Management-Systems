using Microsoft.Data.SqlClient;
using System.Data;

namespace CondoSaleManagementSystemsHelper
{
    public class HomeDesignHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Function COUNT
        private const string COUNT_SOLD_CONDOS = "dbo.fnCountSoldCondos";
        private const string COUNT_ALL_CONDOS = "dbo.fnCountAllCondos";
        private const string COUNT_ALL_STAFFS = "dbo.fnCountAllStaffs";
        private const string COUNT_ALL_CUSTOMERS = "dbo.fnCountAllCustomers";
        private const string COUNT_ALL_INSURANCES = "dbo.fnCountAllInsurances";
        private const string COUNT_ALL_PURCHASES = "dbo.fnCountAllPurchases";
        #endregion

        #region GetAllCountSoldCondo
        public static string GetSoldCondoCount(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_SOLD_CONDOS}()", connection);
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

        #region GetAllCountAllCondos
        public static string GetAllCondos(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_CONDOS}()", connection);
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

        #region GetAllCountAllInsurances
        public static string GetAllInsurances(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_INSURANCES}()", connection);
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
