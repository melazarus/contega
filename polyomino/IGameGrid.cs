using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contega
{
    public interface IGameGrid
    {
        int Width { get; }
        int Height { get; }

        object[,] Grid { get; }
    }
}
