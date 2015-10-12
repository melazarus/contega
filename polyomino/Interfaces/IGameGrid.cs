namespace Contega
{
    public interface IGameGrid
    {
        int Width { get; }
        int Height { get; }

        object[,] Grid { get; }
    }
}