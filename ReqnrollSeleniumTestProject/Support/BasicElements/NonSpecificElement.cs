using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class Button : BaseWebElement
    {
        public Button(By locator, By parentLocator) : base(locator, parentLocator)
        {
        }

        public override string ElementType => "Non specific element";
    }
}
