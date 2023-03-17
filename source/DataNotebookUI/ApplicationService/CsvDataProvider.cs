// Copyright 2023 Jeff Page

using CsvHelper;
using DataNotebookUI.Model;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataNotebookUI.ApplicationService
{
    public static class CsvDataProvider
    {
        public static List<string> GetCsvFiles(string folderPath, string pattern="*.csv")
        {
            var filePaths = Directory.GetFiles(folderPath, pattern);
            return filePaths.ToList();
        }

        public static async Task<List<DailyPrice>> GetDailyPrices(string filePath)
        {
            var dailyPrices = new List<DailyPrice>();

            await Task.Factory.StartNew(() =>
            {
                using (var streamReader = new StreamReader(filePath))
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    dailyPrices = csvReader.GetRecords<DailyPrice>().ToList();
                }
            });


            return dailyPrices;
        }
    }
}
