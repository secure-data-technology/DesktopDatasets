// Copyright 2023 Jeff Page

using System.Reflection;

namespace DataNotebookUI.ApplicationService
{
    public static class ProductInformationProvider
    {
        public static string GetProductName()
        {
            string productName = Assembly.GetExecutingAssembly().GetName().Name;
            return productName;
        }

        public static string GetProductVersion()
        {
            string productVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return productVersion;
        }
    }
}
