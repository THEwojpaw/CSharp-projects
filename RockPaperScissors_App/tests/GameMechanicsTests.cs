using KamienPapierNozyce_Console;

namespace KamienPapierNozyce_App_Tests
{
    [TestClass]
    public class GameMechanicsTest
    {
        [TestMethod]
        public void Fight_ScissorsVSStone_1Result()
        {
            //arrange
            int scissors = 3;
            int stone = 1;

            //act
            var result = GameMechanics.Fight(scissors, stone);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_ScissorsVSPaper_2Result()
        {
            //arrange
            int scissors = 3;
            int paper = 2;

            //act
            var result = GameMechanics.Fight(scissors, paper);

            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Fight_ScissorsVSScissors_3Result()
        {
            //arrange
            int scissors = 3;

            //act
            var result = GameMechanics.Fight(scissors, scissors);

            //assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Fight_StoneVSScissors_2Result()
        {
            //arrange
            int scissors = 3;
            int stone = 1;

            //act
            var result = GameMechanics.Fight(stone, scissors);

            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Fight_StoneVSPaper_1Result()
        {
            //arrange
            int paper = 2;
            int stone = 1;

            //act
            var result = GameMechanics.Fight(stone, paper);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_StoneVSStone_3Result()
        {
            //arrange
            int stone = 1;

            //act
            var result = GameMechanics.Fight(stone, stone);

            //assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Fight_PaperVSScissors_1Result()
        {
            //arrange
            int scissors = 3;
            int paper = 2;

            //act
            var result = GameMechanics.Fight(paper, scissors);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_PaperVSStone_2Result()
        {
            //arrange
            int paper = 2;
            int stone = 1;

            //act
            var result = GameMechanics.Fight(paper, stone);

            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Fight_PaperVSPaper_3Result()
        {
            //arrange
            int paper = 2;

            //act
            var result = GameMechanics.Fight(paper, paper);

            //assert
            Assert.AreEqual(3, result);
        }
    }
}