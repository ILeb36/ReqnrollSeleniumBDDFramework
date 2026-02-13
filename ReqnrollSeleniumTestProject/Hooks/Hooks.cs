using Allure.Net.Commons;
using NUnit.Framework;
using ReqnrollSeleniumTestProject.Support;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public class Hooks : BaseBindings
    {
        public Hooks(ScenarioContext scenarioContext) : base(scenarioContext)
        {

        }

        [BeforeScenario("@web")]
        public void SetUp()
        {
            Browser.WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario("@web")]
        public void TearDown()
        {
            if (ScenarioContext.TestError != null)
            {
                //Alternative - "AfterStep" hook, check step status, make and add screenshot if status is Failed
                var screenshotPath = Browser.MakeScreenshot(this.ScenarioContext.ScenarioInfo.Title);
                TestContext.AddTestAttachment(screenshotPath);
                AllureApi.AddAttachment(screenshotPath);
            }

            Browser.CloseBrowser();
        }

        [BeforeTestRun]
        public static void OneTimeSetUp()
        {

        }

        [AfterTestRun]
        public static void OneTimeTearDown()
        {

        }
    }
}
