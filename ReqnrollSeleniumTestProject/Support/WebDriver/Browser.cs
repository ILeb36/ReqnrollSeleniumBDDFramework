using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Logs;
using ReqnrollSeleniumTestProject.Support.Screenshots;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;

namespace ReqnrollSeleniumTestProject.Support.WebDriver
{
    public class Browser
    {
        private readonly IScreensaver screensaver;
        private readonly ILogger logger;
        private static IWebDriver? webDriver;

        public IWebDriver WebDriver
        {
            get
            {
                webDriver ??= WebDriverManager.GetNewWebDriver;
                return webDriver;
            }
        }

        public Browser(IScreensaver screensaver, ILogger logger)
        {
            this.screensaver = screensaver;
            this.logger = logger;
        }


        //all actions with browser, waits, alerts, refreshing

        public string MakeScreenshot(string screenshotName)
        {
            return screensaver.MakeScreenshot(WebDriver, screenshotName);
        }

        public void OpenUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void OpenBaseUrl()
        {
            var url = ConfigReader.GetUrl;
            WebDriver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            if (WebDriver != null)
            {
                WebDriver.Quit();
                WebDriver.Dispose();
                webDriver = null;
            }
        }
    }
}
