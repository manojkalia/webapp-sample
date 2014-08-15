using SampleApp.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
    
    public class ProviderActivityModel
    {
        public int Id { get; set; }
        public  ProviderModel Provider { get; set; }
        public  ActivityModel Activity { get; set; }
        
    }
}
