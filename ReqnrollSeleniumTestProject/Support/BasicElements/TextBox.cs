using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public class TextBox : BaseWebElement
    {
        public TextBox(By locator, BaseWebElement? parentElement = null) : base(locator, parentElement)
        {

        }

        public TextBox EnterText(string text)
        {
            var element = this.GetElement();
            element.Clear();
            element.SendKeys(text);
            element.SendKeys(Keys.Enter);
            return this;
        }

        public override string ElementType => "Text box";
    }
}
