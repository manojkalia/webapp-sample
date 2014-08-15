using SampleApp.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
  
 public class SiteLocationModel 
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string NPI { get; set; }
        public string HFS { get; set; }
        public  ProviderModel Provider { get; set; }
     }
}
