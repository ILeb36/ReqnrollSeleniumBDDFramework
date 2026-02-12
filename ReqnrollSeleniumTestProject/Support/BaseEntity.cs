using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support
{
    public abstract class BaseEntity
    {
        //protected static IServiceCollection services;
        protected Browser Browser;
        private static IWebDriver? _webDriver;

        public static IWebDriver WebDriver
        {
            get
            {
                _webDriver ??= WebDriverManager.GetNewWebDriver;
                return _webDriver;
            }
            protected set { }
        }

        public BaseEntity()
        {
            //var services = ServiceContainer.GetInstance.ServiceProvider;
            //DriverManager = services.GetRequiredService<WebDriverManager>();
            //Browser = services.GetRequiredService<Browser>();
        }

        protected void CloseWebDriver()
        {
            if (_webDriver != null)
            {
                _webDriver.Quit();
                _webDriver = null;
            }
        }
    }
}
