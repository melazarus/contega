﻿namespace polyomino
{
    class ContegaGame: IContegaGame
    {
        public int Tick()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public bool TryRotate(object direction)
        {
            throw new System.NotImplementedException();
        }

        public object Grid { get; }
        public int Score { get; }
        public int Level { get; }
        public bool GameOver { get; }
        public object NextBlock { get; }
    }
}