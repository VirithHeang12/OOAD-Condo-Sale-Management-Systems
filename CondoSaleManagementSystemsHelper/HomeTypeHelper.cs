using Microsoft.Data.SqlClient;
using System.Data;

namespace CondoSaleManagementSystemsHelper
{
    public static class HomeTypeHelper
    {

        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT = "spInsertNewCondoType";
        private const string UPDATE = "spUpdateCondoType";
        private const string GET_ALL = "vGetAllCondoTypes";
        #endregion

        #region Generate Insert CondoType Command
        public static SqlCommand CreateInsertCondoTypeCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@CondoTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CondoTypeDescription"
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

        #region Generate Get All CondoTypes Command
        public static SqlCommand CreateGetAllCondoTypesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update CondoType Command
        public static SqlCommand CreateUpdateCondoTypeCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CondoTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "CondoTypeID"
            });
            cmd.Parameters.Add(new SqlParameter("@CondoTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CondoTypeDescription"
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
