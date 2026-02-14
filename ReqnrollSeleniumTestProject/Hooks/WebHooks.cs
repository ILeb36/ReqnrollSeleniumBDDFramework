using Allure.Net.Commons;
using NUnit.Framework;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public class WebHooks : BaseWebBindings
    {
        public WebHooks(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [BeforeScenario("@web")]
        public void BeforeScenarioSetUp()
        {
            Browser.WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario("@web")]
        public void AfterScenarioTearDown()
        {
            Browser.CloseBrowser();
        }

        [AfterStep("@web")]
        public void AfterStepTearDown()
        {
            if (ScenarioContext.TestError != null)
            {
                var screenshotPath = Browser.MakeScreenshot(this.ScenarioContext.ScenarioInfo.Title);
                TestContext.AddTestAttachment(screenshotPath);
                AllureApi.AddAttachment(screenshotPath);
                //Another method overload leads to "System.UnauthorizedAccessException : Access to the path 'F:\C#\ReqnrollSeleniumTestProject\ReqnrollSeleniumTestProject\bin\Debug\net8.0\Screenshots' is denied."
                //Adding manifest with Administrator permissions didn't help
                //Need to check with console tests running as Administrator
            }
        }
    }
}
