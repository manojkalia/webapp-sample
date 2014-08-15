using SampleApp.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Domain
{
    /// <summary>
    /// Consultant entity
    /// </summary>
    [Table("Consultant", Schema = "Core")]
    public class Consultant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProviderConsultant> ProviderConsultant { get; set; }
    }
}
