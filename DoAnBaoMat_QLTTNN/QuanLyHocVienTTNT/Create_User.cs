using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    internal class Create_User
    {
        OracleConnection conn;

        public Create_User(OracleConnection conn)
        {
            this.conn = conn;
        }

        public int Pro_CheckUser(string UserName)
        {
            try
            {
                string Function = "sys.pkg_cruser.fun_check_account";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@kq";
                resultParam.OracleDbType = OracleDbType.Int16;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter User = new OracleParameter();
                User.ParameterName = "@username";
                User.OracleDbType = OracleDbType.Varchar2;
                User.Value = UserName.ToUpper();
                User.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(User);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    return int.Parse(resultParam.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gọi chạy hàm ở Package!!");
            }
            return -1;
        }
        public bool Pro_CreateUser(string UserName, string Password)
        {
            try
            {
                string Function = "sys.pkg_cruser.Pro_CrUser";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter User = new OracleParameter();
                User.ParameterName = "@username";
                User.OracleDbType = OracleDbType.Varchar2;
                User.Value = UserName.ToUpper();
                User.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(User);

                OracleParameter Pass = new OracleParameter();
                Pass.ParameterName = "@pass";
                Pass.OracleDbType = OracleDbType.Varchar2;
                Pass.Value = Password;
                Pass.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Pass);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
