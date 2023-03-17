// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNotebookUI.ApplicationService;

namespace DataNotebookUI.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            ProductName = ProductInformationProvider.GetProductName();
            ProductVersion = ProductInformationProvider.GetProductVersion();
        }

        public string ProductName { get; set; }

        public string ProductVersion { get; set; }
    }
}
