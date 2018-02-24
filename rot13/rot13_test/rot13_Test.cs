using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rot13
{
    [TestClass]
    public class Rot13_Test
    {
        [TestMethod]
        public void Test_pre13_Character_lowerCase()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("abcdefghijklm");
            var expect = "nopqrstuvwxyz";
            Assert.AreEqual( result, expect );
        }
        [TestMethod]
        public void Test_post13_Character_lowerCase()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("nopqrstuvwxyz");
            var expect = "abcdefghijklm";
            Assert.AreEqual(result, expect);
        }
        [TestMethod]
        public void Test_pre13_Character_capital()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("ABCDEFGHIJKLM");
            var expect = "NOPQRSTUVWXYZ";
            Assert.AreEqual(result, expect);
        }
        [TestMethod]
        public void Test_post13_Character_capital()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("NOPQRSTUVWXYZ");
            var expect = "ABCDEFGHIJKLM";
            Assert.AreEqual(result, expect);
        }
        [TestMethod]
        public void Example1()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("EBG13 rknzcyr.");
            var expect = "ROT13 example.";
            Assert.AreEqual(result, expect);
        }
        [TestMethod]
        public void Example2()
        {
            var rotTranslation = new Rot13();
            var result = rotTranslation.Rot13_helper("This is my first ROT13 excercise!");
            var expect = "Guvf vf zl svefg EBG13 rkprepvfr!";
            Assert.AreEqual(result, expect);
        }


    }
}
