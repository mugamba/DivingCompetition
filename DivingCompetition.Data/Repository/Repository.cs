using System;
using System.Linq;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Linq;
using DivingCompetition.Model;

namespace DivingCompetition.Data
{
    /// <summary>
    /// Generic entity repository implementation.
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class,IEntity
    {
        readonly ISessionFactory _sessionFactory;
       

        /// <summary>
        /// Initializes instance of <see cref="Repository{TEntity}"/>.
        /// </summary>
        /// <param name="sessionFactory">Instance of <see cref="ISessionFactory"/>.</param>
        public Repository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }
       
        /// <summary>
        /// Current <see cref="ISession"/>.
        /// </summary>
        protected ISession Session
        { get { return _sessionFactory.GetCurrentSession(); } }

        /// <summary>
        /// Adds the entity to the repository (registers an item for insert when 
        /// the <see cref="ISession"/> is flushed).
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        public virtual void Add(TEntity entity)
        {
            Session.Save(entity);
        }

        /// <summary>
        /// Removes the entity from the repository (registers an item for deletion when 
        /// the <see cref="ISession"/> is flushed).
        /// </summary>
        /// <param name="entity">Entity to remove.</param>
        public virtual void Remove(TEntity entity)
        {
            Session.Delete(entity);
        }

        /// <summary>
        /// Updates the entity in the repository (registers the entity for update when 
        /// the <see cref="ISession"/> is flushed).
        /// </summary>
        /// <param name="item">Item to update.</param>
        public void Update(TEntity item)
        {
            Session.Update(item);
        }

        /// <summary>
        /// Adds the item in the repository or updates it if it's already there 
        /// (registers an item for insert or update when the unit of work is completed).
        /// </summary>
        /// <param name="item">Item to add to repository.</param>
        public void AddOrUpdate(TEntity item)
        {
            //isdirty provjeriti pa raditi update i save odvojeno ?
          Session.SaveOrUpdate(item);
        }

        /// <summary>
        /// Retrieves an entity with the given id from the repository.
        /// </summary>
        /// <param name="id">Id of the entity to retrieve.</param>
        /// <returns>Entity with the given id.</returns>
        public virtual TEntity GetById(Object id)
        {
            return Session.Get<TEntity>(id);
        }

        /// <summary>
        /// Retrieves all entites from the repository.
        /// </summary>
        /// <returns>All entites.</returns>
        public virtual IList<TEntity> GetAll()
        {
            return Session
                .CreateCriteria<TEntity>()
                .List<TEntity>();
        }

        /// <summary>
        /// Provides functionality to evalute queries on repository.
        /// </summary>
        /// <returns>Instance of <see cref="IQueryable{T}"/>.</returns>
        public virtual IQueryable<TEntity> Query()
        {
            return Session.Query<TEntity>();
        }
    }
}