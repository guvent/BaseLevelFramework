using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Common.Abstract.DataAccess;
using Common.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,BaseContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (BaseContext context= new BaseContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryID equals c.CategoryID
                    select new ProductDetail
                    {
                        ProductID= p.ProductID,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };
                return result.ToList();
            }
        }
    }
}
