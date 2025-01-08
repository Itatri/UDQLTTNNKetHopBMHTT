using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public class Database
    {
        private static OracleConnection conn;
        private static OracleConnection connSys;

        public static string Host = "localhost"; // Địa chỉ máy chủ
        public static string Port = "1521"; // Cổng kết nối
        public static string Sid = "orcl"; // Tên dịch vụ
        public static string User;
        public static string Password;

        public static void Set_Database(string user, string pass)
        {
            User = user;
            Password = pass;
        }

        public static bool Connect()
        {
            try
            {
                string connString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={Host})(PORT={Port}))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={Sid})));User ID={User};Password={Password}";
                //string connString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={Host})(PORT={Port}))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={Sid})));User ID={User};Password={Password};DBA Privilege=SYSDBA"; //Mở ra nếu cần Audit

                conn = new OracleConnection(connString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }

        public static OracleConnection Get_Connect()
        {
            if (conn == null || conn.State == ConnectionState.Closed)
            {
                if (!Connect())
                {
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");
                }
            }
            return conn;
        }

        public static void Close_Connect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        public static bool ConnectSys()
        {
            string connsys = "";
            try
            {
                if (User.ToUpper().Equals("SYS"))
                {
                    connsys = ";DBA Privilege = SYSDBA";
                }
                string connString = "Data source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + Host + ")(PORT = " + Port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + Sid + ")));User ID= sys ; Password = 123" + connsys;

                connSys = new OracleConnection();
                connSys.ConnectionString = connString;
                connSys.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại chuỗi kết nối!!");
                return false;
            }
        }

        public static OracleConnection Get_ConnectSys()
        {
            if (connSys == null || connSys.State == ConnectionState.Closed)
            {
                if (!ConnectSys())
                {
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu SYSDBA.");
                }
            }
            return connSys;
        }

        public static void Close_ConnectSYS()
        {
            if (connSys != null && connSys.State == ConnectionState.Open)
            {
                connSys.Close();
            }
        }

        // Phương thức để lấy dữ liệu từ cơ sở dữ liệu
        public static DataTable GetDataTable(string query, params OracleParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleCommand cmd = new OracleCommand(query, Get_Connect()))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm các tham số vào lệnh
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                Close_Connect();
            }
            return dt;
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int getNonQuery(string chuoitruyvan)
        {
            Open();

            OracleCommand cmd = new OracleCommand(chuoitruyvan, conn);
            int kq = cmd.ExecuteNonQuery();

            Close();
            return kq;
        }

        public object getScalar(string chuoitruyvan)
        {
            Open();
            OracleCommand cmd = new OracleCommand(chuoitruyvan, conn);
            object kq = cmd.ExecuteScalar();

            Close();
            return kq;
        }

        public DataTable getDataTable(string chuoitruyvan)
        {
            OracleDataAdapter da = new OracleDataAdapter(chuoitruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0]; // DataTable
        }

        public OracleDataReader getReader(string chuoitruyvan)
        {
            Open();
            OracleCommand cmd = new OracleCommand(chuoitruyvan, conn);
            OracleDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public int updateDataTable(DataTable dtnew, string chuoitruyvan)
        {
            OracleDataAdapter da = new OracleDataAdapter(chuoitruyvan, conn);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            int kq = da.Update(dtnew); // Lưu CSDL
            return kq;
        }
        // Phương thức để thực hiện câu lệnh không trả về dữ liệu
        public static int ExecuteNonQuery(string query, params OracleParameter[] parameters)
        {
            int result = 0;
            try
            {
                using (OracleCommand cmd = new OracleCommand(query, Get_Connect()))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm các tham số vào lệnh
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
            }
            finally
            {
                Close_Connect();
            }
            return result;
        }

        public static string Get_Status(string user)
        {
            try
            {
                string function = "fun_account_status";

                using (OracleCommand cmd = new OracleCommand(function, Get_ConnectSys()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter resultParam = new OracleParameter
                    {
                        ParameterName = "RETURN_VALUE",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 100,
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(resultParam);

                    OracleParameter userNameParam = new OracleParameter
                    {
                        ParameterName = "user",
                        OracleDbType = OracleDbType.Varchar2,
                        Value = user.ToUpper(),
                        Direction = ParameterDirection.Input
                    };
                    cmd.Parameters.Add(userNameParam);

                    cmd.ExecuteNonQuery();

                    return resultParam.Value != DBNull.Value ? resultParam.Value.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra status: " + ex.Message);
                return string.Empty;
            }
        }

        //Mở ra nếu cần chạy Audit
        //public static void Set_Database(string host, string port, string sid, string user, string pass)
        //{
        //    Database.Host = "localhost";
        //    Database.Port = "1521";
        //    Database.Sid = "orcl";
        //    Database.User = "sys";
        //    Database.Password = "123";
        //}

    }
}