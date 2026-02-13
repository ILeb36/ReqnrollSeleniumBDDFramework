using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support.Logs;
using ReqnrollSeleniumTestProject.Support.Screenshots;
using ReqnrollSeleniumTestProject.Support.WebDriver;

namespace ReqnrollSeleniumTestProject.Support
{
    public class ServiceContainer
    {
        private static ServiceContainer? container;

        public IServiceProvider ServiceProvider { get; private set; }

        public static ServiceContainer Instance
        {
            get
            {
                container ??= new ServiceContainer();
                return container;
            }
        }

        private ServiceContainer()
        {
            ServiceProvider = InitServiceProvider();
        }

        private IServiceProvider InitServiceProvider()
        {
            var services = new ServiceCollection();
            services
                .AddTransient<IScreensaver, DefaultScreensaver>()
                .AddSingleton<ILogger, DefaultLogger>()
                .AddSingleton<Browser, Browser>();
            return services.BuildServiceProvider();
        }
    }
}
