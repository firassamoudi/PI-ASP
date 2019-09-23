using System.Web;
using System.Web.Optimization;

namespace NeoXam.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Style
            bundles.Add(new StyleBundle("~/assets/css").Include(
                    "~/assets/css/bootstrap.min.css",
                     "~/assets/css/style.css",
                    "~/assets/css/icons.cs"));


            bundles.Add(new StyleBundle("~/assets/plugins").Include(
                    "~/assets/plugins/morris/morris.css"
                    ));
            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/assets/js/jquery.min.js",
                      "~/assets/js/popper.min.js",
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/js/modernizr.min.js",
                      "~/assets/js/detect.js",
                       "~/assets/plugins/morris/morris.min.js",
                       "~/assets/plugins/raphael/raphael-min.js",
                        "~/assets/pages/dashborad.js",
                      "~/assets/js/fastclick.js",
                      "~/assets/js/jquery.blockUI.js",
                      "~/assets/js/waves.js",
                      "~/assets/js/jquery.nicescroll.js",
                      "~/assets/js/jquery.scrollTo.min.js",
                      "~/assets/js/app.js",
                      "~/Scripts/jquery.slimscroll.js"));
        }
    }
}
