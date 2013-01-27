using NHibernate;
using NHibernate.Cfg;

namespace DivingCompetition
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

        internal static void Init()
        {
            var config = new Configuration();
            config.AddAssembly(typeof(Domain.Impl.Dummy).Assembly);
            config.Configure();
            SessionFactory = config.BuildSessionFactory();
        }
    }
}