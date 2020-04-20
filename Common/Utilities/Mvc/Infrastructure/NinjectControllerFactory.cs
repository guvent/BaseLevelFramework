using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Ninject;
using System.Web.Routing;

namespace Common.Utilities.Mvc.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController) _kernel.Get(controllerType);
        }
    }
}
