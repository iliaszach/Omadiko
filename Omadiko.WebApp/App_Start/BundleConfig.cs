using System.Web;
using System.Web.Optimization;

namespace Omadiko.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/CrexisCss").Include(
                "~/Content/css/reset.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/socials.css",
                "~/Content/css/magnific-popup.css",
                "~/Content/css/flexslider.css",
                "~/Content/css/simpletextrotator.css",
                "~/Content/css/cubeportfolio.min.css",
                "~/Content/css/timeline.css",
                "~/Content/css/owl.carousel.css",
                "~/Content/css/settings-ie8.css",
                "~/Content/css/settings.css",
                "~/Content/css/style.css",
                "~/Content/css/backgrounds.css",
                "~/Content/css/responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                "~/Scripts/js/jquery-2.1.3.min.js",
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/jquery.appear.js",
                "~/Scripts/js/waypoint.js",
                "~/Scripts/js/modernizr-latest.js",
                "~/Scripts/js/jquery.easing.1.3.js",
                "~/Scripts/js/SmoothScroll.js",
                "~/Scripts/js/jquery.magnific-popup.min.js",
                "~/Scripts/js/jquery.superslides.js",
                "~/Scripts/js/jquery.flexslider.js",
                "~/Scripts/js/jquery.simple-text-rotator.js",
                "~/Scripts/js/jquery.cubeportfolio.js",
                "~/Scripts/js/owl.carousel.min.js",
                "~/Scripts/js/jquery.parallax-1.1.3.js",
                "~/Scripts/js/skrollr.min.js",
                "~/Scripts/js/jquery.fitvids.js",
                "~/Scripts/js/jquery.mb.YTPlayer.js",
                "~/Scripts/js/google-map.js",
                "~/Scripts/js/rev_slider/jquery.themepunch.revolution.min.js",
                "~/Scripts/js/rev_slider/jquery.themepunch.tools.min.js",
                "~/Scripts/js/rev_slider/rev_plugins.js",
                "~/Scripts/js/jquery.validate.min.js",
                "~/Scripts/js/contact-form.js",
                "~/Scripts/js/plugins.js",
                "~/Scripts/js/portfolio.js",
                "~/Scripts/theme_panel/themepanel.js"
                ));


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
        }
    }
}
