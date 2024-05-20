using Easy_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator_Tests
{
    [TestClass]
    public class SignTests
    {
        [TestMethod]
        public void NotSign()
        {
            double a = 10;
            double b = 5;
            string operation = "a";

            var NotOperation = Counting.Count(a, b, operation);
            Assert.AreEqual(0, NotOperation);
        }
        [TestMethod]
        public void DoubleSign()
        {
            double a = 10;
            double b = 5;
            string operation = "**";

            var DoubleOperation = Counting.Count(a, b, operation);
            Assert.AreEqual(0, DoubleOperation);
        }
    }
}
