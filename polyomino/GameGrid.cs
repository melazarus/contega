namespace Contega
{
    internal class GameGrid : IGameGrid
    {
        public GameGrid(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }
        public object[,] Grid { get; }
    }
}