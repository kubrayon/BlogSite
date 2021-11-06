﻿using DataAccessLayer.Abstracts;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
   public class EFHeadingDal: GenericRepository<Heading>, IHeadingDal
    {
    }
}
