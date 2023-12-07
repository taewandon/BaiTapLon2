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
    public partial class CHAM_CONG_LUONG : Form
    {
        public CHAM_CONG_LUONG()
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

        private void btn_BCC_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bang_cham_cong());
        }

        private void btn_KT_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Khen_thuong());
        }

        private void btn_KL_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Ky_luat());
        }

        private void btn_PC_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Phu_cap());
        }

        private void btn_BL_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Luong());
        }

        private void CHAM_CONG_LUONG_Load(object sender, EventArgs e)
        {

        }
    }
}
