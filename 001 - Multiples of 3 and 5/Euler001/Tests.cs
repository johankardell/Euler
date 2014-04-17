using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner;

/*
Multiples of 3 and 5
Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/
namespace Euler001
{
    [TestClass]
    public class Tests
    {
        private CalculatorEngine _engine;

        [TestInitialize]
        public void Init()
        {
            _engine = new CalculatorEngine(10);
        }

        [TestMethod]
        public void TestAllMultiplesOf3Below10Returns3_6_9()
        {
            var actual = _engine.GetMultiplesOf(3);
            var expected = new List<int> { 3, 6, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAllMultiplesOf5Below10Returns5()
        {
            var actual = _engine.GetMultiplesOf(5);
            var expected = new List<int> { 5 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAllMultiplesOf3And5Below10Returns3_5_6_9()
        {
            var actual = _engine.GetMultiplesOf(3, 5);
            var expected = new List<int> { 3, 5, 6, 9 };
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void TestSumOfAllMultiplesOf3And5Below10Returns23()
        {
            var actual = _engine.GetSumMultiplesOf(3, 5);
            Assert.AreEqual(23, actual);
        }

        [TestMethod]
        public void TestAllMultiplesOf3And5Below20Returns3_5_6_9_10_12_15_18()
        {
            _engine = new CalculatorEngine(20);
            var actual = _engine.GetMultiplesOf(3, 5);
            var expected = new List<int> { 3, 5, 6, 9, 10, 12, 15, 18 };
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void TestSumOfAllMultiplesOf3And5Below1000Returns233168()
        {
            _engine = new CalculatorEngine(1000);
            var actual = _engine.GetSumMultiplesOf(3, 5);
            Assert.AreEqual(233168, actual);
        }

    }
}
