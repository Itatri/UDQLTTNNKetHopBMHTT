using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{

    public class EncryptCeaserT
    {
        private OracleConnection conn;

        // Constructor to initialize the connection
        public EncryptCeaserT()
        {
            conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=quanlyTiengAnh;Password=123;");
            conn.Open();
        }


        // MÃ HÓA ĐỐI XỨNG CaesarCipher gọi funtion từ Oracle
        public string EncryptCeaser_Func(string plaintext, int key)
        {
            if (string.IsNullOrEmpty(plaintext))
            {
                return string.Empty;
            }

            try
            {
                // Đảm bảo kết nối mở
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string functionName = "quanlyTiengAnh.encryptCaesarCipher2";
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

                // Tham số đầu vào: Chuỗi
                OracleParameter strParam = new OracleParameter();
                strParam.ParameterName = "str";
                strParam.OracleDbType = OracleDbType.Varchar2;
                strParam.Value = plaintext;
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

        //private char ShiftChar(char c, int k)
        //{
        //    int baseChar; // Biến lưu ký tự cơ sở để dịch chuyển
        //    int shift; // Biến lưu kết quả sau khi dịch chuyển

        //    // Kiểm tra nếu là ký tự in hoa không dấu (A-Z)
        //    if (char.IsUpper(c))
        //    {
        //        baseChar = 'A';
        //        shift = (c - baseChar + k) % 26; // Dịch chuyển trong phạm vi 26 chữ cái
        //        return (char)(baseChar + shift);
        //    }
        //    // Kiểm tra nếu là ký tự in thường không dấu (a-z)
        //    else if (char.IsLower(c))
        //    {
        //        baseChar = 'a';
        //        shift = (c - baseChar + k) % 26;
        //        return (char)(baseChar + shift);
        //    }
        //    // Ký tự không phải chữ cái, giữ nguyên
        //    return c;
        //}

        //// Mã hóa chuỗi
        //public string EncryptMessage(string message, int k)
        //{
        //    string result = "";
        //    foreach (char c in message)
        //    {
        //        // Nếu ký tự là khoảng trắng hoặc không phải chữ cái thì thêm trực tiếp
        //        if (c == ' ' || !char.IsLetter(c))
        //        {
        //            result += c;
        //        }
        //        else
        //        {
        //            // Mã hóa ký tự
        //            result += ShiftChar(c, k);
        //        }
        //    }
        //    return result;
        //}

        //// Giải mã chuỗi
        //public string DecryptMessage(string message, int k)
        //{
        //    return EncryptMessage(message, 26 - k); // Gọi hàm mã hóa với key đảo ngược
        //}

        private char ShiftChar(char c, int k)
        {
            // Kiểm tra nếu là ký tự in hoa không dấu (A-Z)
            if (char.IsUpper(c))
            {
                int baseChar = 'A';
                int shift = (c - baseChar + k) % 26;
                return (char)(baseChar + shift);
            }
            // Kiểm tra nếu là ký tự in thường không dấu (a-z)
            else if (char.IsLower(c))
            {
                int baseChar = 'a';
                int shift = (c - baseChar + k) % 26;
                return (char)(baseChar + shift);
            }
            // Kiểm tra nếu là chữ số
            else if (char.IsDigit(c))
            {
                int baseDigit = '0';
                int shift = (c - baseDigit + k) % 10;
                return (char)(baseDigit + shift);
            }
            // Ký tự không phải chữ cái hoặc chữ số, giữ nguyên
            return c;
        }

        // Mã hóa chuỗi
        public string EncryptMessage(string message, int k)
        {
            string result = "";
            foreach (char c in message)
            {
                // Nếu ký tự là khoảng trắng hoặc ký tự đặc biệt thì thêm trực tiếp
                if (c == ' ' || (!char.IsLetterOrDigit(c)))
                {
                    result += c;
                }
                else
                {
                    // Mã hóa ký tự
                    result += ShiftChar(c, k);
                }
            }
            return result;
        }

        // Giải mã chuỗi
        public string DecryptMessage(string message, int k)
        {
            // Để giải mã, chúng ta dịch chuyển ngược lại
            return EncryptMessage(message, 26 - k);
        }

        public string EncryptMessageNAME(string message, int k)
        {
            string result = "";
            foreach (char c in message)
            {
                // Nếu là số
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    int shiftedDigit = (digit + k) % 10;
                    result += shiftedDigit.ToString();
                }
                // Nếu là chữ cái hoa
                else if (char.IsUpper(c))
                {
                    char shiftedChar = (char)((((c - 'A') + k) % 26) + 'A');
                    result += shiftedChar;
                }
                // Nếu là chữ cái thường
                else if (char.IsLower(c))
                {
                    char shiftedChar = (char)((((c - 'a') + k) % 26) + 'a');
                    result += shiftedChar;
                }
                // Nếu không phải số hoặc chữ cái (kí tự đặc biệt)
                else
                {
                    result += c;
                }
            }
            return result;
        }


        public string DecryptMessageNAME(string message, int k)
        {
            string result = "";
            foreach (char c in message)
            {
                // Nếu là số
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    int shiftedDigit = (digit - k + 10) % 10;
                    result += shiftedDigit.ToString();
                }
                // Nếu là chữ cái hoa
                else if (char.IsUpper(c))
                {
                    char shiftedChar = (char)((((c - 'A') - k + 26) % 26) + 'A');
                    result += shiftedChar;
                }
                // Nếu là chữ cái thường
                else if (char.IsLower(c))
                {
                    char shiftedChar = (char)((((c - 'a') - k + 26) % 26) + 'a');
                    result += shiftedChar;
                }
                // Nếu không phải số hoặc chữ cái (kí tự đặc biệt)
                else
                {
                    result += c;
                }
            }
            return result;
        }

    }
}
