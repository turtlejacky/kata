using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace getMiddleChar.Tests
{
    [TestClass()]
    public class MiddleCharacterTests
    {
        [DataRow("test", "es", DisplayName = "Length_is_even")]
        [DataRow("testing", "t", DisplayName = "Length_is_Odd")]
        [DataRow("A", "A", DisplayName = "Length_is_1")]
        [DataRow("Hi", "Hi", DisplayName = "Length_is_2")]
        [DataTestMethod]
        public void Get_middle_character(string input, string expected)
        {
            Assert.AreEqual(expected, input.GetMiddleCharacter());
        }
    }
}