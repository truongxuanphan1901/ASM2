using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVienPoly
    {
        private List<SinhVien> sinhViens = new List<SinhVien>();

        public void AddSinhVien(SinhVien sinhVien)
        {
            if (string.IsNullOrEmpty(sinhVien.TenLop) || sinhVien.TenLop.Any(ch => !char.IsLetterOrDigit(ch) && ch != ' '))
            {
                throw new ArgumentException("Tên lớp không được chứa ký tự đặc biệt.");
            }
            if (string.IsNullOrEmpty(sinhVien.MaSV) || !sinhVien.MaSV.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Mã sinh viên không hợp lệ.");
            }

            if (sinhViens.Any(sv => sv.MaSV == sinhVien.MaSV))
            {
                throw new ArgumentException("Mã sinh viên không được trùng lặp.");
            }

            if (sinhVien.TenLop.Any(ch => !Char.IsLetterOrDigit(ch) && ch != ' '))
            {
                throw new ArgumentException("Tên lớp không được chứa ký tự đặc biệt.");
            }

            if (string.IsNullOrEmpty(sinhVien.HoTen))
            {
                throw new ArgumentException("Tên sinh viên không được để trống.");
            }
            sinhViens.Add(sinhVien);
        }

        public List<SinhVien> TimKiemTen(string hoTen)
        {
            return sinhViens.Where(sv => sv.HoTen.Contains(hoTen)).ToList();
        }

        public List<SinhVien> TimKiemMaLop(string maLop)
        {
            return sinhViens.Where(sv => sv.MaLop == maLop).ToList();
        }

        public SinhVien TimKiemMaSv(string masv)
        {
            return sinhViens.FirstOrDefault(sv => sv.MaSV == masv);
        }
    }
}
