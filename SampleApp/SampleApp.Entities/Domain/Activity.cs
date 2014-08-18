
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SampleApp.Entities.Abstraction;

namespace SampleApp.Entities.Domain
{
    /// <summary>
    /// Activity entity
    /// </summary>
    [Table("Activity", Schema = "Core")]
    public class Activity : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DeskReview { get; set; }
        public string OnsiteReview { get; set; }
        public virtual ICollection<ProviderActivity> ProviderActivity { get; set; }
    }
}
