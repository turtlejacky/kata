using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMissingInArithmeticProgression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingInArithmeticProgression.Tests
{
    [TestClass()]
    public class FindMissingNumberTests
    {
        private FindMissingNumber _finder = new FindMissingNumber();
        [TestMethod]
        public void FindMissingTest_Gap_2()
        {
            Assert.AreEqual(7,_finder.FindMissing(new List<int>() { 1, 3, 5, 9, 11 }));
        }

        [TestMethod]
        public void FindMissingTest_Gap_5()
        {
            Assert.AreEqual(15, _finder.FindMissing(new List<int>() { 0, 5, 10, 20, 25 }));
        }

        [TestMethod]
        public void FindMissingTest_Gap_180()
        {
            Assert.AreEqual(1400, _finder.FindMissing(new List<int>() { 1040, 1220, 1580 }));
        }
    }
}