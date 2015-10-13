namespace Contega
{
    public interface IPolyomino
    {
        int Width { get; }
        int Height { get; }
        int Id { get; }

        int X { get; set; }
        int Y { get; set; }
        Rotation Rotation { get; set; }

        int[,] GetBitmap(Rotation angle);
    }
}