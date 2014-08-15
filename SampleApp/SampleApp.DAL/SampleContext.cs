using System.Data.Entity;
using SampleApp.Entities.Domain;

namespace SampleApp.DAL
{
  public  class SampleContext : DbContext
    {
      public SampleContext()
            : base("name=SampleContext")
        {
        }

      public DbSet<Activity> Activities { get; set; }
      public DbSet<Consultant> Consultants { get; set; }
      public DbSet<Contract> Contracts { get; set; }
      public DbSet<Provider> Providers { get; set; }
      public DbSet<ProviderActivity> ProviderActivities { get; set; }
      public DbSet<ProviderConsultant> ProviderConsultants { get; set; }
      public DbSet<SiteLocation> SiteLocations { get; set; }
    }
}
