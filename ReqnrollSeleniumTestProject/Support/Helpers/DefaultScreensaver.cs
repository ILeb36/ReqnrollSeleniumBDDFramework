using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Interfaces;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;

namespace ReqnrollSeleniumTestProject.Support.Helpers
{
    public class DefaultScreensaver : IScreensaver
    {
        private readonly string screenshotsFolderPath;

        public DefaultScreensaver()
        {
            screenshotsFolderPath = FileExplorerHelper.GetScreenshotsFolderPath();
            FileExplorerHelper.CreateFolder(screenshotsFolderPath);
        }

        public string MakeScreenshot(IWebDriver driver, string screenshotName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotPath = Path.Combine(screenshotsFolderPath, GetScreenshotNameWithDatetime(screenshotName));
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        private static string GetScreenshotNameWithDatetime(string screenshotName)
        {
            return string.Concat(screenshotName, DateTime.Now.ToString("_dd.MM.yyyy_HH.mm"), ".png");
        }
    }
}
