namespace TH_Bai01_1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.txtTongTinChi = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDanhSachMH);
            this.groupBox2.Location = new System.Drawing.Point(302, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng số điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm trung bình";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(30, 71);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(229, 21);
            this.cbMonHoc.TabIndex = 3;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoTinChi.Location = new System.Drawing.Point(97, 126);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(162, 20);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(97, 177);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(103, 20);
            this.txtDiem.TabIndex = 5;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(73, 239);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(138, 40);
            this.btnThemDS.TabIndex = 6;
            this.btnThemDS.Text = "Thêm vào DS";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.Location = new System.Drawing.Point(7, 20);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.Size = new System.Drawing.Size(531, 173);
            this.lbDanhSachMH.TabIndex = 0;
            // 
            // txtTongTinChi
            // 
            this.txtTongTinChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongTinChi.Location = new System.Drawing.Point(416, 237);
            this.txtTongTinChi.Name = "txtTongTinChi";
            this.txtTongTinChi.ReadOnly = true;
            this.txtTongTinChi.Size = new System.Drawing.Size(128, 20);
            this.txtTongTinChi.TabIndex = 7;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongDiem.Location = new System.Drawing.Point(666, 237);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(137, 20);
            this.txtTongDiem.TabIndex = 8;
            // 
            // txtDTB
            // 
            this.txtDTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDTB.Location = new System.Drawing.Point(418, 286);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.ReadOnly = true;
            this.txtDTB.Size = new System.Drawing.Size(180, 20);
            this.txtDTB.TabIndex = 9;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(418, 325);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(95, 37);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(708, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 37);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 388);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtTongTinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính điểm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.ListBox lbDanhSachMH;
        private System.Windows.Forms.TextBox txtTongTinChi;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

