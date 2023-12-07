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
    public partial class Bao_hiem : Form
    {
        public Bao_hiem()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();

        public void LoadBaoHiem()
        {
            DGV_BaoHiem.DataSource = data.table("Select * From BaoHiem ");
            DGV_BaoHiem.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv,sobaohiem,ngaylap,ngayhethan,tienbaohiem from NhanVien_BaoHiem inner join BaoHiem on NhanVien_BaoHiem.mabaohiem = BaoHiem.mabaohiem");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_MBH.DataSource = data.table("Select * From BaoHiem");
            cbb_MBH.DisplayMember = "tenbaohiem";
            cbb_MBH.ValueMember = "mabaohiem";
        }

        public int CheckBaoHiem(string ma)
        {
            string query = "select COUNT(*) from BaoHiem where mabaohiem = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVBH(string manv, string mabh)
        {
            string query = "select COUNT(*) from NhanVien_BaoHiem where manv = '" + manv + "' and mabaohiem = '" + mabh + "'";
            return data.kiemtra(query);
        }

        public void ResetBaoHiem()
        {
            txt_MBH.ResetText();
            txt_TBH.ResetText();
            txt_MBH.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_MBH.SelectedIndex = 0;
            txt_TienBH.ResetText();
            txt_MNV.Focus();
        }
        private void Bao_hiem_Load(object sender, EventArgs e)
        {
            LoadBaoHiem();
            LoadNhanVien();
            LoadComboBox();
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bảo hiểm");
            }
            else if (CheckBaoHiem(txt_MBH.Text) == 1)
            {
                MessageBox.Show("Mã bảo hiểm đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into BaoHiem values ('" + txt_MBH.Text + "',N'" + txt_TBH.Text + "')";
                    data.command(query);
                    LoadBaoHiem();
                    LoadComboBox();
                    LoadNhanVien();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBaoHiem();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
            }
            else if (CheckBaoHiem(txt_MBH.Text) == 0)
            {
                MessageBox.Show("Mã bảo hiểm không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update BaoHiem set tenbaohiem ='" + txt_TBH.Text + "' where mabaohiem ='" + txt_MBH.Text + "'";
                    data.command(query);
                    LoadBaoHiem();
                    LoadComboBox();
                    LoadNhanVien();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBaoHiem();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bảo hiểm");
            }
            else if (CheckBaoHiem(txt_MBH.Text) == 0)
            {
                MessageBox.Show("Mã bảo hiểm không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from BaoHiem where mabaohiem = '" + txt_MBH.Text + "'";
                    data.command(query);
                    LoadBaoHiem();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBaoHiem();
        }

        private void btn_Them2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_MNV.Text)||string.IsNullOrEmpty(cbb_MBH.SelectedIndex.ToString())||string.IsNullOrEmpty(txt_SBH.Text)||string.IsNullOrEmpty(txt_Tien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Check_NVBH(txt_MNV.Text, cbb_MBH.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_BaoHiem values ('" + txt_MNV.Text + "','" + cbb_MBH.SelectedValue.ToString() + "','" + txt_SBH.Text + "','" + dateTime_NL.Value + "','"+datetime_NHH.Value+"',"+txt_TienBH.Text+")";
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

        private void btn_Sua2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else if (Check_NVBH(txt_MNV.Text, cbb_MBH.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần sửa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update NhanVien_BaoHiem set tienbaohiem = " + txt_TienBH.Text + ", sobaohiem ='"+txt_SBH.Text + "', ngaylap='"+dateTime_NL.Value+"', ngayhethan='"+datetime_NHH.Value+"' where manv = '" + txt_MNV.Text + "' and mabaohiem = '" + cbb_MBH.SelectedValue + "' ";
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
            else if (Check_NVBH(txt_MNV.Text, cbb_MBH.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_BaoHiem where manv = '" + txt_MNV.Text + "' and mabaohiem = '" + cbb_MBH.SelectedValue + "'";
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
