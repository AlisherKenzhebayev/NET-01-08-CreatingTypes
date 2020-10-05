// <copyright file="BubbleSortRowsSumElements.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StrategyBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BubbleSortRowsSumElements : IStrategyBubbleSort
    {
        public void SortUsingBubble(int[][] data, Modes mode = Modes.Ascending)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (this.Helper(data[j], data[j + 1], mode))
                    {
                        var t = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = t;
                    }
                }
            }
        }

        private bool Helper(int[] f, int[] s, Modes mode)
        {
            if (mode == Modes.Ascending)
            {
                return f.Sum() > s.Sum();
            }
            else
            {
                return f.Sum() < s.Sum();
            }
        }
    }
}
