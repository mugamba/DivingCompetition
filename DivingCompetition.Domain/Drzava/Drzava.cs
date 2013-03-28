using System;

namespace DivingCompetition.Domain
{
    public class Drzava:Entity
    {
        public virtual String Sifra { get; set; }
        public virtual String Naziv { get; set; }
    }
}
