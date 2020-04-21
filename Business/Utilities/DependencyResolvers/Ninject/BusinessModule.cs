using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using Business.MicroServices.KPSService;
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

            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();

            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();

            Bind<IKPSService>().To<KPSServiceAdapter>().InSingletonScope();

            // EF or NH switch.....
            Bind<DbContext>().To<BaseContext>();
            
            // NHibernate
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<NHibernateHelper>().To<SqlServerHelper>();

            //Bind<IProductDal>().To<NhProductDal>().InSingletonScope();
        }
    }
}
