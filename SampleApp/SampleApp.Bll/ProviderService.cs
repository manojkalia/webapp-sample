using System;
using System.Collections.Generic;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Abstraction;
using SampleApp.Entities.Models;

namespace SampleApp.Service
{
    public class ProviderService : IProvider
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ProviderModel GetProvider(int id)
        {

           var providerEntity= _unitOfWork.ProviderRepository.Find(id);

            //ToDo:Need to implement Automapper

           ProviderModel providerModel = new ProviderModel { Name = providerEntity.Name};

           return providerModel;
        }


        public List<ProviderModel> GetAllProvider()
        {
            throw new NotImplementedException();
        }
        #endregion
        
    }
}
