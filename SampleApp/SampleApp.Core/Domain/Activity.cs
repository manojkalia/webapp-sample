
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Abstraction;

namespace SampleApp.Core.Domain
{
    /// <summary>
    /// Activity entity
    /// </summary>
    [Table("Activity", Schema = "Core")]
    public class Activity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeskReview { get; set; }
        public string OnsiteReview { get; set; }
        public virtual ICollection<ProviderActivity> ProviderActivity { get; set; }
    }
}
