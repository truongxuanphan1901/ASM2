using NUnit.Framework;
using System;

namespace ASM2
{
    public class TongTest
    {
        static void Main(string[] args)
        {
        }

        public int TinhTong(double a, double b)
        {
            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new ArgumentException("Cả hai số phải là số nguyên.");
            }

            
            return (int)a + (int)b;
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 2)]
        [TestCase(-1, -1, -2)]
        [TestCase(10, 5, 15)]
        [TestCase(-10, 5, -5)]
        [TestCase(50001, 1, 50002)]
        [TestCase(-50001, 1, -50000)]
        public void TinhTong_Test1(int a, int b, int expected)
        {
            var result = TinhTong(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1.5, 1)]
        [TestCase(1, 2.2)]
        [TestCase(3.3, 4.4)]
        public void TinhTong_Test2(double a, double b)
        {
            var ex = Assert.Throws<ArgumentException>(() => TinhTong(a, b));
            Assert.That(ex.Message, Is.EqualTo("Cả hai số phải là số nguyên."));
        }
    }
}
