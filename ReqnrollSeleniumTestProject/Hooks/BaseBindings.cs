using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support;
using ReqnrollSeleniumTestProject.Support.WebDriver;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public abstract class BaseBindings
    {
        protected readonly ScenarioContext ScenarioContext;
        protected static readonly ServiceContainer ServiceContainer;
        protected static readonly Browser Browser;
        protected IWebDriver WebDriver
        {
            get
            {
                return Browser.WebDriver;
            }
        }

        public BaseBindings(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        static BaseBindings()
        {
            ServiceContainer = ServiceContainer.Instance;
            Browser = ServiceContainer.ServiceProvider.GetRequiredService<Browser>();           
        }
    }
}
