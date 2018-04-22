using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeCoins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCoins.Tests
{
    [TestClass()]
    public class ChangeCoinsTests
    {
        [TestMethod()]
        public void CountCombinationsTest()
        {
            var expect = 3;
            var actual = ChangeCoins.CountCombinations(4, new int[] {1, 2});
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void CountCombinationsTest1()
        {
            var expect = 5;
            var actual = ChangeCoins.CountCombinations(5, new int[] {1, 2, 3});
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void CountCombinationsTest2()
        {
            var expect = 4;
            var actual = ChangeCoins.CountCombinations(10, new[] {5, 2, 3});
            Assert.AreEqual(expect, actual);
        }



    }
}