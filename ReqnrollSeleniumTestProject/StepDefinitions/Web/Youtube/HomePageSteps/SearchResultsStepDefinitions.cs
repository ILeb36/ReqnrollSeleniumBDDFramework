using NUnit.Framework;
using ReqnrollSeleniumTestProject.Hooks;
using ReqnrollSeleniumTestProject.Models.YoutubeSearch;
using ReqnrollSeleniumTestProject.Pages.Youtube.HomePage;

namespace ReqnrollSeleniumTestProject.StepDefinitions.Web.Youtube.HomePageSteps
{
    [Binding]
    public class SearchResultsStepDefinitions : BaseWebBindings
    {
        private HomePage homePage = new HomePage();

        public SearchResultsStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Then("Search results page is opened")]
        public void ThenSearchResultPageIsOpened()
        {
            var isSearchResultsSectionOpened = this.homePage.SearchResultsSection.IsPresent();
            Assert.That(isSearchResultsSectionOpened, "Search results section is not visible");
        }


        [Then("Search results page is absent")]
        public void ThenSearchResultPageIsAbsent()
        {
            var isSearchResultsSectionOpened = this.homePage.SearchResultsSection.IsDisappeared();
            Assert.That(!isSearchResultsSectionOpened, "Search results section is visible");
        }

        [Then("Search results page is opened for every item in the list")]
        public void ThenSearchResultPageIsOpenedForEveryItemInTheList(DataTable dataTable)
        {
            var youtubeContent = dataTable.CreateSet<YoutubeContent>();
            foreach (var content in youtubeContent)
            {
                var oldUrl = Browser.Url;
                this.homePage.Header.SearchSection.SearchTextBox.EnterText(content.SearchValue);
                var newUrl = Browser.WaitForUrlToChange(oldUrl).Url;
                var isUrlCorrect = newUrl.EndsWith($"search_query={content.UrlQuery}");

                Assert.Multiple(() =>
                {
                    Assert.That(isUrlCorrect, $"Current Url does not contain the expected one:\r\nActual Url: '{newUrl}'\r\nExpected value: '{content.UrlQuery}'");
                });
            }
        }
    }
}
