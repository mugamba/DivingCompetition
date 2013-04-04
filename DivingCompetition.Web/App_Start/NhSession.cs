using NHibernate;
using NHibernate.Cfg;
using DivingCompetition.Data;

namespace DivingCompetition.Web
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
            config.AddAssembly(typeof(MjestoRepository).Assembly);
            config.Configure();
            SessionFactory = config.BuildSessionFactory();
            return SessionFactory;
        }
    }
}