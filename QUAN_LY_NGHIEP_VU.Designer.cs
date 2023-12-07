namespace PTUD_với_CSDL
{
    partial class QUAN_LY_NGHIEP_VU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btn_CongTac = new System.Windows.Forms.Button();
            this.btn_DaoTao = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Silver;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(120, 50);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(858, 694);
            this.panel_Body.TabIndex = 14;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(120, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(858, 50);
            this.panel_Top.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nghiệp Vụ";
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Left.Controls.Add(this.btn_CongTac);
            this.panel_Left.Controls.Add(this.btn_DaoTao);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(120, 744);
            this.panel_Left.TabIndex = 12;
            // 
            // btn_CongTac
            // 
            this.btn_CongTac.BackColor = System.Drawing.Color.Gray;
            this.btn_CongTac.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CongTac.ForeColor = System.Drawing.Color.Black;
            this.btn_CongTac.Location = new System.Drawing.Point(0, 150);
            this.btn_CongTac.Name = "btn_CongTac";
            this.btn_CongTac.Size = new System.Drawing.Size(120, 100);
            this.btn_CongTac.TabIndex = 4;
            this.btn_CongTac.Text = "Công tác";
            this.btn_CongTac.UseVisualStyleBackColor = false;
            this.btn_CongTac.Click += new System.EventHandler(this.btn_CongTac_Click);
            // 
            // btn_DaoTao
            // 
            this.btn_DaoTao.BackColor = System.Drawing.Color.Gray;
            this.btn_DaoTao.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DaoTao.ForeColor = System.Drawing.Color.Black;
            this.btn_DaoTao.Location = new System.Drawing.Point(0, 50);
            this.btn_DaoTao.Name = "btn_DaoTao";
            this.btn_DaoTao.Size = new System.Drawing.Size(120, 100);
            this.btn_DaoTao.TabIndex = 3;
            this.btn_DaoTao.Text = "Đào tạo";
            this.btn_DaoTao.UseVisualStyleBackColor = false;
            this.btn_DaoTao.Click += new System.EventHandler(this.btn_DaoTao_Click);
            // 
            // QUAN_LY_NGHIEP_VU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "QUAN_LY_NGHIEP_VU";
            this.Text = "QUAN_LY_NGHIEP_VU";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btn_CongTac;
        private System.Windows.Forms.Button btn_DaoTao;
    }
}