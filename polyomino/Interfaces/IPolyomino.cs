namespace Contega
{
    public interface IPolyomino
    {
        int Width { get; }
        int Height { get; }
        int Id { get; }

        int[,] GetRotated(Rotation angle);
    }
}