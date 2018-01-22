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
                      "~/Vendor/bootstrap/dist/css/bootstrap.css", new CssRewriteUrlTransform()));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Vendor/bootstrap/dist/js/bootstrap.min.js"));

            // Vue.js
            bundles.Add(new ScriptBundle("~/bundles/vue/js").Include(
                      "~/Vendor/Vue/vue.js"));

            //datepicker js
            bundles.Add(new ScriptBundle("~/bundles/datepicker/js").Include(
                "~/Vendor/bootstrap-datepicker-master/dist/js/bootstrap-datepicker.js"));

            //datepicker style
            bundles.Add(new StyleBundle("~/bundles/datepicker/css").Include(
                        "~/Vendor/bootstrap-datepicker-master/dist/css/bootstrap-datepicker3.css", new CssRewriteUrlTransform()));

            //datetimepicker js
            bundles.Add(new ScriptBundle("~/bundles/datetimepicker/js").Include(
                "~/Vendor/bootstrap-datetimepicker-master/js/moment.min.js",
                "~/Vendor/bootstrap-datetimepicker-master/js/bootstrap-datetimepicker.min.js"));

            //datetimepicker style
            bundles.Add(new StyleBundle("~/bundles/datetimepicker/css").Include(
                        "~/Vendor/bootstrap-datetimepicker-master/css/bootstrap-datetimepicker.min.css", new CssRewriteUrlTransform()));






       //       < script type = "text/javascript" src = "~/Vendor/jquery/dist/jquery.min.js" ></ script >
   
       //< script type = "text/javascript" src = "~/Vendor/bootstrap/dist/js/bootstrap.min.js" ></ script >
      
       //   < script type = "text/javascript" src = "~/Scripts/moment.min.js" ></ script >
         
       //      < script type = "text/javascript" src = "~/Vendor/bootstrap-datetimepicker-master/js/bootstrap-datetimepicker.min.js" ></ script >
            


       //         < link rel = "stylesheet" href = "~/Vendor/bootstrap/dist/css/bootstrap.css" />
               
       //            < link rel = "stylesheet" href = "~/Vendor/bootstrap-datetimepicker-master/css/bootstrap-datetimepicker.min.css" />






        }

    }
}