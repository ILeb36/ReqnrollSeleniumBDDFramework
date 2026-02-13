using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.Screenshots
{
    public class DefaultScreensaver : IScreensaver
    {
        private readonly Browser browser;
        private string screenshotsFolderPath;

        public DefaultScreensaver(Browser browser)
        {
            this.browser = browser;
            this.screenshotsFolderPath = FileExplorerHelper.GetScreenshotsFolderPath();
            FileExplorerHelper.CreateFolder(this.screenshotsFolderPath);
        }

        public string MakeScreenshot(ScenarioContext context)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)this.browser.WebDriver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotPath = Path.Combine(this.screenshotsFolderPath, this.GetScreenshotNameWithDatetime(context));
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        private string GetScreenshotNameWithDatetime(ScenarioContext context)
        {
            return string.Concat(context.ScenarioInfo.Title, DateTime.Now.ToString("_dd.MM.yyyy_HH.mm"), ".png");
        }
    }
}
