using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Bai01
{
    public partial class FormTimKiem : Form
    {
        List<NguoiGui> listNguoiGui = new List<NguoiGui>();

        public FormTimKiem()
        {
            InitializeComponent();
            listNguoiGui = StaticData._NguoiGui;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int maKH = Convert.ToInt32(txtMaKH.Text);
            
            foreach (var nguoiGui in listNguoiGui)
            {
                if (nguoiGui.MaKH1 == maKH)
                {
                    rtxtKetQua.Text = string.Format("{0, -15} |{1, -30} |{2, -15}\n", "Mã KH", "Họ tên", "Số tiền nhận");
                    rtxtKetQua.Text += string.Format("{0, -15} |{1, -30} |{2, -15}", nguoiGui.MaKH1, nguoiGui.TenKH1, (nguoiGui.Tien1 + nguoiGui.SoTienGui1));
                    return;
                }
            }

            rtxtKetQua.Text = "Khách hàng có mã " + maKH.ToString() + " chưa có trong danh sách!";
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số nguyên!!");
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
