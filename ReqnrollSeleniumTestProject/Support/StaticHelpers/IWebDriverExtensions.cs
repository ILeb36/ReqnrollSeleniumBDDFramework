using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.StaticHelpers
{
    public static class IWebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver webDriver, By elementLocator, By? parentElementLocator = null)
        {
            return parentElementLocator is null ? webDriver.FindElement(elementLocator) : webDriver.FindElement(parentElementLocator).FindElement(elementLocator);
        }
    }
}
