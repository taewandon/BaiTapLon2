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
    public partial class QUAN_LY_NHAN_VIEN : Form
    {
        public QUAN_LY_NHAN_VIEN()
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

        private void btn_TTNV_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Thong_tin_nhan_vien());
        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Phong_ban());
        }

        private void btn_BC_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bang_cap());
        }

        private void btn_CC_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Chung_chi());
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Hop_dong());
        }

        private void btn_BH_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bao_hiem());
        }
    }
}
