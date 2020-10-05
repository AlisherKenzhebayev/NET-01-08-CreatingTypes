// <copyright file="Solution.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CreatingTypes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public double FindNthRoot(double a, double n, double accuracy)
        {
            if (n < 0 || accuracy < 0 || (a < 0 && n % 2 == 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            double prediction = accuracy;
            double eps = Math.Min(1e-6, accuracy);

            while (true)
            {
                if (Math.Abs(a - Math.Pow(prediction, n)) <= eps)
                {
                    break;
                }

                prediction = ((prediction * (n - 1)) + (a / Math.Pow(prediction, n - 1))) / n;
            }

            return prediction;
        }
    }
}
