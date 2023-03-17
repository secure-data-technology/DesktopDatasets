// Copyright 2023 Jeff Page

using MathNet.Numerics.Statistics;
using System.Collections.Generic;

namespace DataNotebookUI.ApplicationService
{
    public static class DescriptiveStatisticsProvider
    {
        public static double GetMean(IEnumerable<double> data)
        {
            double mean = double.NaN;

            var descriptiveStatistics = new DescriptiveStatistics(data);
            mean = descriptiveStatistics.Mean;
            return mean;
        }
    }
}
