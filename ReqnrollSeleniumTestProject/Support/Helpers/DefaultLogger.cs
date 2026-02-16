using ReqnrollSeleniumTestProject.Support.Interfaces;

namespace ReqnrollSeleniumTestProject.Support.Helpers
{
    public class DefaultLogger : ILogger
    {
        public DefaultLogger()
        {

        }

        // to do: add custom logger later

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public void Error(string message, Exception exception = null, string screenshot = null)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, Exception exception = null, string screenshot = null)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message, Exception exception = null, string screenshot = null)
        {
            Console.WriteLine(message);
        }
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }
}
