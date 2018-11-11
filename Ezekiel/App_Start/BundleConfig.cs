using System.Web;
using System.Web.Optimization;

namespace Ezekiel
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

            bundles.Add(new ScriptBundle("~/bundles/utilities").Include(
                        "~/Scripts/utilities.js"));

            bundles.Add(new ScriptBundle("~/bundles/buttons").Include(
                      "~/Scripts/Buttons-1.5.4/js/buttons.bootstrap.js",
                      "~/Scripts/Buttons-1.5.4/js/datatables.buttons.js",
                      "~/Scripts/Buttons-1.5.4/js/buttons.colVis.js",
                      "~/Scripts/Buttons-1.5.4/js/buttons.html5.js",
                      "~/Scripts/Buttons-1.5.4/js/buttons.html5.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/dataTables.js",
                      "~/Scripts/DataTables-1.10.18/js/dataTables.bootstrap.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/highcharts").Include(
                      "~/Scripts/Highcharts/code/js/highcharts.js",
                      "~/Scripts/Highcharts-Gantt/js/code/highcharts-gantt.js"
                      //"~/Scripts/Highmaps/code/js/highmaps.js",
                      //"~/Scripts/Highstock/code/js/highstock.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                      "~/Scripts/moment.js",
                      "~/Scripts/moment-timezone.js",
                      "~/Scripts/moment-timezone-with-data.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/buttons").Include(
                      "~/Content/Buttons-1.5.4/css/buttons.bootstrap.css",
                      "~/Content/Buttons-1.5.4/css/buttons.bootstrap.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                      "~/Content/DataTables-1.10.18/css/dataTables.bootstrap.css",
                      "~/Content/DataTables-1.10.18/css/dataTables.bootstrap.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/highcharts").Include(
                      "~/Content/Highcharts/code/css/highcharts.css",
                      "~/Content/Highcharts-Gantt/code/css/highcharts.css",
                      "~/Content/Highmaps/code/css/highcharts.css",
                      "~/Content/Highstock/code/css/highcharts.css"
                      ));
        }
    }
}
