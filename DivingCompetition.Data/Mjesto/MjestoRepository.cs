using DivingCompetition.Model;
using NHibernate;

namespace DivingCompetition.Data
{

    public class MjestoRepository : Repository<Mjesto>, IMjestoRepository
    {
        public MjestoRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
