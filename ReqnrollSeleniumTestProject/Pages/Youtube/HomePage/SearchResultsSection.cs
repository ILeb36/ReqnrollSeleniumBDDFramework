using ReqnrollSeleniumTestProject.Locators.Youtube.HomePage;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.HomePage
{
    public class SearchResultsSection : BaseWebElement
    {
        public SearchResultsSection() : base(HomePageLocators.SeachResultsSections.SearchResultsContainer)
        {
        }

        public override string ElementType => "Search results section on Home page";
    }
}
