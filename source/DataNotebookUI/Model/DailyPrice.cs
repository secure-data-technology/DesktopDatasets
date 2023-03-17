// Copyright 2023 Jeff Page

using System;

namespace DataNotebookUI.Model
{
    public class DailyPrice
    {
        public DateTime Date { get; set; }
        double OpenPrice { get; set; }
        double HighPrice { get; set; }
        double LowPrice { get; set; }
        double ClosePrice { get; set; }
        long Volume { get; set; }
        string Currency { get; set; }
    }
}
