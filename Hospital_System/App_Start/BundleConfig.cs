using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Hospital_System.Models;

namespace Hospital_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            User user = new User();
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/lib/font-awesome/css/all.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            
            bundles.Add(new StyleBundle("~/bundles/font_awesome").Include(
                     "~/lib/font-awesome/css/all.css"));
            if(string.IsNullOrEmpty(user.Theme) || user.Theme =="default")
            {
                bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap_slate.css"
                      "~/Content/bootstrap.css"
                      //"~/Content/bootstrap_ocean.css"
                      // "~/Content/site.css"
                      //"~/Content/bootstrap_cyborg.css"
                      //"~/Content/bootstrap_solar.css"
                      //"~/Content/bootstrap_darkly.css"
                      ));
            }
            else
            {
                
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap_slate.css"
                      //"~/Content/bootstrap.css"
                      "~/Content/bootstrap_"+ user.Theme +".css"
                      // "~/Content/site.css"
                      //"~/Content/bootstrap_cyborg.css"
                      //"~/Content/bootstrap_solar.css"
                      //"~/Content/bootstrap_darkly.css"
                      ));

            }
            //Bundle for app methods.
            bundles.Add(new ScriptBundle("~/bundles/methods").Include(
                       "~/Scripts/Custom/methods-{version}.js"));
            //Bundle for api call method.
            bundles.Add(new ScriptBundle("~/bundles/api").Include(
                      "~/Scripts/API/doAPIRequest-{version}.js"));

            //Bundle for vuejs import.
            bundles.Add(new ScriptBundle("~/bundles/vuejs").Include(
                "~/Scripts/API/VueImport-{version}.js"));

            //Bundle for vuejs import.
            bundles.Add(new ScriptBundle("~/bundles/methods").Include(
                "~/Scripts/Custom/methods-{version}.js"));
            //Bundle for styling the app
            bundles.Add(new StyleBundle("~/Content/appCss").Include(
                      "~/Content/appCss.css"));
        }
    }
}
