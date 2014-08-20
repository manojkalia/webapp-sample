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
<<<<<<< HEAD
        public int Id { get; set; }
        public int ProviderId { get; set; }
=======
        public int Id { get; set; }
        public int ProviderId { get; set; }
>>>>>>> 2f9878a32a525f628e354fd8e385615d76fc0ed6
        public int ConsultantId { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual Provider Provider { get; set; }
       
    }
}
