using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ReqnrollSeleniumTestProject.Support.Interfaces;
using ReqnrollSeleniumTestProject.Support.StaticHelpers;

namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    public abstract class BaseWebElement : BaseWebEntity
    {
        public By Locator { get; }

        protected BaseWebElement(By locator)
        {
            Locator = locator;
        }

        public void Click()
        {
            var element = this.GetElement();
            try
            {
                element.Click();
            }
            catch (InvalidOperationException exception)
            {
                var message = $"Not able to click at element '{this.Locator}'";
                Logger.Error(message, exception);
                throw;
            }
        }

        public void ClickWithJavascript()
        {
            var element = this.GetElement();
            Browser.ExecuteJavascript("arguments[0].click();", element);
        }

        public void ClickWithMouseOver()
        {
            var element = this.GetElement();
            new Actions(WebDriver).MoveToElement(element).Click(element).Perform();
        }

        public void DoubleClick()
        {
            var element = this.GetElement();
            new Actions(WebDriver).DoubleClick(element).Perform();
        }

        public void RightClick()
        {
            var element = this.GetElement();
            new Actions(WebDriver).ContextClick(element).Perform();
        }

        public string GetText()
        {
            var element = this.GetElement();
            return element.Text;
        }

        public string? GetValue()
        {
            return this.GetAttribute("value");
        }

        public string? GetAttribute(string attributeName)
        {
            var element = this.GetElement();
            return element.GetAttribute(attributeName);
        }

        public void WaitForElementIsPresent(TimeSpan? timeout = null)
        {
            try
            {
                this.GetWebDriverWait(timeout).Until(driver => driver.FindElement(this.Locator));
            }
            catch (TimeoutException exception)
            {
                var message = $"Element with locator {this.Locator} was not found!";
                Logger.Error(message, exception);
                throw;
            }
        }

        public void WaitForElementIsEnabled(TimeSpan? timeout = null)
        {
            try
            {
                this.GetWebDriverWait(timeout).Until(driver =>
                {
                    var element = driver.FindElement(this.Locator);
                    return CheckIfElemenetIsEnabled(element);
                });

            }
            catch (TimeoutException exception)
            {
                var message = $"Element with locator {this.Locator} was disabled or missing!";
                Logger.Error(message);
                throw new InvalidElementStateException(message, exception);
            }
        }

        public bool IsPresent(TimeSpan? timeout = null)
        {
            try
            {
                this.WaitForElementIsPresent(timeout);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsEnabled(TimeSpan? timeout = null)
        {
            return CheckIfElemenetIsEnabled(this.GetElement(timeout));
        }

        protected IWebElement GetElement(TimeSpan? timeout = null)
        {
            WaitForElementIsPresent(timeout);
            return WebDriver.FindElement(this.Locator);
        }

        protected WebDriverWait GetWebDriverWait(TimeSpan? timeout = null)
        {
            return new WebDriverWait(WebDriver, timeout ?? ConfigReader.GetFindWebElementTimeout);
        }

        private bool CheckIfElemenetIsEnabled(IWebElement element)
        {
            var classAttributeValue = this.GetAttribute("class") ?? string.Empty;
            return element.Enabled && (!classAttributeValue.Contains("disabled", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
