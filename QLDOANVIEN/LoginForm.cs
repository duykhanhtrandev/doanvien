using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using ManageLayer;

namespace QLDOANVIEN
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS01;Initial Catalog=QLDOANVIEN;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUserName.Text;
                string mk = txtPassWord.Text;
                string sql = "select *from tb_TAIKHOAN where TENDANGNHAP='" + tk + "' and MATKHAU='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm f = new MainForm();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kêt nối");
            }
        }

        private void cbPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassWord.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbPassWord_Click(object sender, EventArgs e)
        {

        }
    }
}