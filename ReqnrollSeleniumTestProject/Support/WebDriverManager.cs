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
            var browserName = ConfigReader.GetBrowser;
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

        private static BrowserEnum ParseBrowserName(string browserName)
        {
            if (EnumsHelper.TryParse(browserName, out BrowserEnum? enumElement))
            {
                return enumElement.Value;
            }

            throw new Exception($"We can't convert browser {browserName} to {nameof(BrowserEnum)} element");
        }
    }
}
