using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormAudit : Form
    {
        private OracleConnection conn;
        public FormAudit()
        {
            InitializeComponent();
            CenterToScreen();
            conn = Database.Get_Connect();

            //Them su kien click vao dong cua bang xem SQL TEXT
            dgvAudit.CellClick += new DataGridViewCellEventHandler(dgvAudit_CellContentClick);

            //Cau hinh cho check list box lua chon viec giam sat
            checkedListBox1.CheckOnClick = true;
        }

        private void FormAudit_Load(object sender, EventArgs e)
        {
            load_Cbo_User(conn);
        }



        private void load_Cbo_User(OracleConnection conn)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("PRO_SELECT_ALL_USERS", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    //Tạo tham số output
                    OracleParameter outParam = new OracleParameter("v_out", OracleDbType.RefCursor);
                    outParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    //Thực thi thủ tục
                    command.ExecuteNonQuery();

                    // Lấy dữ liệu từ tham số output
                    using(OracleDataReader reader = command.ExecuteReader())
                    {
                        cbo_User.Items.Clear();
                        while (reader.Read())
                        {
                            string userName = reader.GetString(0);
                            cbo_User.Items.Add(userName);
                            cbo_User.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi lấy người dùng: "+ ex.Message );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void LoadAuditUser(string user, DataGridView dataGridView, OracleConnection conn)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("PRO_SELECT_AUDIT_TRAIL_USER", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = user;
                    command.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xem bảng audit user được: " + ex.Message);
            }
        }

        private void cbo_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = cbo_User.SelectedItem.ToString();
            LoadAuditUser(user, dgvAudit, conn);
            load_checkListBox_audit_opts(user, conn);
        }

        private void dgvAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                //Lấy giá trị từ cột thứ hai (index = 1) của hàng được chọn
                DataGridViewRow row = dgvAudit.Rows[e.RowIndex];
                string valueFromSecondColumn = row.Cells[8].Value.ToString();

                //Gán giá trị vào textbox
                txtSql.Text = valueFromSecondColumn;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string user = cbo_User.SelectedItem.ToString();
            LoadAuditUser(user, dgvAudit, conn);
            load_checkListBox_audit_opts(user, conn);
        }

        private void load_checkListBox_audit_opts(string user, OracleConnection conn)
        {
            try
            {
                checkedListBox1.Items.Clear();
                using (OracleCommand command = new OracleCommand("PRO_SELECT_STMT_AUDIT_OPTS", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = user;
                    command.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        HashSet<string> uniqueOptions = new HashSet<string>();
                        foreach(DataRow row in dt.Rows)
                        {
                            string auditOption = row["AUDIT_OPTION"].ToString().ToUpper();
                            uniqueOptions.Add(auditOption);
                        }

                        foreach (string option in uniqueOptions)
                        {
                            int index = checkedListBox1.Items.Add(option);
                            checkedListBox1.SetItemChecked(index, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xem bảng audit user được! ", ex.Message);
            }
        }
    }
}
