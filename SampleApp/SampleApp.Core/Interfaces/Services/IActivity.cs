using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Entities.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface IActivity
    {
        ActivityModel GetActivity(int id);
        List<ActivityModel> GetAllActivities();
        bool Delete(int id);
        bool Insert(ActivityModel activityModel);
        bool Update(ActivityModel activityModel);
    }
}
