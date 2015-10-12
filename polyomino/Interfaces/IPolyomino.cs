using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
