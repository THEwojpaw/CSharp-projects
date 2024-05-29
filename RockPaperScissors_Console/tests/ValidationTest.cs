using KamienPapierNozyce_Console;
using System.Numerics;

namespace KamienPapierNozyce_Console_Tests
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void IsSignInGamesRange_InputMatchesRegex_TrueResult()
        {
            //arrange
            string input = "x";

            //act
            bool result = Validation.IsSignInGamesRange(input);

            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsSignInGamesRange_InputDoesntMatchRegex_FalseResult()
        {
            //arrange
            string input = "2";

            //act
            bool result = Validation.IsSignInGamesRange(input);

            //assert
            Assert.IsFalse(result);
        }
    }
}