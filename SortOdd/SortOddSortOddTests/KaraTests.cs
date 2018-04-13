using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortOdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOdd
{
    [TestClass()]
    public class KaraTests
    {
        [TestMethod()]
        public void SortArrayTest()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }
        [TestMethod()]
        public void SortArrayTest2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }
        [TestMethod()]
        public void SortArrayTest3()
        {
            CollectionAssert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }
        [TestMethod()]
        public void SortArrayTest4()
        {
            CollectionAssert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, Kata.SortArray(new int[] { 2,4,6,8,10}));
        }
    }
}