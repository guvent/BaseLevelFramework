using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Concrete.NHibernate;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NHEntityRepositoryBase<Product>,IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                    join c in session.Query<Category>() on p.CategoryID equals c.CategoryID
                    select new ProductDetail
                    {
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };

                return result.ToList();
            }
        }
    }
}
