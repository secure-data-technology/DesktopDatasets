// Copyright 2023 Jeff Page

using CommunityToolkit.Mvvm.ComponentModel;
using DataNotebookUI.ApplicationService;
using System.Collections.Generic;

namespace DataNotebookUI.ViewModel
{
    public class StatisticsViewModel : ObservableObject
    {
        public StatisticsViewModel()
        {
            DataPoints = new List<double>();
            Mean = double.NaN;
            StandardDeviation = double.NaN;
        }

        private List<double> dataPoints;
        public List<double> DataPoints
        {
            get => dataPoints;
            set
            {
                if (dataPoints != value)
                {
                    dataPoints = value;
                    Mean = DescriptiveStatisticsProvider.GetMean(dataPoints);
                   StandardDeviation = DescriptiveStatisticsProvider.GetStandardDeviation(dataPoints);
                }
            }
        }

        private double mean;
        public double Mean       
        { 
            get => mean; 
            private set
            {
                SetProperty(ref mean, value);
            }
        }

        private double standardDeviation;
        public double StandardDeviation 
        { 
            get => standardDeviation;
            private set
            {
                SetProperty(ref standardDeviation, value);
            }
        }
    }
}
