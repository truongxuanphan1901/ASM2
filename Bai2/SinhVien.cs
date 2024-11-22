using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien
    {
        public string Id;
        public string HoTen;
        public string MaLop;
        public string TenLop;
        public string MaSV;
        public SinhVien() { }
        public SinhVien(string id, string hoTen, string maLop, string tenLop, string maSV)
        {
            Id = id;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
            MaSV = maSV;
        }
    }
}
