namespace Contega
{
    class GameGrid : IGameGrid
    {
        public int Width { get; }
        public int Height { get; }
        public object[,] Grid { get; }
    }
}