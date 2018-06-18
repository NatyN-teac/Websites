using System.Web.Optimization;

namespace BHSM
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
                       "~/Scripts/bootbox.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/slider").Include(
                     "~/Scripts/immersive.js"));

            bundles.Add(new ScriptBundle("~/bundles/pageSpec").Include(
                    "~/Scripts/OfficePageScript.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/slider.css",
                       "~/Content/indexBodyStyle.css",
                       "~/Content/foot.css",
                       "~/Content/deprt.css",
                        "~/Content/curriculum.css",
                       "~/Content/DepartOnly.css"));
           
            bundles.Add(new StyleBundle("~/Content/admin").Include(
                   "~/Areas/Admin/Content/bootstrap.css", 
                   "~/Areas/Admin/Content/site.css",
                  
                   "~/Areas/Admin/Content/sb-admin.css"
                   
                   ));

            bundles.Add(new StyleBundle("~/Content/Non").Include(
                     "~/Content/StyleForNonDep.css"));

            bundles.Add(new StyleBundle("~/Content/share").Include(
                   "~/Content/sharedstyle.css"));

        }
    }
}
