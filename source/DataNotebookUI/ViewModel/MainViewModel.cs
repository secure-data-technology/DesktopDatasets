// Copyright 2023 Jeff Page

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataNotebookUI.ApplicationService;
using Microsoft.Win32;

namespace DataNotebookUI.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            ProductName = ProductInformationProvider.GetProductName();
            ProductVersion = ProductInformationProvider.GetProductVersion();
            OpenDatasetCommand = new RelayCommand(OpenDataset);
        }

        public string ProductName { get; set; }

        public string ProductVersion { get; set; }

        public string DatasetFilePath { get; set; }

        public RelayCommand OpenDatasetCommand { get; }

        private void OpenDataset()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DatasetFilePath = openFileDialog.FileName;
            }
        }
    }
}
