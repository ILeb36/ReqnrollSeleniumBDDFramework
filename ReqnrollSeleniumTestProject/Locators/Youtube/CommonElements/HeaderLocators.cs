using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements
{
    public static class HeaderLocators
    {
        public static By HeaderBar => By.XPath("//ytd-masthead[@id='masthead']/div[@id='container']");


        public static class StartSection
        {
            public static By StartSectionContainer => By.XPath("./div[@id='start']");
            public static By YoutubeLogo => By.Id("logo");
        }

        public static class SearchSection
        {
            public static By SearchSectionContainer => By.XPath("./div[@id='center']");
            public static By SearchTextBox => By.Name("search_query");
        }

        public static class LoginSection
        {

        }
    }
}
