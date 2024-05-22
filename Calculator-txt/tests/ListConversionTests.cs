using Kalkulator_txt.Extensives;

namespace Kalkulator_txtTests
{
    [TestClass]
    public class ListConversionTests
    {
        [TestMethod]
        public void ConvertToInt_ListTurnsIntoInt_InputListAsInt()
        {
            //arrange
            List<int> result = new();
            List<string> nbrs = new() { "10", "32", "56", "12" };

            //act
            result = ListConversion.ListOfStringToListOfInt(nbrs);

            //assert
            Assert.AreEqual(32, result[1]);
            Assert.IsInstanceOfType(result, typeof(List<int>));
        }
    }
}
