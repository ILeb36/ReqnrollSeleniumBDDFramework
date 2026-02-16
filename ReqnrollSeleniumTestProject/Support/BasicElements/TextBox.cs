using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class TextBox : BaseWebElement
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public override string ElementType => "Text box";
    }
}
