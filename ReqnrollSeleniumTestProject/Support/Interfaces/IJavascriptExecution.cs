using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support.Interfaces
{
    public interface IJavascriptExecution
    {
        public object ExecuteJavascript(IWebDriver webDriver, string script);
    }
}
