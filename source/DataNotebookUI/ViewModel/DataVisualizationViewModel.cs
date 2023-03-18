/// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNotebookUI.Model;

namespace DataNotebookUI.ViewModel
{
    public class DataVisualizationViewModel
    {
        public DataVisualizationViewModel()
        {
            Datasets = new List<List<double>>();
        }

        public List<List<double>> Datasets { get; set; }
    }
}
