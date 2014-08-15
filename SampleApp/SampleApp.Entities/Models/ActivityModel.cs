
using System.Collections.Generic;

namespace SampleApp.Entities.Models
{
   
    public class ActivityModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeskReview { get; set; }
        public string OnsiteReview { get; set; }
        public  List<ProviderActivityModel> ProviderActivity { get; set; }
    }
}
