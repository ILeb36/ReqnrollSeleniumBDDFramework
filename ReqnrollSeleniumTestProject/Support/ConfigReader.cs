using System.Configuration;

namespace ReqnrollSeleniumTestProject.Support
{
    internal static class ConfigReader
    {
#pragma warning disable CS8603 // Possible null reference return.
        public static string GetDefaultBrowser => ConfigurationManager.AppSettings["DefaultBrowser"];

        public static string GetEnvironmentVariableNameForBrowser => ConfigurationManager.AppSettings["EnvironmentVariableNameForBrowser"];

        public static string GetDownloadsFolderName => ConfigurationManager.AppSettings["DownloadsFolderName"];

        public static string GetScreenshotsFolderName => ConfigurationManager.AppSettings["ScreenshotsFolderName"];

        public static string GetEnvironmentVariableNameForUrl => ConfigurationManager.AppSettings["EnvironmentVariableNameForUrl"];
#pragma warning restore CS8603 // Possible null reference return.
    }
}
