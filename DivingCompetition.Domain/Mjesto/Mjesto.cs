using System;

namespace DivingCompetition.Domain
{
    public class Mjesto : Entity
    {
        public virtual String Sifra { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String PostanskiBroj { get; set; }
        public virtual Int32 DrzavaId { get; set; }
    }
}
