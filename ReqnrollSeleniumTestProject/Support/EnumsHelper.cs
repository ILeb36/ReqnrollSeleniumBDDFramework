namespace ReqnrollSeleniumTestProject.Support
{
    public static class EnumsHelper
    {
        public static bool TryParse<T>(string enumElementStringRepresentation, out T? enumElement) where T : struct, Enum
        {
            if (Enum.TryParse(typeof(T), enumElementStringRepresentation, true, out var result))
            {
                enumElement = (T)result;
                return true;
            }

            enumElement = null;
            return false;
        }
    }
}
