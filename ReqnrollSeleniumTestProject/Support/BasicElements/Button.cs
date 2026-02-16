using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class Button : BaseWebElement
    {
        public Button(By locator) : base(locator)
        {
        }

        public override string ElementType => "Button";
    }
}
