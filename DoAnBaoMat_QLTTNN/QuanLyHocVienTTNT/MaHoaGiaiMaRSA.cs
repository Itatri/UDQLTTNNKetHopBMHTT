using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public class MaHoaGiaiMaRSA
    {
        private OracleConnection conn;

        // Constructor to initialize the connection
        public MaHoaGiaiMaRSA()
        {
            conn = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP ) (HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED ) (SERVICE_NAME = orcl))); User ID=quanlyTiengAnh; Password = 123;");
            conn.Open();
        }
        public string generateKey(int keySize)
        {
            try
            {
                string Function = "quanlyTiengAnh.CRYPTO.RSA_GENERATE_KEYS";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 10000;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter size = new OracleParameter();
                size.ParameterName = "@Key_Size";
                size.OracleDbType = OracleDbType.Int32;
                size.Value = keySize;
                size.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(size);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    return ret.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
                return null;
            }
        }

        public string encrypt(string plainText, string publicKey)
        {
            try
            {
                string Function = "quanlyTiengAnh.CRYPTO.RSA_ENCRYPT";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 10000;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter pltext = new OracleParameter();
                pltext.ParameterName = "@PLAIN_TEXT";
                pltext.OracleDbType = OracleDbType.Varchar2;
                pltext.Value = plainText;
                pltext.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pltext);

                OracleParameter key = new OracleParameter();
                key.ParameterName = "@PRIVATE_KEY";
                key.OracleDbType = OracleDbType.Varchar2;
                key.Value = publicKey;
                key.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(key);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    return ret.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());

            }
            return null;
        }


        public string decrypt(string encrypted, string privatekey)
        {
            try
            {
                string Function = "quanlyTiengAnh.CRYPTO.RSA_DECRYPT";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 10000;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter pltext = new OracleParameter();
                pltext.ParameterName = "@ENCRYPTED_TEXT";
                pltext.OracleDbType = OracleDbType.Varchar2;
                pltext.Value = encrypted;
                pltext.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pltext);

                OracleParameter key = new OracleParameter();
                key.ParameterName = "@PRIVATE_KEY";
                key.OracleDbType = OracleDbType.Varchar2;
                key.Value = privatekey;
                key.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(key);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    return ret.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());

            }
            return null;
        }
    }
}
