// Copyright 2023 Jeff Page

using CsvHelper.Configuration.Attributes;
using System;

namespace DataNotebookUI.Model
{
    public class DailyPrice
    {
        public DateTime Date { get; set; }
        [Name("Open")]
        public double OpenPrice { get; set; }
        [Name("High")]
        public double HighPrice { get; set; }
        [Name("Low")]
        public double LowPrice { get; set; }
        [Name("Close")]
        public double ClosePrice { get; set; }
        public long Volume { get; set; }
        public string Currency { get; set; }
    }
}
