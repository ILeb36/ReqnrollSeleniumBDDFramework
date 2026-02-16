using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;
using ReqnrollSeleniumTestProject.Support.BasicElements;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header
{
    public class HeaderSearchSection : BaseWebElement
    {
        public TextBox SearchTextBox;

        public HeaderSearchSection(By elementLocator, BaseWebElement? parentElement = null) : base(elementLocator, parentElement)
        {
            this.SearchTextBox = new TextBox(HeaderLocators.SearchSection.SearchTextBox, this);
        }

        public override string ElementType => "Header search section";
    }
}
