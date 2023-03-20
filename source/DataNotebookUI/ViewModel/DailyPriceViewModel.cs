// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNotebookUI.Model;
using System.Collections.ObjectModel;
using DataNotebookUI.ApplicationService;
using DataNotebookUI.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DataNotebookUI.ViewModel
{
    public class DailyPriceViewModel : ObservableObject
    {
        public DailyPriceViewModel()
        {
            ProductName = string.Empty;
            DailyPrices = new ObservableCollection<DailyPrice>();
        }

        public ObservableCollection<DailyPrice> DailyPrices { get; set; }

        public string ProductName { get; set; }

        public async Task GetDailyPrices(string filePath)
        {
            var dailyPrices = await CsvDataProvider.GetDailyPrices(filePath);
            DailyPrices =  new ObservableCollection<DailyPrice>(dailyPrices);
        }
    }
}
