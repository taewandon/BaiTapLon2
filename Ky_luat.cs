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
    public partial class Ky_luat : Form
    {
        public Ky_luat()
        {
            InitializeComponent();
        }
        SqlConnect data = new SqlConnect();

        public void LoadKyLuat()
        {
            DGV_KyLuat.DataSource = data.table("Select * From KyLuat");
            DGV_KyLuat.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv, tenkyluat From NhanVien_KyLuat inner join KyLuat on NhanVien_KyLuat.makyluat = KyLuat.makyluat");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_KL.DataSource = data.table("Select * From KyLuat");
            cbb_KL.DisplayMember = "tenkyluat";
            cbb_KL.ValueMember = "makyluat";
        }

        public int CheckKyLuat(string ma)
        {
            string query = "select COUNT(*) from KyLuat where makyluat = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVKL(string manv, string makl)
        {
            string query = "select COUNT(*) from NhanVien_KyLuat where manv = '" + manv + "' and makyluat = '" + makl + "'";
            return data.kiemtra(query);
        }

        public void ResetKyLuat()
        {
            txt_MKL.ResetText();
            txt_TKL.ResetText();
            txt_TP.ResetText();
            txt_MKL.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_KL.SelectedIndex = 0;
            txt_MNV.Focus();
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKL.Text) || string.IsNullOrEmpty(txt_TKL.Text) || string.IsNullOrEmpty(txt_TP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin kỷ luật");
            }
            else if (CheckKyLuat(txt_MKL.Text) == 1)
            {
                MessageBox.Show("Mã kỷ luật đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into KyLuat values ('" + txt_MKL.Text + "',N'" + txt_TKL.Text + "'," + int.Parse(txt_TP.Text) + ")";
                    data.command(query);
                    LoadKyLuat();
                    LoadComboBox();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKyLuat();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKL.Text) || string.IsNullOrEmpty(txt_TKL.Text) || string.IsNullOrEmpty(txt_TP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin kỷ luật");
            }
            else if (CheckKyLuat(txt_MKL.Text) == 0)
            {
                MessageBox.Show("Mã kỷ luật không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update KyLuat set tenkyluat = N'" + txt_TKL.Text + "', tienphat = " + int.Parse(txt_TP.Text) + " where makyluat ='" + txt_MKL.Text + "'";
                    data.command(query);
                    LoadKyLuat();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKyLuat();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKL.Text))
            {
                MessageBox.Show("Vui lòng nhập mã kỷ luật");
            }
            else if (CheckKyLuat(txt_MKL.Text) == 0)
            {
                MessageBox.Show("Mã kỷ luật không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from KyLuat where makyluat = '" + txt_MKL.Text + "'";
                    data.command(query);
                    LoadKyLuat();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKyLuat();
        }

        private void btn_Them2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (Check_NVKL(txt_MNV.Text, cbb_KL.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_KyLuat values ('" + txt_MNV.Text + "','" + cbb_KL.SelectedValue.ToString() + "')";
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

        private void btn_Xoa2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else if (Check_NVKL(txt_MNV.Text, cbb_KL.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_KyLuat where manv = '" + txt_MNV.Text + "' and makyluat = '" + cbb_KL.SelectedValue + "'";
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

        private void Ky_luat_Load(object sender, EventArgs e)
        {
            LoadKyLuat();
            LoadNhanVien();
            LoadComboBox();
        }
    }
}
