using Kalkulator_txt.BaseOperations;
using Kalkulator_txt.ListOperations;

namespace Kalkulator_txtTests
{
    [TestClass]
    public class ListCreationTests
    {
        [TestMethod]
        public void MatchTest_NormalLineToSplit_ReturnLists()
        {
            //arrange
            string operation = "10+43+15";
            List<string> testSigns = new();
            List<int> testNumbers = new();
            
            //act
            testNumbers = ListConversion.ListOfStringToListOfInt(ListCreation.MatchPatternRangeAndInsertToList(operation, @"\d{1,}"));
            testSigns = ListCreation.MatchPatternRangeAndInsertToList(operation, @"[\+-\/\*:]");

            //assert
            Assert.AreEqual(10, testNumbers[0]);
            Assert.AreEqual(43, testNumbers[1]);
            Assert.AreEqual(15, testNumbers[2]);
            Assert.AreEqual("+", testSigns[0]);
        }
    }
}