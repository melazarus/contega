using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contega.Interfaces
{
    public interface IRandomGenerator
    {
        void Reset();
        int Next();
        int Peek();
    }
}
