using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ReqnrollSeleniumTestProject.Support
{
    public class Browser
    {
        private readonly IWebDriver _webDriver;




        public Browser(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //all actions with browser, waits, alerts, refreshing
    }
}
