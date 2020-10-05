// <copyright file="UnitTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StrategyBubbleSort
{
    using System.Collections.Generic;
    using NUnit.Framework;

    // TODO: jagged Array
    [TestFixture]
    public class UnitTests
    {
        private ContextBubbleSortRows contextMaxElements;
        private ContextBubbleSortRows contextMinElements;
        private ContextBubbleSortRows contextSumElements;

        [SetUp]
        public void SetUp()
        {
            this.contextMaxElements = new ContextBubbleSortRows(new BubbleSortRowsMaxElements());
            this.contextMinElements = new ContextBubbleSortRows(new BubbleSortRowsMinElements());
            this.contextSumElements = new ContextBubbleSortRows(new BubbleSortRowsSumElements());
        }

        [TestCase]
        public void TestMaxElementsAsc()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            var retval = this.contextMaxElements.DoSortRows(array, Modes.Ascending);

            Assert.AreEqual(expected, retval);
        }

        [TestCase]
        public void TestMaxElementsDes()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            int[][] expected =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            var retval = this.contextMaxElements.DoSortRows(array, Modes.Descending);

            Assert.AreEqual(expected, retval);
        }

        [TestCase]
        public void TestMinElementsAsc()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            var retval = this.contextMinElements.DoSortRows(array, Modes.Ascending);

            Assert.AreEqual(expected, retval);
        }

        [TestCase]
        public void TestMinElementsDes()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            int[][] expected =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            var retval = this.contextMinElements.DoSortRows(array, Modes.Descending);

            Assert.AreEqual(expected, retval);
        }


        [TestCase]
        public void TestSumElementsAsc()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            var retval = this.contextSumElements.DoSortRows(array, Modes.Ascending);

            Assert.AreEqual(expected, retval);
        }

        [TestCase]
        public void TestSumElementsDes()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 10 },
                new int[] { 7, 8, 9 },
            };

            int[][] expected =
            {
                new int[] { 4, 5, 6, 10 },
                new int[] { 7, 8, 9 },
                new int[] { 1, 2, 3 },
            };

            var retval = this.contextSumElements.DoSortRows(array, Modes.Descending);

            Assert.AreEqual(expected, retval);
        }
    }
}
