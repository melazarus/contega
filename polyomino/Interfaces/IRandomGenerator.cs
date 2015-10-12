namespace Contega.Interfaces
{
    /// <summary>
    /// Generate random numbers in a bag.
    /// Start over when the bag is empty.
    /// This ensures that two same numbers are never more than a certain distance away.
    /// </summary>
    public interface IRandomGenerator
    {
        /// <summary>
        /// Reset the bag.
        /// </summary>
        void Reset();

        /// <summary>
        /// Pick the next item from tha bag.
        /// </summary>
        /// <returns></returns>
        int Next();

        /// <summary>
        /// Peek at the next item in the bag
        /// </summary>
        /// <returns></returns>
        int Peek();
    }
}