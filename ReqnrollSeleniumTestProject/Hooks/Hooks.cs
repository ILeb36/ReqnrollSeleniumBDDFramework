using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support;
using ReqnrollSeleniumTestProject.Support.Screenshots;
using ServiceContainer = ReqnrollSeleniumTestProject.Support.ServiceContainer;

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
            Browser.MakeScreenshot(this.ScenarioContext.ScenarioInfo.Title);
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
