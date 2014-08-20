using System.Collections.Generic;

namespace SampleApp.Entities.Models
{
   
    public class ConsultantModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<ProviderConsultantModel> ProviderConsultant { get; set; }
        public List<int> ConsultantProviderIds { get; set; }
    }
}
