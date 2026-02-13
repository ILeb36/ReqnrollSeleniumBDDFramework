using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReqnrollSeleniumTestProject.Support.WebDriver.WebDriverInitialization
{
    public class ChromeWebDriverStrategy : IWebDriverStrategy
    {
        public IWebDriver GetWebDriver(string downloadFolder)
        {
            var options = GetChromeOptions(downloadFolder);
            return new ChromeDriver(options);
        }

        private static ChromeOptions GetChromeOptions(string downloadFolder)
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadFolder);
            options.AddUserProfilePreference("unexpectedAlertBehaviour", "ignore");
            options.AddUserProfilePreference("safebrowsing.enabled", true);

            options.AddArguments("disable-application-cache");
            options.AddArguments("disable-cache");
            options.AddArguments("disable-gpu-program-cache");
            return options;
        }
    }
}
