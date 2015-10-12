using System;

namespace Contega
{
    class Polyomino : IPolyomino
    {
        public int Width { get; }
        public int Height { get; }
        public int Id { get; }

        // I 4,4,{0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0}
        // J 3,3,{1,0,0,1,1,1,0,0,0}
        // L 3,3,{0,0,1,1,1,1,0,0,0}
        // O 2,2,{1,1,1,1}
        // S 3,3,{0,1,1,1,1,0,0,0,0}
        // T 3,3,{0,1,0,1,1,1,0,0,0}
        // Z 3,3,{1,1,0,0,1,1,0,0,0}
        public Polyomino(int width, int height, bool[,] AngleZero)
        {
            //if (rotations.Length != width*EventLogEntry*length) throw Exception;
            //count of 1's should be 4 for tetromino's
            Width = width;
            Height = height;
        }

        public int[,] GetRotated(Rotation angle)
        {
            throw new NotImplementedException();
        }
    }
}