using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Mappers
{
    public class ContractMapper
    {
       public static ContractModel ConvertEntityToModel(Contract contract)
       {
           ContractModel contractModel = new ContractModel();
           contractModel.Code = contract.Code;
           contractModel.Id = contract.Id;
           contractModel.Number = contract.Number;
           contractModel.ProviderId = contract.ProviderId;

           return contractModel;
       }


       public static Contract ConvertModelToEntity(ContractModel contractModel)
       {
           Contract contract = new Contract();
           contract.Code = contractModel.Code;
           contract.Id = contractModel.Id;
           contract.Number = contractModel.Number;
           contract.ProviderId = contractModel.ProviderId;
           
           return contract;
       }
    }
}
