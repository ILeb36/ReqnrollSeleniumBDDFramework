using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;

namespace ReqnrollSeleniumTestProject.Support.Screenshots
{
    public class DefaultScreensaver : IScreensaver
    {
        private string screenshotsFolderPath;

        public DefaultScreensaver()
        {
            this.screenshotsFolderPath = FileExplorerHelper.GetScreenshotsFolderPath();
            FileExplorerHelper.CreateFolder(this.screenshotsFolderPath);
        }

        public string MakeScreenshot(IWebDriver driver, string screenshotName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotPath = Path.Combine(this.screenshotsFolderPath, this.GetScreenshotNameWithDatetime(screenshotName));
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        private string GetScreenshotNameWithDatetime(string screenshotName)
        {
            return string.Concat(screenshotName, DateTime.Now.ToString("_dd.MM.yyyy_HH.mm"), ".png");
        }
    }
}
