using System.Collections.Generic;

namespace SampleApp.Entities.Models
{
   
    public class ConsultantModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public  List<ProviderConsultantModel> ProviderConsultant { get; set; }
=======
        public  List<ProviderConsultantModel> ProviderConsultant { get; set; }
>>>>>>> 2f9878a32a525f628e354fd8e385615d76fc0ed6
        public List<int> ConsultantProviderIds { get; set; }
    }
}
