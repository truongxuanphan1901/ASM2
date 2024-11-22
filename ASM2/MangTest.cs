using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class MangTest
    {
        public int TinhMang(int[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentException("Mảng không được null.");
            }

            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ số ngoài phạm vi mảng.");
            }

            return array[index];
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0, 1)]      
        [TestCase(new int[] { 1, 2, 3 }, 2, 3)]      
        [TestCase(new int[] { 1, 2, 3 }, 1, 2)]      
        public void GetElementAtIndex_ValidInputs(int[] array, int index, int expected)
        {
            var result = TinhMang(array, index);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetElementAtIndex_NullArray_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => TinhMang(null, 0), "Mảng không được null.");
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, -1)]        
        [TestCase(new int[] { 1, 2, 3 }, 3)]         
        public void GetElementAtIndex_IndexOutOfBounds_ThrowsException(int[] array, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => TinhMang(array, index), "Chỉ số ngoài phạm vi mảng.");
        }
    }
}
