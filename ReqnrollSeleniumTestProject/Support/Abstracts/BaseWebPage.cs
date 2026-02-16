using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.BasicElements;

namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    public abstract class BaseWebPage : BaseWebEntity
    {
        public By PageIdentifyingLocator { get; }
        public string PageName { get; }
        protected NonSpecificElement PageIdentifyingElement { get; }

        protected BaseWebPage(By pageIdentifyingLocator, string pageName)
        {
            this.PageIdentifyingLocator = pageIdentifyingLocator;
            this.PageName = pageName;
            this.PageIdentifyingElement = new NonSpecificElement(this.PageIdentifyingLocator);
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
