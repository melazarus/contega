using System.CodeDom;

namespace Contega
{
    public class ContegaGame : IContegaGame
    {
        const int MinGridWidth= 10;
        private const int MinGridHeight = 22;

        public ContegaGame(int width, int height)
        {
            if(width < MinGridWidth) throw new GridToSmallException();
            if (height < MinGridHeight) throw new GridToSmallException();

        }

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