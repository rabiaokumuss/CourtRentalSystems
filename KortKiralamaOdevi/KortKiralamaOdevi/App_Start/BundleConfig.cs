using System.Web;
using System.Web.Optimization;

namespace KortKiralamaOdevi
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/adminJs").Include(
                "~/Content/admin/vendor/jquery/jquery.min.js",
                "~/Content/admin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/admin/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/admin/js/sb-admin.min.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/admincss").Include(
                "~/Content/admin/css/sb-admin.css",
                "~/Content/admin/vendor/font-awesome/css/font-awesome.min.css",
                "~/Content/admin/vendor/bootstrap/css/bootstrap.min.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/maincss").Include(
                "~/Content/main/css/bootstrap.min.css",
                "~/Content/main/css/simple-line-icons.css",
                "~/Content/main/css/themify-icons.css",
                "~/Content/main/css/set1.css",
                "~/Content/main/css/swiper.min.css",
                "~/Content/main/css/magnific-popup.css",
                "~/Content/main/css/style.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/mainJs").Include(
                "~/Content/main/js/jquery-3.2.1.min.js",
                "~/Content/main/js/popper.min.js",
                "~/Content/main/js/bootstrap.min.js",
                "~/Content/main/js/jquery.magnific-popup.js",
                "~/Content/main/js/swiper.min.js"
            ));
        }
    }
}
