using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.App_Start {
    using System.Web.Optimization;

    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));
            

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                        .Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/masonry")
                        .Include("~/Scripts/jquery.masonry.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css")
                        .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap.min/css")
                        .Include("~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new StyleBundle("~/Content/base/css")
                        .Include("~/Content/base.css"));

            BundleTable.EnableOptimizations = true;
        }

    }
}