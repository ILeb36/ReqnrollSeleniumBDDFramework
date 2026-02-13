using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.Screenshots
{
    public interface IScreensaver
    {
        public string MakeScreenshot(IWebDriver driver, string screenshotName);
    }
}
