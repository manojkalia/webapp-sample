
namespace SampleApp.Entities.Models
{

    public class ProviderConsultantModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ConsultantId { get; set; }
        public ConsultantModel Consultant { get; set; }
        public ProviderModel Provider { get; set; }

    }
}
