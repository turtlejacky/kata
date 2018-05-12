using System;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace PascalTriangle.Tests
{
    [TestClass()]
    public class PascalTriangleHelperTests
    {
        private PascalTriangleHelper _pascalTriangleHelper = new PascalTriangleHelper();

        [TestMethod()]
        public void PascalsTriangleTest_Raw_1()
        {
            var actual = _pascalTriangleHelper.PascalsTriangle(1);
            var expected = new List<int> { 1 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void PascalsTriangleTest_Raw_3()
        {
            var actual = _pascalTriangleHelper.PascalsTriangle(4);
            var expected = new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void PascalsTriangleTest_Raw_5()
        {
            var actual = _pascalTriangleHelper.PascalsTriangle(5);
            var expected = new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}