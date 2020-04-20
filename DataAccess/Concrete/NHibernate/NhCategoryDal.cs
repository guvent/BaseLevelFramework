using System;
using System.Collections.Generic;
using System.Text;
using Common.Concrete.NHibernate;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal:NHEntityRepositoryBase<Category>,ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
