using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ReqnrollSeleniumTestProject.Support.WebDriver.WebDriverInitialization
{
    public class FirefoxWebDriverStrategy : IWebDriverStrategy
    {
        public IWebDriver GetWebDriver(string downloadFolder)
        {
            var options = GetFirefoxOptions(downloadFolder);
            return new FirefoxDriver(options);
        }

        private static FirefoxOptions GetFirefoxOptions(string downloadFolder)
        {
            var options = new FirefoxOptions();
            options.SetPreference("browser.helperApps.alwaysAsk.force", false);
            options.SetPreference("browser.download.folderList", 2);
            options.SetPreference("browser.download.dir", downloadFolder);
            options.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
            options.SetPreference("browser.download.useDownloadDir", true);
            options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/zip, application/x-gzip, application/octet-stream, application/x-msdownload");

            return options;
        }
    }
}
