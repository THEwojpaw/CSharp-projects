using Easy_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator_Tests
{
    [TestClass]
    public class CountingTests
    {
        [TestMethod]
        public void ValidSum()
        {
            int a = 8;
            int b = 3;
            char operation = '+';

            int sum = Counting.Count(a, b, operation);
            Assert.AreEqual(11, sum);
        }

        [TestMethod]
        public void ValidDifference()
        {
            int a = 90;
            int b = 15;
            char operation = '-';

            int difference = Counting.Count(a, b, operation);
            Assert.AreEqual(75, difference);
        }

        [TestMethod]
        public void ValidProduct()
        {
            int a = 7;
            int b = 7;
            char operation = '*';

            int product = Counting.Count(a, b, operation);
            Assert.AreEqual(49, product);
        }

        [TestMethod]
        public void ValidQuotient()
        {
            int a = 32;
            int b = 4;
            char operation = '/';

            int quotient = Counting.Count(a, b, operation);
            Assert.AreEqual(8, quotient);
        }
        [TestMethod]
        public void ValidQuotient2()
        {
            int a = 32;
            int b = 4;
            char operation = ':';

            int quotient2 = Counting.Count(a, b, operation);
            Assert.AreEqual(8, quotient2);
        }
        [TestMethod]
        public void DivideByZero()
        {
            int a = 32;
            int b = 0;
            char operation = '/';

            int quotient = Counting.Count(a, b, operation);
            Assert.AreEqual(0, quotient);
        }

        [TestMethod]
        public void NotSign()
        {
            int a = 76;
            int b = 12;
            var operation = 'a';

            int NotOperation = Counting.Count(a, b, operation);
            Assert.AreEqual(0, NotOperation);
        }


    }
}

