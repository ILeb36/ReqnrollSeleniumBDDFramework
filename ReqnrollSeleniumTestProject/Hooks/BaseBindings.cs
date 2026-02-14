using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public abstract class BaseBindings
    {
        protected readonly ScenarioContext ScenarioContext;
        protected static readonly ServiceContainer ServiceContainer;
        protected static readonly HttpClient HttpClient;


        protected BaseBindings(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        static BaseBindings()
        {
            ServiceContainer = ServiceContainer.Instance;
            HttpClient = ServiceContainer.ServiceProvider.GetRequiredService<HttpClient>();
        }
    }
}
