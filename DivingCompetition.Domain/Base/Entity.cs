using System;

namespace DivingCompetition.Domain
{
    public class Entity : IEntity
    {
        public virtual Guid Id { get; set; }
    }
}
