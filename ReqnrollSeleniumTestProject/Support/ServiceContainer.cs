using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support.Logs;
using ReqnrollSeleniumTestProject.Support.Screenshots;

namespace ReqnrollSeleniumTestProject.Support
{
    public class ServiceContainer
    {
        private static ServiceContainer _container;

        public IServiceProvider ServiceProvider { get; private set; }

        public static ServiceContainer GetInstance
        {
            get
            {
                _container ??= new ServiceContainer();
                return _container;
            }
        }

        private ServiceContainer()
        {
            ServiceProvider = InitServiceProvider();
        }

        private IServiceProvider InitServiceProvider()
        {
            //IWebDriver driver = WebDriverManager.GetInstance.WebDriver;
            var services = new ServiceCollection();
            services
                //.AddSingleton<IWebDriver>(driver)
                .AddTransient<ILogger, DefaultLogger>()
                .AddTransient<IScreensaver, DefaultScreensaver>()
                .AddTransient<Browser, Browser>();
            return services.BuildServiceProvider();
        }
    }
}
