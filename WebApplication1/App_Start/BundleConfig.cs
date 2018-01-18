using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                      "~/Vendor/jquery/dist/jquery.min.js"));

            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Vendor/bootstrap/dist/css/bootstrap.min.css", new CssRewriteUrlTransform()));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Vendor/bootstrap/dist/js/bootstrap.min.js"));

            // Vue.js
            bundles.Add(new ScriptBundle("~/bundles/vue/js").Include(
                      "~/Vendor/Vue/vue.js"));

            //daterangepicker js
            bundles.Add(new ScriptBundle("~/bundles/daterangepicker-master/js").Include(
                "~/Vendor/daterangepicker-master/daterangepicker.js",
                "~/Vendor/daterangepicker-master/moment.min.js"));

            //daterangepicker style
            bundles.Add(new StyleBundle("~/bundles/daterangepicker-master/css").Include(
                        "~/Vendor/daterangepicker-master/daterangepicker.css", new CssRewriteUrlTransform()));
        }

    }
}