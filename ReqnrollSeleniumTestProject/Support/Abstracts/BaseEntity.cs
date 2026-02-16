using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using ReqnrollSeleniumTestProject.Support.Interfaces;

namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    [Binding]
    public abstract class BaseEntity
    {
        protected static readonly ServiceContainer ServiceContainer;
        protected static readonly ILogger Logger;

        static BaseEntity()
        {
            ServiceContainer = ServiceContainer.Instance;
            Logger = ServiceContainer.ServiceProvider.GetRequiredService<ILogger>();
        }
    }
}
