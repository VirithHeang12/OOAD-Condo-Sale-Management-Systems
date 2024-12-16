using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeSaleManagementSystemsHelper
{
    public static class HomeHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_HOME = "spInsertNewHome";
        private const string UPDATE_HOME = "spUpdateHome";
        private const string GET_ALL_HOMES = "vGetAllHomes";


        private const string GET_ALL_HOMETYPES_FOR_COMBO_BOX = "vGetAllHomeTypesForComboBox";
        #endregion

        #region Generate Insert Home Command
        public static SqlCommand CreateInsertHomeCommand()
        {
            var cmd = new SqlCommand(INSERT_HOME, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Width", SqlDbType.Decimal)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Width"
            });
            cmd.Parameters.Add(new SqlParameter("@Length", SqlDbType.Decimal)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Length"
            });
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Status"
            });
            cmd.Parameters.Add(new SqlParameter("@HomeTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeTypeID"
            });
            return cmd;
        }
        #endregion

        #region Generate Update Home Command
        public static SqlCommand CreateUpdateHomeCommand()
        {
            var cmd = new SqlCommand(UPDATE_HOME, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@HomeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "HomeID"
            });
            cmd.Parameters.Add(new SqlParameter("@Width", SqlDbType.Decimal)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Width"
            });
            cmd.Parameters.Add(new SqlParameter("@Length", SqlDbType.Decimal)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Length"
            });
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Status"
            });
            cmd.Parameters.Add(new SqlParameter("@HomeTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeTypeID"
            });
            return cmd;

        }
        #endregion

        #region Generate Get All Homes Command
        public static SqlCommand CreateGetAllHomesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_HOMES}";
            return cmd;
        }
        #endregion

        #region Generate Get All HomeTypes For Combo Box Command
        public static SqlCommand CreateGetAllHomeTypesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_HOMETYPES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        
    }
}
