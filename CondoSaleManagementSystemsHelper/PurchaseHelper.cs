using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeSaleManagementSystemsHelper
{
    public static class PurchaseHelper
    {
        public static SqlConnection Connection { get; set; } = default!;

        #region Procedure and View Names
        private const string INSERT = "spInsertNewPurchase";
        private const string UPDATE = "spUpdatePurchase";
        private const string GET_ALL = "vGetAllPurchases";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        private const string GET_ALL_HOMES_FOR_COMBO_BOX = "vGetAllFreeHomesForComboBox";
        private const string GET_ALL_CUSTOMERS_FOR_COMBO_BOX = "vGetAllCustomersForComboBox";
        #endregion

        #region Generate Insert Purchase Command
        public static SqlCommand CreateInsertPurchaseCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PurchaseDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PurchaseDate"
            });
            cmd.Parameters.Add(new SqlParameter("@PurchasePrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PurchasePrice"
            });

            cmd.Parameters.Add(new SqlParameter("@HomeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeID"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffID"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffName", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffName"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffPosition"
            });
            return cmd;
        }
        #endregion

        #region Generate Get All Purchases Command
        public static SqlCommand CreateGetAllPurchasesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Purchase Command
        public static SqlCommand CreateUpdatePurchaseCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PurchaseID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "PurchaseID"
            });
            cmd.Parameters.Add(new SqlParameter("@PurchaseDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PurchaseDate"
            });
            cmd.Parameters.Add(new SqlParameter("@PurchasePrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PurchasePrice"
            });
            cmd.Parameters.Add(new SqlParameter("@HomeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeID"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffID"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffName", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffName"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffPosition"
            });

            return cmd;
        }
        #endregion

        #region Generate Get All Staffs For Combo Box Command
        public static SqlCommand CreateGetAllStaffsForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STAFFS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Customers For Combo Box Command
        public static SqlCommand CreateGetAllCustomersForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_CUSTOMERS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Homes For Combo Box Command
        public static SqlCommand CreateGetAllHomesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_HOMES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion
    }
}
