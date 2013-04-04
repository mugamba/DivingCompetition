using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NHibernate;
using NHibernate.Context;
using Ninject;

namespace DivingCompetition.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();


            IocConfig.RegisterIoc(GlobalConfiguration.Configuration);

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            NhSession.Init();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfig.CustomizeConfig(GlobalConfiguration.Configuration);
        }

        protected void Application_BeginRequest()
        {
            var session = NhSession.SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);

        }
        protected void Application_EndRequest()
        {
            CurrentSessionContext.Unbind(NhSession.SessionFactory);
        }
    }
}