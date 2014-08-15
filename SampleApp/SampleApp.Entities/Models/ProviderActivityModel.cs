
namespace SampleApp.Entities.Models
{

    public class ProviderActivityModel
    {
        public int Id { get; set; }
        public ProviderModel Provider { get; set; }
        public ActivityModel Activity { get; set; }

    }
}
