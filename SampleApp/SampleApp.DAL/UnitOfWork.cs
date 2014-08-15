using SampleApp.Entities.Abstraction;
using SampleApp.Entities.Domain;

namespace SampleApp.DAL
{
  

    public class UnitOfWork : IUnitOfWork

    {
        private readonly SampleContext _context;

        private SampleRepository<Activity> _activity;
        private SampleRepository<Consultant> _consultant;
        private SampleRepository<Contract> _contract;
        private SampleRepository<Provider> _provider;
        private SampleRepository<ProviderActivity> _providerActivity;
        private SampleRepository<ProviderConsultant> _providerConsultant;
        private SampleRepository<SiteLocation> _siteLocation;

        public UnitOfWork(SampleContext sampleContext)
        {
            _context = sampleContext;
        }

        public IEntityRepository<Activity> ActivityRepository
        {
            get { return _activity ?? (_activity = new SampleRepository<Activity>(_context)); }
        }

        public IEntityRepository<Consultant> ConsultantRepository
        {
            get { return _consultant ?? (_consultant = new SampleRepository<Consultant>(_context)); }
        }

       

        public IEntityRepository<Contract> ContractRepository
        {
            get { return _contract ?? (_contract = new SampleRepository<Contract>(_context)); }
        }

        public IEntityRepository<Provider> ProviderRepository
        {
            get { return _provider ?? (_provider = new SampleRepository<Provider>(_context)); }
        }

        public IEntityRepository<ProviderActivity> ProviderActivityRepository
        {
            get { return _providerActivity ?? (_providerActivity = new SampleRepository<ProviderActivity>(_context)); }
        }

        public IEntityRepository<ProviderConsultant> ProviderConsultantRepository
        {
            get { return _providerConsultant ?? (_providerConsultant = new SampleRepository<ProviderConsultant>(_context)); }
        }

        public IEntityRepository<SiteLocation> SiteLocationRepository
        {
            get { return _siteLocation ?? (_siteLocation = new SampleRepository<SiteLocation>(_context)); }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
        
}
