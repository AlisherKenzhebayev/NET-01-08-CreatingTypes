// <copyright file="Solution.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CreatingTypes
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;

    public class Solution
    {
        private static Random rand = new Random();

        public double FindNthRoot(double a, double n, double accuracy)
        {
            if (n < 0 || accuracy < 0 || (a < 0 && n % 2 == 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            double prediction = rand.NextDouble();
            var diff = 1.0;
            do
            {
                /*if (Math.Abs(a - Math.Pow(prediction, n)) <= eps)
                {
                    break;
                }*/

                var newPrediction = ((prediction * (n - 1)) + (a / Math.Pow(prediction, n - 1))) / n;
                diff = Math.Abs(newPrediction - prediction);
                prediction = newPrediction;
            }
            while (diff >= accuracy);

            return prediction;
        }
    }
}
