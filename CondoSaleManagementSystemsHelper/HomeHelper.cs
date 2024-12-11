using Microsoft.Data.SqlClient;
using System.Data;

namespace CondoSaleManagementSystemsHelper
{
    public static class HomeHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_CONDO = "spInsertNewCondo";
        private const string UPDATE_CONDO = "spUpdateCondo";
        private const string GET_ALL_CONDOS = "vGetAllCondos";


        private const string GET_ALL_CONDOTYPES_FOR_COMBO_BOX = "vGetAllCondoTypesForComboBox";
        #endregion

        #region Generate Insert Condo Command
        public static SqlCommand CreateInsertCondoCommand()
        {
            var cmd = new SqlCommand(INSERT_CONDO, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FloorNumber", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "FloorNumber"
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
            cmd.Parameters.Add(new SqlParameter("@CondoTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CondoTypeID"
            });
            return cmd;
        }
        #endregion

        #region Generate Update Condo Command
        public static SqlCommand CreateUpdateCondoCommand()
        {
            var cmd = new SqlCommand(UPDATE_CONDO, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CondoID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "CondoID"
            });
            cmd.Parameters.Add(new SqlParameter("@FloorNumber", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "FloorNumber"
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
            cmd.Parameters.Add(new SqlParameter("@CondoTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CondoTypeID"
            });
            return cmd;

        }
        #endregion

        #region Generate Get All Condos Command
        public static SqlCommand CreateGetAllCondosCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_CONDOS}";
            return cmd;
        }
        #endregion

        #region Generate Get All CondoTypes For Combo Box Command
        public static SqlCommand CreateGetAllCondoTypesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_CONDOTYPES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        
    }
}
