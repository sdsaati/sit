using System.Web;
using System.Web.Optimization;

namespace Sitaad
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
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
            /* Styles for Sitaad Theme */
            bundles.Add(new StyleBundle("~/Sitaad/GlobalCSS").Include(
                      "~/Content/Sitaad/plugins/bootstrap/css/bootstrap-rtll.css",
                      "~/Content/Sitaad/css/css-rtl/ie8-rtl.css",
                      "~/Content/Sitaad/css/css-rtl/blocks-rtl.css",
                      "~/Content/Sitaad/css/css-rtl/plugins-rtl.css",
                      "~/Content/Sitaad/css/css-rtl/app-rtl.css",
                      "~/Content/Sitaad/css/css-rtl/style-rtl.css"));
            bundles.Add(new StyleBundle("~/Sitaad/HeaderFooterCSS").Include(
                      "~/Content/Sitaad/css/css-rtl/headers/header-default-rtl.css",
                      "~/Content/Sitaad/css/css-rtl/footers/footer-v1-rtl.css"));
            bundles.Add(new StyleBundle("~/Sitaad/ImplementingPluginsCSS").Include(
                      "~/Content/Sitaad/plugins/animate.css",
                      "~/Content/Sitaad/plugins/line-icons/line-icons.css",
                      "~/Content/Sitaad/plugins/font-awesome/css/font-awesomee.css",
                      "~/Content/Sitaad/plugins/fancybox/source/jquery.fancybox.css"));
            bundles.Add(new StyleBundle("~/Sitaad/owlCSS").Include(
                      "~/Content/Sitaad/plugins/owl-carousel2/assets/owl.carousel.css"));
            bundles.Add(new StyleBundle("~/Sitaad/IE9CSS").Include(
                      "~/Content/Sitaad/plugins/revolution-slider/rs-plugin/css/settings.css"));
            bundles.Add(new StyleBundle("~/Sitaad/StyleSwitcherCSS").Include(
                      "~/Content/Sitaad/plugins/revolution-slider/rs-plugin/css/settings-ie8.css"));
            bundles.Add(new StyleBundle("~/Sitaad/TurbosoftsCSS").Include(
                      "~/Content/Sitaad/css/Turbosofts.css"));
            bundles.Add(new StyleBundle("~/Sitaad/ThemeCSS").Include(
                      "~/Content/Sitaad/css/css-rtl/theme-colors/Sitadblue.css",
                      "~/Content/Sitaad/css/css-rtl/theme-skins/dark.css"));
            bundles.Add(new StyleBundle("~/Sitaad/RTLCustomizationCSS").Include(
                      "~/Content/Sitaad/css/css-rtl/rtl.css"));
            bundles.Add(new StyleBundle("~/Sitaad/CustomizationCSS").Include(
                      "~/Content/Sitaad/css/css-rtl/custom-rtl.css"));
            /* Scripts for Sitaad Theme */
            bundles.Add(new ScriptBundle("~/Sitaad/GlobalJS").Include(
                            "~/Content/Sitaad/plugins/jquery/jquery.js",
                            "~/Content/Sitaad/plugins/jquery/jquery-migratee.js",
                            "~/Content/Sitaad/plugins/bootstrap/js/bootstrapp.js"));
            bundles.Add(new ScriptBundle("~/Sitaad/ImplementingJS").Include(
                            "~/Content/Sitaad/plugins/back-to-top.js",
                            "~/Content/Sitaad/plugins/jquery.parallax.js",
                            "~/Content/Sitaad/plugins/fancybox/source/jquery.fancybox.pack.js",
                            "~/Content/Sitaad/plugins/revolution-slider/rs-plugin/js/jquery.themepunch.toolss.js",
                            "~/Content/Sitaad/plugins/revolution-slider/rs-plugin/js/jquery.themepunch.revolutionn.js"));
            bundles.Add(new ScriptBundle("~/Sitaad/PageLevelJS").Include(
                            "~/Content/Sitaad/js/app.js",
                            "~/Content/Sitaad/js/plugins/fancy-box.js",
                            "~/Content/Sitaad/js/plugins/revolution-slider.js"));
            bundles.Add(new ScriptBundle("~/Sitaad/CustomizationJS").Include(
                            "~/Content/Sitaad/js/custom.js"));
            bundles.Add(new ScriptBundle("~/Sitaad/IE9JS").Include(
                            "~/Content/Sitaad/plugins/respond.js",
                            "~/Content/Sitaad/plugins/html5shiv.js",
                            "~/Content/Sitaad/plugins/placeholder-IE-fixes.js"));
        }
        
    }
}
