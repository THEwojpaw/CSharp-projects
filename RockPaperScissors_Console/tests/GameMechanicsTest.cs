using KamienPapierNozyce_Console;

namespace KamienPapierNozyce_Console_Tests
{
    [TestClass]
    public class GameMechanicsTest
    {
        [TestMethod]
        public void Fight_XvsI_return1()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.X;
            ConsoleKey item2 = ConsoleKey.I;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(2 , result);
        }
        [TestMethod]
        public void Fight_XvsO_return2()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.X;
            ConsoleKey item2 = ConsoleKey.O;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1 , result);
        }
        [TestMethod]
        public void Fight_XvsX_return3()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.X;
            ConsoleKey item2 = ConsoleKey.X;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(3 , result);
        }

        [TestMethod]
        public void Fight_IvsX_return1()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.I;
            ConsoleKey item2 = ConsoleKey.X;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_IvsO_return2()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.I;
            ConsoleKey item2 = ConsoleKey.O;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Fight_IvsI_return3()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.I;
            ConsoleKey item2 = ConsoleKey.I;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Fight_OvsX_return1()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.O;
            ConsoleKey item2 = ConsoleKey.X;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Fight_OvsI_return2()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.O;
            ConsoleKey item2 = ConsoleKey.I;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_OvsO_return3()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.O;
            ConsoleKey item2 = ConsoleKey.O;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Fight_EasterEggWithI_returnWin()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.I;
            ConsoleKey item2 = ConsoleKey.L;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1 , result);
        }
        [TestMethod]
        public void Fight_EasterEggWithO_returnWin()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.O;
            ConsoleKey item2 = ConsoleKey.L;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fight_EasterEggWithX_returnWin()
        {
            //arrange
            ConsoleKey item1 = ConsoleKey.X;
            ConsoleKey item2 = ConsoleKey.L;

            //act
            int result = GameMechanics.Fight(item1, item2);

            //assert
            Assert.AreEqual(1, result);
        }
    }
}
