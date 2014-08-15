using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
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
