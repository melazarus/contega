using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contega
{
    public interface IPolyomino
    {
        int width { get; }
        int height { get; }
        int id { get; }

        int[,] GetRotated(int angle);
    }
}
