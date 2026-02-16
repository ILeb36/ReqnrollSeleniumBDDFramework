using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements
{
    public class LeftNavigationMenuOpened : BaseWebPage
    {
        public LeftNavigationMenuOpened() : base(LeftNavigationMenuOpenedLocators.MenuContainer)
        {

        }

        public override string PageName => "Youtube left opened navigation menu";
    }
}
