using System.Web;
using System.Web.Optimization;

namespace Omadiko.WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/libCss").Include(
              "~/Content/Dashboard/css/bootstrap.css",
              "~/Content/Dashboard/css/plugins.css",
              "~/Content/Dashboard/css/main.css",
              "~/Content/Dashboard/css/themes.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizrA").Include(
                        "~/Content/Dashboard/js/vendor/modernizr-respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
              "~/Content/Dashboard/js/vendor/bootstrap.min.js",
              "~/Content/Dashboard/js/plugins.js",
              "~/Content/Dashboard/js/main.js"
              ));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
