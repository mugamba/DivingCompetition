using DC.Model;
using NHibernate;

namespace DC.Data
{

    public class DrzavaRepository : Repository<Drzava>, IDrzavaRepository
    {
        public DrzavaRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
