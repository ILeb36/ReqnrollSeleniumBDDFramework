using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class Button : BaseWebElement
    {
        public Button(By locator, BaseWebElement? parentElement = null) : base(locator, parentElement)
        {
        }

        public override string ElementType => "Non specific element";
    }
}
