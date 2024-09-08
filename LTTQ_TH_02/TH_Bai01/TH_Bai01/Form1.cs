using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TH_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddComboBox()
        {
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            //string title = String.Format("{0, -10} | {1, -30} | {2, -40} | {3, -20} | {4, -15} | {5, -10} | {6, -10}", "Mã KH", "Họ Tên", "Địa chỉ", "Ngày gửi", "Số tiền gửi", "Thời hạn", "Tiền lãi");
            //lstDanhSach.Items.Add(title);
            this.KeyPreview = true;
        }

        private void txtCheckInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số nguyên!!");
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienGui.Text = "";
            dtpNgayGui.Text = "";
            cbThoiGianGui.Text = "";
            cbThoiGianGui.SelectedIndex = -1;
            rbThuong.Checked = false;
            rbPhatLoc.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string message = "";

            if (txtMaKH.TextLength < 6)
            {
                txtMaKH.Focus();
                message += "- Mã KH tối thiểu 6 số\n";
                valid = false;
            }

            if (txtHoTenKH.Text == "" || txtDiaChi.Text == "")
            {
                message += "- Tên hoặc địa chỉ không được rỗng\n";
                valid = false;
            }

            if (txtSoTienGui.Text == "")
            {
                message += "- Số tiền gửi không được rỗng\n";
                valid = false;
            }

            if (cbThoiGianGui.Text == "")
            {
                message += "- Thời gian gửi không được rỗng\n";
                valid = false;
            }

            if (!rbThuong.Checked && !rbPhatLoc.Checked)
            {
                message += "- Loại tiết kiệm chưa chọn\n";
                valid = false;
            }

            double tienLai = 0;
            
            if (!valid)
            {
                MessageBox.Show(message, "Thông báo");
                return;
            }
            else
            {
                switch (cbThoiGianGui.SelectedItem)
                {
                    case "1":
                        tienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.06;
                        break;
                    case "3":
                        tienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;
                        break;
                    case "6":
                        tienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;
                        break;
                    case "12":
                        tienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.09;
                        break;
                }
                
                if (rbPhatLoc.Checked)
                {
                    tienLai += Convert.ToInt32(txtSoTienGui.Text) * 0.01;
                }
            }

            NguoiGui nguoiGui = new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtHoTenKH.Text, txtDiaChi.Text, Convert.ToInt32(txtSoTienGui.Text), dtpNgayGui.Text, cbThoiGianGui.Text, tienLai);

            StaticData._NguoiGui.ForEach(ng =>
            {
                valid = ng.MaKH1 == nguoiGui.MaKH1 ? false : true;
            });

            if (StaticData._NguoiGui.Count == 0 || valid)
            {
                string item = String.Format("{0, -10} | {1, -30} | {2, -40} | {3, -20} | {4, -15} | {5, -10} | {6, -10}", txtMaKH.Text, txtHoTenKH.Text, txtDiaChi.Text, dtpNgayGui.Text, txtSoTienGui.Text, cbThoiGianGui.Text, tienLai);
                lstDanhSach.Items.Add(item);
                lstDanhSach.HorizontalScrollbar = true;
                lstDanhSach.HorizontalExtent = 1000;
                StaticData._NguoiGui.Add(nguoiGui);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();

            form.ShowDialog();
        }
    }
}
