using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support
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
            this.ScenarioContext = scenarioContext;
        }

        static BaseBindings()
        {
            ServiceContainer = ServiceContainer.Instance;
            Browser = ServiceContainer.ServiceProvider.GetRequiredService<Browser>();           
        }
    }
}
