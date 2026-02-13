using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using ReqnrollSeleniumTestProject.Support;

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

        [When("I search for the Might and Magic {int}")]
        public void WhenISearchForTheMightAndMagic(int number)
        {
            var element = WebDriver.FindElement(By.Name("search_query"));
            
            element.SendKeys($"Might and Magic {number} -heroes");
            element.SendKeys(Keys.Enter);
        }

        [Then("Search result page is opened")]
        public void ThenSearchResultPageIsOpened()
        {
            Thread.Sleep(3000);
        }

    }
}
