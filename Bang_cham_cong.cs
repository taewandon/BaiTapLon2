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

namespace PTUD_với_CSDL
{
    public partial class Bang_cham_cong : Form
    {
        public Bang_cham_cong()
        {
            InitializeComponent();
        }


        SqlConnect data = new SqlConnect();

        public void LoadBangChamCong()
        {
            DGV_BCC.DataSource = data.table("Select * From BangChamCong ");
            DGV_BCC.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv, ngaycong,ngaynghi From NhanVien_ChamCong inner join BangChamCong on NhanVien_ChamCong.mabangchamcong = BangChamCong.mabangchamcong");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_BCC.DataSource = data.table("Select * From BangChamCong");
            cbb_BCC.DisplayMember = "mabangchamcong";
            cbb_BCC.ValueMember = "mabangchamcong";
        }

        public int CheckBangChamCong(string ma)
        {
            string query = "select COUNT(*) from BangChamCong where mabangchamcong = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVCC(string manv, string mabcc)
        {
            string query = "select COUNT(*) from NhanVien_ChamCong where manv = '" + manv + "' and mabangchamcong = '" + mabcc + "'";
            return data.kiemtra(query);
        }

        public void ResetBangChamCong()
        {
            txt_MBCC.ResetText();
    
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_BCC.SelectedIndex = 0;
            txt_NC.ResetText();
            txt_NN.ResetText();
            txt_MNV.Focus();
        }

        private void Bang_cham_cong_Load(object sender, EventArgs e)
        {
            LoadBangChamCong();
            LoadNhanVien();
            LoadComboBox();
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBCC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã bảng chấm công");
            }
            else if (CheckBangChamCong(txt_MBCC.Text) == 1)
            {
                MessageBox.Show("Mã bảng đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into BangChamCong values ('" + txt_MBCC.Text + "','" + Datetime_NBD.Value+ "','"+Datetime_NKT.Value+"')";
                    data.command(query);
                    LoadBangChamCong();
                    LoadComboBox();
                    LoadNhanVien();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangChamCong();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBCC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bảng");
            }
            else if (CheckBangChamCong(txt_MBCC.Text) == 0)
            {
                MessageBox.Show("Mã bảng không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update BangChamCong set ngaybatdau = '" + Datetime_NBD.Value + "', ngayketthuc ='"+Datetime_NKT.Value+"' where mabangchamcong ='" + txt_MBCC.Text + "'";
                    data.command(query);
                    LoadBangChamCong();
                    LoadComboBox();
                    LoadNhanVien();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangChamCong();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bảng");
            }
            else if (CheckBangChamCong(txt_MBCC.Text) == 0)
            {
                MessageBox.Show("Mã bảng không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from BangChamCong where mabangchamcong = '" + txt_MBCC.Text + "'";
                    data.command(query);
                    LoadBangChamCong();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangChamCong();
        }

        private void btn_Them2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên");
            }
            else if (Check_NVCC(txt_MNV.Text, cbb_BCC.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_ChamCong values ('" + txt_MNV.Text + "','" + cbb_BCC.SelectedValue.ToString() + "'," + txt_NC.Text + ","+txt_NN.Text+")";
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
            else if (Check_NVCC(txt_MNV.Text, cbb_BCC.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_ChamCong where manv = '" + txt_MNV.Text + "' and mabangchamcong = '" + cbb_BCC.SelectedValue + "'";
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
            else if (Check_NVCC(txt_MNV.Text, cbb_BCC.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần sửa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update NhanVien_ChamCong set ngaycong = " + txt_NC.Text+ ", ngaynghi ="+txt_NN.Text+ " where manv = '" + txt_MNV.Text + "' and mabangchamcong = '" + cbb_BCC.SelectedValue + "' ";
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
    }
}
