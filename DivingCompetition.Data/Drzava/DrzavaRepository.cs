using DivingCompetition.Model;
using NHibernate;

namespace DivingCompetition.Data
{

    public class DrzavaRepository : Data.Repository<Drzava>, IDrzavaRepository
    {
        public DrzavaRepository(ISessionFactory sessionFactory)
            : base(sessionFactory){}
    }
}
