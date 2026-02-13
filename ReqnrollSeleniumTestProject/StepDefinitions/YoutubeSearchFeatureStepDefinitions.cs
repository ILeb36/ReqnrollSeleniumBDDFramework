using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using ReqnrollSeleniumTestProject.Support;

namespace ReqnrollSeleniumTestProject.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions : Browser
    {

        [Given("I open the Youtube")]
        public void GivenIOpenTheYoutube()
        {
            WebDriver.Navigate().GoToUrl("https://www.youtube.com");
        }

        [When("I search for the Testers Talk")]
        public void WhenISearchForTheTestersTalk()
        {
            var element = WebDriver.FindElement(By.Name("search_query"));
            
            element.SendKeys("Testers talk");
            element.SendKeys(Keys.Enter);
        }

        [Then("Search result page is opened")]
        public void ThenSearchResultPageIsOpened()
        {
            Thread.Sleep(3000);
        }

    }
}
