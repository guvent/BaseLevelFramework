using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutoMapper;
using Business.Abstract;
using Business.Utilities.ValidationRules.FluentValidation;
using Common.Abstract.DataAccess;
using Common.Aspects.Postsharp;
using Common.Aspects.Postsharp.AuthorizationAspects;
using Common.Aspects.Postsharp.CacheAspects;
using Common.Aspects.Postsharp.FluentValidationAspects;
using Common.Aspects.Postsharp.LogAspects;
using Common.Aspects.Postsharp.PerformanceAspects;
using Common.Aspects.Postsharp.TransActionAspectScope;
using Common.CrossCuttingConcerns.Caching.Microsoft;
using Common.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Common.Utilities.Mappings;
using Entities.Abstract;
using Entities.Concrete;
//using NHibernate.Linq;

namespace Business.Concrete
{
    [LogAspect(typeof(DatabaseLogger))]
    // Cache için de Aspect Oriented gerekiyor ....
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMapper _mapper;

        // NHibernate Queryable ile çalışmak istenilirse metotları buna uyumlu değiştir...
        //private IQueryableRepository<Product> _queryable;
        //public ProductManager(IQueryableRepository<Product> productQueryable)
        //{
        //    _queryable = productQueryable;
        //}

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        [CacheAspect(typeof(MemoryCaching))]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        [PerformanceCounterAspect(3)]
        //[SecuredOperation(Roles = "Admin,Editor")]
        public List<Product> GetAll()
        {
            // Performans sayacı testi...
            //Thread.Sleep(6000);

            // orjinal ...
            //return _productDal.GetList();

            // EF için serialize hatasını giderir (mapper)....
            //return _productDal.GetList().Select(p => new Product
            //{
            //    ProductID = p.ProductID,
            //    CategoryID = p.CategoryID,
            //    ProductName = p.ProductName,
            //    UnitsInStock = p.UnitsInStock,
            //    UnitPrice = p.UnitPrice,
            //    QuantityPerUnit = p.QuantityPerUnit
            //}).ToList();


            // Serialize hatasını tamamen giderir (AutoMapper)...

            // AutoMapper çalışma mantığı .....
            //return AutoMapperHelper.MappedList(_productDal.GetList());

            // Automapper profile, automappermodule, ninject >> DI
            return _mapper.Map<List<Product>>(_productDal.GetList());
        }

        public Product GetByid(int id)
        {
            return _productDal.Get(p => p.ProductID.Equals(id));
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
        [FluentValidatorAspect(typeof(ProductValidator))]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            /// business codes...
            _productDal.Update(product2);

        }
    }
}
