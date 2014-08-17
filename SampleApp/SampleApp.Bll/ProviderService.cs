using System;
using System.Collections.Generic;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Abstraction;
using SampleApp.Entities.Models;
using SampleApp.Service.Properties;
using SampleApp.Service.Mappers;
using System.Linq;
using SampleApp.Entities.Domain;

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

                ProviderModel providerModel = ProviderMapper.ConvertEntityToModel(providerEntity);

                return providerModel;
            }, Resources.ExceptionGetProvider, id);
        }

        public List<ProviderModel> GetAllProviders()
        {
            return LogIfOperationFailed(() =>
            {
                var providerEntity = _unitOfWork.ProviderRepository.GetAll;
                var providerModelList = new List<ProviderModel>();
                // ToDo:Need to implement Automapper
                providerEntity
                    .ToList()
                    .ForEach(m => { providerModelList.Add(ProviderMapper.ConvertEntityToModel(m)); });

                return providerModelList;
            }, Resources.ExceptionGetForAllProviders);
        }

        public bool Delete(int id)
        {
            return LogIfOperationFailed(() =>
            {
                _unitOfWork.ProviderRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionDeleteProvider, "Provider");
            
        }

        public bool Insert(ProviderModel providerModel)
        {
            return LogIfOperationFailed(() =>
            {
                Provider provider = ProviderMapper.ConvertModelToEntity(providerModel);
                _unitOfWork.ProviderRepository.InsertOrUpdate(provider);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionInsertProvider, providerModel.Name);
           
        }

        public bool Update(ProviderModel providerModel)
        {
            return LogIfOperationFailed(() =>
            {
                Provider provider = ProviderMapper.ConvertModelToEntity(providerModel);
                _unitOfWork.ProviderRepository.InsertOrUpdate(provider);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionUpdateProvider, providerModel.Name);
        }
        #endregion
    }
}
