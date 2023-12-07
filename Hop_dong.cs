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
    public partial class Hop_dong : Form
    {
        public Hop_dong()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();
        public void LoadHopDong()
        {
            DGV_HopDong.DataSource = data.table("Select * From HopDong");
            DGV_HopDong.AutoResizeColumns();
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckHopDong(string manv, string mahd)
        {
            string query = "select COUNT(*) from HopDong where manv = '" + manv + "' and mahopdong = '" + mahd + "'";
            return data.kiemtra(query);
        }
        public void ResetHopDong()
        {
            txt_MNV.ResetText();
            txt_MHD.ResetText();
            txt_THD.ResetText();
            txt_ND.ResetText();
            txt_MNV.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MHD.Text) || string.IsNullOrEmpty(txt_MNV.Text) || string.IsNullOrEmpty(txt_THD.Text) || string.IsNullOrEmpty(txt_ND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp đồng");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else if (CheckHopDong(txt_MNV.Text, txt_MHD.Text) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into HopDong values ('" + txt_MHD.Text + "',N'" + txt_THD.Text + "','" + txt_MNV.Text + "','" + dateTime_NK.Value + "','" + dateTime_NHH.Value + "',N'" + txt_ND.Text + "')";
                    data.command(query);
                    LoadHopDong();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetHopDong();
        }

        private void Hop_dong_Load(object sender, EventArgs e)
        {
            LoadHopDong();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MHD.Text) || string.IsNullOrEmpty(txt_MNV.Text) || string.IsNullOrEmpty(txt_THD.Text) || string.IsNullOrEmpty(txt_ND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp đồng");
            }
            else if (CheckHopDong(txt_MNV.Text, txt_MHD.Text) == 0)
            {
                MessageBox.Show("Thông tin cần sửa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update HopDong set tenhopdong = N'" + txt_THD.Text + "',ngayky = '" + dateTime_NK.Value + "',ngayhethieuluc = '" + dateTime_NHH.Value + "',noidung = N'" + txt_ND.Text + "' where mahopdong = '" + txt_MHD.Text + "' and manv = '" + txt_MNV.Text + "'";
                    data.command(query);
                    LoadHopDong();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetHopDong();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text) || string.IsNullOrEmpty(txt_MHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và mã hợp đồng");
            }
            else if (CheckHopDong(txt_MNV.Text, txt_MHD.Text) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from HopDong where manv = '" + txt_MNV.Text + "' and mahopdong = '" + txt_MHD.Text + "'";
                    data.command(query);
                    LoadHopDong();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetHopDong();
        }
    }
}
