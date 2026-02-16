using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.StaticHelpers
{
    public static class IWebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver webDriver, By elementLocator, IWebElement? parentElement = null)
        {
            return parentElement is null ? webDriver.FindElement(elementLocator) : parentElement.FindElement(elementLocator);
        }
    }
}
