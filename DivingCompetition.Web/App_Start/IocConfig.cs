using System.Web.Http;
using DivingCompetition.Data;
using DivingCompetition.Model;
using NHibernate.Cfg;
using Ninject;
using NHibernate;

namespace DivingCompetition.Web
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

            // These registrations are "per instance request".
            // See http://blog.bobcravens.com/2010/03/ninject-life-cycle-management-or-scoping/


            kernel.Bind<ISessionFactory>().ToMethod<ISessionFactory>(ctx => NhSession.SessionFactory).InSingletonScope();


            kernel.Bind<IMjestoRepository>().To<MjestoRepository>();
            // Tell WebApi how to use our Ninject IoC
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}