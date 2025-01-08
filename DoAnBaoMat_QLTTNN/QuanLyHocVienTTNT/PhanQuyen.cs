using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public class PhanQuyen
    {
        OracleConnection conn;

        public PhanQuyen(OracleConnection conn)
        {
            this.conn = conn;
        }

        public OracleDataReader Get_User()
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_select_user";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_user");
            }

            return null;
        }

        public OracleDataReader Get_Roles()
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_select_roles";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_roles");
            }

            return null;
        }

        public OracleDataReader Get_Procedure_User(string userowner, string type)
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_select_procedure_user";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter Userowner = new OracleParameter();
                Userowner.ParameterName = "@userowner";
                Userowner.OracleDbType = OracleDbType.Varchar2;
                Userowner.Value = userowner.ToUpper();
                Userowner.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Userowner);

                OracleParameter pro_type = new OracleParameter();
                pro_type.ParameterName = "@pro_type";
                pro_type.OracleDbType = OracleDbType.Varchar2;
                pro_type.Value = type.ToUpper();
                pro_type.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pro_type);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_procedure_user");
            }
            return null;
        }

        public OracleDataReader Get_Table_User(string userowner)
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_select_table";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter Userowner = new OracleParameter();
                Userowner.ParameterName = "@userowner";
                Userowner.OracleDbType = OracleDbType.Varchar2;
                Userowner.Value = userowner.ToUpper();
                Userowner.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Userowner);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_table");
            }
            return null;
        }

        public DataTable Get_Roles_User(string username)
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_user_roles";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    DataTable data = new DataTable();
                    data.Load(ret);
                    return data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_user_roles");
                return null;
            }
            return null;
        }

        public int Get_Roles_User_Check(string username, string roles)
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_user_roles_check";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter Roles = new OracleParameter();
                Roles.ParameterName = "@roles";
                Roles.OracleDbType = OracleDbType.Varchar2;
                Roles.Value = roles.ToUpper();
                Roles.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Roles);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Int16;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    return int.Parse(resultParam.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_user_roles");
                return -1;
            }

            return -1;
        }

        public DataTable Get_Grant_User(string username)
        {
            try
            {
                string Procedure = "pkg_PhanQuyen.pro_select_grant_user";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    DataTable data = new DataTable();
                    data.Load(ret);
                    return data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_grant_user");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Grant(string username, string userschema, string tab)
        {
            try
            {
                string Procedure = "sys.pkg_PhanQuyen.pro_select_grant";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter UserSchema = new OracleParameter();
                UserSchema.ParameterName = "@userschema";
                UserSchema.OracleDbType = OracleDbType.Varchar2;
                UserSchema.Value = userschema.ToUpper();
                UserSchema.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserSchema);

                OracleParameter TableName = new OracleParameter();
                TableName.ParameterName = "@tablename";
                TableName.OracleDbType = OracleDbType.Varchar2;
                TableName.Value = tab.ToUpper();
                TableName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(TableName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_select_grant");
                return null;
            }
            return null;
        }

        public bool Grant_Revoke_Pro(string username, string user_schema, string pro_tab,
                                        string type_pro, int dk)
        {
            try
            {
                string Procedure = "sys.pkg_PhanQuyen.pro_grant_revoke";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter UserSchema = new OracleParameter();
                UserSchema.ParameterName = "@userschema";
                UserSchema.OracleDbType = OracleDbType.Varchar2;
                UserSchema.Value = user_schema.ToUpper();
                UserSchema.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserSchema);

                OracleParameter ProTab = new OracleParameter();
                ProTab.ParameterName = "@tablename";
                ProTab.OracleDbType = OracleDbType.Varchar2;
                ProTab.Value = pro_tab.ToUpper();
                ProTab.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(ProTab);

                OracleParameter TypePro = new OracleParameter();
                TypePro.ParameterName = "@tyepro";
                TypePro.OracleDbType = OracleDbType.Varchar2;
                TypePro.Value = type_pro.ToUpper();
                TypePro.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(TypePro);

                OracleParameter DK = new OracleParameter();
                DK.ParameterName = "@dk";
                DK.OracleDbType = OracleDbType.Int16;
                DK.Value = dk;
                DK.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(DK);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_grant_revoke");
                return false;
            }
        }

        public bool Grant_Revoke_Role(string username, string role, int dk)
        {
            try
            {
                string Procedure = "sys.pkg_PhanQuyen.pro_grant_revoke_Roles";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter Role = new OracleParameter();
                Role.ParameterName = "@userschema";
                Role.OracleDbType = OracleDbType.Varchar2;
                Role.Value = role.ToUpper();
                Role.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Role);

                OracleParameter DK = new OracleParameter();
                DK.ParameterName = "@dk";
                DK.OracleDbType = OracleDbType.Int16;
                DK.Value = dk;
                DK.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(DK);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi Gọi chạy thủ tục: pro_grant_revoke_Roles");
                return false;
            }
        }
    }
}
