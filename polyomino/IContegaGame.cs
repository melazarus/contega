using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyomino
{
    public interface IContegaGame
    {
        /// <summary>
        /// Advance the game one tick
        /// </summary>
        /// <returns>number of rows elliminated after tick</returns>
        int Tick();

        /// <summary>
        /// Reset the game to its initial state
        /// </summary>
        void Reset();

        object Grid { get; }

        int Score { get; }

        int Level { get; }
    }
}
