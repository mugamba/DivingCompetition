using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivingCompetition.Domain
{
    public class TestEntity
    {
        public virtual Guid Id { get; set; }
        public virtual String Sifra { get; set; }
        public virtual String Naziv { get; set; }
    }
}
