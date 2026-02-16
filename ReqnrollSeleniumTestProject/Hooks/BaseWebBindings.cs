using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Hooks
{
    [Binding]
    public abstract class BaseWebBindings : BaseWebEntity
    {
        protected readonly ScenarioContext ScenarioContext;

        protected BaseWebBindings(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }
    }
}
