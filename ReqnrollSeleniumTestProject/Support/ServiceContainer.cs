using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support.Helpers;
using ReqnrollSeleniumTestProject.Support.Interfaces;
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

        private static IServiceProvider InitServiceProvider()
        {
            var services = new ServiceCollection();
            services
                .AddSingleton<HttpClient, HttpClient>()
                .AddTransient<IScreensaver, DefaultScreensaver>()
                .AddSingleton<ILogger, DefaultLogger>()
                .AddTransient<IJavascriptExecution, JavascriptExecution>()
                .AddSingleton<Browser, Browser>();
            return services.BuildServiceProvider();
        }
    }
}
