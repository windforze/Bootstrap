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
                        .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/bootstrap-responsive.css"));

            BundleTable.EnableOptimizations = true;
        }

    }
}