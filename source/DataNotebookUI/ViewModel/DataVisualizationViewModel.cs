/// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNotebookUI.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace DataNotebookUI.ViewModel
{
    public class DataVisualizationViewModel : ObservableObject
    {
        public DataVisualizationViewModel()
        {
            Datasets = new ObservableCollection<List<double>>();
        }

        public ObservableCollection<List<double>> Datasets { get; set; }
    }
}
