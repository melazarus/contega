//TODO: allow swap current block with next block
//TODO: allow initial seed of grid with random data or with predefined set of data
//TODO: allow lines to be added on the bottom
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
        object Grid { get; }

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
        object NextBlock { get; }
    }
}