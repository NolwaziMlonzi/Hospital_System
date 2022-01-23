using System.Web;
using System.Web.Optimization;

namespace Hospital_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //Bundle for app methods.
            bundles.Add(new ScriptBundle("~/bundles/methods").Include(
                       "~/Scripts/Custom/methods-{version}.js"));
            //Bundle for api call method.
            bundles.Add(new ScriptBundle("~/bundles/api").Include(
                      "~/Scripts/API/doAPIRequest-{version}.js"));
            //Bundle for styling the app
            bundles.Add(new StyleBundle("~/Content/appCss").Include(
                      "~/Content/appCss.css"));
        }
    }
}
