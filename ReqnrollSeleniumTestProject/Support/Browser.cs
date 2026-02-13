using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support
{
    public class Browser
    {
        private static IWebDriver _webDriver;

        public IWebDriver WebDriver
        {
            get
            {
                _webDriver ??= WebDriverManager.GetNewWebDriver;
                return _webDriver;
            }
            private set
            {
                _webDriver = value;
            }
        }

        public Browser()
        {
            //initialization when I will have something for that
        }


        //all actions with browser, waits, alerts, refreshing

        public void OpenUrl(string url)
        {
            this.WebDriver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            if (this.WebDriver != null)
            {
                this.WebDriver.Quit();
                this.WebDriver = null;
            }
        }
    }
}
