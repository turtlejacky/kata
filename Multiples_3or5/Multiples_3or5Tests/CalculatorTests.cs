using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multiples__3or5
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator _calculator = new Calculator();
        [TestMethod()]
        public void SumMultiplesTest_23()
        {
            Assert.AreEqual(23, _calculator.SumMultiples(10));
        }

        [TestMethod()]
        public void SumMultiplesTest_45()
        {
            Assert.AreEqual(45, _calculator.SumMultiples(15));
        }
    }
}