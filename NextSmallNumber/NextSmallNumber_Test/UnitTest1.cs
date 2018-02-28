using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextSmallNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NumberClass input = new NumberClass(917);
            var result = input.NextSmaller();
            var expect = 791;
            Assert.AreEqual(expect, result);
        }



        [TestMethod]
        public void TestMethod2()
        {
            NumberClass input = new NumberClass(123456798);
            var result = input.NextSmaller();
            var expect = 123456789;
            Assert.AreEqual(expect, result);
        }


        [TestMethod]
        public void TestMethod3()
        {
            NumberClass input = new NumberClass(59884848483559);
            var result = input.NextSmaller();
            var expect = 59884848459853;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            NumberClass input = new NumberClass(29009);
            var result = input.NextSmaller();
            var expect = 20990;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            NumberClass input = new NumberClass(1027);
            var result = input.NextSmaller();
            var expect = -1;
            Assert.AreEqual(expect, result);
        }



        [TestMethod]
        public void TestFindBiggestOfSmallThanPreIndex()
        {
            NumberClass input = new NumberClass(1023456789);
            var result = input.FindBiggestOfSmallThanPreIndex(1);
            var expect = -1;
            Assert.AreEqual(expect, result);
        }

    }
}
