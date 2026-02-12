using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Enums;
using ReqnrollSeleniumTestProject.Support.WebDriverInitializations;

namespace ReqnrollSeleniumTestProject.Support
{
    public static class WebDriverManager
    {
        public static IWebDriver GetNewWebDriver
        {
            get
            {
                return InitializeWebDriver();
            }
        }

        private static IWebDriver InitializeWebDriver()
        {
            var downloadFolderPath = FileExplorerHelper.GetDownloadFolderPath();
            var browserName = GetBrowserName();
            var browser = ParseBrowserName(browserName);
            var webDriverStrategy = GetWebDriverStrategy(browser);
            return webDriverStrategy.GetWebDriver(downloadFolderPath);
        }

        private static IWebDriverStrategy GetWebDriverStrategy(BrowserEnum browser)
        {
            switch (browser)
            {
                case BrowserEnum.firefox:
                    return new FirefoxWebDriverStrategy();
                case BrowserEnum.chrome:
                    return new ChromeWebDriverStrategy();
                default:
                    throw new NotSupportedException($"We don't know how to initialize browser {browser}.");
            }
        }

        private static string GetBrowserName()
        {
            var browserVariableName = ConfigReader.GetEnvironmentVariableNameForBrowser;
            var browserName = Environment.GetEnvironmentVariable(browserVariableName, EnvironmentVariableTarget.Process);
            //if (browserName is null) // for environment variables
            //{
            //    throw new Exception($"Not able to ready value from '{browserVariableName}' environment variables.");
            //}

            browserName ??= ConfigReader.GetDefaultBrowser;
            return browserName;
        }

        private static BrowserEnum ParseBrowserName(string browserName)
        {
            if (Enum.TryParse(typeof(BrowserEnum), browserName, true, out var result))
            {
                return (BrowserEnum)result;
            }

            throw new Exception($"Can't convert browser {browserName} to {nameof(BrowserEnum)} element");
        }
    }
}
