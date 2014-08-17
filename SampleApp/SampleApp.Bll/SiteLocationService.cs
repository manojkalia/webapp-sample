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
    public class SiteLocationService : ServiceBase, ISiteLocation
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public SiteLocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public SiteLocationModel GetSiteLocation(int id)
        {
            return LogIfOperationFailed(() =>
            {
                var siteLocationEntity = _unitOfWork.SiteLocationRepository.Find(id);

                //ToDo:Need to implement Automapper

                SiteLocationModel siteLocationModel = SiteLocationMapper.ConvertEntityToModel(siteLocationEntity);

                return siteLocationModel;
            }, Resources.ExceptionGetProvider, id);
        }


        public List<SiteLocationModel> GetAllSiteLocations()
        {
            return LogIfOperationFailed(() =>
            {
                var siteLocationEntity = _unitOfWork.SiteLocationRepository.GetAll;
                var siteModelModelList = new List<SiteLocationModel>();
                // ToDo:Need to implement Automapper
                siteLocationEntity.ToList().ForEach(m => { siteModelModelList.Add(SiteLocationMapper.ConvertEntityToModel(m)); });

                return siteModelModelList;
            }, Resources.ExceptionGetForAllProviders, "Provider");
        }

        public bool Delete(int id)
        {

            return LogIfOperationFailed(() =>
            {
                _unitOfWork.SiteLocationRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Provider");
            
        }

        public bool Insert(SiteLocationModel siteLocationModel)
        {
            return LogIfOperationFailed(() =>
            {
                SiteLocation siteLocation = SiteLocationMapper.ConvertModelToEntity(siteLocationModel);
                _unitOfWork.SiteLocationRepository.InsertOrUpdate(siteLocation);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Sitelocation");
           
        }

        public bool Update(SiteLocationModel siteLocationModel)
        {
            return LogIfOperationFailed(() =>
            {
                SiteLocation siteLocation = SiteLocationMapper.ConvertModelToEntity(siteLocationModel);
                _unitOfWork.SiteLocationRepository.InsertOrUpdate(siteLocation);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionGetForAllProviders, "Sitelocation");
        }
        #endregion









        
    }
}
