using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class TichTest
    {
        public int TinhTich(double a, double b)
        {
            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new ArgumentException("Cả 2 số phải là só nguyên");
            }

            return (int)a * (int)b;
        }

        [Test]
        [TestCase(0, 0, 0)]                       
        [TestCase(1, 1, 1)]                       
        [TestCase(-1, -1, 1)]                     
        [TestCase(1000, 1000, 1000000)]           
        [TestCase(-1000, 1000, -1000000)]         
        [TestCase(-2147483647, 1, -2147483647)]   
        [TestCase(2147483647, 1, 2147483647)]     
        public void TinhTich_Test1(int a, int b, int expected)
        {
            var result = TinhTich(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1.5, 2)]                       
        [TestCase(2, 3.7)]                       
        [TestCase(1.5, 3.5)]                     
        public void TinhTich_Test2(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => TinhTich(a, b), "Cả 2 số phải là só nguyên");
        }
    }
}
