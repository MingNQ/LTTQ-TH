using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Bai01_1
{
    internal class MonHoc
    {
        public string TenMH { get; set; }
        public int SoTin { get; set; }
        public double Diem {  get; set; }

        public MonHoc(string tenMH, int soTin, double diem)
        {
            TenMH = tenMH;
            SoTin = soTin;
            Diem = diem;
        }
    }
}
