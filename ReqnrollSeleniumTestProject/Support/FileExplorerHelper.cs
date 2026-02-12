namespace ReqnrollSeleniumTestProject.Support
{
    public static class FileExplorerHelper
    {
        public static string GetDownloadFolderPath()
        {
            var downloadFolderName = ConfigReader.GetDownloadFolderName;
            var currentDirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(currentDirectoryPath, downloadFolderName);
        }
    }
}
