using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class NonSpecificElement : BaseWebElement
    {
        public NonSpecificElement(By locator, BaseWebElement? parentElement = null) : base(locator, parentElement)
        {
        }

        public override string ElementType => "Button";
    }
}
