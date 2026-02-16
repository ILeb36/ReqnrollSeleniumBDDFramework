using ReqnrollSeleniumTestProject.Locators.Youtube;
using ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube
{
    public class HomePage : BaseWebPage
    {
        public readonly LeftNavigationMenuOpened LeftNavigationMenuOpened = new();
        public readonly LeftNavigationMenuShortened LeftNavigationMenuShortened = new();
        public readonly Header header = new();

        public HomePage() : base(HomePageLocators.UniqueIdentifier)
        {

        }

        public override string PageName => "Youtube home page";
    }
}
