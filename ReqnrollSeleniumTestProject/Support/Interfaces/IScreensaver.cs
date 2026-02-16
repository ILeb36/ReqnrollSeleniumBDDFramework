using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.Interfaces
{
    public interface IScreensaver
    {
        public string MakeScreenshot(IWebDriver driver, string screenshotName);
    }
}
