using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayTwoString
{
    [TestClass]
    public class PlayTwoStringTest
    {

        CombineHelper combineHelper = new CombineHelper();

        [TestMethod]
        public void TestUpperToLower_Or_LowerToUpper()
        {
            Assert.AreEqual('a', combineHelper.UpperToLower_Or_LowerToUpper('A'));
            Assert.AreEqual('A', combineHelper.UpperToLower_Or_LowerToUpper('a'));
            Assert.AreEqual('b', combineHelper.UpperToLower_Or_LowerToUpper('B'));
        }


        [TestMethod]
        public void TestAns1()
        {
            Assert.AreEqual("abCCde", combineHelper.WorkOnStrings("abc", "cde"));
        }
        [TestMethod]
        public void TestAns2()
        {
            Assert.AreEqual("ABABbababa", combineHelper.WorkOnStrings("abab", "bababa"));

        }
        [TestMethod]
        public void TestAns3()
        {
            Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", combineHelper.WorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe"));
        }
        [TestMethod]
        public void TestAns4()
        {
            Assert.AreEqual("abcDEfgDEFGg", combineHelper.WorkOnStrings("abcdeFg", "defgG"));
        }
    }
}
