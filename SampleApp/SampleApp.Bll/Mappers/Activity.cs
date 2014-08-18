using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;

namespace SampleApp.Service.Mappers
{
    public class ActivityMapper
    {
        public static ActivityModel ConvertEntityToModel(Activity activity)
        {
            ActivityModel activityModel = new ActivityModel();
            activityModel.Name = activity.Title;
            activityModel.Id = activity.Id;
            activityModel.DeskReview = activity.DeskReview;
            activityModel.OnsiteReview = activity.OnsiteReview;
           
            return activityModel;
        }


        public static Activity ConvertModelToEntity(ActivityModel activityModel)
        {
            Activity activity = new Activity();
            activity.Title = activityModel.Name;
            activity.Id = activityModel.Id;
            activity.DeskReview = activityModel.DeskReview;
            activity.OnsiteReview = activityModel.OnsiteReview;

            return activity;
        }
    }
}
