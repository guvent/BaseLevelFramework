using System;
using System.Collections.Generic;
using System.Text;
using Business.Utilities.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace Business.Utilities.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
