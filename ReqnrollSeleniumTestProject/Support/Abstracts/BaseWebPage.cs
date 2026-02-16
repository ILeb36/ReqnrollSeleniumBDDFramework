using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.BasicElements;

namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    public abstract class BaseWebPage : BaseWebEntity
    {
        public abstract string PageName { get; }
        protected NonSpecificElement PageIdentifyingElement { get; private set; }

        protected BaseWebPage(By pageIdentifyingLocator)
        {
            this.PageIdentifyingElement = new NonSpecificElement(pageIdentifyingLocator);
        }

        public bool IsOpened()
        {
            return this.PageIdentifyingElement.IsPresent();
        }

        public void WaitForPageIsOpened(TimeSpan? timeout = null)
        {
            try
            {
                Browser.WaitForPageToLoad(timeout);
                this.PageIdentifyingElement.WaitForElementIsPresent();
            }
            catch (Exception exception)
            {
                Logger.Error($"Page {this.PageName} was not opened.", exception);
                throw;
            }
        }
    }
}
