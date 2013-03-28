using System;
using DivingCompetition.Domain;
using System.Collections.Generic;

namespace DC.Application
{
    public interface IKlubManagementService
    {
         IList<Klub> GetData();

         Klub GetById(Int32 id);
    }

    public class KlubManagementService :IKlubManagementService
    {
        private readonly IKlubRepository _repository;
        public KlubManagementService(IKlubRepository repository)
        {
            _repository = repository;
        }
       
        public IList<Klub> GetData()
        {
            return _repository.GetAll();
        }

        public Klub GetById(Int32 id)
        {
            return _repository.GetById(id);
        }
    }
}
