using ReqnrollSeleniumTestProject.Support;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public class Hooks : BaseEntity
    {

        public Hooks()
        {
        }

        [BeforeScenario]
        public void SetUp()
        {
            WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            CloseWebDriver();
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
