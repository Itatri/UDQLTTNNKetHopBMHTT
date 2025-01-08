using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public partial class FormMaHoaThongTinGV : Form
    {
        Database db = new Database();
        DataTable dt;

        private int encryptionKey;
        private string filePath;

        MaHoaGiaiMaRSA rsaOracle;

        private string publicKey;
        private string privateKey;



        public FormMaHoaThongTinGV()
        {
            InitializeComponent();
            CenterToScreen();
            rsaOracle = new MaHoaGiaiMaRSA();
            GenerateRSAKeys();
        }

        private void GenerateRSAKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false)); // Khóa công khai
                privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true)); // Khóa riêng tư
            }
        }



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
        private void dataGridViewHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void FormMaHoaThongTinGV_Load(object sender, System.EventArgs e)
        {
            hienThiDanhSachGV();
        }

        void hienThiDanhSachGV()
        {
            try
            {
                string chuoitruyvan = "SELECT * FROM DuLieu.GIAOVIEN";
                dt = Database.GetDataTable(chuoitruyvan); // Sử dụng lớp Database
                DataColumn[] key = new DataColumn[1];
                key[0] = dt.Columns["MaGV"]; // Đảm bảo rằng tên cột là "MaGV"
                dt.PrimaryKey = key;

                dgv_GiaoVien.DataSource = dt;

                // Đăng ký sự kiện CellFormatting để xử lý hiển thị mật khẩu
                dgv_GiaoVien.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dgv_GiaoVien.Columns["MatKhau"].Index)
                    {
                        if (e.Value != DBNull.Value)
                        {
                            // Hiển thị mật khẩu dưới dạng dấu sao (*)
                            e.Value = new string('*', e.Value.ToString().Length);
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách giáo viên: " + ex.Message);
            }
        }

        private void checkBoxUngDung_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxUngDungCeaser.Checked)
            {
                checkBoxCSDLCeaser.Checked = false;
            }
        }

        private void checkBoxCSDL_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxCSDLCeaser.Checked)
            {
                checkBoxUngDungCeaser.Checked = false;
            }
        }

        private void btnMaHoaCS_Click(object sender, System.EventArgs e)
        {

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NameEncryptionCSDL.txt");
            if (checkBoxCSDLCeaser.Checked)
            {
                EncryptCeaserT encryptFun = new EncryptCeaserT();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string originalAddress = row["TENTKGV"].ToString();
                        string encryptedAddress = encryptFun.EncryptCeaser_Func(originalAddress, encryptionKey);
                        row["TENTKGV"] = encryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENTKGV = '{encryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;


                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Encryption Key: {encryptionKey}");
                    writer.WriteLine($"Encryption Method: Caesar");
                }
                MessageBox.Show("Tệp lưu trữ thông tin mã hóa EmailEncryptionCSDL.txt đã được tải về Desktop.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (checkBoxUngDungCeaser.Checked)
            {
                EncryptCeaserT encryptFun = new EncryptCeaserT();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string originalAddress = row["TENTKGV"].ToString();
                        string encryptedAddress = encryptFun.EncryptMessage(originalAddress, encryptionKey);
                        row["TENTKGV"] = encryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENTKGV = '{encryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;


                string appFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NameEncryptionCSDL.txt");
                using (StreamWriter writer = new StreamWriter(appFilePath))
                {
                    writer.WriteLine($"Encryption Key: {encryptionKey}");
                    writer.WriteLine($"Encryption Method: Message");
                }
                MessageBox.Show("Tệp lưu trữ thông tin mã hóa EmailEncryptionUngDung.txt đã được tải về Desktop.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        


        private void btnImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                labelTepCS.Text = Path.GetFileName(filePath);
                this.filePath = filePath;
            }


        }



        private void labelTep_Click(object sender, EventArgs e)
        {

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

        // Phương thức kiểm tra tên file cho RSA
        private bool IsValidFileNameRSA(string fileName)
        {

            string[] expectedFileNames = {
            "RSA_Keys_MucCSDL.txt",
            "RSA_Keys_MucUngDung.txt"
        };


            return expectedFileNames.Any(expectedName =>
                fileName.Equals(expectedName, StringComparison.OrdinalIgnoreCase));
        }

        private void buttonDongYRSA_Click(object sender, EventArgs e)
        {

        }

        private void labelTepRSA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrivateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKeyEncryptDES_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            hienThiDanhSachGV();
        }

        private void numericUpDownKeyMaHoaLai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPublicKeyMaHoaLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrivateKeyMaHoaLai_TextChanged(object sender, EventArgs e)
        {

        }




        private void txtKeyMaHoa_TextChanged(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Tên tệp không hợp lệ. Vui lòng chọn tệp 'EncryptionKeysMaHoaLai.txt'.",
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
        // Phương thức kiểm tra tên file
        private bool IsValidFileNameMHLAI(string fileName)
        {

            string expectedFileName = "EncryptionKeysMaHoaLai.txt";


            return fileName.Equals(expectedFileName, StringComparison.OrdinalIgnoreCase);
        }
        private void btnMaHoaLaiKhoa_Click(object sender, EventArgs e)
        {

        }

        private void labelMaHoaLaitxt_Click(object sender, EventArgs e)
        {

        }


        private void btnGiaiMaCS_Click(object sender, EventArgs e)
        {      
            if (checkBoxCSDLCeaser.Checked)
            {
                DecryptCeaser decryptFun = new DecryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string encryptedAddress = row["TENTKGV"].ToString();
                        string decryptedAddress = decryptFun.DecryptCaesarFunc(encryptedAddress, encryptionKey);
                        row["TENTKGV"] = decryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENGV = '{decryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;
            }

            if (checkBoxUngDungCeaser.Checked)
            {
                EncryptCeaserT encryptFun = new EncryptCeaserT();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string originalAddress = row["TENTKGV"].ToString();
                        string decryptedAddress = encryptFun.DecryptMessage(originalAddress, encryptionKey);
                        row["TENTKGV"] = decryptedAddress;

                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENTKGV = '{decryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;
            }   
        }

        private void btnImportFileCS_Click(object sender, EventArgs e)
        {
            if (checkBoxCSDLCeaser.Checked)
            {
                DecryptCeaser decryptFun = new DecryptCeaser();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string encryptedAddress = row["TENTKGV"].ToString();
                        string decryptedAddress = decryptFun.DecryptCaesarFunc(encryptedAddress, encryptionKey);
                        row["TENTKGV"] = decryptedAddress;


                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENTKGV = '{decryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;
            }

            if (checkBoxUngDungCeaser.Checked)
            {
                EncryptCeaserT encryptFun = new EncryptCeaserT();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENTKGV"] != DBNull.Value)
                    {
                        string originalAddress = row["TENTKGV"].ToString();
                        string decryptedAddress = encryptFun.DecryptMessage(originalAddress, encryptionKey);
                        row["TENTKGV"] = decryptedAddress;

                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENTKGV = '{decryptedAddress}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                dgv_GiaoVien.DataSource = dt;
            }
        }

        private void btnDongYCS_Click(object sender, EventArgs e)
        {
            if (checkBoxCSDLCeaser.Checked && (string.IsNullOrEmpty(this.filePath) || !this.filePath.EndsWith("EmailEncryptionCSDL.txt")))
            {
                MessageBox.Show("Vui lòng nhập đúng tệp EmailEncryptionCSDL.txt trước khi giải mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxUngDungCeaser.Checked && (string.IsNullOrEmpty(this.filePath) || !this.filePath.EndsWith("EmailEncryptionUngDung.txt")))
            {
                MessageBox.Show("Vui lòng nhập đúng t��p EmailEncryptionUngDung.txt trước khi giải mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(this.filePath))
            {
                string[] lines = File.ReadAllLines(this.filePath);
                if (lines.Length >= 2)
                {
                    encryptionKey = int.Parse(lines[0].Split(':')[1].Trim());
                    string method = lines[1].Split(':')[1].Trim();

                    DecryptCeaser decryptFun = new DecryptCeaser();
                    EncryptCeaserT encryptFun = new EncryptCeaserT();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["EMAIL"] != DBNull.Value)
                        {
                            string encryptedAddress = row["EMAIL"].ToString();
                            string decryptedAddress = method == "Caesar"
                                ? decryptFun.DecryptCaesarFunc(encryptedAddress, encryptionKey)
                                : encryptFun.DecryptMessage(encryptedAddress, encryptionKey);
                            row["EMAIL"] = decryptedAddress;


                            string updateQuery = $"UPDATE DuLieu.HOCVIEN SET EMAIL = '{decryptedAddress}' WHERE MAHV = '{row["MAHV"]}'";
                            db.getNonQuery(updateQuery);
                        }
                    }
                    dgv_GiaoVien.DataSource = dt;
                }
            }
        }

        private void buttonGenerateKeyRSA_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxCSDLRSA.Checked)
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
                else if (checkBoxUngDungRSA.Checked)
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

        private void buttonMaHoaRSA_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxCSDLRSA.Checked)
                {
                    // Mã hóa bằng CSDL
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.GIAOVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string plainText = row["MATKHAU"].ToString();
                        string encrypted = rsaOracle.encrypt(plainText, txt_publickey.Text);

                        // Cập nhật vào cơ sở dữ liệu
                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET MATKHAU = '{encrypted}' WHERE MATKHAU = '{plainText}'";
                        db.getNonQuery(updateQuery);
                    }

                    // Lưu trữ public và private keys vào file
                    string keysFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RSA_Keys_MucCSDL.txt");
                    using (StreamWriter writer = new StreamWriter(keysFilePath))
                    {
                        writer.WriteLine($"Public Key: {txt_publickey.Text}");
                        writer.WriteLine($"Private Key: {txt_privatekey.Text}");
                    }

                    MessageBox.Show("Mã hóa tất cả địa chỉ thành công bằng mã hóa RSA mức CSDL !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxUngDungRSA.Checked)
                {
                    // Mã hóa bằng ứng dụng
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.GIAOVIEN";
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
                            string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET MATKHAU = '{encrypted}' WHERE MATKHAU = '{plainText}'";
                            db.getNonQuery(updateQuery);
                        }
                    }

                    // Lưu trữ public và private keys vào file
                    string keysFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RSA_Keys_MucUngDung.txt");
                    using (StreamWriter writer = new StreamWriter(keysFilePath))
                    {
                        writer.WriteLine($"Public Key: {txt_publickey.Text}");
                        writer.WriteLine($"Private Key: {txt_privatekey.Text}");
                    }

                    MessageBox.Show("Mã hóa tất cả địa chỉ thành công bằng mã hóa RSA mức ứng dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            hienThiDanhSachGV();
        }

        private void buttonGiaiMaRSA_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxCSDLRSA.Checked)
                {
                    // Giải mã bằng CSDL
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.GIAOVIEN";
                    DataTable dt = db.getDataTable(chuoitruyvan);

                    foreach (DataRow row in dt.Rows)
                    {
                        string encrypted = row["MATKHAU"].ToString();
                        string decrypted = rsaOracle.decrypt(encrypted, txt_privatekey.Text);

                        // Cập nhật vào cơ sở dữ liệu
                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET MATKHAU = '{decrypted}' WHERE MATKHAU = '{encrypted}'";
                        db.getNonQuery(updateQuery);
                    }

                    MessageBox.Show("Giải mã tất cả địa chỉ thành công bằng mã hóa RSA mức CSDL !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxUngDungRSA.Checked)
                {
                    // Giải mã UD
                    string chuoitruyvan = "SELECT MATKHAU FROM DuLieu.GIAOVIEN";
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


                            string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET MATKHAU = '{decryptedText}' WHERE MATKHAU = '{encrypted}'";
                            db.getNonQuery(updateQuery);
                        }
                    }

                    MessageBox.Show("Giải mã tất cả địa chỉ thành công bằng mã hóa RSA mức ứng dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            hienThiDanhSachGV();
        }

        private void numericKeyEncrypt_ValueChanged_1(object sender, EventArgs e)
        {
            encryptionKey = (int)numericKeyEncrypt.Value;
        }

        private void checkBoxUngDungRSA_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxUngDungRSA.Checked)
            {
                checkBoxCSDLRSA.Checked = false;
            }
        }

        private void checkBoxCSDLRSA_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxCSDLRSA.Checked)
            {
                checkBoxUngDungRSA.Checked = false;
            }
        }

        private void buttonTaiLai_Click_1(object sender, EventArgs e)
        {
            hienThiDanhSachGV();
        }

        private void btnMaHoaMHLai_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy key từ numericUpDownKeyMaHoaLai
                int encryptionKey = (int)numericUpDownKeyMaHoaLai.Value;

                EncryptCeaserT encryptFun = new EncryptCeaserT();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENGV"] != DBNull.Value)
                    {
                        string originalNAME = row["TENGV"].ToString();
                        string encryptedNAME = encryptFun.EncryptMessageNAME(originalNAME, encryptionKey);


                        Console.WriteLine($"Original TENGV: {originalNAME}");
                        Console.WriteLine($"Encrypted TENGV: {encryptedNAME}");

                        row["TENGV"] = encryptedNAME;

                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENGV = '{encryptedNAME}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                // Lưu thông tin vào tệp
                string keyFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "EncryptionKeysMaHoaLai.txt");
                using (StreamWriter writer = new StreamWriter(keyFilePath))
                {
                    writer.WriteLine($"Public Key: {publicKey}");
                    writer.WriteLine($"Private Key: {privateKey}");
                    writer.WriteLine($"Encrypted Key: {EncryptWithRSA(encryptionKey.ToString(), publicKey)}");
                }

                // Hiển thị các key lên các textbox tương ứng
                txtKeyMaHoa.Text = EncryptWithRSA(encryptionKey.ToString(), publicKey);
                textBoxPublicKeyMaHoaLai.Text = publicKey;
                textBoxPrivateKeyMaHoaLai.Text = privateKey;

                MessageBox.Show("Mã hóa tất cả Tên Giáo Viên thành công! Thông tin key đã được lưu vào EncryptionKeysMaHoaLai.txt trên Desktop.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiMaMaHoaLai_Click_1(object sender, EventArgs e)
        {
            try
            {
                int caesarKey = (int)numericUpDownKeyMaHoaLai.Value;
                EncryptCeaserT decryptFun = new EncryptCeaserT();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["TENGV"] != DBNull.Value)
                    {
                        string encryptedNAME = row["TENGV"].ToString();
                        string decryptedNAME = decryptFun.DecryptMessageNAME(encryptedNAME, caesarKey);

                        // Debug 
                        Console.WriteLine($"Original Encrypted NAME: {encryptedNAME}");
                        Console.WriteLine($"Decrypted NAME: {decryptedNAME}");

                        row["TENGV"] = decryptedNAME;

                        string updateQuery = $"UPDATE DuLieu.GIAOVIEN SET TENGV = '{decryptedNAME}' WHERE MAGV = '{row["MAGV"]}'";
                        db.getNonQuery(updateQuery);
                    }
                }

                MessageBox.Show("Giải mã tên giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownKeyMaHoaLai_ValueChanged_1(object sender, EventArgs e)
        {
            encryptionKey = (int)numericKeyEncrypt.Value;
        }
    }
}
