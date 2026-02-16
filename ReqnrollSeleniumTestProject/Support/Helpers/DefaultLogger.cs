using ReqnrollSeleniumTestProject.Support.Interfaces;

namespace ReqnrollSeleniumTestProject.Support.Helpers
{
    public class DefaultLogger : ILogger
    {
        public DefaultLogger()
        {

        }

        // to do: add custom logger when I have time

        public void Error(string message, Exception? exception = null, string? screenshot = null)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, Exception? exception = null, string? screenshot = null)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message, Exception? exception = null, string? screenshot = null)
        {
            Console.WriteLine(message);
        }
    }
}
