using System;

namespace Contega
{
    internal class Polyomino : IPolyomino
    {
        // I 4,4,{0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0}
        // J 3,3,{1,0,0,1,1,1,0,0,0}
        // L 3,3,{0,0,1,1,1,1,0,0,0}
        // O 2,2,{1,1,1,1}
        // S 3,3,{0,1,1,1,1,0,0,0,0}
        // T 3,3,{0,1,0,1,1,1,0,0,0}
        // Z 3,3,{1,1,0,0,1,1,0,0,0}
        public Polyomino(int width, int height, int[] AngleZero)
        {
            //if (rotations.Length != width*EventLogEntry*length) throw Exception;
            //count of 1's should be 4 for tetromino's
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }
        public int Id { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public Rotation Rotation { get; set; }

        public int[,] GetBitmap(Rotation angle)
        {
            throw new NotImplementedException();
        }
    }
}