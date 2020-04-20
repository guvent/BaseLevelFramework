using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Utilities.ValidationRules.FluentValidation;
using Common.Abstract.DataAccess;
using Common.Aspects.Postsharp;
using Common.Aspects.Postsharp.CacheAspects;
using Common.Aspects.Postsharp.FluentValidationAspects;
using Common.Aspects.Postsharp.LogAspects;
using Common.Aspects.Postsharp.TransActionAspectScope;
using Common.CrossCuttingConcerns.Caching.Microsoft;
using Common.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Entities.Abstract;
using Entities.Concrete;
//using NHibernate.Linq;

namespace Business.Concrete
{
    // Cache için de Aspect Oriented gerekiyor ....
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        // NHibernate Queryable ile çalışmak istenilirse metotları buna uyumlu değiştir...
        //private IQueryableRepository<Product> _queryable;
        //public ProductManager(IQueryableRepository<Product> productQueryable)
        //{
        //    _queryable = productQueryable;
        //}

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        [CacheAspect(typeof(MemoryCaching))]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId.Equals(id));
        }

        [FluentValidatorAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCaching))]
        [LogAspect(typeof(DatabaseLogger))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidatorAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        // Postsharp tercih edilmedi aspect oriented için çözüm uygulanmalı
        [TransActionAspectScope]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            /// business codes...
            _productDal.Update(product2);

        }
    }
}
