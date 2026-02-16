using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.WebDriver;

namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    public abstract class BaseWebEntity : BaseEntity
    {
        protected static readonly Browser Browser;

        protected IWebDriver WebDriver
        {
            get
            {
                return Browser.WebDriver;
            }
        }

        static BaseWebEntity()
        {
            Browser = ServiceContainer.ServiceProvider.GetRequiredService<Browser>();           
        }
    }
}
