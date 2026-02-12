using System.Configuration;

namespace ReqnrollSeleniumTestProject.Support
{
    internal static class ConfigReader
    {
#pragma warning disable CS8603 // Possible null reference return.
        public static string GetDefaultBrowser => ConfigurationManager.AppSettings["DefaultBrowser"];

        public static string GetEnvironmentVariableNameForBrowser => ConfigurationManager.AppSettings["EnvironmentVariableNameForBrowser"];

        public static string GetDownloadFolderName => ConfigurationManager.AppSettings["DownloadFolderName"];

#pragma warning restore CS8603 // Possible null reference return.
    }
}
