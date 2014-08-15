using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// Contract entity
    /// </summary>
    [Table("Contract", Schema = "Addr")]
    public class Contract : IEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public virtual Provider Provider { get; set; }

       
    }
}
