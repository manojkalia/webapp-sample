using SampleApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
