﻿using IFS.Core.DataAccess.EntityFramework;
using IFS.DataAccsess.Abstract;
using IFS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.DataAccsess.Concrete.EntityFramework
{
    public class EfCompanyDAL : EfEntityRepositoryBase<Company, NorthwindContext>,ICompanyDAL 
    {

    }
}
