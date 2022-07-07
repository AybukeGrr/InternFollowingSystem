using IFS.Core.DataAccess;
using IFS.DataAccsess.Abstract;
using IFS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.DataAccsess.Abstract
{
    public interface IStudentDAL : IEntityRepository<Student>
    {
    }
}
