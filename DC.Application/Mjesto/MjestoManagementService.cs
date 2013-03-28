using System;
using DivingCompetition.Domain;
using System.Collections.Generic;

namespace DC.Application
{
    public interface IMjestoManagementService
    {
         IList<Mjesto> GetData();

         Mjesto GetById(Int32 id);
    }

    public class MjestoManagementService :IMjestoManagementService
    {
        private readonly IMjestoRepository _repository;
        public MjestoManagementService(IMjestoRepository repository)
        {
            _repository = repository;
        }
       
        public IList<Mjesto> GetData()
        {
            return _repository.GetAll();
        }

        public Mjesto GetById(Int32 id)
        {
            return _repository.GetById(id);
        }
    }
}
