// Copyright 2023 Jeff Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotebookUI.ViewModel
{
    public class DatasetNavigationViewModel
    {
        public DatasetNavigationViewModel()
        {
            FilePaths = new List<string>();
        }

        public List<String> FilePaths { get; set; }
    }
}
