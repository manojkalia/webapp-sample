
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Abstraction;

namespace SampleApp.Core.Models
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
