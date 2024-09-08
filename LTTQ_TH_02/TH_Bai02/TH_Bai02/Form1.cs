using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            rbCaNgay.Checked = false;
            rbNuaNgay.Checked = false;
            txtGiaDuThuyen.Text = "";
            cbDoUong.Text = "";
            cbSoLuong.Text = "";
            txtTien.Text = "";
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string message = "";

            if (txtHoTen.Text == "")
            {
                message += "- Chưa nhập họ tên!\n";
                valid = false;
            }

            if (!rbCaNgay.Checked && !rbNuaNgay.Checked)
            {
                message += "- Chưa chọn thời gian thuê\n";
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show(message, "Thông báo!");
                return;
            }

            double tien = txtTien.Text == "" ? 0 : Convert.ToDouble(txtTien.Text);
            double tongTien = Convert.ToInt32(txtGiaDuThuyen.Text) + tien;
            lbDanhSach.Items.Add(txtHoTen.Text + "| " + (rbCaNgay.Checked ? rbCaNgay.Text : rbNuaNgay.Text) + "| " + txtGiaDuThuyen.Text + "$| Đồ uống " + (txtTien.Text == "" ? "0" : txtTien.Text) + "$| Tổng: " + tongTien.ToString() + "$");
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdBtn = sender as RadioButton;
            txtGiaDuThuyen.Text = rdBtn == rbCaNgay ? "200" : "100";
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            double gia = 0;
            switch (cbDoUong.SelectedIndex)
            {
                case 0: // Coca cola
                    gia = 0.5;
                    break;
                case 1: // Pepsi
                    gia = 0.8;
                    break;
                case 2: // Seven up
                    gia = 1;
                    break;
            }

            txtTien.Text = (gia * Convert.ToInt32(cbSoLuong.SelectedItem)).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
