using IFS.Business.Abstract;
using IFS.DataAccsess.Abstract;
using IFS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.Business.Concrete
{
    public class PersonnelManager : IPersonnelService
    {
        private IPersonnelDAL _personnelDal;

        public PersonnelManager(IPersonnelDAL personnelDal)
        {
            _personnelDal = personnelDal;
            
        }

        public void Add(Personnel personnel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int PersonnelId)
        {
            throw new NotImplementedException();
        }

        public List<Personnel> GetAll()
        {
            return _personnelDal.GetList();
        }

        public List<Personnel> GetByCompany(int companyId)
        {
            throw new NotImplementedException();
        }

        public void Update(Personnel personnel)
        {
            throw new NotImplementedException();
        }
    }
}
