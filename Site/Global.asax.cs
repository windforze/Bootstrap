using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Site {
    using System.Web.Optimization;

    using Elmah;

    using Site.App_Start;
    using Site.Helpers;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            RegisterGlobalFilters(GlobalFilters.Filters);

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new ElmahHandledErrorLoggerFilter());
            filters.Add(new HandleErrorAttribute());
        }

        // ELMAH Filtering
// ReSharper disable InconsistentNaming
        protected void ErrorLog_Filtering(object sender, ExceptionFilterEventArgs e) {
// ReSharper restore InconsistentNaming
            FilterError404(e);
        }

// ReSharper disable InconsistentNaming
        protected void ErrorMail_Filtering(object sender, ExceptionFilterEventArgs e) {
// ReSharper restore InconsistentNaming
            FilterError404(e);
        }

        // Dismiss 404 errors for ELMAH
        private static void FilterError404(ExceptionFilterEventArgs e) {
            if (!(e.Exception.GetBaseException() is HttpException))
            {
                return;
            }
            var ex = (HttpException)e.Exception.GetBaseException();
            if (ex.GetHttpCode() == 404)
                e.Dismiss();
        }
    }
}