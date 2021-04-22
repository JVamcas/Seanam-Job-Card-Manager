using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SeaNam_Job_Card_Controller.Utils
{
    public static class ParseUtils
    {
        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static ObservableCollection<T> AddAll<T>(this ObservableCollection<T> target, IList<T> source)
        {
            if (target == null)
                target = new ObservableCollection<T>();

            if (source == null)
                return target;

            foreach (var element in source)
            {
                target.Add(element);
            }
            return target;
        }
    }
}