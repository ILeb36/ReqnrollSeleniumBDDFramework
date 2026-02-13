using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.WebDriver.WebDriverInitialization
{
    interface IWebDriverStrategy
    {
        IWebDriver GetWebDriver(string downloadFolder);
    }
}
