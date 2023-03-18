// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNotebookUI.ApplicationService;

namespace DataNotebookUI.ViewModel
{
    public class StatisticsViewModel
    {
        public StatisticsViewModel()
        {
        }

        public List<double> DataPoints { get; set; } 
        public double Mean { get; private set; }
        public double StandardDeviation { get; private set; }
    }
}
