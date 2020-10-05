// <copyright file="UnitTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CreatingTypes
{
    using System;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using NUnit;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTests
    {
        private Solution solution;

        [SetUp]
        public void SetUp()
        {
            this.solution = new Solution();
        }

        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        public void FindNthRoot_ReturnDouble(double a, double n, double accuracy, double result)
        {
            var retval = this.solution.FindNthRoot(a, n, accuracy);
            Assert.AreEqual(retval, result, 1e-4);
        }

        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.001, -2, 0.0001)]
        [TestCase(0.01, 2, -1)]
        public void FindNthRoot_Number_Degree_Precision_ArgumentOutOfRangeException(double number, int degree, double accuracy) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => this.solution.FindNthRoot(number, degree, accuracy));
    }
}
