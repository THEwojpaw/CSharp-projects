using Easy_calculator;

namespace EasyCalculator_Tests
{
    [TestClass]
    public class CountingTests
    {
        [TestMethod]
        public void Count_ValidSum_SumOfEquation()
        {
            //arrange
            double a = 8;
            double b = 3;
            char operation = '+';

            //act
            double sum = Counting.Count(a, b, operation);
            
            //assert
            Assert.AreEqual(11, sum);
        }

        [TestMethod]
        public void Count_ValidDifference_DifferenceOfEquation()
        {
            //arrange
            double a = 90;
            double b = 15;
            char operation = '-';

            //act
            double difference = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(75, difference);
        }

        [TestMethod]
        public void Count_ValidProduct_ProductOfEquation()
        {
            //arrange
            double a = 7;
            double b = 7;
            char operation = '*';

            //act
            double product = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(49, product);
        }

        [TestMethod]
        public void Count_ValidQuotient_QuotientOfEquation()
        {
            //arrange
            double a = 32;
            double b = 4;
            char operation = '/';

            //act
            double quotient = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(8, quotient);
        }
        [TestMethod]
        public void Count_ValidQuotient2_QuotientOfEquation()
        {
            //arrange
            double a = 32;
            double b = 4;
            char operation = ':';

            //act
            double quotient2 = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(8, quotient2);
        }
        [TestMethod]
        public void Count_DivideByZero_ErrorResult()
        {
            //arrange
            double a = 32;
            double b = 0;
            char operation = '/';

            //act
            double quotient = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(0, quotient);
        }

        [TestMethod]
        public void Count_NotSign_ErrorResult()
        {
            //arrange
            double a = 76;
            double b = 12;
            var operation = 'a';

            //act
            double NotOperation = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(0, NotOperation);
        }


    }
}

