namespace PTUD_với_CSDL
{
    partial class Hop_dong
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.DGV_HopDong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_NK = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_THD = new System.Windows.Forms.TextBox();
            this.txt_MHD = new System.Windows.Forms.TextBox();
            this.txt_MNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_NHH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HopDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Sua.Location = new System.Drawing.Point(757, 195);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(161, 51);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Xoa.Location = new System.Drawing.Point(757, 278);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(161, 51);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa thông tin";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Them.Location = new System.Drawing.Point(757, 113);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(161, 51);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm thông tin";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // DGV_HopDong
            // 
            this.DGV_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HopDong.Location = new System.Drawing.Point(60, 461);
            this.DGV_HopDong.Name = "DGV_HopDong";
            this.DGV_HopDong.RowHeadersWidth = 62;
            this.DGV_HopDong.RowTemplate.Height = 28;
            this.DGV_HopDong.Size = new System.Drawing.Size(858, 250);
            this.DGV_HopDong.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_NHH);
            this.groupBox1.Controls.Add(this.txt_ND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTime_NK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_THD);
            this.groupBox1.Controls.Add(this.txt_MHD);
            this.groupBox1.Controls.Add(this.txt_MNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 373);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp đồng";
            // 
            // txt_ND
            // 
            this.txt_ND.Location = new System.Drawing.Point(194, 307);
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(413, 33);
            this.txt_ND.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nội dung:";
            // 
            // dateTime_NK
            // 
            this.dateTime_NK.Location = new System.Drawing.Point(194, 195);
            this.dateTime_NK.Name = "dateTime_NK";
            this.dateTime_NK.Size = new System.Drawing.Size(413, 33);
            this.dateTime_NK.TabIndex = 9;
            this.dateTime_NK.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày ký:";
            // 
            // txt_THD
            // 
            this.txt_THD.Location = new System.Drawing.Point(196, 139);
            this.txt_THD.Name = "txt_THD";
            this.txt_THD.Size = new System.Drawing.Size(343, 33);
            this.txt_THD.TabIndex = 6;
            // 
            // txt_MHD
            // 
            this.txt_MHD.Location = new System.Drawing.Point(196, 86);
            this.txt_MHD.Name = "txt_MHD";
            this.txt_MHD.Size = new System.Drawing.Size(178, 33);
            this.txt_MHD.TabIndex = 5;
            // 
            // txt_MNV
            // 
            this.txt_MNV.Location = new System.Drawing.Point(196, 37);
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Size = new System.Drawing.Size(178, 33);
            this.txt_MNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hợp đồng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dateTime_NHH
            // 
            this.dateTime_NHH.Location = new System.Drawing.Point(194, 250);
            this.dateTime_NHH.Name = "dateTime_NHH";
            this.dateTime_NHH.Size = new System.Drawing.Size(413, 33);
            this.dateTime_NHH.TabIndex = 14;
            this.dateTime_NHH.Value = new System.DateTime(2024, 5, 24, 0, 0, 0, 0);
            // 
            // Hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.DGV_HopDong);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hop_dong";
            this.Text = "Hop_dong";
            this.Load += new System.EventHandler(this.Hop_dong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HopDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView DGV_HopDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime_NK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_THD;
        private System.Windows.Forms.TextBox txt_MHD;
        private System.Windows.Forms.TextBox txt_MNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_NHH;
    }
}