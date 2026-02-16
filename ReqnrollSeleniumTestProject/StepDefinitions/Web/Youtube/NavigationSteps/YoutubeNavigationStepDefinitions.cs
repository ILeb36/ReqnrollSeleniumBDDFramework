using NUnit.Framework;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Models.YoutubeSearch;
using ReqnrollSeleniumTestProject.Hooks;

namespace ReqnrollSeleniumTestProject.StepDefinitions.Web.Youtube.NavigationSteps
{
    [Binding]
    public class YoutubeNavigationStepDefinitions : BaseWebBindings
    {
        public YoutubeNavigationStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given("I open the Youtube")]
        public void GivenIOpenTheYoutube()
        {
            Browser.OpenBaseUrl();
        }
    }
}
