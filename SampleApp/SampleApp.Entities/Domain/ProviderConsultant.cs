using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// ProviderConsultant entity
    /// </summary>
    [Table("ProviderConsultant", Schema = "Core")]
    public class ProviderConsultant : IEntity
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ConsultantId { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual Provider Provider { get; set; }
       
    }
}
