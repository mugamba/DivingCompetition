using System;
using DivingCompetition.Domain;
using System.Collections.Generic;

namespace DC.Application
{
    public interface IDrzavaManagementService
    {
         IList<Drzava> GetData();

         Drzava GetById(Int32 id);
    }

    public class DrzavaManagementService :IDrzavaManagementService
    {
        private readonly IDrzavaRepository _repository;
        public DrzavaManagementService(IDrzavaRepository repository)
        {
            _repository = repository;
        }
       
        public IList<Drzava> GetData()
        {
            return _repository.GetAll();
        }

        public Drzava GetById(Int32 id)
        {
            return _repository.GetById(id);
        }
    }
}
