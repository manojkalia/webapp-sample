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
           if (provider.Contract !=null)
           {
               provider.Contract
                   .ToList()
                   .ForEach(m => providerModel.Contracts.Add(ContractMapper.ConvertEntityToModel(m)));
           }
           return providerModel;
       }


       public static Provider ConvertModelToEntity(ProviderModel providerModel)
       {
           Provider provider = new Provider();
           provider.Name = providerModel.Name;
           provider.Id = providerModel.Id;

           return provider;
       }
    }
}
