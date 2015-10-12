using Contega;
using Contega.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Contega.core
{
    [TestClass]
    public class ContagaGameTests
    {
        [TestMethod]
        [ExpectedException(typeof(GridToSmallException))]
        public void New_ToNarrow_GridToSmallException()
        {
            new ContegaGame(9, 22);
        }

        [TestMethod]
        [ExpectedException(typeof(GridToSmallException))]
        public void New_ToShort_GridToSmallException()
        {
            new ContegaGame(10, 21);
        }

        [TestMethod]
        public void New_10_22_GridSizeCheck()
        {
            var game = new ContegaGame(10, 22);

            Assert.AreEqual(10, game.Grid.Width);
            Assert.AreEqual(22, game.Grid.Height);
        }

        [TestMethod]
        public void ActiveBlock_NotNull()
        {
            var game = new ContegaGame(10, 22);
            
            var block = game.ActiveBlock;

            Assert.IsNotNull(block);
        }

        // test if first block is there
        // test is second block is there
        // test if first 7 blocks contain 7 different values
        // test if tetromino drops on tick
        // test if tetromino stops dropping at bottom
        // test if tetromino stop dropping when hitting other
        // test if move left works
        // test if move right works
        // test if move left stops after hitting wall
        // test if move right stops after hitting wall
        // test if rotate left/right works
        // test if rotated block still hits walls and other blocks
        // test if a full line is detected
        // test if 4 fulle lines are detected
        // test if full lines get removed
        // test if ghost image is correct
        // test if hard drop works
        // test if game over is detected
        // test if reset game works
        // test if block ID's are correctly copied to the grid
        // test if score increases in all situations
        // test if level rises after 10 lines.
        // test if level stops rising after reaching max
        // test is next block moves to active block
    }
}
