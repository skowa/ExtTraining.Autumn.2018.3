using System.Collections.Generic;

namespace No3.Solution.AverageCalculator
{
    public interface IAverageCalculator
    {
        double CalculateAverage(List<double> values);
    }
}