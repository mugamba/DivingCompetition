using System;

namespace DivingCompetition.Domain
{
    public interface IEntity
    {
        //Gets or sets the object's identity.
        Guid Id { get; set; }
    }
}
