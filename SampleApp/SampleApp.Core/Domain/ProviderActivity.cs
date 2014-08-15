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
