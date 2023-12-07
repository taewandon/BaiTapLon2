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
    public partial class Khen_thuong : Form
    {
        public Khen_thuong()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();

        public void LoadKhenThuong()
        {
            DGV_KhenThuong.DataSource = data.table("Select * From Khenthuong");
            DGV_KhenThuong.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv, tenkhenthuong From NhanVien_KhenThuong inner join KhenThuong on NhanVien_KhenThuong.makhenthuong = KhenThuong.makhenthuong");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_KT.DataSource = data.table("Select * From KhenThuong");
            cbb_KT.DisplayMember = "tenkhenthuong";
            cbb_KT.ValueMember = "makhenthuong";
        }

        public int CheckKhenThuong(string ma)
        {
            string query = "select COUNT(*) from KhenThuong where makhenthuong = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVKT(string manv, string makt)
        {
            string query = "select COUNT(*) from NhanVien_KhenThuong where manv = '" + manv + "' and makhenthuong = '" + makt + "'";
            return data.kiemtra(query);
        }

        public void ResetKhenThuong()
        {
            txt_MKT.ResetText();
            txt_TKT.ResetText();
            txt_TT.ResetText();
            txt_MKT.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_KT.SelectedIndex = 0;
            txt_MNV.Focus();
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKT.Text) || string.IsNullOrEmpty(txt_TKT.Text) || string.IsNullOrEmpty(txt_TT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khen thưởng");
            }
            else if (CheckKhenThuong(txt_MKT.Text) == 1)
            {
                MessageBox.Show("Mã khen thưởng đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into KhenThuong values ('" + txt_MKT.Text + "',N'" + txt_TKT.Text + "'," + int.Parse(txt_TT.Text)+ ")";
                    data.command(query);
                    LoadKhenThuong();
                    LoadComboBox();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKhenThuong();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKT.Text) || string.IsNullOrEmpty(txt_TKT.Text) || string.IsNullOrEmpty(txt_TT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khen thưởng");
            }
            else if (CheckKhenThuong(txt_MKT.Text) == 0)
            {
                MessageBox.Show("Mã khen thưởng không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update KhenThuong set tenkhenthuong = N'" + txt_TKT.Text + "', tienthuong = " + int.Parse(txt_TT.Text) + " where makhenthuong ='" + txt_MKT.Text + "'";
                    data.command(query);
                    LoadKhenThuong();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKhenThuong();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MKT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khen thưởng");
            }
            else if (CheckKhenThuong(txt_MKT.Text) == 0)
            {
                MessageBox.Show("Mã khen thưởng không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from KhenThuong where makhenthuong = '" + txt_MKT.Text + "'";
                    data.command(query);
                    LoadKhenThuong();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetKhenThuong();
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
            else if (Check_NVKT(txt_MNV.Text, cbb_KT.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_KhenThuong values ('" + txt_MNV.Text + "','" + cbb_KT.SelectedValue.ToString() +"')";
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
            else if (Check_NVKT(txt_MNV.Text, cbb_KT.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_KhenThuong where manv = '" + txt_MNV.Text + "' and makhenthuong = '" + cbb_KT.SelectedValue + "'";
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

        private void Khen_thuong_Load(object sender, EventArgs e)
        {
            LoadKhenThuong();
            LoadNhanVien();
            LoadComboBox();
        }
    }
}
