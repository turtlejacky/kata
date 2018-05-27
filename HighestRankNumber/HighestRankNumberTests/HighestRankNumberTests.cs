using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighestRankNumber.Tests
{
    [TestClass()]
    public class HighestRankNumberTests
    {
        private HighestRankNumber helper = new HighestRankNumber();

        [TestMethod()]
        public void Test_SameFrequency_Take_Bigger()
        {
            Assert.AreEqual(8, helper.HighestRank(new int[] { 1, 2, 3, 3, 4, 4, 4, 4, 7, 8, 8, 8, 8 }));
        }

        [TestMethod()]
        public void Test_Simple_Case()
        {
            Assert.AreEqual(8, helper.HighestRank(new int[] { 1, 2, 3, 3, 4, 7, 8, 8, 8, 8 }));
        }
    }
}