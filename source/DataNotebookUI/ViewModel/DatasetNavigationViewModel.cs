// Copyright 2023 Jeff Page

using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;

namespace DataNotebookUI.ViewModel
{
    public class DatasetNavigationViewModel : ObservableObject
    {
        public DatasetNavigationViewModel()
        {
            FilePaths = new ObservableCollection<String>();
        }

        public void AddFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            if (!FilePaths.Contains(filePath))
            {
                FilePaths.Add(filePath);
            }
        }

        public ObservableCollection<String> FilePaths { get; set; }
    }
}
