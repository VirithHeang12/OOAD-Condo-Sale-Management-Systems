using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeSaleManagementSystemsHelper
{
    public class UserHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Procedure and View Names
        private const string INSERT_NEW_USER = "spInsertNewUser";
        private const string UPDATE_USER = "spUpdateUser";
        private const string GET_ALL_USERS = "vGetAllUsers";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        #endregion

        #region Generate Insert User Command
        public static SqlCommand CreateInsertUserCommand()
        {
            var cmd = new SqlCommand(INSERT_NEW_USER, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@UserName ", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UserName"
            });
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Password"
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

        #region Generate Update User Command
        public static SqlCommand CreateUpdateUserCommand()
        {
            var cmd = new SqlCommand(UPDATE_USER, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "UserID"
            });
            cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar,100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UserName"
            });
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar,255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Password"
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

        #region Generate Get All Users Command
        public static SqlCommand CreateGetAllUsersCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_USERS}";
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

    }
}
