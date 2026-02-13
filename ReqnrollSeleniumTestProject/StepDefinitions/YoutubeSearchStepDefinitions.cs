using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll.CommonModels;
using ReqnrollSeleniumTestProject.Classes.YoutubeSearch;
using ReqnrollSeleniumTestProject.Hooks;

namespace ReqnrollSeleniumTestProject.StepDefinitions
{
    [Binding]
    public class YoutubeSearchStepDefinitions : BaseBindings
    {
        public YoutubeSearchStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
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

        [Then("Search result page is opened for every item in the list")]
        public void ThenSearchResultPageIsOpenedForEveryItemInTheList(DataTable dataTable)
        {
            var youtubeContent = dataTable.CreateSet<YoutubeContent>();
            foreach(var content in youtubeContent)
            {
                var element = WebDriver.FindElement(By.Name("search_query"));
                element.Clear();
                element.SendKeys(content.SearchValue);
                element.SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                // to do: check how Assert.EnterMultipleScope() works
                // to do: Add method for group of assertions with adding screenshot for every fail (and logging)
            }
            Assert.Pass();
        }

    }
}
