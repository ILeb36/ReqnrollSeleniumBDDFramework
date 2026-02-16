using ReqnrollSeleniumTestProject.Locators.Youtube.HomePage;
using ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.HomePage
{
    public class HomePage : BaseWebPage
    {
        public readonly Header Header = new();
        public readonly LeftNavigationMenuOpened LeftNavigationMenuOpened = new();
        public readonly LeftNavigationMenuShortened LeftNavigationMenuShortened = new();
        public readonly SearchResultsSection SearchResultsSection = new();

        public HomePage() : base(HomePageLocators.UniqueIdentifier)
        {

        }

        public override string PageName => "Youtube home page";
    }
}
