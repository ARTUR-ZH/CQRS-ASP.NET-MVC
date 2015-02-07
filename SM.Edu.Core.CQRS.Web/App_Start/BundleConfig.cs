using System.Web;
using System.Web.Optimization;

namespace SM.Edu.Core.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/cdn/Scripts/vendor/jquery/jquery-{version}.js",
                        "~/cdn/Scripts/vendor/jquery/jquery.unobtrusive*",
                        "~/cdn/Scripts/vendor/jquery/jquery.validate*"));

        }
    }
}