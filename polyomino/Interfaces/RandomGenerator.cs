using System;

namespace Contega.Interfaces
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly int[] _bag;
        private readonly Random _random;
        private int _bagPointer;

        public RandomGenerator(int itemsInBag)
        {
            if (itemsInBag < 1) throw new ArgumentException("items should be greater than 0");
            _random = new Random();
            _bag = new int[itemsInBag];
            for (var i = 0; i < _bag.Length; i++) _bag[i] = i;
            Reset();
        }

        public void Reset()
        {
            _bagPointer = 0;
            for (var i = 0; i < _bag.Length; i++)
            {
                var ii = _random.Next(_bag.Length);
                if (ii == i) continue;
                var temp = _bag[i];
                _bag[i] = _bag[ii];
                _bag[ii] = temp;
            }
        }

        /// <summary>
        ///     Return the next block and advance the pointer.
        ///     If there are no more blocks in the bag a reset will happen
        /// </summary>
        /// <returns></returns>
        public int Next()
        {
            return GetNextItemFromBag(true);
        }

        /// <summary>
        ///     Return the next block without advancing the pointer.
        ///     If there are no more blocks in the bag a reset will happen
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return GetNextItemFromBag(false);
        }

        private int GetNextItemFromBag(bool advance = true)
        {
            while (true)
            {
                if (!BagEmpty())
                {
                    var returnValue = _bag[_bagPointer];
                    if (advance) _bagPointer++;
                    return returnValue;
                }
                Reset();
            }
        }

        private bool BagEmpty()
        {
            return _bagPointer >= _bag.Length;
        }
    }
}