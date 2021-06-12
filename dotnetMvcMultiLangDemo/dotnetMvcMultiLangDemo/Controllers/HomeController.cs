using dotnetMvcMultiLangDemo.Tool;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetMvcMultiLangDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SetCulture(string culture, string returnUrl)
        {
            //Reference : https://dotblogs.com.tw/wasichris/2015/06/20/151608

            var MultiLangSetting = ConfigurationManager.AppSettings["MultiLanguageCookie"];
            CookieTool.SetCookie(Request,Response, MultiLangSetting, culture,new TimeSpan(365,0,0,0));
            return Redirect(returnUrl);
        }
    }
}