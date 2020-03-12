using Ocaramba;
using Ocaramba.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace TestAutomationFramework
{
    public static class OcarambaConfigurationFile
    {
        private static readonly string CurrentDirectory = Directory.GetCurrentDirectory();

        /// <summary>
        /// Gets the Download Folder path
        /// </summary>
        public static string DownloadFolderPath
        {
            get { return FilesHelper.GetFolder(ConfigurationManager.AppSettings["DownloadFolder"], CurrentDirectory); }
        }
    }
}
