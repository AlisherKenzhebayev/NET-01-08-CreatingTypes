// <copyright file="ContextBubbleSortRows.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StrategyBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ContextBubbleSortRows
    {
        private IStrategyBubbleSort strategy;

        public ContextBubbleSortRows(IStrategyBubbleSort strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategyBubbleSort strategy)
        {
            this.strategy = strategy;
        }

        public object DoSortRows(int[][] array, Modes mode = Modes.Ascending)
        {
            this.strategy.SortUsingBubble(array, mode);
            return array;
        }
    }
}
