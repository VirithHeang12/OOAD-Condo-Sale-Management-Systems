using Microsoft.Data.SqlClient;

namespace HomeSaleManagementSystemsHelper
{
    public static class LoginHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region View Name
        private const string GET_ALL = "vGetAllUsersForAuthentication";
        #endregion

        #region Generate Get All Users Command
        public static SqlCommand CreateGetAllUsersCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion
    }
}
