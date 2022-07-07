using IFS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.Business.Abstract
{
    public interface IPersonnelService
    {
        List<Personnel> GetAll();
        List<Personnel> GetByCompany(int companyId);
        void Add(Personnel personnel);
        void Update(Personnel personnel); 
        void Delete(int PersonnelId);
    }
}
