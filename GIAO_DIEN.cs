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
    public partial class GIAO_DIEN : Form
    {
        public GIAO_DIEN()
        {
            InitializeComponent();
        }

        private Form currentFormBody;
        private void OpenFormBody(Form FormBody)
        {
            if (currentFormBody != null)
            {
                currentFormBody.Close();
            }
            currentFormBody = FormBody;
            FormBody.TopLevel = false;
            FormBody.FormBorderStyle = FormBorderStyle.None;
            FormBody.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(FormBody);
            panel_Body.Tag = FormBody;
            FormBody.BringToFront();
            FormBody.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormBody(new HE_THONG());
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            OpenFormBody(new QUAN_LY_NHAN_VIEN());
        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            OpenFormBody(new CHAM_CONG_LUONG());
        }

        private void btn_QLNVu_Click(object sender, EventArgs e)
        {
            OpenFormBody(new QUAN_LY_NGHIEP_VU());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Dang_Nhap f1 = new Dang_Nhap();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void GIAO_DIEN_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            OpenFormBody(new TIM_KIEM());
        }
    }
}
