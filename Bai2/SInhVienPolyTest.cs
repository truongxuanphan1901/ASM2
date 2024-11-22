using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class SInhVienPolyTest
    {
        static void Main(string[] args)
        {
        }
        private SinhVienPoly sinhVienPoly;

        [SetUp]
        public void Setup()
        {
            sinhVienPoly = new SinhVienPoly();
            sinhVienPoly.AddSinhVien(new SinhVien("1", "Nguyen Van A", "ML01", "Lop1", "SV001"));
            sinhVienPoly.AddSinhVien(new SinhVien("2", "Nguyen Van B", "ML01", "Lop1", "SV002"));
        }

        [Test]
        [TestCase("SV001", "Nguyen Van A", "Lop1", false)]
        [TestCase("SV002", "Nguyen Van B", "Lop1", false)]
        [TestCase("SV003", "Nguyen Thi C", "Lop2", true)]        
        [TestCase("SV002", "Nguyen Thi D", "Lop2", false)]       
        [TestCase("SV004", "Nguyen Thi E", "Lop1", true)]        
        [TestCase("SV001", "Nguyen Thi F", "Lop1", false)]       
        [TestCase("SV005", "Nguyen Thi G", "Lop@3", false)]        
        public void AddSinhVien_TestBoundary(string maSv, string hoTen, string tenLop, bool isValid)
        {
            var sinhVien = new SinhVien("5", hoTen, "ML01", tenLop, maSv);

            if (isValid)
            {
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => sinhVienPoly.AddSinhVien(sinhVien), "Thông tin sinh viên không hợp lệ.");
            }
        }
    }
}
