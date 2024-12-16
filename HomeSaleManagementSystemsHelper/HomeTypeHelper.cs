using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeSaleManagementSystemsHelper
{
    public static class HomeTypeHelper
    {

        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT = "spInsertNewHomeType";
        private const string UPDATE = "spUpdateHomeType";
        private const string GET_ALL = "vGetAllHomeTypes";
        #endregion

        #region Generate Insert HomeType Command
        public static SqlCommand CreateInsertHomeTypeCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@HomeTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeTypeDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Price"
            });
            return cmd;
        }
        #endregion

        #region Generate Get All HomeTypes Command
        public static SqlCommand CreateGetAllHomeTypesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update HomeType Command
        public static SqlCommand CreateUpdateHomeTypeCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@HomeTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "HomeTypeID"
            });
            cmd.Parameters.Add(new SqlParameter("@HomeTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HomeTypeDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Price"
            });
            return cmd;
        }
        #endregion
    }
}
