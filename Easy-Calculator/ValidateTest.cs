using Easy_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator_Tests
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void String()
        {
            string text = "hocus pocus";

            var txt = Validate.ValidateInput(text, out int a);
            Assert.AreEqual(false, txt);
        }
        [TestMethod]
        public void Int()
        {
            string number = "2137";

            var nmbr = Validate.ValidateInput(number, out int b);
            Assert.AreEqual(true, nmbr);
        }
    }
}