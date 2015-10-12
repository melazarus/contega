using Contega.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest.Contega.core
{
    [TestClass]
    public class RandomGeneratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void New_zeroIndex_exception()
        {
            var rnd = new RandomGenerator(0);
        }

        [TestMethod]
        public void PeekPeek_equalValue()
        {
            var rnd = new RandomGenerator(7);
            var val1 = rnd.Peek();
            for (var i = 0; i < 100; i++)
            {
                var val2 = rnd.Peek();
                Assert.AreEqual(val1, val2);
            }
        }

        [TestMethod]
        public void PeekNext_equalValue()
        {
            var rnd = new RandomGenerator(7);
            var val1 = rnd.Peek();
            var val2 = rnd.Next();
            Assert.AreEqual(val1, val2);
        }

        [TestMethod]
        public void Next_nTimes_UniqueValues()
        {
            var rnd = new RandomGenerator(7);
            var values = new List<int>();
            for (var i = 0; i < 7; i++)
                values.Add(rnd.Next());

            Assert.AreEqual(7, values.Distinct().Count());
        }
    }
}