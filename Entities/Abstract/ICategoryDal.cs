using System;
using System.Collections.Generic;
using System.Text;
using Common.Abstract.DataAccess;
using Entities.Concrete;

namespace Entities.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
