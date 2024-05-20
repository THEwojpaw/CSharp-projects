using Easy_calculator.ValidationClasses;

namespace EasyCalculator_Tests
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void ValidateInput_String_FalseResult()
        {
            //arrange
            string text = "hocus pocus";

            //act
            var txt = ValidateInput.ValidateInputType(text, out int a);

            //assert
            Assert.AreEqual(false, txt);
        }
        [TestMethod]
        public void ValidateInput_Int_TrueResult()
        {
            //arrange
            string number = "2137";

            //act
            var nmbr = ValidateInput.ValidateInputType(number, out int b);

            //assert
            Assert.AreEqual(true, nmbr);
        }
    }
}