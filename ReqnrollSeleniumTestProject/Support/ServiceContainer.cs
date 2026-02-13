using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support.Logs;
using ReqnrollSeleniumTestProject.Support.Screenshots;

namespace ReqnrollSeleniumTestProject.Support
{
    public class ServiceContainer
    {
        private static ServiceContainer _container;

        public IServiceProvider ServiceProvider { get; private set; }

        public static ServiceContainer Instance
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
            var services = new ServiceCollection();
            services
                .AddSingleton<Browser, Browser>()
                .AddSingleton<ILogger, DefaultLogger>()
                .AddTransient<IScreensaver, DefaultScreensaver>();
            return services.BuildServiceProvider();
        }
    }
}
