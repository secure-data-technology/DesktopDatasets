// Copyright 2023 Jeff Page

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataNotebookUI.ApplicationService;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;

namespace DataNotebookUI.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            ProductName = ProductInformationProvider.GetProductName();
            ProductVersion = ProductInformationProvider.GetProductVersion();
            OpenDatasetCommand = new RelayCommand(OpenDataset);
            CloseDatasetCommand = new RelayCommand(CloseDataset);

            NavigationViewModel = new DatasetNavigationViewModel();
            DataViewModel = new DailyPriceViewModel();
            StatisticsViewModel = new StatisticsViewModel();
            VisualizationViewModel = new DataVisualizationViewModel();
        }

        public string ProductName { get; set; }

        public string ProductVersion { get; set; }

        public DatasetNavigationViewModel NavigationViewModel { get; }

        public DailyPriceViewModel DataViewModel;

        public StatisticsViewModel StatisticsViewModel;

        public DataVisualizationViewModel VisualizationViewModel;

        public string DatasetFilePath { get; set; }

        public RelayCommand OpenDatasetCommand { get; }

        public RelayCommand CloseDatasetCommand { get; }

        private async void OpenDataset()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DatasetFilePath = openFileDialog.FileName;
                NavigationViewModel.AddFilePath(DatasetFilePath);
                await DataViewModel.GetDailyPrices(DatasetFilePath);
                List<double> closingPrices = CsvDataProvider.GetPricesByType(DataViewModel.DailyPrices.ToList(), PriceType.ClosePrice);
                StatisticsViewModel.DataPoints = closingPrices;
                //VisualizationViewModel.
            }

        }

        private void CloseDataset()
        {
        }
    }
}
