using Microsoft.Data.SqlClient;
using System.Data;

namespace CondoSaleManagementSystemsHelper
{
    public static class InsuranceHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT = "spInsertNewInsurance";
        private const string UPDATE = "spUpdateInsurance";
        private const string GET_ALL = "vGetAllInsurances";
        #endregion

        #region Generate Insert Insurance Command
        public static SqlCommand CreateInsertInsuranceCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@InsuranceName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceName"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceWebsite", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceWebsite"
            });

            return cmd;
        }
        #endregion

        #region Generate Get All Insurances Command
        public static SqlCommand CreateGetAllInsurancesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Insurance Command
        public static SqlCommand CreateUpdateInsuranceCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@InsuranceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "InsuranceID"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceName"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceWebsite", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceWebsite"
            });

            return cmd;
        }
        #endregion
    }
}
