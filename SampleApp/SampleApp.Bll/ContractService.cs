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
    public class ContractService : ServiceBase, IContract
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public ContractService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ContractModel GetContract(int id)
        {
            return LogIfOperationFailed(() =>
            {
                var contractEntity = _unitOfWork.ContractRepository.Find(id);

                //ToDo:Need to implement Automapper

                ContractModel contractModel = ContractMapper.ConvertEntityToModel(contractEntity);

                return contractModel;
            }, Resources.ExceptionGetProvider, id);
        }

        public List<ContractModel> GetAllContracts()
        {
            return LogIfOperationFailed(() =>
            {
                var contractEntity = _unitOfWork.ContractRepository.GetAll;
                var ContractModelList = new List<ContractModel>();
                // ToDo:Need to implement Automapper
                contractEntity.ToList().ForEach(m => { ContractModelList.Add(ContractMapper.ConvertEntityToModel(m)); });

                return ContractModelList;
            }, Resources.ExceptionGetForAllProviders, "Provider");
        }

        public bool Delete(int id)
        {

            return LogIfOperationFailed(() =>
            {
                _unitOfWork.ContractRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Provider");

        }

        public bool Insert(ContractModel contractModel)
        {
            return LogIfOperationFailed(() =>
            {
                Contract contract = ContractMapper.ConvertModelToEntity(contractModel);
                _unitOfWork.ContractRepository.InsertOrUpdate(contract);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Provider");

        }

        public bool Update(ContractModel contractModel)
        {
            return LogIfOperationFailed(() =>
            {
                Contract contract = ContractMapper.ConvertModelToEntity(contractModel);
                _unitOfWork.ContractRepository.InsertOrUpdate(contract);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Provider");
        }
        #endregion
    }
}
