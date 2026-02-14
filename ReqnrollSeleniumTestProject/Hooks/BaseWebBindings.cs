using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support;
using ReqnrollSeleniumTestProject.Support.WebDriver;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public abstract class BaseWebBindings : BaseBindings
    {
        protected static readonly Browser Browser;

        protected IWebDriver WebDriver
        {
            get
            {
                return Browser.WebDriver;
            }
        }

        protected BaseWebBindings(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        static BaseWebBindings()
        {
            Browser = ServiceContainer.ServiceProvider.GetRequiredService<Browser>();           
        }
    }
}
