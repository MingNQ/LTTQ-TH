namespace TH_Bai01
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.cbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPhatLoc = new System.Windows.Forms.RadioButton();
            this.rbThuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayGui);
            this.groupBox1.Controls.Add(this.cbThoiGianGui);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.Location = new System.Drawing.Point(106, 196);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(213, 20);
            this.dtpNgayGui.TabIndex = 17;
            // 
            // cbThoiGianGui
            // 
            this.cbThoiGianGui.FormattingEnabled = true;
            this.cbThoiGianGui.Location = new System.Drawing.Point(106, 229);
            this.cbThoiGianGui.Name = "cbThoiGianGui";
            this.cbThoiGianGui.Size = new System.Drawing.Size(53, 21);
            this.cbThoiGianGui.TabIndex = 16;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(184, 354);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(51, 354);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(75, 23);
            this.btnThemVao.TabIndex = 14;
            this.btnThemVao.Text = "Thêm vào";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thời gian gửi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày gửi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(106, 154);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(163, 20);
            this.txtSoTienGui.TabIndex = 10;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckInt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số tiền gửi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(106, 114);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(213, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(106, 74);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(163, 20);
            this.txtHoTenKH.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(106, 37);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(163, 20);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckInt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã KH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPhatLoc);
            this.groupBox3.Controls.Add(this.rbThuong);
            this.groupBox3.Location = new System.Drawing.Point(18, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rbPhatLoc
            // 
            this.rbPhatLoc.AutoSize = true;
            this.rbPhatLoc.Location = new System.Drawing.Point(166, 19);
            this.rbPhatLoc.Name = "rbPhatLoc";
            this.rbPhatLoc.Size = new System.Drawing.Size(64, 17);
            this.rbPhatLoc.TabIndex = 1;
            this.rbPhatLoc.Text = "Phát lộc";
            this.rbPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rbThuong
            // 
            this.rbThuong.AutoSize = true;
            this.rbThuong.Location = new System.Drawing.Point(23, 19);
            this.rbThuong.Name = "rbThuong";
            this.rbThuong.Size = new System.Drawing.Size(62, 17);
            this.rbThuong.TabIndex = 0;
            this.rbThuong.Text = "Thường";
            this.rbThuong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(372, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(7, 20);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(736, 277);
            this.lstDanhSach.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(863, 367);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(997, 367);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lãi xuất tiết kiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.RadioButton rbPhatLoc;
        private System.Windows.Forms.RadioButton rbThuong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbThoiGianGui;
        private System.Windows.Forms.DateTimePicker dtpNgayGui;
    }
}

