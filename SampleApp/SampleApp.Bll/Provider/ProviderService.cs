using SampleApp.Core.Abstraction;
using SampleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Provider
{
    public class ProviderService : IProvider
    {
        #region  Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Methods

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ProviderModel GetProvider(int id)
        {

           var providerEntity= _unitOfWork.ProviderRepository.Find(id);

            //ToDo:Need to implement Automapper

           ProviderModel providerModel = new ProviderModel { Name = providerEntity.Name};

           return providerModel;
        }

        #endregion
    }
}
