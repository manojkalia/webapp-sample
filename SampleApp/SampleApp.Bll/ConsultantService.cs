using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Abstraction;
using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;
using SampleApp.Service.Mappers;
using SampleApp.Service.Properties;

namespace SampleApp.Service
{
    public class ConsultantService : ServiceBase, IConsultant
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public ConsultantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ConsultantModel GetConsultant(int id)
        {
            return LogIfOperationFailed(() =>
            {
                var consultantEntity = _unitOfWork.ConsultantRepository.Find(id);

                //ToDo:Need to implement Automapper

                ConsultantModel consultantModel = ConsultantMapper.ConvertEntityToModel(consultantEntity);

                return consultantModel;
            }, Resources.ExceptionGetConsultant, id);
        }

        public List<ConsultantModel> GetAllConsultants()
        {
            return LogIfOperationFailed(() =>
            {
                var consultantEntity = _unitOfWork.ConsultantRepository.GetAll;
                var ConsultantModelList = new List<ConsultantModel>();
                // ToDo:Need to implement Automapper
                consultantEntity.ToList().ForEach(m => { ConsultantModelList.Add(ConsultantMapper.ConvertEntityToModel(m)); });

                return ConsultantModelList;
            }, Resources.ExceptionGetForAllConsultants, "Provider");
        }

        public bool Delete(int id)
        {

            return LogIfOperationFailed(() =>
            {
                _unitOfWork.ConsultantRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionDeleteConsultant, id);

        }

        public bool Insert(ConsultantModel consultantModel)
        {
            return LogIfOperationFailed(() =>
            {
                Consultant consultant = ConsultantMapper.ConvertModelToEntity(consultantModel);
                _unitOfWork.ConsultantRepository.InsertOrUpdate(consultant);
                _unitOfWork.Commit();
                var existingProviderConsultant = _unitOfWork.ProviderConsultantRepository.GetAll.Where(m => m.ConsultantId == consultant.Id).ToList();
                foreach(var ProviderConsultant in existingProviderConsultant)
                {
                    _unitOfWork.ProviderConsultantRepository.Delete(ProviderConsultant.Id);
                }
                _unitOfWork.Commit();

                if (consultantModel.ConsultantProviderIds != null)
                {
                    foreach (var providerId in consultantModel.ConsultantProviderIds)
                    {
                        var providerConsultant = new ProviderConsultant();
                        providerConsultant.ConsultantId = consultant.Id;
                        providerConsultant.ProviderId = providerId;


                        _unitOfWork.ProviderConsultantRepository.InsertOrUpdate(providerConsultant);

                    }
                }
                _unitOfWork.Commit();
<<<<<<< HEAD
                var existingProviderConsultant = _unitOfWork.ProviderConsultantRepository.GetAll.Where(m => m.ConsultantId == consultant.Id).ToList();
                foreach(var ProviderConsultant in existingProviderConsultant)
                {
                    _unitOfWork.ProviderConsultantRepository.Delete(ProviderConsultant.Id);
                }
                _unitOfWork.Commit();

                if (consultantModel.ConsultantProviderIds != null)
                {
                    foreach (var providerId in consultantModel.ConsultantProviderIds)
                    {
                        var providerConsultant = new ProviderConsultant();
                        providerConsultant.ConsultantId = consultant.Id;
                        providerConsultant.ProviderId = providerId;


                        _unitOfWork.ProviderConsultantRepository.InsertOrUpdate(providerConsultant);

                    }
                }
                _unitOfWork.Commit();
=======
>>>>>>> 2f9878a32a525f628e354fd8e385615d76fc0ed6
                
                return true;
            }, Resources.ExceptionInsertConsultant, consultantModel.Name);

        }

        public bool Update(ConsultantModel consultantModel)
        {
            return LogIfOperationFailed(() =>
            {
                Consultant consultant = ConsultantMapper.ConvertModelToEntity(consultantModel);
                _unitOfWork.ConsultantRepository.InsertOrUpdate(consultant);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionUpdateConsultant, consultantModel.Name);
        }
        #endregion
    }
}
