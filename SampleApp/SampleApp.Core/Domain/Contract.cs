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
