using Contega;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Contega.core
{
    [TestClass]
    public class ContagaGame
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
    }
}
