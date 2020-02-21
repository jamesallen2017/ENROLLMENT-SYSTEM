using System.Web;
using System.Web.Optimization;

namespace Enrollment_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/main_assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js",
                        "~/main_assets/js/vendor/jquery-1.11.2.min.js",
                        "~/main_assets/js/vendor/bootstrap.min.js",
                        "~/main_assets/js/datepicker.js",
                        "~/main_assets/js/plugins.js",
                        "~/main_assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/main_assets/css/bootstrap.min.css",
                      "~/main_assets/css/bootstrap-theme.min.css",
                      "~/main_assets/css/fontAwesome.css",
                      "~/main_assets/css/hero-slider.css",
                      "~/main_assets/css/owl-carousel.css",
                      "~/main_assets/css/datepicker.css",
                      "~/main_assets/css/tooplate-style.css"));

            bundles.Add(new ScriptBundle("~/bundles/Adminjquery").Include(
                    "~/assets/vendor/jquery/jquery-3.3.1.min.js",
                    "~/assets/vendor/bootstrap/js/bootstrap.bundle.js",
                    "~/assets/vendor/slimscroll/jquery.slimscroll.js",
                    "~/assets/libs/js/main-js.js",
                    "~/assets/libs/datatables/jquery.dataTables.min.js",
                    "~/assets/libs/datatables/dataTables.bootstrap.js",
                    "~/assets/libs/datatables/dataTables.buttons.min.js",
                    "~/assets/libs/datatables/buttons.bootstrap.min.js",
                    "~/assets/libs/datatables/jszip.min.js",
                    "~/assets/libs/datatables/pdfmake.min.js",
                    "~/assets/libs/datatables/vfs_fonts.js",
                    "~/assets/libs/datatables/buttons.html5.min.js",
                    "~/assets/libs/datatables/buttons.print.min.js",
                    "~/assets/libs/datatables/dataTables.fixedHeader.min.js",
                    "~/assets/libs/datatables/dataTables.keyTable.min.js",
                    "~/assets/libs/datatables/dataTables.responsive.min.js",
                    "~/assets/libs/datatables/responsive.bootstrap.min.js",
                    "~/assets/libs/datatables/dataTables.scroller.min.js",
                    "~/assets/libs/datatables/dataTables.colVis.js",
                    "~/assets/libs/datatables/dataTables.fixedColumns.min.js",
                    "~/assets/libs/jquery.datatables.init.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/Admincss").Include(
                    "~/assets/libs/datatables/jquery.dataTables.min.css",
                    "~/assets/libs/datatables/buttons.bootstrap.min.css",
                    "~/assets/libs/datatables/fixedHeader.bootstrap.min.css",
                    "~/assets/libs/datatables/responsive.bootstrap.min.css",
                    "~/assets/libs/datatables/scroller.bootstrap.min.css",
                    "~/assets/libs/datatables/dataTables.colVis.css",
                    "~/assets/libs/datatables/dataTables.bootstrap.min.css",
                    "~/assets/libs/datatables/fixedColumns.dataTables.min.css",
                    "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                    "~/assets/vendor/fonts/circular-std/style.css",
                    "~/assets/css/style.css"
                    ));
        }
    }
}
