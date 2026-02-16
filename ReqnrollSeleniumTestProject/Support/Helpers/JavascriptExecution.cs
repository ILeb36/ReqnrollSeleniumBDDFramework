using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Interfaces;
using ILogger = ReqnrollSeleniumTestProject.Support.Interfaces.ILogger;

namespace ReqnrollSeleniumTestProject.Support.Helpers
{
    public class JavascriptExecution : IJavascriptExecution
    {
        private readonly ILogger logger;

        public JavascriptExecution(ILogger logger)
        {
            this.logger = logger;
        }

        public object ExecuteJavascript(IWebDriver webDriver, string script)
        {
            this.logger.Error($"Execute script: '{script}'");
            return ((IJavaScriptExecutor)webDriver).ExecuteScript(script);
        }
    }
}
