﻿using System.Web;
using System.Web.Mvc;

namespace HL7Parser.Services
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}