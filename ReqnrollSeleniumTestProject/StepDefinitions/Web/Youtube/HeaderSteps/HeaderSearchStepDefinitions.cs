using ReqnrollSeleniumTestProject.Hooks;
using ReqnrollSeleniumTestProject.Pages.Youtube.HomePage;

namespace ReqnrollSeleniumTestProject.StepDefinitions.Web.Youtube.HeaderSteps
{
    [Binding]
    internal class HeaderSearchStepDefinitions : BaseWebBindings
    {
        private readonly HomePage homePage = new HomePage();

        public HeaderSearchStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When("I search for {string}")]
        public void WhenISearchForContent(string search)
        {
            this.homePage.Header.SearchSection.SearchTextBox.EnterText(search);
            Browser.WaitForPageToLoad();
        }

        [When("I click Youtube logo")]
        public void WhenIClickYoutubeLogo()
        {
            this.homePage.Header.StartSection.LogoButton.Click();
            Browser.WaitForPageToLoad();
        }
    }
}
