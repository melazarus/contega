//TODO: allow swap current block with next block
//TODO: allow initial seed of grid with random data or with predefined set of data
//TODO: allow lines to be added on the bottom
//TODO: implement random bag generator
//TODO: ghost piece
//TODO: Implement score for T-SPIN
namespace Contega
{
    public interface IContegaGame
    {
        //TODO: add option to do a Hard drop
        /// <summary>
        /// Advance the game one tick
        /// </summary>
        /// <returns>number of rows elliminated after tick</returns>
        int Tick();

        /// <summary>
        /// Moves the active Block left/right
        /// </summary>
        /// <param name="LeftRight"></param>
        /// <returns></returns>
        bool Move(object LeftRight);

        /// <summary>
        /// Reset the game to its initial state (score, level, grid, next block)
        /// </summary>
        void Reset();

        /// <summary>
        /// Try to rotate the active Tetromino clockwise or counter clockwise
        /// </summary>
        /// <param name="direction"></param>
        /// <returns>True if success</returns>
        bool TryRotate(object direction);

        /// <summary>
        /// A 2d array of tetromio enums
        /// </summary>
        IGameGrid Grid { get; }

        /// <summary>
        /// The current score
        /// </summary>
        int Score { get; }

        /// <summary>
        /// The level of the game. Starts at 1.
        /// </summary>
        int Level { get; }

        /// <summary>
        /// Indicate if the game is over or not
        /// </summary>
        bool GameOver { get; }

        /// <summary>
        /// The the next type of tetromino
        /// </summary>
        IPolyomino NextBlock { get; }

        IPolyomino ActiveBlock { get; }
    }
}