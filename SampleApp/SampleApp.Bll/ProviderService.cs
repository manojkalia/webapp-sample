using System;
using System.Collections.Generic;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Abstraction;
using SampleApp.Entities.Models;
using SampleApp.Service.Properties;

namespace SampleApp.Service
{
    public class ProviderService : ServiceBase, IProvider
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
            return LogIfOperationFailed(() =>
            {
                var providerEntity = _unitOfWork.ProviderRepository.Find(id);

                //ToDo:Need to implement Automapper

                ProviderModel providerModel = new ProviderModel { Name = providerEntity.Name };

                return providerModel;
            }, Resources.ExceptionGetProvider, id);
        }


        public List<ProviderModel> GetAllProvider()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
