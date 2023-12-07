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
    public partial class Thong_tin_nhan_vien : Form
    {
        public Thong_tin_nhan_vien()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select * From NhanVien");
            DGV_NhanVien.AutoResizeColumns();
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            txt_Ten.ResetText();
            cbb_GT.SelectedIndex = 0;
            txt_CCCD.ResetText();
            txt_SDT.ResetText();
            txt_CV.ResetText();
            txt_DC.ResetText();
            txt_MNV.Focus();
        }

        private void Thong_tin_nhan_vien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            cbb_GT.Items.Add("Nam");
            cbb_GT.Items.Add("Nữ");
            cbb_GT.SelectedIndex = 0;
            txt_MNV.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_CCCD.Text) || string.IsNullOrEmpty(txt_CV.Text)  || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_DC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien values ('" + txt_MNV.Text + "',N'" + txt_Ten.Text + "','" + Datetime_NS.Value + "','" + txt_CCCD.Text + "',N'" + cbb_GT.Text + "','" + txt_SDT.Text + "',N'" + txt_CV.Text + "',N'" + txt_DC.Text + "')";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_CCCD.Text) || string.IsNullOrEmpty(txt_CV.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_DC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bằng cấp");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update NhanVien  set hoten = N'" + txt_Ten.Text + "', ngaysinh = '" + Datetime_NS.Value + "', cccd = '" + txt_CCCD.Text + "', gioitinh = N'" + cbb_GT.Text + "', sodienthoai = '" + txt_SDT.Text + "',chucvu = N'" + txt_CV.Text + "', diachi = N'" + txt_DC.Text + "' where manv = '" + txt_MNV.Text + "'";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien where manv = '" + txt_MNV.Text + "'";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }
    }
}
