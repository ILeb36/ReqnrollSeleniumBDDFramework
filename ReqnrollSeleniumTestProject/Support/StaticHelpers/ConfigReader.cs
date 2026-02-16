using System.Configuration;

namespace ReqnrollSeleniumTestProject.Support.StaticHelpers
{
    internal static class ConfigReader
    {
#pragma warning disable CS8603 // Possible null reference return.
        public static string GetBrowser => GetSetting("Browser");

        public static string GetDownloadsFolderName => GetSetting("DownloadsFolderName");

        public static string GetScreenshotsFolderName => GetSetting("ScreenshotsFolderName");

        public static string GetSiteUrl => GetSetting("SiteUrl");

        public static string GetAPIUrl => GetSetting("APIUrl");

        public static TimeSpan GetImplicitTimeout => TimeSpan.FromSeconds(double.Parse(GetSetting("ImplicitTimeout")));

        public static TimeSpan GetPageLoadingTimeout => TimeSpan.FromSeconds(double.Parse(GetSetting("PageLoadingTimeout")));

        public static TimeSpan GetAlertLoadingTimeout => TimeSpan.FromSeconds(double.Parse(GetSetting("AlertLoadingTimeout")));

        public static TimeSpan GetFindWebElementTimeout => TimeSpan.FromSeconds(double.Parse(GetSetting("FindWebElementTimeout")));

        private static string GetSetting(string key)
        {
            var value = Environment.GetEnvironmentVariable(key);

            // I don't like this solution, even if it's used in real projects
            if (string.IsNullOrEmpty(value))
            {
                // to do: WARN in logger
                value = ConfigurationManager.AppSettings[key];
            }

            return value;
        }
#pragma warning restore CS8603 // Possible null reference return.
    }
}
