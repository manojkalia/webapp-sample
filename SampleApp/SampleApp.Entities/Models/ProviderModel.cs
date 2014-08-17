using System.Collections.Generic;

namespace SampleApp.Entities.Models
{
   
    public class ProviderModel 
    {
        public ProviderModel()
        {
            Contracts = new List<ContractModel>();
            SiteLocations = new List<SiteLocationModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<ProviderActivityModel> ProviderActivity { get; set; }
        public List<ProviderConsultantModel> ProviderConsultant { get; set; }
        public List<ContractModel> Contracts { get; set; }
        public List<SiteLocationModel> SiteLocations { get; set; }
    }
}
