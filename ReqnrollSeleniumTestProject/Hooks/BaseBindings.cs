using ReqnrollSeleniumTestProject.Support;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public abstract class BaseBindings
    {
        protected readonly ScenarioContext ScenarioContext;
        protected static readonly ServiceContainer ServiceContainer;


        protected BaseBindings(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        static BaseBindings()
        {
            ServiceContainer = ServiceContainer.Instance;        
        }
    }
}
