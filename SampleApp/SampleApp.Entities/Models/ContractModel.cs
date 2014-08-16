
namespace SampleApp.Entities.Models
{
    
    public class ContractModel 
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public int ProviderId { get; set; }
        public  ProviderModel Provider { get; set; }

    }
}
