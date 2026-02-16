using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollSeleniumTestProject.Support.Interfaces
{
    public interface ILogger
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        void Info(string message, Exception exception = null, string screenshotPath = null);
        void Warn(string message, Exception exception = null, string screenshotPath = null);
        void Error(string message, Exception exception = null, string screenshotPath = null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }
}
