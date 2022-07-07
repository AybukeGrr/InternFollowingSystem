using IFS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string IdentityNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? InternStart { get; set; }
        public DateTime? InternEnd { get; set; }
        public int UniversityId { get; set; }
        public int PersonnelId { get; set; }
        public int EducatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
