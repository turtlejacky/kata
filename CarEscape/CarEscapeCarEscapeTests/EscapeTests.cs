using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarEscape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEscape
{
    [TestClass()]
    public class EscapeTests
    {
        Escape escapeObj = new Escape();
        [TestMethod()]
        public void escapeTest()
        {
            var expect = String.Join(",",new string[] { });
            var actual = String.Join(",",escapeObj.escape(new int[,] {{0, 0, 0, 0, 2}}));

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void escapeTest2()
        {
            var expect = "L4,D3,R4";
            var actual = String.Join(",", escapeObj.escape(new int[,] { { 0, 0, 0, 0, 2 },{1,0,0,0,0},{1,0,0,0,0},{0,0,0,0,0} }));

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void escapeTest3()
        {
            var expect = "L4,D1,R4";
            var actual = String.Join(",", escapeObj.escape(new int[,] { { 1, 0, 0, 0, 2 },{ 0, 0, 0, 0, 0 } }));

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void FindTheStartRaw()
        {
            var expect = Tuple.Create(0, 4);
            var actual = escapeObj.FindTheStartRaw(new int[,] { { 0, 0, 0, 0, 2 } });

            Assert.AreEqual(expect, actual);
        }

    }
}