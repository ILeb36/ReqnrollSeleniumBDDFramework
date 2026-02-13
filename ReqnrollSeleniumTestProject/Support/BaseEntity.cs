using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support
{
    public abstract class BaseEntity
    {
        //protected static IServiceCollection services;
        protected Browser Browser;
        private IWebDriver? webDriver;

        public IWebDriver WebDriver
        {
            get
            {
                this.webDriver ??= WebDriverManager.GetNewWebDriver;
                return this.webDriver;
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
            if (this.webDriver != null)
            {
                this.webDriver.Quit();
                this.webDriver = null;
            }
        }
    }
}
