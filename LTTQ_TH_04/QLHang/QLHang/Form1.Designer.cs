namespace QLHang
{
	partial class frmMatHang
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblTieuDe = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTKMaSP = new System.Windows.Forms.TextBox();
			this.txtTKTenSP = new System.Windows.Forms.TextBox();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDonVi = new System.Windows.Forms.TextBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
			this.dgvMatHang = new System.Windows.Forms.DataGridView();
			this.btnHuy = new System.Windows.Forms.Button();
			this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblTieuDe);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(954, 56);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnThoat);
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnTimKiem);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 449);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(954, 60);
			this.panel2.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTKTenSP);
			this.groupBox1.Controls.Add(this.txtTKMaSP);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(659, 57);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.dtpNgayHH);
			this.groupBox2.Controls.Add(this.dtpNgaySX);
			this.groupBox2.Controls.Add(this.btnLuu);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtGhiChu);
			this.groupBox2.Controls.Add(this.txtDonGia);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtDonVi);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtTenSP);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtMaSP);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Location = new System.Drawing.Point(659, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(295, 393);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chi tiết";
			// 
			// lblTieuDe
			// 
			this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lblTieuDe.AutoSize = true;
			this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTieuDe.Location = new System.Drawing.Point(339, 9);
			this.lblTieuDe.Name = "lblTieuDe";
			this.lblTieuDe.Size = new System.Drawing.Size(255, 31);
			this.lblTieuDe.TabIndex = 0;
			this.lblTieuDe.Text = "Quản lý Sản Phẩm";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(50, 15);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
			this.btnTimKiem.TabIndex = 0;
			this.btnTimKiem.Text = "&Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(180, 15);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(90, 30);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "T&hêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(310, 15);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(90, 30);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "&Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(440, 15);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnXoa.Size = new System.Drawing.Size(90, 30);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "&Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(570, 15);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(90, 30);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Th&oát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvMatHang);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 113);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(659, 336);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kết quả";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã SP:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(310, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên SP:";
			// 
			// txtTKMaSP
			// 
			this.txtTKMaSP.Location = new System.Drawing.Point(70, 17);
			this.txtTKMaSP.Name = "txtTKMaSP";
			this.txtTKMaSP.Size = new System.Drawing.Size(202, 20);
			this.txtTKMaSP.TabIndex = 2;
			// 
			// txtTKTenSP
			// 
			this.txtTKTenSP.Location = new System.Drawing.Point(374, 19);
			this.txtTKTenSP.Name = "txtTKTenSP";
			this.txtTKTenSP.Size = new System.Drawing.Size(202, 20);
			this.txtTKTenSP.TabIndex = 3;
			// 
			// txtMaSP
			// 
			this.txtMaSP.Location = new System.Drawing.Point(81, 22);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(202, 20);
			this.txtMaSP.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mã SP:";
			// 
			// txtTenSP
			// 
			this.txtTenSP.Location = new System.Drawing.Point(81, 57);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(202, 20);
			this.txtTenSP.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tên SP:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Ngày SX:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Ngày HH:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Đơn vị:";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(81, 223);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(202, 20);
			this.txtDonGia.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 227);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Đơn giá:";
			// 
			// txtDonVi
			// 
			this.txtDonVi.Location = new System.Drawing.Point(81, 181);
			this.txtDonVi.Name = "txtDonVi";
			this.txtDonVi.Size = new System.Drawing.Size(202, 20);
			this.txtDonVi.TabIndex = 9;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(81, 267);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(202, 20);
			this.txtGhiChu.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 271);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 17;
			this.label10.Text = "Ghi chú:";
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(54, 323);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(86, 33);
			this.btnLuu.TabIndex = 18;
			this.btnLuu.Text = "&Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// dtpNgaySX
			// 
			this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySX.Location = new System.Drawing.Point(81, 100);
			this.dtpNgaySX.Name = "dtpNgaySX";
			this.dtpNgaySX.Size = new System.Drawing.Size(200, 20);
			this.dtpNgaySX.TabIndex = 7;
			// 
			// dtpNgayHH
			// 
			this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayHH.Location = new System.Drawing.Point(81, 141);
			this.dtpNgayHH.Name = "dtpNgayHH";
			this.dtpNgayHH.Size = new System.Drawing.Size(200, 20);
			this.dtpNgayHH.TabIndex = 8;
			// 
			// dgvMatHang
			// 
			this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMatHang.Location = new System.Drawing.Point(6, 19);
			this.dgvMatHang.Name = "dgvMatHang";
			this.dgvMatHang.Size = new System.Drawing.Size(646, 211);
			this.dgvMatHang.TabIndex = 0;
			this.dgvMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellClick);
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(170, 323);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(86, 33);
			this.btnHuy.TabIndex = 22;
			this.btnHuy.Text = "&Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// errChiTiet
			// 
			this.errChiTiet.ContainerControl = this;
			// 
			// frmMatHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 509);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmMatHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý Sản Phẩm";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblTieuDe;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtTKTenSP;
		private System.Windows.Forms.TextBox txtTKMaSP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpNgayHH;
		private System.Windows.Forms.DateTimePicker dtpNgaySX;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDonVi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTenSP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaSP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.DataGridView dgvMatHang;
		private System.Windows.Forms.ErrorProvider errChiTiet;
	}
}

