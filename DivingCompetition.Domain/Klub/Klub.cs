using System;

namespace DivingCompetition.Domain
{
    public class Klub:Entity
    {
        public virtual String Naziv { get; set; }
        public virtual String Adresa { get; set; }
        public virtual Int32 MjestoId { get; set; }
    }
}
