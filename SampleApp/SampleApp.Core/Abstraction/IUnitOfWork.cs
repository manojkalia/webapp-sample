using SampleApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Abstraction
{
   public interface  IUnitOfWork
    {
       IEntityRepository<Activity> ActivityRepository { get; }

       IEntityRepository<Consultant> ConsultantRepository { get; }

       IEntityRepository<Contract> ContractRepository { get; }

       IEntityRepository<Provider> ProviderRepository { get; }

       IEntityRepository<ProviderActivity> ProviderActivityRepository { get; }

       IEntityRepository<ProviderConsultant> ProviderConsultantRepository { get; }

       IEntityRepository<SiteLocation> SiteLocationRepository { get; }

        
        #region  Methods
        void Commit();
        #endregion  
    }
}
