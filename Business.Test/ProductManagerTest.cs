using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using FluentValidation;
using log4net;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Business.Test
{

    [TestClass]
    public class ProductManagerTest
    {
        // kurallara uymayan bir test ....
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void product_validation_check()
        {

            Mock<IProductDal> mock = new Mock<IProductDal>();
            //Mock<IProductDal> mock = new Mock<IProductDal>();

            ProductManager productManager = new ProductManager(mock.Object,null);

            productManager.Add(new Product());
        }
    }
}
