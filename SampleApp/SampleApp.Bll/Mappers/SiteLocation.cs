using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Mappers
{
    public class SiteLocationMapper
    {
        public static SiteLocationModel ConvertEntityToModel(SiteLocation site)
       {
           SiteLocationModel siteLocationModel = new SiteLocationModel();
           siteLocationModel.Address = site.Address;
           siteLocationModel.Id = site.Id;
           siteLocationModel.HFS = site.HFS;
           siteLocationModel.NPI = site.NPI;
           siteLocationModel.ProviderId = site.ProviderId;



           return siteLocationModel;
       }


        public static SiteLocation ConvertModelToEntity(SiteLocationModel siteModel)
       {
           SiteLocation siteLocation = new SiteLocation();
           siteLocation.Address = siteModel.Address;
           siteLocation.Id = siteModel.Id;
           siteLocation.HFS = siteModel.HFS;
           siteLocation.NPI = siteModel.NPI;
           siteLocation.ProviderId = siteModel.ProviderId;



           return siteLocation;
       }
    }
}
