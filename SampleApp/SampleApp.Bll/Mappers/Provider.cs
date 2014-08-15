using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Mappers
{
   public class ProviderMapper
    {
       public static ProviderModel ConvertEntityToModel(Provider provider)
       {
           ProviderModel providerModel = new ProviderModel();
           providerModel.Name = provider.Name;
           providerModel.Id = provider.Id;

           return providerModel;
       }
    }
}
