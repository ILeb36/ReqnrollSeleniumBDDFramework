using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.WebDriverInitializations
{
    interface IWebDriverStrategy
    {
        IWebDriver GetWebDriver(string downloadFolder);
    }
}
