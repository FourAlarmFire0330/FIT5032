using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace EatForHealth
{
    public class BundleConfig
    {
          public static void RegisterBundles(BundleCollection bundles)
          {
             bundles.Add(new StyleBundle("~/Content/LoginCss").Include(
                 "~/Content/css/Login.css"
                 ));
         }
    }
}