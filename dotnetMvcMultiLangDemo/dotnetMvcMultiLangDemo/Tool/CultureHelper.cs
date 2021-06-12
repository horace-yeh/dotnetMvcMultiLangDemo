using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace dotnetMvcMultiLangDemo.Tool
{
    public static class CultureHelper
    {
        public static string GetCurrentLanguage()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
            return currentCulture;
        }

        public static void SetLanguage(string culture)
        {
            CultureInfo ci = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}