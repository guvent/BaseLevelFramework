using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using Common.Abstract.DataAccess;
using Common.Concrete.EntityFramework;
using Common.Concrete.NHibernate;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using DataAccess.Concrete.NHibernate.Helpers;
using Entities.Abstract;
using Ninject.Modules;

namespace Business.Utilities.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            // EntityFramework
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            
            Bind<DbContext>().To<BaseContext>();

            
            // NHibernate
            //Bind<IProductDal>().To<NhProductDal>().InSingletonScope();

            Bind<NHibernateHelper>().To<SqlServerHelper>();

            // NHibernate Queryable ile çalışmak istenilirse...
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));

        }
    }
}
