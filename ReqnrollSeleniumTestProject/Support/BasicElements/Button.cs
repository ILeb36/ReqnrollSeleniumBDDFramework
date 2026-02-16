using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class NonSpecificElement : BaseWebElement
    {
        public NonSpecificElement(By locator, By? parentLocator = null) : base(locator, parentLocator)
        {
        }

        public override string ElementType => "Button";
    }
}
