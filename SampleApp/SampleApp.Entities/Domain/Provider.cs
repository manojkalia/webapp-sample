using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// Provider entity
    /// </summary>
    [Table("Provider", Schema = "Core")]
    public class Provider : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProviderActivity> ProviderActivity { get; set; }
        public virtual ICollection<ProviderConsultant> ProviderConsultant { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<SiteLocation> SiteLocation { get; set; }
    }
}
