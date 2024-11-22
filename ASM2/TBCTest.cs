using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class TBCTest
    {
        public double TinhTrungBinh(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng.");
            }

            return numbers.Average();
        }
        [Test]
        [TestCase(new double[] { 1, 2, 3 }, 2)]                    
        [TestCase(new double[] { -1, 0, 1 }, 0)]                   
        [TestCase(new double[] { -2, -4, -6 }, -4)]                
        [TestCase(new double[] { 5 }, 5)]                          
        [TestCase(new double[] { 0, 0, 0 }, 0)]                    
        [TestCase(new double[] { 1.5, 2.5, 3.5 }, 2.5)]            
        public void TinhTrungBinh_ValidInputs(double[] numbers, double expected)
        {
            var result = TinhTrungBinh(new List<double>(numbers));
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void TinhTrungBinh_EmptyList_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => TinhTrungBinh(new List<double>()), "Danh sách không được rỗng.");
        }

        [Test]
        public void TinhTrungBinh_NullList_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => TinhTrungBinh(null), "Danh sách không được rỗng.");
        }
    }

}
