using System.Web;
using System.Web.Optimization;

namespace WebApp
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

            bundles.Add(new StyleBundle("~/GLOBAL/MANDATORY/STYLES/s").Include(

                      "~/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                      "~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                      "~/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                      "~/assets/global/plugins/uniform/css/uniform.default.css",
                      "~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css"

                      ));
            bundles.Add(new StyleBundle("~/PAGE/LEVEL/PLUGINS/s").Include(
                  "~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css",
                      "~/assets/global/plugins/morris/morris.css",
                      "~/assets/global/plugins/fullcalendar/fullcalendar.min.css",
                      "~/assets/global/plugins/jqvmap/jqvmap/jqvmap.css"

                      ));
            bundles.Add(new StyleBundle("~/PAGE/LEVEL/PLUGINS2/s").Include(
       "~/assets/global/plugins/datatables/datatables.min.css",
           "~/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.css",
           "~/assets/global/plugins/bootstrap-datepicker/css/bootstrap-datepicker3.min.css"

           ));
            bundles.Add(new StyleBundle("~/THEME/GLOBAL/STYLES/s").Include(
                 "~/assets/global/css/components-md.min.css",
                     "~/assets/global/css/plugins-md.min.css"
                     ));
            bundles.Add(new StyleBundle("~/THEME/LAYOUT/STYLES/s").Include(
                "~/assets/layouts/layout/css/layout.min.css",
                    "~/assets/layouts/layout/css/themes/default.min.css",
                    "~/assets/layouts/layout/css/custom.min.css"
                    ));
            bundles.Add(new ScriptBundle("~/CORE/PLUGINS/x").Include(
                        "~/assets/global/plugins/jquery.min.js",
                        "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/global/plugins/js.cookie.min.js",
                        "~/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                        "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/global/plugins/jquery.blockui.min.js",
                        "~/assets/global/plugins/uniform/jquery.uniform.min.js",
                        "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/PAGE/LEVEL/PLUGINS/x").Include(
                       "~/assets/global/plugins/moment.min.js",
                       "~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js",
                       "~/assets/global/plugins/morris/morris.min.js",
                       "~/assets/global/plugins/morris/raphael-min.js",
                       "~/assets/global/plugins/counterup/jquery.waypoints.min.js",
                       "~/assets/global/plugins/counterup/jquery.counterup.min.js",
                       "~/assets/global/plugins/amcharts/amcharts/amcharts.js",
                       "~/assets/global/plugins/amcharts/amcharts/serial.js",
                        "~/assets/global/plugins/amcharts/amcharts/pie.js",
                       "~/assets/global/plugins/amcharts/amcharts/radar.js",
                       "~/assets/global/plugins/amcharts/amcharts/themes/light.js",
                       "~/assets/global/plugins/amcharts/amcharts/themes/patterns.js",
                       "~/assets/global/plugins/amcharts/amcharts/themes/chalk.js",
                       "~/assets/global/plugins/amcharts/ammap/ammap.js",
                       "~/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js",
                       "~/assets/global/plugins/amcharts/amstockcharts/amstock.js",
                        "~/assets/global/plugins/fullcalendar/fullcalendar.min.js",
                       "~/assets/global/plugins/flot/jquery.flot.min.js",
                       "~/assets/global/plugins/flot/jquery.flot.resize.min.js",
                       "~/assets/global/plugins/flot/jquery.flot.categories.min.js",
                       "~/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js",
                       "~/assets/global/plugins/jquery.sparkline.min.js",


                       "~/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js"
                       ));
            bundles.Add(new ScriptBundle("~/PAGE/LEVEL/PLUGINS2/x").Include(
                 "~/assets/global/scripts/datatable.js",
                  "~/assets/global/plugins/datatables/datatables.min.js",
                   "~/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.js",
                    "~/assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js",
                    "~/assets/global/plugins/bootstrap-confirmation/bootstrap-confirmation.min.js"

                ));
            bundles.Add(new ScriptBundle("~/THEME/GLOBAL/SCRIPTS/x").Include(
               "~/assets/global/scripts/app.min.js"
               ));
            bundles.Add(new ScriptBundle("~/PAGE/LEVEL/SCRIPTS/x").Include(
          "~/assets/pages/scripts/dashboard.min.js"
          ));
            bundles.Add(new ScriptBundle("~/PAGE/LEVEL/SCRIPTS2/x").Include(
    "~/assets/pages/scripts/table-datatables-buttons.min.js",
     "~/assets/pages/scripts/ui-confirmations.min.js"
    ));
            bundles.Add(new ScriptBundle("~/THEME/LAYOUT/SCRIPTS/x").Include(
  "~/assets/layouts/layout/scripts/layout.min.js",
                       "~/assets/layouts/layout/scripts/demo.min.js",
                       "~/assets/layouts/global/scripts/quick-sidebar.min.js"
  ));

        }
    }
}