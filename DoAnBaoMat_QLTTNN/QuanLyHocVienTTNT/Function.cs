using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace QuanLyHocVienTTNT
{
    class Function
    {
        // List màu sắc cho các form
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};

        // HÀM NÀY CỦA TRÂNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
        public static string CreateKey(string sql)
        {
            string key = "HD" + DateTime.Now.ToString("ddMMyyyy_");
            string chuoitruyvan = sql;

            Database db = new Database();
            DataTable dt = db.getDataTable(chuoitruyvan);

            if (dt.Rows.Count == 0)
            {
                key += "001";
            }
            else
            {

                string maBanDau = dt.Rows[0][0].ToString();
                string sott = maBanDau.Substring(11, 3);
                int num = int.Parse(sott) + 1;
                if (num < 10)
                    key += "00" + num;
                else
                {
                    if (num < 100)
                        key += "0" + num;
                    else
                        key += num;
                }
            }
            return key;

        }

        public static string taoMaBTTuDong(string maLop, string chuoitv)
        {
            string mbt = "BT";
            mbt = mbt + maLop.Trim(' ').ToString() + "_";

            //lấy mã trong csdl
            Database db = new Database();
            DataTable dt = db.getDataTable(chuoitv);
            dt = db.getDataTable(chuoitv);

            if (dt.Rows.Count == 0) //chưa có thì tạo mới
            {
                mbt = mbt + "001";
            }
            else //đã có thì tăng 3 số cuối thêm 1
            {
                string mbtbandau = dt.Rows[0][0].ToString();
                string stt = mbtbandau.Substring(8, 3);
                int so = int.Parse(stt) + 1;
                //bổ sung đủ 3 kí tự (nếu cần)
                if (so < 10)
                    mbt = mbt + "00" + so;
                else
                {
                    if (so < 100)
                        mbt = mbt + "0" + so;
                    else
                        mbt = mbt + so;
                }
            }
            return mbt;
        }

        // Tạo mã tự động cho GiaoVien, Ví dụ: GV001
        public static string TaoMa(string tiento, string sql)
        {
            string key = tiento;
            string chuoitruyvan = sql;
            Database db = new Database();
            DataTable dt = db.getDataTable(chuoitruyvan);

            if (dt.Rows.Count == 0)
            {
                key += "001";
            }
            else
            {

                string maBanDau = dt.Rows[0][0].ToString();
                string sott = maBanDau.Substring(3, 3);
                int num = int.Parse(sott) + 1;
                if (num < 10)
                    key += "00" + num;
                else
                {
                    if (num < 100)
                        key += "0" + num;
                    else
                        key += num;
                }
            }
            return key;

        }

        // Kiểm tra account phải 6 kí tự trở lên và nhỏ hơn 24 kí tự
        public static bool checkAccount(string user)
        {
            return Regex.IsMatch(user, "^[a-zA-z0-9]{6,24}$"); // 6 chữ cái trở lên và nhỏ hơn 24 kí tự
        }

        // Kiểm tra password phải có ít nhất 8 ký tự 1 chữ cái viết hoa, số và kí tự đặc biệt
        public static bool checkPass(string pass)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(pass, pattern);
        }
    }
}
