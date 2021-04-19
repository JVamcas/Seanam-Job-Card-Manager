using System.Globalization;

namespace SeaNam_Job_Card_Controller.Utils
{
    public static class ParseUtils
    {
        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}