using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Locators.Youtube.CommonElements
{
    public static class HeaderLocators
    {
        public static By HeaderBar => By.XPath("//ytd-masthead[@id='masthead']/div[@id='container']");

        public static class SearchBar
        {
            public static By SearchBarContainer => By.XPath("./div[@id='center']");
            public static By SearchTextBox => By.Name("search_query");
        }
    }
}
