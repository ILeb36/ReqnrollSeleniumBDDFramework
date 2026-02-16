using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ReqnrollSeleniumTestProject.Support.Abstracts;

namespace ReqnrollSeleniumTestProject.Pages.Youtube.CommonElements.Header
{
    public class HeaderSearchBar : BaseWebElement
    {
        public HeaderSearchBar(By elementLocator, By parentElementLocator) : base(elementLocator, parentElementLocator)
        {
        }

        public override string ElementType => "Header search bar";
    }
}
