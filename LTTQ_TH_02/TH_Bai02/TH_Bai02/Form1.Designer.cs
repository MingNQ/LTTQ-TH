namespace TH_Bai02
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.rbNuaNgay = new System.Windows.Forms.RadioButton();
            this.rbCaNgay = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.txtGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.rbNuaNgay);
            this.groupBox1.Controls.Add(this.rbCaNgay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.cbSoLuong);
            this.groupBox1.Controls.Add(this.cbDoUong);
            this.groupBox1.Controls.Add(this.txtGiaDuThuyen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(224, 269);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 23);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(61, 269);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(105, 23);
            this.btnThemVao.TabIndex = 15;
            this.btnThemVao.Text = "Thêm Vào DS";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // rbNuaNgay
            // 
            this.rbNuaNgay.AutoSize = true;
            this.rbNuaNgay.Location = new System.Drawing.Point(213, 84);
            this.rbNuaNgay.Name = "rbNuaNgay";
            this.rbNuaNgay.Size = new System.Drawing.Size(73, 17);
            this.rbNuaNgay.TabIndex = 14;
            this.rbNuaNgay.TabStop = true;
            this.rbNuaNgay.Text = "Nửa Ngày";
            this.rbNuaNgay.UseVisualStyleBackColor = true;
            this.rbNuaNgay.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCaNgay
            // 
            this.rbCaNgay.AutoSize = true;
            this.rbCaNgay.Location = new System.Drawing.Point(30, 84);
            this.rbCaNgay.Name = "rbCaNgay";
            this.rbCaNgay.Size = new System.Drawing.Size(66, 17);
            this.rbCaNgay.TabIndex = 13;
            this.rbCaNgay.TabStop = true;
            this.rbCaNgay.Text = "Cả Ngày";
            this.rbCaNgay.UseVisualStyleBackColor = true;
            this.rbCaNgay.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "$";
            // 
            // txtTien
            // 
            this.txtTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtTien.Location = new System.Drawing.Point(293, 196);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(65, 20);
            this.txtTien.TabIndex = 9;
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbSoLuong.Location = new System.Drawing.Point(162, 196);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(90, 21);
            this.cbSoLuong.TabIndex = 8;
            this.cbSoLuong.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbDoUong
            // 
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Items.AddRange(new object[] {
            "Coca cola\t",
            "Pepsi",
            "Seven up"});
            this.cbDoUong.Location = new System.Drawing.Point(30, 196);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(90, 21);
            this.cbDoUong.TabIndex = 7;
            this.cbDoUong.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // txtGiaDuThuyen
            // 
            this.txtGiaDuThuyen.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaDuThuyen.Location = new System.Drawing.Point(119, 120);
            this.txtGiaDuThuyen.Name = "txtGiaDuThuyen";
            this.txtGiaDuThuyen.ReadOnly = true;
            this.txtGiaDuThuyen.Size = new System.Drawing.Size(199, 20);
            this.txtGiaDuThuyen.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(119, 44);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(199, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn Đồ Uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Du Thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(418, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Location = new System.Drawing.Point(22, 28);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(355, 264);
            this.lbDanhSach.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(712, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 24);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(830, 407);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Ty Du Thuyền Hồ Tây";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNuaNgay;
        private System.Windows.Forms.RadioButton rbCaNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.TextBox txtGiaDuThuyen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.Button btnThoat;
    }
}

