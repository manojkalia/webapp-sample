using System.Collections.Generic;
using SampleApp.Entities.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface IContract
    {
        ContractModel GetContract(int id);
        List<ContractModel> GetAllContracts();
        bool Delete(int id);
        bool Insert(ContractModel contractModel);
        bool Update(ContractModel contractModel);
    }
}
