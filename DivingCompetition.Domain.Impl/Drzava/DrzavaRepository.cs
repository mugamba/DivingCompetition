using NHibernate;

namespace DivingCompetition.Domain.Impl
{

    public class DrzavaRepository : Repository<Drzava>, IDrzavaRepository
    {
        public DrzavaRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
