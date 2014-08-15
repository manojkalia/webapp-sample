
namespace SampleApp.Entities.Models
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
