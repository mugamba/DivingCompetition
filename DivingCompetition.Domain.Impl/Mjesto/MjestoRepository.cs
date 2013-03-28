using NHibernate;

namespace DivingCompetition.Domain.Impl
{

    public class MjestoRepository : Repository<Mjesto>, IMjestoRepository
    {
        public MjestoRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
