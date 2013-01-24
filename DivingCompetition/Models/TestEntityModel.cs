using DivingCompetition.Domain;
using System;

namespace DivingCompetition.Models
{
    public class TestEntityModel
    {
        public TestEntity _entity;
        public TestEntityModel(TestEntity entity)
        {
            _entity = entity;
        }

        public Guid Id
        {
            get { return _entity.Id; }
            set { _entity.Id = value; }
        }

        public String Sifra
        {
            get { return _entity.Sifra; }
            set { _entity.Sifra = value; }
        }

        public String Naziv
        {
            get { return _entity.Sifra; }
            set { _entity.Naziv = value; }
        }
    }
}