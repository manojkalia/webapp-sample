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
    /// ProviderConsultant entity
    /// </summary>
    [Table("ProviderConsultant", Schema = "Core")]
    public class ProviderConsultant : IEntity
    {
        public int Id { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual Provider Provider { get; set; }
       
    }
}
