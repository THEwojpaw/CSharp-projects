using Easy_calculator;
namespace EasyCalculator_Tests
{
    [TestClass]
    public class SignTests
    {
        [TestMethod]
        public void CountAndValidateSign_NotSign_ErrorResult()
        {
            //arrange
            double a = 10;
            double b = 5;
            string operation = "a";

            //act
            var NotOperation = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(0, NotOperation);
        }
        [TestMethod]
        public void CountAndValidateSign_DoubleSign_ErrorResult()
        {
            //arrange
            double a = 10;
            double b = 5;
            string operation = "**";

            //act
            var DoubleOperation = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(0, DoubleOperation);
        }
    }
}
