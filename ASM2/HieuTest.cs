using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    
    public class HieuTest
    {
        public int TinhHieu(double a, double b)
        {

            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new ArgumentException("Cả hai số phải là số nguyên.");
            }
            return (int)a - (int)b;
        }

        [Test]
        [TestCase(0, 0, 0)]                       
        [TestCase(1, 0, 1)]                       
        [TestCase(0, 1, -1)]                      
        [TestCase(-1, -1, 0)]                     
        [TestCase(1000, 500, 500)]                
        [TestCase(-2147483646, 1, -2147483647)]   
        [TestCase(2147483647, 1, 2147483646)]     
        public void TinhHieu_ValidInputs(int a, int b, int expected)
        {
            var result = TinhHieu(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1.5, 2)]                       
        [TestCase(2, 3.7)]                       
        [TestCase(1.5, 3.5)]                     
        public void TinhHieu_InvalidInputs(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => TinhHieu(a, b), "Cả hai số phải là số nguyên.");
        }
    }

}

