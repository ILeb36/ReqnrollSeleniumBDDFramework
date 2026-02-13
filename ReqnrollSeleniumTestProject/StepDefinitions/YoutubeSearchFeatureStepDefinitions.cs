using NUnit.Framework;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Hooks;

namespace ReqnrollSeleniumTestProject.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions : BaseBindings
    {
        public YoutubeSearchFeatureStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given("I open the Youtube")]
        public void GivenIOpenTheYoutube()
        {
            Browser.OpenBaseUrl();
        }

        [When("I search for {string}")]
        public void WhenISearchForContent(string search)
        {
            var element = WebDriver.FindElement(By.Name("search_query"));

            element.SendKeys(search);
            element.SendKeys(Keys.Enter);
        }

        [Then("Search result page is opened")]
        public void ThenSearchResultPageIsOpened()
        {
            Thread.Sleep(1000);
        }

        [Then("Scenario is failed for testing purpose")]
        public void ThenScenarioIsFailedForTestingPurpose()
        {
            Assert.Fail();
        }
    }
}
