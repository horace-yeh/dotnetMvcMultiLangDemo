﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetMvcMultiLangDemo.Tool
{
    public static class CookieTool
    {
        public static void SetCookie(HttpRequestBase req, HttpResponseBase resp, string key, string value, TimeSpan expires)
        {
            HttpCookie cookie = req.Cookies.Get(key);
            if (cookie == null)
            {
                cookie = new HttpCookie(key);
            }
            cookie.Expires = DateTime.Now.Add(expires);
            cookie.Value = value;
            resp.Cookies.Add(cookie);
        }

        public static string GetCookie(HttpRequestBase req, string key)
        {
            HttpCookie cookie = req.Cookies[key];
            var value = cookie?.Value;
            return value;
        }
    }
}