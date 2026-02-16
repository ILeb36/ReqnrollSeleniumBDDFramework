using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header
{
    public class Header : BaseWebPage
    {
        public Header() : base(HeaderLocators.HeaderBar)
        {
        }

        public override string PageName => "Youtube header";
    }
}
