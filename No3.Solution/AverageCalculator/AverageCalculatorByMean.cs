using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.AverageCalculator
{
    public class AverageCalculatorByMean : IAverageCalculator
    {
        public double CalculateAverage(List<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return values.Sum() / values.Count;
        }
    }
}