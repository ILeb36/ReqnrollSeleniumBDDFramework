using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Enums;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;
using ReqnrollSeleniumTestProject.Support.WebDriver.WebDriverInitialization;

namespace ReqnrollSeleniumTestProject.Support.WebDriver
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
            var webDriver = webDriverStrategy.GetWebDriver(downloadFolderPath);
            webDriver.Manage().Timeouts().ImplicitWait = ConfigReader.GetImplicitTimeout;
            return webDriver;
        }

        private static IWebDriverStrategy GetWebDriverStrategy(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.firefox:
                    return new FirefoxWebDriverStrategy();
                case BrowserType.chrome:
                    return new ChromeWebDriverStrategy();
                default:
                    throw new NotSupportedException($"We don't know how to initialize browser {browser}.");
            }
        }

        private static BrowserType ParseBrowserName(string browserName)
        {
            if (EnumsHelper.TryParse(browserName, true, out BrowserType? enumElement))
            {
#pragma warning disable CS8629 // Nullable value type may be null.
                return enumElement.Value;
#pragma warning restore CS8629 // Nullable value type may be null.
            }

            throw new Exception($"We can't convert browser {browserName} to {nameof(BrowserType)} element");
        }
    }
}
