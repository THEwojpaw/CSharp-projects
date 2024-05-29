using Kalkulator_txt.BaseOperations;

namespace Kalkulator_txtTests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        public void Calculate_Sum_ProperResult()
        {
            //arrange
            List<int> numbers = new() { 1, 32, 53, 86, 73 };
            string sign = "+";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(245, result);
        }
        [TestMethod]
        public void Calculate_difference_ProperResult() 
        {
            //arrange
            List<int> numbers = new() { 1, 32, 53, 86, 73 };
            string sign = "-";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(-243, result);
        }
        [TestMethod]
        public void Calculate_product_ProperResult()
        {
            //arrange
            List<int> numbers = new() { 1, 32, 53 };
            string sign = "*";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(1696, result);
        }
        [TestMethod]
        public void Calculate_quotient_ProperResult()
        {
            //arrange
            List<int> numbers = new() { 92, 2, 8};
            string sign = "/";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(5.75, result);
        }
        [TestMethod]
        public void Calculate_quotient2_ProperResult()
        {
            //arrange
            List<int> numbers = new() { 92, 2, 8 };
            string sign = ":";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(5.75, result);
        }
        [TestMethod]
        public void Calculate_doubleSign_ErrorResult()
        {
            //arrange
            List<int> numbers = new() { 92, 2, 8 };
            string sign = "++";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Calculate_letterInsteadOfSign_ErrorResult()
        {
            //arrange
            List<int> numbers = new() { 92, 2, 8 };
            string sign = "b";

            //act
            var result = Calculations.Calculate(sign, numbers);

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
