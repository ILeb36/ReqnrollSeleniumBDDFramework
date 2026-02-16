using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ReqnrollSeleniumTestProject.Support.Interfaces;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;
using ILogger = ReqnrollSeleniumTestProject.Support.Interfaces.ILogger;

namespace ReqnrollSeleniumTestProject.Support.WebDriver
{
    public class Browser
    {
        private readonly IScreensaver screensaver;
        private readonly ILogger logger;
        private readonly IJavascriptExecution javascriptExecution;

        public int WindowsCount => this.WebDriver.WindowHandles.Count;
        public string Url => this.WebDriver.Url;

        private static IWebDriver? webDriver;

        public IWebDriver WebDriver
        {
            get
            {
                //to do: add monitor
                webDriver ??= WebDriverManager.GetNewWebDriver;
                return webDriver;
            }
        }

        public Browser(IScreensaver screensaver, ILogger logger, IJavascriptExecution javascriptExecution)
        {
            this.screensaver = screensaver;
            this.logger = logger;
            this.javascriptExecution = javascriptExecution;
        }

        public string MakeScreenshot(string screenshotName)
        {
            return screensaver.MakeScreenshot(WebDriver, screenshotName);
        }

        public Browser OpenUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
            return WaitForPageToLoad();
        }

        public Browser OpenBaseUrl()
        {
            var url = ConfigReader.GetSiteUrl;
            return this.OpenUrl(url);
        }

        public Browser CloseBrowser()
        {
            if (WebDriver != null)
            {
                WebDriver.Quit();
                WebDriver.Dispose();
                webDriver = null;
            }
            return this;
        }

        public Browser WaitForPageToLoad(TimeSpan? timeout = null)
        {
            var wait = new WebDriverWait(WebDriver, timeout ?? ConfigReader.GetPageLoadingTimeout);
            try
            {
                wait.Until(driver =>
                {
                    var result = this.javascriptExecution.ExecuteJavascript(WebDriver, "return document['readyState'] ? 'complete' == document.readyState : true");
                    return result is bool && (bool)result;
                });

                return this;
            }
            catch (Exception exception)
            {
                this.logger.Error($"And error occured while waiting for web page '{this.Url}' to load.", exception);
                throw;
            }
        }

        public string WaitForAnAlertAndClickAccept()
        {
            var alert = this.WaitForAnAlert();
            string alertText = alert.Text ?? string.Empty;
            this.logger.Info($"Alert with text '{alertText}' is opened");
            alert.Accept();
            this.WaitForPageToLoad();
            return alertText;
        }

        public Browser WaitForUrlToChange(string oldUrl)
        {
            var wait = new WebDriverWait(WebDriver, ConfigReader.GetPageLoadingTimeout);
            try
            {
                wait.Until(driver =>
                {
                    var cuurentUrl = driver.Url;
                    return !oldUrl.Equals(cuurentUrl);
                });

                return this;
            }
            catch (Exception exception)
            {
                this.logger.Error($"An error occured while waiting for Url changing from '{oldUrl}' to '{this.Url}'.", exception);
                throw;
            }
        }

        public Browser RefreshPage()
        {
            this.logger.Info("Refresh web page");
            WebDriver.Navigate().Refresh();
            return this.WaitForPageToLoad();
        }

        public Browser SwtichToLastWindow()
        {
            if (this.WindowsCount > 1)
            {
                WebDriver.SwitchTo().Window(WebDriver.WindowHandles[^1]);
            }

            return this;
        }

        public Browser SwtichToFirstWindow()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles[0]);
            return this;
        }

        public Browser WaitForNewWindowToOpen(int previousWindowsCount)
        {
            var wait = new WebDriverWait(WebDriver, ConfigReader.GetPageLoadingTimeout);
            wait.Until(driver => driver.WindowHandles.Count > previousWindowsCount);
            return this.SwtichToLastWindow().WaitForPageToLoad();
        }

        public Browser ScrollCurrentPageToTheTop()
        {
            this.logger.Info($"Scrolling to the top of the page at {this.Url}");
            this.javascriptExecution.ExecuteJavascript(WebDriver, "window.scrollTo(0, 0)");
            return this;
        }

        public Browser ScrollCurrentPageToTheDownRight()
        {
            this.logger.Info($"Scrolling to the down right corner of the page at {this.Url}");
            this.javascriptExecution.ExecuteJavascript(WebDriver, "window.scrollTo(document.body.scrollWidth, document.body.scrollHeight)");
            return this;
        }

        public object? ExecuteJavascript(string script, IWebElement? webElement = null)
        {
            return this.javascriptExecution.ExecuteJavascript(this.WebDriver, script, webElement);
        }

        private IAlert WaitForAnAlert()
        {
            var wait = new WebDriverWait(WebDriver, ConfigReader.GetAlertLoadingTimeout);
            try
            {
                IAlert alert = wait.Until(driver =>
                {
                    IAlert expectedAlert = driver.SwitchTo().Alert();
                    return expectedAlert;
                });
                return alert;
            }
            catch (WebDriverTimeoutException) // to do: check with NoAlertPresentException 
            {
                throw new Exception($"No alert was shown in {ConfigReader.GetAlertLoadingTimeout} seconds");
            }
        }
    }
}
