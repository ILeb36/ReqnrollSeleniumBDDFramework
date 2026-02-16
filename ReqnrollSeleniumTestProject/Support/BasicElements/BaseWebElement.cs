using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ReqnrollSeleniumTestProject.Support.Abstracts;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;

namespace ReqnrollSeleniumTestProject.Support.BasicElements
{
    public abstract class BaseWebElement : BaseWebEntity
    {
        public By Locator { get; }
        public abstract string ElementType { get; }
        private By? parentLocator { get; }

        protected BaseWebElement(By locator, By? parentLocator = null)
        {
            this.Locator = locator;
            this.parentLocator = parentLocator;
        }

        public void Click()
        {
            var element = GetElement();
            try
            {
                element.Click();
            }
            catch (InvalidOperationException exception)
            {
                var message = $"Not able to click at {this.ElementType} '{this.Locator}'";
                Logger.Error(message, exception);
                throw;
            }
        }

        public void ClickWithJavascript()
        {
            var element = GetElement();
            Browser.ExecuteJavascript("arguments[0].click();", element);
        }

        public void ClickWithMouseOver()
        {
            var element = GetElement();
            new Actions(WebDriver).MoveToElement(element).Click(element).Perform();
        }

        public void DoubleClick()
        {
            var element = GetElement();
            new Actions(WebDriver).DoubleClick(element).Perform();
        }

        public void RightClick()
        {
            var element = GetElement();
            new Actions(WebDriver).ContextClick(element).Perform();
        }

        public string GetText()
        {
            var element = GetElement();
            return element.Text;
        }

        public string? GetValue()
        {
            return GetAttribute("value");
        }

        public string? GetAttribute(string attributeName)
        {
            var element = GetElement();
            return element.GetAttribute(attributeName);
        }

        public void WaitForElementIsPresent(TimeSpan? timeout = null)
        {
            try
            {
                GetWebDriverWait(timeout).Until(driver => driver.FindElement(this.Locator, this.parentLocator));
            }
            catch (TimeoutException exception)
            {
                var message = $"{this.ElementType} with locator {this.Locator} was not found!";
                Logger.Error(message, exception);
                throw;
            }
        }

        public void WaitForElementIsEnabled(TimeSpan? timeout = null)
        {
            try
            {
                GetWebDriverWait(timeout).Until(driver =>
                {
                    var element = driver.FindElement(this.Locator, this.parentLocator);
                    return CheckIfElemenetIsEnabled(element);
                });

            }
            catch (TimeoutException exception)
            {
                var message = $"{this.ElementType} with locator {this.Locator} was disabled or missing!";
                Logger.Error(message);
                throw new InvalidElementStateException(message, exception);
            }
        }

        public bool IsPresent(TimeSpan? timeout = null)
        {
            try
            {
                WaitForElementIsPresent(timeout);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsEnabled(TimeSpan? timeout = null)
        {
            return CheckIfElemenetIsEnabled(GetElement(timeout));
        }

        protected IWebElement GetElement(TimeSpan? timeout = null)
        {
            WaitForElementIsPresent(timeout);
            return WebDriver.FindElement(this.Locator, this.parentLocator);
        }

        protected WebDriverWait GetWebDriverWait(TimeSpan? timeout = null)
        {
            return new WebDriverWait(WebDriver, timeout ?? ConfigReader.GetFindWebElementTimeout);
        }

        private bool CheckIfElemenetIsEnabled(IWebElement element)
        {
            var classAttributeValue = GetAttribute("class") ?? string.Empty;
            return element.Enabled && !classAttributeValue.Contains("disabled", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
