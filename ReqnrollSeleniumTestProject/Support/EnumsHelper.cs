namespace ReqnrollSeleniumTestProject.Support
{
    public static class EnumsHelper
    {
        public static bool TryParse<T>(string enumElementStringRepresentation, bool ignoreCase, out T? enumElement) where T : struct, Enum
        {
            if (Enum.TryParse(typeof(T), enumElementStringRepresentation, ignoreCase, out var result))
            {
                enumElement = (T)result;
                return true;
            }

            enumElement = null;
            return false;
        }
    }
}
