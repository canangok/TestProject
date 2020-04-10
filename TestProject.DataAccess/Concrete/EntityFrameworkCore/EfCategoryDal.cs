﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Core.DataAccess.EntityFrameworkCore;
using TestProject.DataAccess.Abstract;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,TestProjectDBContext>, ICategoryDal
    {
        //ICategoryDal'dan implement aldım.
        //EfEntityRepositoryBase class ICategoryDal'dan implement alıyor ve onun içini doduruyor.
    }
}
