using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Locators.Youtube.HomePage
{
    public static class HomePageLocators
    {
        public static By UniqueIdentifier => By.XPath("//div[@id='frosted-glass' and contains(@class, 'with-chipbar')]");


        public static class SeachResultsSections
        {
            public static By SearchResultsContainer => By.XPath("//ytd-search[@role='main']");
        }
    }
}
