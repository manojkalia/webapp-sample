using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// SiteLocation entity
    /// </summary>
    [Table("SiteLocation", Schema = "Addr")]
    public class SiteLocation : IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string NPI { get; set; }
        public string HFS { get; set; }
        public virtual Provider Provider { get; set; }
     }
}
