using System.Collections.Generic;

namespace SampleApp.Entities.Models
{
   
    public class ProviderModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<ProviderActivityModel> ProviderActivity { get; set; }
        public List<ProviderConsultantModel> ProviderConsultant { get; set; }
        public List<ContractModel> Contract { get; set; }
        public List<SiteLocationModel> SiteLocation { get; set; }
    }
}
