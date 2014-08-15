using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// ProviderActivity entity
    /// </summary>
    [Table("ProviderActivity", Schema = "Core")]
    public class ProviderActivity : IEntity
    {
        public int Id { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Activity Activity { get; set; }
        
    }
}
