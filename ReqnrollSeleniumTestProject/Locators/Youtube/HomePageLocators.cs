using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Locators.Youtube
{
    public static class HomePageLocators
    {
        public static By UniqueIdentifier => By.XPath("//div[@id='frosted-glass' and contains(@class, 'with-chipbar')]");
    }
}
