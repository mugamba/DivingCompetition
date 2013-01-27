using DivingCompetition.Domain;
using System;

namespace DivingCompetition.Models
{
    public class TestEntityModel
    {
        public TestEntity Entity;
        public TestEntityModel(TestEntity entity)
        {
            Entity = entity;
        }

        public Guid Id
        {
            get { return Entity.Id; }
            set { Entity.Id = value; }
        }

        public String Sifra
        {
            get { return Entity.Sifra; }
            set { Entity.Sifra = value; }
        }

        public String Naziv
        {
            get { return Entity.Sifra; }
            set { Entity.Naziv = value; }
        }
    }
}