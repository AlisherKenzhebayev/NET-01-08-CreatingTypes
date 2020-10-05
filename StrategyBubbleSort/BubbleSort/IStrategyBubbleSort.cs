// <copyright file="IStrategyBubbleSort.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StrategyBubbleSort
{
    using System;
    using System.Collections.Generic;

    public interface IStrategyBubbleSort
    {
        void SortUsingBubble(int[][] data, Modes mode = Modes.Ascending);
    }
}
