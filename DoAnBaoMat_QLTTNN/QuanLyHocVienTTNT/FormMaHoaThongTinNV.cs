using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyHocVienTTNT
{
    public partial class FormMaHoaThongTinNV : Form
    {
        Database db = new Database();
        DataTable dt;

        private int encryptionKey;
        private string filePath;

        MaHoaGiaiMaRSA rsaOracle;

        private string publicKey;
        private string privateKey;

        public FormMaHoaThongTinNV()
        {
            InitializeComponent();
            CenterToScreen();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rsaOracle = new MaHoaGiaiMaRSA();

            GenerateRSAKeys();
        }


        //TẠO KHÓA CHO MÃ HÓA RSA
        private void GenerateRSAKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false)); // Khóa công khai
                privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true)); // Khóa riêng tư
            }
        }

        //HÀM MÃ HÓA RSA
        private string EncryptWithRSA(string data, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(Convert.FromBase64String(publicKey));

                // Prepare the data for encryption
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(data);
                int maxBlockSize = (rsa.KeySize / 8) - 42;
                List<byte> encryptedData = new List<byte>();

                // Encrypt the data in blocks
                for (int i = 0; i < dataToEncrypt.Length; i += maxBlockSize)
                {
                    int currentBlockSize = Math.Min(maxBlockSize, dataToEncrypt.Length - i);
                    byte[] dataBlock = new byte[currentBlockSize];
                    Array.Copy(dataToEncrypt, i, dataBlock, 0, currentBlockSize);
                    byte[] encryptedBlock = rsa.Encrypt(dataBlock, true);
                    encryptedData.AddRange(encryptedBlock);
                }

                return Convert.ToBase64String(encryptedData.ToArray());
            }
        }

        //HÀM GIẢI MÃ RSA
        private string DecryptWithRSA(string encryptedData, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(Convert.FromBase64String(privateKey));
                byte[] dataToDecrypt = Convert.FromBase64String(encryptedData);


                List<byte> decryptedBytes = new List<byte>();
                int blockSize = rsa.KeySize / 8;

                for (int i = 0; i < dataToDecrypt.Length; i += blockSize)
                {
                    byte[] block = new byte[Math.Min(blockSize, dataToDecrypt.Length - i)];
                    Array.Copy(dataToDecrypt, i, block, 0, block.Length);

                    byte[] decryptedBlock = rsa.Decrypt(block, true);
                    decryptedBytes.AddRange(decryptedBlock);
                }

                return Encoding.UTF8.GetString(decryptedBytes.ToArray());
            }
        }

        private void FormMaHoaThongTinNV_Load(object sender, EventArgs e)
        {
            hienThiDanhSachNV();
            btnLuuKhoaLAI.Enabled = false;
        }

        void hienThiDanhSachNV()
        {
            string chuoitruyvan = "SELECT TENTKNV, MATKHAU, EMAIL, SDT FROM DuLieu.NHANVIEN";
            dt = db.getDataTable(chuoitruyvan);
            dgv.DataSource = dt;
        }

        //Mã hóa đối xứng
        private void btnMaHoaCS_Click(object sender, EventArgs e)
        {
            if (rdb_doixungCSDL.Checked)
            {
                EncryptCeaser encryptFun = new EncryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["EMAIL"] != DBNull.Value)
                    {
                        string originalAddress = row["EMAIL"].ToString();
                        string encryptedAddress = encryptFun.EncryptCeaser_Func(originalAddress, encryptionKey);
                        row["EMAIL"] = encryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET EMAIL = '{encryptedAddress}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }
                dgv.DataSource = dt;
                MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (rdb_doixungUD.Checked)
            {
                EncryptCeaser encryptFun = new EncryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["EMAIL"] != DBNull.Value)
                    {
                        string originalAddress = row["EMAIL"].ToString();
                        string encryptedAddress = encryptFun.EncryptMessage(originalAddress, encryptionKey);
                        row["EMAIL"] = encryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET EMAIL = '{encryptedAddress}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv.DataSource = dt;
                MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Giải mã Đối Xứng
        private void btnGiaiMaCS_Click(object sender, EventArgs e)
        {
            if (rdb_doixungCSDL.Checked)
            {
                DecryptCeaser decryptFun = new DecryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["EMAIL"] != DBNull.Value)
                    {
                        string encryptedPassword = row["EMAIL"].ToString();
                        string decryptedPassword = decryptFun.DecryptCaesarFunc(encryptedPassword, encryptionKey);
                        row["EMAIL"] = decryptedPassword;


                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET EMAIL = '{decryptedPassword}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }
                dgv.DataSource = dt;
                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rdb_doixungUD.Checked)
            {
                EncryptCeaser encryptFun = new EncryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["EMAIL"] != DBNull.Value)
                    {
                        string plainPassword = row["EMAIL"].ToString();
                        string decryptedPassword = encryptFun.DecryptMessage(plainPassword, encryptionKey);
                        row["EMAIL"] = decryptedPassword;

                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET EMAIL = '{decryptedPassword}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }
                dgv.DataSource = dt;
                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Cập nhật giá trị khóa trên sự kiện numerickey thay đổi giá trị
        private void numericKeyEncrypt_ValueChanged(object sender, EventArgs e)
        {
            encryptionKey = (int)numericKeyEncrypt.Value;
        }

        private void buttonMaHoaRSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoRSACSDL.Checked)
                {
                    // Mã hóa bằng CSDL
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.NHANVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string plainText = row["MATKHAU"].ToString();
                        string encrypted = rsaOracle.encrypt(plainText, txt_publickey.Text);

                        // Cập nhật vào cơ sở dữ liệu
                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET MATKHAU = '{encrypted}' WHERE MATKHAU = '{plainText}'";
                        db.getNonQuery(updateQuery);
                    }
                    MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdoRSAUD.Checked)
                {
                    // Mã hóa bằng ứng dụng
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.NHANVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string plainText = row["MATKHAU"].ToString();
                        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                        {
                            rsa.ImportCspBlob(Convert.FromBase64String(txt_publickey.Text));


                            byte[] data = Encoding.UTF8.GetBytes(plainText);
                            int maxBlockSize = (rsa.KeySize / 8) - 42;
                            List<byte> encryptedData = new List<byte>();


                            for (int i = 0; i < data.Length; i += maxBlockSize)
                            {
                                int currentBlockSize = Math.Min(maxBlockSize, data.Length - i);
                                byte[] dataBlock = new byte[currentBlockSize];
                                Array.Copy(data, i, dataBlock, 0, currentBlockSize);
                                byte[] encryptedBlock = rsa.Encrypt(dataBlock, true);
                                encryptedData.AddRange(encryptedBlock);
                            }


                            string encrypted = Convert.ToBase64String(encryptedData.ToArray());

                            // Cập nhật vào cơ sở dữ liệu
                            string updateQuery = $"UPDATE DuLieu.NHANVIEN SET MATKHAU = '{encrypted}' WHERE MATKHAU = '{plainText}'";
                            db.getNonQuery(updateQuery);
                        }
                        MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGenerateKeyRSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoRSACSDL.Checked)
                {
                    // Tạo khóa CSDL
                    string key = rsaOracle.generateKey(1024);
                    string[] keyPair = key.Split(new string[] {
                        "****publicKey start*****",
                        "****publicKey end**** ****privateKey start****",
                        "****privateKey end**** do not copy asteric(*) ****" }, StringSplitOptions.RemoveEmptyEntries);

                    txt_publickey.Text = keyPair[0].Trim();
                    txt_privatekey.Text = keyPair[1].Trim();
                }
                else if (rdoRSAUD.Checked)
                {
                    // Tạo khóa UD
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                    string publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
                    txt_publickey.Text = publicKey;

                    string privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));
                    txt_privatekey.Text = privateKey;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoRSACSDL.Checked)
            {
                // Lưu trữ public và private keys vào file
                string keysFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RSA_Keys_MucCSDL.txt");
                using (StreamWriter writer = new StreamWriter(keysFilePath))
                {
                    writer.WriteLine($"Public Key: {txt_publickey.Text}");
                    writer.WriteLine($"Private Key: {txt_privatekey.Text}");
                }

                MessageBox.Show("Lưu thông tin khóa RSA thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoRSAUD.Checked)
            {
                string keysFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RSA_Keys_MucUngDung.txt");
                using (StreamWriter writer = new StreamWriter(keysFilePath))
                {
                    writer.WriteLine($"Public Key: {txt_publickey.Text}");
                    writer.WriteLine($"Private Key: {txt_privatekey.Text}");
                }
                MessageBox.Show("Lưu thông tin khóa RSA thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu khóa để lưu!");
            }
        }

        private void buttonGiaiMaRSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoRSACSDL.Checked)
                {
                    // Giải mã bằng CSDL
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.NHANVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string encrypted = row["MATKHAU"].ToString();
                        string decrypted = rsaOracle.decrypt(encrypted, txt_privatekey.Text);

                        // Cập nhật vào cơ sở dữ liệu
                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET MATKHAU = '{decrypted}' WHERE MATKHAU = '{encrypted}'";
                        db.getNonQuery(updateQuery);
                    }

                    MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdoRSAUD.Checked)
                {
                    // Giải mã UD
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.NHANVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string encrypted = row["MATKHAU"].ToString();
                        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                        {
                            rsa.ImportCspBlob(Convert.FromBase64String(txt_privatekey.Text));


                            byte[] encryptedData = Convert.FromBase64String(encrypted);
                            int blockSize = rsa.KeySize / 8;


                            List<byte> decryptedData = new List<byte>();
                            for (int i = 0; i < encryptedData.Length; i += blockSize)
                            {
                                byte[] encryptedBlock = new byte[blockSize];
                                Array.Copy(encryptedData, i, encryptedBlock, 0, blockSize);
                                byte[] decryptedBlock = rsa.Decrypt(encryptedBlock, true);
                                decryptedData.AddRange(decryptedBlock);
                            }


                            string decryptedText = Encoding.UTF8.GetString(decryptedData.ToArray());


                            string updateQuery = $"UPDATE DuLieu.NHANVIEN SET MATKHAU = '{decryptedText}' WHERE MATKHAU = '{encrypted}'";
                            db.getNonQuery(updateQuery);
                        }
                    }

                    MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidFileNameRSA(string fileName)
        {

            string[] expectedFileNames = {
            "RSA_Keys_MucCSDL.txt",
            "RSA_Keys_MucUngDung.txt"
        };


            return expectedFileNames.Any(expectedName =>
                fileName.Equals(expectedName, StringComparison.OrdinalIgnoreCase));
        }

        private void buttonChonTepRSA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                // Kiểm tra tên file
                if (!IsValidFileNameRSA(fileName))
                {
                    MessageBox.Show("Tên tệp không hợp lệ. Vui lòng chọn tệp 'RSA_Keys_MucCSDL.txt' hoặc 'RSA_Keys_MucUngDung.txt'.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 2)
                {
                    txt_publickey.Text = lines[0].Split(':')[1].Trim(); // Lấy public key từ file
                    txt_privatekey.Text = lines[1].Split(':')[1].Trim(); // Lấy private key từ file 

                    labelTepRSA.Text = Path.GetFileName(filePath);
                }
                else
                {
                    MessageBox.Show("Tệp không hợp lệ. Vui lòng chọn tệp chứa khóa RSA.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMaHoaMHLai_Click(object sender, EventArgs e)
        {
            btnLuuKhoaLAI.Enabled = true;
            try
            {
                // Lấy key từ numericUpDownKeyMaHoaLai
                int encryptionKey = (int)numericUpDownKeyMaHoaLai.Value;

                EncryptCeaser encryptFun = new EncryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SDT"] != DBNull.Value)
                    {
                        string originalSDT = row["SDT"].ToString();
                        string encryptedSDT = encryptFun.EncryptMessageSDT(originalSDT, encryptionKey);


                        //Console.WriteLine($"Original SDT: {originalSDT}");
                        //Console.WriteLine($"Encrypted SDT: {encryptedSDT}");

                        row["SDT"] = encryptedSDT;

                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET SDT = '{encryptedSDT}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                // Hiển thị các key lên các textbox tương ứng
                txtKeyMaHoa.Text = EncryptWithRSA(encryptionKey.ToString(), publicKey);
                textBoxPublicKeyMaHoaLai.Text = publicKey;
                textBoxPrivateKeyMaHoaLai.Text = privateKey;

                MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuKhoaLAI_Click(object sender, EventArgs e)
        {
            string keyFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "EncryptionKeysMaHoaLaiSDT.txt");
            using (StreamWriter writer = new StreamWriter(keyFilePath))
            {
                writer.WriteLine($"Public Key: {textBoxPublicKeyMaHoaLai.Text}");
                writer.WriteLine($"Private Key: {textBoxPrivateKeyMaHoaLai.Text}");
                writer.WriteLine($"Encrypted Key: {EncryptWithRSA(encryptionKey.ToString(), publicKey)}");
            }
            MessageBox.Show("Lưu thông tin khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGiaiMaMaHoaLai_Click(object sender, EventArgs e)
        {
            try
            {
                int caesarKey = (int)numericUpDownKeyMaHoaLai.Value;
                EncryptCeaser decryptFun = new EncryptCeaser();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["SDT"] != DBNull.Value)
                    {
                        string encryptedSDT = row["SDT"].ToString();
                        string decryptedSDT = decryptFun.DecryptMessageSDT(encryptedSDT, caesarKey);

                        // Debug 
                        Console.WriteLine($"Original Encrypted SDT: {encryptedSDT}");
                        Console.WriteLine($"Decrypted SDT: {decryptedSDT}");

                        row["SDT"] = decryptedSDT;

                        string updateQuery = $"UPDATE DuLieu.NHANVIEN SET SDT = '{decryptedSDT}' WHERE TENTKNV = '{row["TENTKNV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidFileNameMHLAI(string fileName)
        {

            string expectedFileName = "EncryptionKeysMaHoaLaiSDT.txt";


            return fileName.Equals(expectedFileName, StringComparison.OrdinalIgnoreCase);
        }

        private void btnChonTepMaHoaLai_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                string fileName = Path.GetFileName(filePath);

                // Kiểm tra tên file
                if (!IsValidFileNameMHLAI(fileName))
                {
                    MessageBox.Show("Tên tệp không hợp lệ. Vui lòng chọn tệp 'EncryptionKeysMaHoaLaiSDT.txt'.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 3)
                {
                    // Hiển thị khóa công khai và riêng tư
                    string publicKey = lines[0].Split(':')[1].Trim();
                    string privateKey = lines[1].Split(':')[1].Trim();
                    string encryptedKey = lines[2].Split(':')[1].Trim();

                    // Hiển thị các khóa lên các trường tương ứng
                    textBoxPublicKeyMaHoaLai.Text = publicKey;
                    textBoxPrivateKeyMaHoaLai.Text = privateKey;
                    txtKeyMaHoa.Text = encryptedKey;


                    labelMaHoaLaitxt.Text = Path.GetFileName(filePath);

                    try
                    {
                        // Giải mã khóa Ceaser bằng privateKey
                        string decryptedKey = DecryptWithRSA(encryptedKey, privateKey);

                        // Chuyển khóa Ceaser đã giải mã vào numericUpDownKeyMaHoaLai
                        int caesarKey = int.Parse(decryptedKey);
                        numericUpDownKeyMaHoaLai.Value = caesarKey;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi giải mã khóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tệp không hợp lệ. Vui lòng chọn tệp chứa khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienThiDanhSachNV();
        }
    }
}
