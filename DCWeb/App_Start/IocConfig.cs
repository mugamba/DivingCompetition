using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Configuration;
using DC.Application;
using DC.Web;
using DivingCompetition.Domain;
using DivingCompetition.Domain.Impl;
using NHibernate;
using NHibernate.Cfg;

namespace DivingCompetition.App_Start
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
       
            builder.RegisterInstance(NhSession.SessionFactory).As<ISessionFactory>().SingleInstance();
            
          //Mjesto
            builder.RegisterType<MjestoRepository>().As<IMjestoRepository>().InstancePerHttpRequest();
            builder.RegisterType<MjestoManagementService>().As<IMjestoManagementService>().InstancePerHttpRequest();
          //Drzava
            builder.RegisterType<DrzavaRepository>().As<IDrzavaRepository>().InstancePerHttpRequest();
            builder.RegisterType<DrzavaManagementService>().As<IDrzavaManagementService>().InstancePerHttpRequest();
          //Klub
            builder.RegisterType<KlubRepository>().As<IKlubRepository>().InstancePerHttpRequest();
            builder.RegisterType<KlubManagementService>().As<IKlubManagementService>().InstancePerHttpRequest();

            // override default dependency resolver to use Autofac
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}