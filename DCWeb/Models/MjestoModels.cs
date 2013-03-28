using DivingCompetition.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace DivingCompetition.Models
{
    public class MjestoModelDetails
    {
        public Mjesto Entity;
        public MjestoModelDetails(Mjesto entity)
        {
            Entity = entity;
        }

        public Int32 Id
        {
            get { return Entity.Id; }
            set { Entity.Id = value; }
        }

        [Display(Name = "Šifra")]
        public String Sifra
        {
            get { return Entity.Sifra; }
            set { Entity.Sifra = value; }
        }

        [Display(Name = "Naziv")]
        public String Naziv
        {
            get { return Entity.Naziv; }
            set { Entity.Naziv = value; }
        }

        [Display(Name = "Poštanski Broj")]
        public String PostanskiBroj
        {
            get { return Entity.PostanskiBroj; }
            set { Entity.PostanskiBroj = value; }
        }
    }
}