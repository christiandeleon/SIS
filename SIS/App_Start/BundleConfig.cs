using System.Web;
using System.Web.Optimization;

namespace SIS
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

      
            //Modify 

            //gebo styles
            bundles.Add(new StyleBundle("~/bundles/gebo/css").Include(
              "~/bootstrap/css/bootstrap.css",
              "~/lib/jquery-ui/css/Aristo/Aristo.css",
              "~/lib/jBreadcrumbs/css/BreadCrumb.css",
              "~/lib/qtip2/jquery.qtip.min.css",
              "~/lib/colorbox/colorbox.css",
              "~/lib/google-code-prettify/prettify.css",
              "~/lib/sticky/sticky.css",
              "~/img/splashy/splashy.css",
              "~/img/flags/flags.css",
              "~/lib/datatables/extras/TableTools/media/css/TableTools.css",
              "~/lib/smoke/themes/gebo.css",
              "~/Content/style.css",
              "~/Content/Site.css",
              "~/Content/blue.css"));

            //gebo scripts
            bundles.Add(new ScriptBundle("~/bundles/gebo/js").Include(
                        "~/lib/jquery-ui/jquery-ui-1.10.0.custom.min.js",
                        "~/js/forms/jquery.ui.touch-punch.min.js",
                        "~/js/jquery.easing.1.3.min.js",
                        "~/js/jquery.debouncedresize.min.js",
                        "~/js/jquery_cookie_min.js",
                        "~/lib/typeahead/typeahead.min.js",
                        "~/lib/google-code-prettify/prettify.min.js",
                        "~/lib/sticky/sticky.min.js",
                        "~/lib/jBreadcrumbs/js/jquery.jBreadCrumb.1.1.min.js",
                        "~/js/jquery.actual.min.js",
                        "~/lib/slimScroll/jquery.slimscroll.js",
                        "~/js/ios-orientationchange-fix.js",
                        "~/lib/UItoTop/jquery.ui.totop.min.js",
                        "~/js/selectNav.js",
                        "~/lib/moment/moment.min.js",
                        "~/js/pages/gebo_common.js",
                         "~/lib/smoke/smoke.js",
                         "~/js/jquery.inputmask.bundle.min.js",
                        "~/js/sis_common.js"));


            //jqwidgets styles
            bundles.Add(new StyleBundle("~/bundles/jqwidgets/css").Include(
                "~/js/jqwidgets/css/jqx.base.css",
                "~/js/jqwidgets/css/jqx.bootstrap.css"
            ));



            //jqwidgets scripts
           bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
                        "~/js/jqwidgets/jqx-all.js"));

        }
    }
}
