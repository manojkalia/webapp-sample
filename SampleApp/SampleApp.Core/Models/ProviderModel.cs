using SampleApp.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
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
