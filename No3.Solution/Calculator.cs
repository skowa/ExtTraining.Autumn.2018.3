using System;
using System.Collections.Generic;
using No3.Solution.AverageCalculator;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> getAverage)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return getAverage(values);
        }

        public double CalculateAverage(List<double> values, IAverageCalculator calculator) =>
            calculator.CalculateAverage(values);
    }
}