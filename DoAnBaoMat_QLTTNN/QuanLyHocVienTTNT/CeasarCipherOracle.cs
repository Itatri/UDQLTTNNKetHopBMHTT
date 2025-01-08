using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public class CaesarCipherOracle
    {
        private Database db;

        public CaesarCipherOracle(Database db)
        {
            this.db = db;
        }

        private OracleConnection GetConnection()
        {
            if (Database.Get_Connect() == null || Database.Get_Connect().State == ConnectionState.Closed)
            {
                if (!Database.Connect())
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                    return null;
                }
            }
            return Database.Get_Connect();
        }

        public string EncryptCaesar_Func(string plainText, int key)
        {
            try
            {
                var conn = GetConnection();
                if (conn == null) return null;

                using (OracleCommand cmd = new OracleCommand("SELECT quanlyTiengAnh.encryptCaesarCipher2(:plaintext, :key) FROM DUAL", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("plaintext", OracleDbType.Varchar2).Value = plainText;
                    cmd.Parameters.Add("key", OracleDbType.Int32).Value = key;

                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi mã hóa: " + ex.Message);
                return null;
            }
        }

        public string DecryptCaesar_Func(string encryptedText, int key)
        {
            try
            {
                var conn = GetConnection();
                if (conn == null) return null;

                using (OracleCommand cmd = new OracleCommand("SELECT quanlyTiengAnh.decryptCaesarCipher2(:encryptedtext, :key) FROM DUAL", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("encryptedtext", OracleDbType.Varchar2).Value = encryptedText;
                    cmd.Parameters.Add("key", OracleDbType.Int32).Value = key;

                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message);
                return null;
            }
        }

        public string EncryptCaesar_Proc(string plainText, int key)
        {
            try
            {
                var conn = GetConnection();
                if (conn == null) return null;

                using (OracleCommand cmd = new OracleCommand("quanlyTiengAnh.encryptCaesarCipher_Proc2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_plaintext", OracleDbType.Varchar2).Value = plainText;
                    cmd.Parameters.Add("p_key", OracleDbType.Int32).Value = key;

                    OracleParameter outputParam = new OracleParameter
                    {
                        ParameterName = "p_result",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 1000,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();
                    return outputParam.Value?.ToString();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi mã hóa: " + ex.Message);
                return null;
            }
        }

        public string DecryptCaesar_Proc(string encryptedText, int key)
        {
            try
            {
                var conn = GetConnection();
                if (conn == null) return null;

                using (OracleCommand cmd = new OracleCommand("quanlyTiengAnh.decryptCaesarCipher_Proc2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_encryptedtext", OracleDbType.Varchar2).Value = encryptedText;
                    cmd.Parameters.Add("p_key", OracleDbType.Int32).Value = key;

                    OracleParameter outputParam = new OracleParameter
                    {
                        ParameterName = "p_result",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 1000,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();
                    return outputParam.Value?.ToString();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message);
                return null;
            }
        }
    }
}
