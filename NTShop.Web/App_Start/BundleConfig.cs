using System.Web.Optimization;

namespace NTShop.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include("~/Assets/client/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/js/plugins").Include(
                 "~/bower_components/jquery-ui/jquery-ui.min.js",
                 "~/bower_components/mustache/mustache.js",
                 "~/bower_components/numeral/numeral.js",
                 "~/bower_components/jquery-validation/dist/jquery.validate.js",
                 "~/bower_components/jquery-validation/dist/additional-methods.min.js",
                 "~/Assets/client/js/common.js"
                 ));

            bundles.Add(new StyleBundle("~/css/base")
                .Include("~/Assets/client/css/bootstrap.css", new CssRewriteUrlTransform())
                .Include("~/bower_components/jquery-ui/themes/smoothness/jquery-ui.min.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/css/style.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/css/custom.css", new CssRewriteUrlTransform())

                );

            BundleTable.EnableOptimizations = true;
        }
    }
}