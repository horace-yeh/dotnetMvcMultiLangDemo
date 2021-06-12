using dotnetMvcMultiLangDemo.Tool;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace dotnetMvcMultiLangDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
            var MultiLangSetting = ConfigurationManager.AppSettings["MultiLanguageCookie"];
            var LangSetting = CookieTool.GetCookie(new HttpRequestWrapper(Request),MultiLangSetting);
            if(LangSetting != null)
            {
                CultureHelper.SetLanguage(LangSetting);
            }
		}
	}
}
