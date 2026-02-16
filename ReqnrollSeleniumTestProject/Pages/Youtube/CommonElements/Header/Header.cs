using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header
{
    public class Header : BaseWebElement
    {
        public HeaderSearchSection SearchSection;
        public HeaderStartSection StartSection;

        public Header() : base(HeaderLocators.HeaderBar)
        {
            this.SearchSection = new HeaderSearchSection(HeaderLocators.SearchSection.SearchSectionContainer, this);
            this.StartSection = new HeaderStartSection(HeaderLocators.StartSection.StartSectionContainer, this);
        }

        public override string ElementType => "Youtube header";
    }
}
