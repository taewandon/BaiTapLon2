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
    public partial class Quan_ly_tai_khoan : Form
    {
        public Quan_ly_tai_khoan()
        {
            InitializeComponent();
        }
        SqlConnect data = new SqlConnect();
        public void LoadTaiKhoan()
        {
            DGV_HopDong.DataSource = data.table("Select * From TaiKhoan");
            DGV_HopDong.AutoResizeColumns();
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckTaiKhoan(string ma)
        {
            string query = "select COUNT(*) from TaiKhoan where taikhoan = '" + ma + "'";
            return data.kiemtra(query);
        }
        public void ResetTaiKhoan()
        {
            txt_TK.ResetText();
            txt_MK.ResetText();
            txt_PQ.ResetText();
            txt_TK.Focus();
        }

        private void Quan_ly_tai_khoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            txt_TK.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TK.Text) || string.IsNullOrEmpty(txt_MK.Text) || string.IsNullOrEmpty(txt_PQ.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
            }
            else if (CheckNhanVien(txt_TK.Text) == 0)
            {
                MessageBox.Show("Tài khoản là mã nhân viên");
            }
            else if (CheckTaiKhoan(txt_TK.Text) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into TaiKhoan values ('" + txt_TK.Text + "',N'" + txt_MK.Text + "',N'" + txt_PQ.Text + "')";
                    data.command(query);
                    LoadTaiKhoan();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetTaiKhoan();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TK.Text) || string.IsNullOrEmpty(txt_MK.Text) || string.IsNullOrEmpty(txt_PQ.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
            }
            else if (CheckTaiKhoan(txt_TK.Text) == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update TaiKhoan set matkhau = N'" + txt_MK.Text + "',phanquyen = N'" + txt_PQ.Text + "' where taikhoan = '" + txt_TK.Text + "'";
                    data.command(query);
                    LoadTaiKhoan();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetTaiKhoan();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TK.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else if (CheckTaiKhoan(txt_TK.Text) == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from TaiKhoan where taikhoan = '" + txt_TK.Text + "'";
                    data.command(query);
                    LoadTaiKhoan();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetTaiKhoan();
        }
    }
}
