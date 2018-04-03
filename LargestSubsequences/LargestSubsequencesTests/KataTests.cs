using Microsoft.VisualStudio.TestTools.UnitTesting;
using LargestSubsequences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSubsequences
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void LargestSumTest_AllNegative()
        {
            var expect = 0;
            var actual = Kata.LargestSum(new[] { -1, -2, -3 });
            Assert.AreEqual(expect,actual);
        }

        [TestMethod()]
        public void LargestSumTest_None()
        {
            var expect = 0;
            var actual = Kata.LargestSum(new int[0]);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void LargestSumTest_1()
        {
            var expect = 10;
            var actual = Kata.LargestSum(new [] { 1, 2, 3, 4 });
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void LargestSumTest_2()
        {
            var expect = 187;
            var actual = Kata.LargestSum(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 });
            Assert.AreEqual(expect, actual);
        }
    }
}