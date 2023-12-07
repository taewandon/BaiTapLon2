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
    public partial class HE_THONG : Form
    {
        public HE_THONG()
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

        private void btn_QLTK_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Quan_ly_tai_khoan());
        }
    }
}
