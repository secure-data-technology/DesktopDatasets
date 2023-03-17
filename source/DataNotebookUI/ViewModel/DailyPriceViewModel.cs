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

namespace DataNotebookUI.ViewModel
{
    public class DailyPriceViewModel
    {
        public DailyPriceViewModel()
        {
            DailyPrices = new List<DailyPrice>();
            _ = GetDailyPrices();
        }

        public List<DailyPrice> DailyPrices { get; set; }

        public string ProductName { get; set; }

        public async Task GetDailyPrices()
        {
            var dailyPrices = await CsvDataProvider.GetDailyPrices("C:\\repos\\DataNotebook\\DataNotebookUI\\Data\\coffee.csv");
        }
    }
}
