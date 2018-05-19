using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWord.Tests
{
    [TestClass()]
    public class ReverseTests
    {
        private readonly Reverse _reverseHelp = new Reverse();

        [TestMethod]
        public void ReverseSentence_LongSentence()
        {
            Assert.AreEqual("siht si ym !koob", _reverseHelp.ReverseSentence("this is my book!"));
        }

        [TestMethod]
        public void ReverseSentence_Test()
        {
            Assert.AreEqual("cba", _reverseHelp.ReverseSentence("abc"));
        }

        [TestMethod]
        public void ReverseSentence_Test_EndOfDot()
        {
            Assert.AreEqual(".cba", _reverseHelp.ReverseSentence("abc."));
        }

        [TestMethod]
        public void ReverseSentence_Test_EndOfSpace()
        {
            Assert.AreEqual("cba ", _reverseHelp.ReverseSentence("abc "));
        }
    }
}