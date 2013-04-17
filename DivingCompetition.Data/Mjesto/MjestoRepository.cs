using DC.Model;
using NHibernate;

namespace DC.Data
{

    public class MjestoRepository : Repository<Mjesto>, IMjestoRepository
    {
        public MjestoRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
