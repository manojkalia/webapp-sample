using System.Web;
using System.Web.Optimization;

namespace SampleApp.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // angular js 
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-resource.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-ui-router.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                   "~/app/app.js",
                   "~/app/common/directives.js",
                   "~/app/common/filters.js",
                   "~/app/common/services.js",
                   "~/app/common/common-service.js",
                   "~/app/settings/controllers/settings-ctrl.js",
                   "~/app/providers/controllers/provider-ctrl.js",
                   "~/app/aboutus/controllers/aboutus-ctrl.js",
                   "~/app/contactus/controllers/contactus-ctrl.js",
                   "~/app/home/controllers/home-ctrl.js"
                   
               ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
