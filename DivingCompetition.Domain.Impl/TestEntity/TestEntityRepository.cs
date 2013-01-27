using DivingCompetition.Domain;
using NHibernate;

namespace DivingCompetition.Domain.Impl
{

    public class TestEntityRepository :
        Repository<TestEntity>, ITestEntityRepository
    {
        public TestEntityRepository(ISessionFactory sessionFactory)
            : base(sessionFactory)
        {
        }
    }
}
