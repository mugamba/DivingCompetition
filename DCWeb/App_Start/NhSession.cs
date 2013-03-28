using NHibernate;
using NHibernate.Cfg;
using DivingCompetition.Domain.Impl;

namespace DC.Web
{
    public class NhSession
    {
        public static ISessionFactory SessionFactory { get; private set; }

        public static ISession Current
        {
            get
            {
                return SessionFactory.GetCurrentSession();
            }
        }

        internal static ISessionFactory Init()
        {
            var config = new Configuration();
            config.AddAssembly(typeof(Dummy).Assembly);
            config.Configure();
            SessionFactory = config.BuildSessionFactory();
            return SessionFactory;
        }
    }
}