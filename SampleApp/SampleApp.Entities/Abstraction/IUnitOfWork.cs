
using SampleApp.Entities.Domain;
namespace SampleApp.Entities.Abstraction
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
