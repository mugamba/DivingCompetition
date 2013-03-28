using NHibernate;

namespace DivingCompetition.Domain.Impl
{

    public class KlubRepository : Repository<Klub>, IKlubRepository
    {
        public KlubRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
