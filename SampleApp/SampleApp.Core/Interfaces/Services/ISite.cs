using System.Collections.Generic;
using SampleApp.Entities.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface ISiteLocation
    {
        SiteLocationModel GetSiteLocation(int id);
        List<SiteLocationModel> GetAllSiteLocations();
        bool Delete(int id);
        bool Insert(SiteLocationModel siteModel);
        bool Update(SiteLocationModel siteModel);
    }
}
