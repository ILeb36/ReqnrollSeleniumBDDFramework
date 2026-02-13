using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Logs;
using ReqnrollSeleniumTestProject.Support.Screenshots;

namespace ReqnrollSeleniumTestProject.Support
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

        public void MakeScreenshot(string screenshotName)
        {
            var screenshotPath = this.screensaver.MakeScreenshot(this.WebDriver, screenshotName);
            //log screenshotPath
        }

        public void OpenUrl(string url)
        {
            this.WebDriver.Navigate().GoToUrl(url);
        }

        public void OpenBaseUrl()
        {
            var url = ConfigReader.GetUrl;
            this.WebDriver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            if (this.WebDriver != null)
            {
                this.WebDriver.Quit();
                webDriver = null;
            }
        }
    }
}
