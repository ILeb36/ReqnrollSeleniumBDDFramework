using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class TextBox : BaseWebElement
    {
        public TextBox(By locator, By parentLocator) : base(locator, parentLocator)
        {
        }

        public override string ElementType => "Text box";
    }
}
