using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Darts
{
    [TestClass]
    public class DartsTest
    {
        /*
        [TestCase("X", -133.69, -147.38)]
        [TestCase("DB", 4.06, 0.71)]
        [TestCase("SB", 2.38, -6.06)]
        [TestCase("20", -5.43, 117.95)]
        [TestCase("7", -73.905, -95.94)]
        [TestCase("T2", 55.53, -87.95)]
        [TestCase("D9", -145.19, 86.53)]
        */
        PlayDarts dartsBoard = new PlayDarts();
        [TestMethod]
        public void TestBasic()
        {
            Assert.AreEqual("X",dartsBoard.GetScore(-133.69, -147.38));
            Assert.AreEqual("DB", dartsBoard.GetScore(4.06, 0.71));
            Assert.AreEqual("SB", dartsBoard.GetScore(2.38, -6.06));
            Assert.AreEqual("20", dartsBoard.GetScore(-5.43, 117.95));
            Assert.AreEqual("7", dartsBoard.GetScore(-73.905, -95.94));
            Assert.AreEqual("T2", dartsBoard.GetScore(55.53, -87.95));
            Assert.AreEqual("D9", dartsBoard.GetScore(-145.19, 86.5));

        }
        /*
        [TestMethod]
        public void Test(){
            Assert.AreEqual("T2", dartsBoard.GetDistance(55.53, -87.95));
        }
        */
       
    }
}
