using Contega.Interfaces;
using System;

namespace Contega
{
    public class ContegaGame : IContegaGame
    {
        private const int MinGridWidth = 10;
        private const int MinGridHeight = 22;
        private const int TetrominoBlockCount = 7;

        public ContegaGame(int width, int height)
        {
            if (width < MinGridWidth) throw new GridToSmallException();
            if (height < MinGridHeight) throw new GridToSmallException();

            Grid = new GameGrid(width, height);
            RandomGenerator = new RandomGenerator(TetrominoBlockCount);

            LoadTetrominos();
        }

        private void LoadTetrominos()
        {
        }

        public IRandomGenerator RandomGenerator { get; set; }

        public int Tick()
        {
            throw new NotImplementedException();
        }

        //todo rename to tryMove
        public bool Move(object LeftRight)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public bool TryRotate(object direction)
        {
            throw new NotImplementedException();
        }

        public IGameGrid Grid { get; }
        public int Score { get; }
        public int Level { get; }
        public bool GameOver { get; }
        public IPolyomino NextBlock { get; }
        public IPolyomino ActiveBlock { get; }
    }
}