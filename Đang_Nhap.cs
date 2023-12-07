using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_với_CSDL
{
    public partial class Dang_Nhap : Form
    {
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();

        public int CheckTaiKhoan(string tk, string mk)
        {
            string query = "select COUNT(*) from TaiKhoan where taikhoan = '" + tk + "' and matkhau = '" + mk +"'";
            return data.kiemtra(query);
        }
        public void ResetTaiKhoan()
        {
            txt_TK.ResetText();
            txt_MK.ResetText();
            txt_TK.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_TK.Focus();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TK.Text) || string.IsNullOrEmpty(txt_MK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
            }
            else if(CheckTaiKhoan(txt_TK.Text, txt_MK.Text) == 0)
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                GIAO_DIEN f1 = new GIAO_DIEN();
                f1.ShowDialog();
            }
            ResetTaiKhoan();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
