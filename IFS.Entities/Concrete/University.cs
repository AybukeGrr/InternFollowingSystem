using IFS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.Entities.Concrete
{
    public class University : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreadtedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UptatedOn { get; set; }
        public int? UptadtedBy { get; set; }
    }
}
