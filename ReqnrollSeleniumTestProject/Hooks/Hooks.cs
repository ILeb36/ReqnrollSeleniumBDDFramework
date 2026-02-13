using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support;
using ReqnrollSeleniumTestProject.Support.Screenshots;
using ServiceContainer = ReqnrollSeleniumTestProject.Support.ServiceContainer;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext scenarioContext;
        private readonly ServiceContainer serviceContainer;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.serviceContainer = ServiceContainer.Instance;
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("@web")]
        public void SetUp()
        {
            var browser = this.serviceContainer.ServiceProvider.GetRequiredService<Browser>();
            browser.WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario("@web")]
        public void TearDown()
        {
            var browser = this.serviceContainer.ServiceProvider.GetRequiredService<Browser>();
            var screenSaver = this.serviceContainer.ServiceProvider.GetRequiredService<IScreensaver>();
            var screenPath = screenSaver.MakeScreenshot(this.scenarioContext);
            browser.CloseBrowser();
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
