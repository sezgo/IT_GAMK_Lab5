﻿using System.Web;
using System.Web.Mvc;

namespace IT_GAMK_Lab5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
