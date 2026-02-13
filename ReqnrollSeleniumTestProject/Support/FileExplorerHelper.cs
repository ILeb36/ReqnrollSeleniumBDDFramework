namespace ReqnrollSeleniumTestProject.Support
{
    public static class FileExplorerHelper
    {
        public static string GetDownloadFolderPath()
        {
            var downloadsFolderName = ConfigReader.GetDownloadsFolderName;
            var currentDirectoryPath = GetExecutionFolderPath();
            return Path.Combine(currentDirectoryPath, downloadsFolderName);
        }

        public static string GetScreenshotsFolderPath()
        {
            var screenshotsFolderName = ConfigReader.GetScreenshotsFolderName;
            var currentDirectoryPath = GetExecutionFolderPath();
            return Path.Combine(currentDirectoryPath, screenshotsFolderName);
        }

        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        private static string GetExecutionFolderPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
