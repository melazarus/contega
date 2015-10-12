namespace Contega
{
    internal class GameGrid : IGameGrid
    {
        public int Width { get; }
        public int Height { get; }
        public object[,] Grid { get; }

        public GameGrid(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}