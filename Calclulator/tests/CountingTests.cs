using Kalkulator_txt.BaseOperations;

namespace Kalkulator_txtTests
{
    [TestClass]
    public class CountingTests
    {
        [TestMethod]
        public void Count_ValidSum_ProperResult()
        {
            //arrange
            double a = 8;
            double b = 3;
            string operation = "+";

            //act
            double sum = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(11, sum);
        }

        [TestMethod]
        public void Count_ValidDifference_ProperResult()
        {
            //arrange
            double a = 90;
            double b = 15;
            string operation = "-";

            //act
            double difference = Counting.Count(a, b, operation);
            
            //assert
            Assert.AreEqual(75, difference);
        }

        [TestMethod]
        public void Count_ValidProduct_ProperResult()
        {
            //arrange
            double a = 7;
            double b = 7;
            string operation = "*";
            
            //act
            double product = Counting.Count(a, b, operation);
            
            //assert
            Assert.AreEqual(49, product);
        }

        [TestMethod]
        public void Count_ValidQuotient_ProperResult()
        {
            //arrange
            double a = 32;
            double b = 4;
            string operation = "/";
            
            //act
            double quotient = Counting.Count(a, b, operation);
           
            //assert
            Assert.AreEqual(8, quotient);
        }
        [TestMethod]
        public void Count_ValidQuotient2_ProperResult()
        {
            //arrange
            double a = 32;
            double b = 4;
            string operation = ":";
            
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
            string operation = "/";
            
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
            string operation = "a";
           
            //act
            double NotOperation = Counting.Count(a, b, operation);
            
            //assert
            Assert.AreEqual(0, NotOperation);
        }

        [TestMethod]
        public void Count_DoubleSign_ErrorResult()
        {
            //arrange
            double a = 76;
            double b = 12;
            string operation = "**";

            //act
            double NotOperation = Counting.Count(a, b, operation);

            //assert
            Assert.AreEqual(0, NotOperation);
        }

    }
}

