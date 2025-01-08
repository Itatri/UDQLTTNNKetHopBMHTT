using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public class DecryptCeaser
    {
        private OracleConnection conn;

        // Constructor to initialize the connection
        public DecryptCeaser()
        {
            conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=quanlyTiengAnh;Password=123;");
            conn.Open();
        }


        // MÃ HÓA ĐỐI XỨNG CaesarCipher gọi funtion từ Oracle ( Mức CSDL ) 
        public string DecryptCaesarFunc(string encryptedText, int key)
        {
            if (string.IsNullOrEmpty(encryptedText))
            {
                return string.Empty;
            }

            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string functionName = "quanlyTiengAnh.decryptCaesarCipher";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = functionName;
                cmd.CommandType = CommandType.StoredProcedure;

                // Tham số trả về
                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "return_value";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 4000;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                // Tham số đầu vào: Chuỗi mã hóa
                OracleParameter strParam = new OracleParameter();
                strParam.ParameterName = "str";
                strParam.OracleDbType = OracleDbType.Varchar2;
                strParam.Value = encryptedText;
                strParam.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(strParam);

                // Tham số đầu vào: Key
                OracleParameter keyParam = new OracleParameter();
                keyParam.ParameterName = "k";
                keyParam.OracleDbType = OracleDbType.Int32;
                keyParam.Value = key;
                keyParam.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(keyParam);

                // Thực thi lệnh
                cmd.ExecuteNonQuery();

                // Lấy kết quả
                return resultParam.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        // Ensure to close the connection when done
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        // MÃ HÓA ĐỐI XỨNG CaesarCipher  ( Mức Ứng dụng )  


    }
}
