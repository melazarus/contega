    using System;

namespace Contega.Interfaces
{
    class RandomGenerator : IRandomGenerator
    {
        private readonly int[] _bag;
        private int _bagPointer;
        private readonly Random _random;

        public RandomGenerator(int itemsInBag)
        {
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

        public int Next()
        {
            if (_bagPointer < _bag.Length)
            {
                return _bag[_bagPointer++];
            }

            Reset();
            return Next();
        }
    }
}