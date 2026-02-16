namespace ReqnrollSeleniumTestProject.Support.Interfaces
{
    public interface ILogger
    {
        void Info(string message, Exception? exception = null, string? screenshotPath = null);
        void Warn(string message, Exception? exception = null, string? screenshotPath = null);
        void Error(string message, Exception? exception = null, string? screenshotPath = null);
    }
}
