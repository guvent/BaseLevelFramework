using System;
using System.Collections.Generic;
using System.Text;
using Common.Abstract.DataAccess;
using Common.Abstract.Entities;
using Common.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;

namespace Entities.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
