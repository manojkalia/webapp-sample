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
    public class ActivityService : ServiceBase, IActivity
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public ActivityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActivityModel GetActivity(int id)
        {
            return LogIfOperationFailed(() =>
            {
                var activityEntity = _unitOfWork.ActivityRepository.Find(id);

                //ToDo:Need to implement Automapper

                ActivityModel activityModel = ActivityMapper.ConvertEntityToModel(activityEntity);

                return activityModel;
            }, Resources.ExceptionGetActivity, id);
        }

        public List<ActivityModel> GetAllActivities()
        {
            return LogIfOperationFailed(() =>
            {
                var activityEntity = _unitOfWork.ActivityRepository.GetAll;
                var activityModelList = new List<ActivityModel>();
                // ToDo:Need to implement Automapper
                activityEntity
                    .ToList()
                    .ForEach(m => { activityModelList.Add(ActivityMapper.ConvertEntityToModel(m)); });

                return activityModelList;
            }, Resources.ExceptionGetForAllActivitys);
        }

        public bool Delete(int id)
        {
            return LogIfOperationFailed(() =>
            {
                _unitOfWork.ActivityRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionDeleteActivity, id);

        }

        public bool Insert(ActivityModel activityModel)
        {
            return LogIfOperationFailed(() =>
            {
                Activity activity = ActivityMapper.ConvertModelToEntity(activityModel);
                _unitOfWork.ActivityRepository.InsertOrUpdate(activity);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionInsertActivity, activityModel.Name);
        }

        public bool Update(ActivityModel activityModel)
        {
            return LogIfOperationFailed(() =>
            {
                Activity activity = ActivityMapper.ConvertModelToEntity(activityModel);
                _unitOfWork.ActivityRepository.InsertOrUpdate(activity);
                _unitOfWork.Commit();
                return true;
            }, Resources.ExceptionUpdateActivity, activityModel.Name);
        }
        #endregion
    }
}
