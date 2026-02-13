using Allure.Net.Commons;
using NUnit.Framework;
using Reqnroll.Bindings;
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
        public void BeforeScenarioSetUp()
        {
            Browser.WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario("@web")]
        public void AfterScenarioTearDown()
        {
            Browser.CloseBrowser();
        }

        [AfterStep]
        public void AfterStepTearDown()
        {
            if (ScenarioContext.TestError != null)
            {
                var screenshotPath = Browser.MakeScreenshot(this.ScenarioContext.ScenarioInfo.Title);
                TestContext.AddTestAttachment(screenshotPath);
                AllureApi.AddAttachment(screenshotPath);
            }
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
