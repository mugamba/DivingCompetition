using System;
using System.Collections.Generic;
using System.Linq;

namespace DivingCompetition.Model
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// Adds the entity to the repository (registers an item for insert when 
        /// the unit of work is completed).
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        void Add(TEntity entity);
        /// <summary>
        /// Removes the entity from the repository (registers an item for deletion when 
        /// the unit of work is completed).
        /// </summary>
        /// <param name="entity">Entity to remove.</param>
        void Remove(TEntity entity);
        /// <summary>
        /// Updates the entity in the repository (registers the entity for update when 
        /// the unit of work is completed).
        /// </summary>
        /// <param name="item">Item to update.</param>
        void Update(TEntity item);
        /// <summary>
        /// Adds the item in the repository or updates it if it's already there 
        /// (registers an item for insert or update when the unit of work is completed).
        /// </summary>
        /// <param name="item">Item to add to repository.</param>
        void AddOrUpdate(TEntity item);
        /// <summary>
        /// Retrieves an entity with the given id from the repository.
        /// </summary>
        /// <param name="id">Id of the entity to retrieve.</param>
        /// <returns>Entity with the given id.</returns>
        TEntity GetById(Object id);
        /// <summary>
        /// Retrieves all entites from the repository.
        /// </summary>
        /// <returns>All entites.</returns>
        IList<TEntity> GetAll();
        /// <summary>
        /// Finds all entites in the repository that satisfy the provided <see cref="Specification{T}"/>.
        /// </summary>
        /// <param name="specification">The specification.</param>
        /// <returns>All entites that satisfy the provided <see cref="Specification{T}"/>.</returns>
  //      IList<TEntity> FindAll(Specification<TEntity> specification);
        /// <summary>
        /// Finds a single entity in the repository that satisfies the provided <see cref="Specification{T}"/>.
        /// </summary>
        /// <param name="specification">The specification.</param>
        /// <returns>A single entity that satisfies the provided <see cref="Specification{T}"/>.</returns>
 //       TEntity FindOne(Specification<TEntity> specification);
        /// <summary>
        /// Provides functionality to evalute queries on repository.
        /// </summary>
        /// <returns>Instance of <see cref="IQueryable{T}"/>.</returns>
        IQueryable<TEntity> Query();
    }
}
