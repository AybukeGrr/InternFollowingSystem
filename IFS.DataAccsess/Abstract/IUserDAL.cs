﻿using IFS.Core.DataAccess;
using IFS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS.DataAccsess.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {
    }
}
