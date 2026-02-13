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
                Browser.MakeScreenshot(this.ScenarioContext.ScenarioInfo.Title);

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
