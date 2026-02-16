using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements;
using ReqnrollSeleniumTestProject.Support.Abstracts;
using ReqnrollSeleniumTestProject.Support.BasicElements;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header
{
    public class HeaderStartSection : BaseWebElement
    {
        public Button LogoButton;

        public HeaderStartSection(By elementLocator, BaseWebElement? parentElement = null) : base(elementLocator, parentElement)
        {
            this.LogoButton = new Button(HeaderLocators.StartSection.YoutubeLogo, this);
        }

        public override string ElementType => "Header search section";
    }
}
