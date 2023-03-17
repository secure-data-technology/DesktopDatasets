using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DataNotebookUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM2MDQ0NUAzMjMwMmUzNDJlMzBhOENLV09hYzdMNUx5SkRDMW9ZWWhrSlJ1YmhDV3c3YjZTVXNFa1ZxdHk4PQ==");
        }
    }
}
