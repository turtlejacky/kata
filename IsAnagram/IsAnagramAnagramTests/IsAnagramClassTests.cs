using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsAnagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnagram
{
    [TestClass()]
    public class IsAnagramClassTests
    {
        [TestMethod()]
        public void IsAnagramTestSorted()
        {
            Assert.AreEqual(true, IsAnagramClass.IsAnagram("foefet", "toffee"));
        }
        [TestMethod()]
        public void IsAnagramTestUpperCase()
        {
            Assert.AreEqual(true, IsAnagramClass.IsAnagram("Buckethead", "buckethead"));
        }
        [TestMethod()]
        public void IsAnagramTestSortedAndUpperCase()
        {
            Assert.AreEqual(true, IsAnagramClass.IsAnagram("Twoo", "Woot"));
        }
        [TestMethod()]
        public void IsAnagramTestDifferentLength()
        {
            Assert.AreEqual(false, IsAnagramClass.IsAnagram("apple", "pale"));
        }
    }
}