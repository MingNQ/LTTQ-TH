using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Bai01_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void AddComboBox()
        {
            cbMonHoc.Items.Add("Tin học đại cương");
            cbMonHoc.Items.Add("Giải tích F1");
            cbMonHoc.Items.Add("Tiếng Anh A0");
            cbMonHoc.Items.Add("Triết học Mác-Lênin");
            cbMonHoc.Items.Add("Vật lý F1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbMonHoc.SelectedIndex)
            {
                case 0: // Tin học đại cương
                    txtSoTinChi.Text = "2";
                    break;
                case 1: // Giải tích F1
                    txtSoTinChi.Text = "3";
                    break;
                case 2: // Tiếng Anh A0
                    txtSoTinChi.Text = "3";
                    break;
                case 3: // Triết học Mác-Lênin
                    txtSoTinChi.Text = "2";
                    break;
                case 4: // Vật lý F1
                    txtSoTinChi.Text = "3";
                    break;
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Chỉ nhập số!");
                e.Handled = true;
            }
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            double diem;
            bool valid = true;
            string message = "";

            if (cbMonHoc.Text == "")
            {
                message += "- Chưa chọn môn học\n";
                valid = false;
            }

            if (!double.TryParse(txtDiem.Text, out diem) || txtDiem.Text == "")
            {
                message += "- Chưa nhập điểm hoặc lỗi nhập điểm!";
                valid = false;
                txtDiem.Focus();
            }

            if (!valid)
            {
                MessageBox.Show(message, "Thông báo!");
                return;
            }

            MonHoc monHoc = new MonHoc(cbMonHoc.Text, Convert.ToInt32(txtSoTinChi.Text), diem);
            lbDanhSachMH.Items.Add(cbMonHoc.Text + " - " + txtSoTinChi.Text + " - " + diem);
            StaticData._MonHoc.Add(monHoc);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (lbDanhSachMH.Items.Count == 0)
            {
                MessageBox.Show("Chưa có môn học trong danh sách!");
                return;
            }

            int tongTinChi = 0;
            double tongDiem = 0;

            StaticData._MonHoc.ForEach(mh => 
            { 
                tongTinChi += mh.SoTin;
                tongDiem += mh.SoTin * mh.Diem;
            });

            double diemTrungBinh = tongDiem / tongTinChi;

            txtTongTinChi.Text = tongTinChi.ToString();
            txtTongDiem.Text = tongDiem.ToString();
            txtDTB.Text = diemTrungBinh.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

    }
}
