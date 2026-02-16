using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements
{
    public class LeftNavigationMenuShortened : BaseWebPage
    {
        public LeftNavigationMenuShortened() : base(LeftNavigationMenuShortenedLocators.MenuContainer)
        {

        }

        public override string PageName => "Youtube left short navigation menu";
    }
}
