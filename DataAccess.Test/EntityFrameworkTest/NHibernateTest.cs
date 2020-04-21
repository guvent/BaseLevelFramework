using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_product()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_product_detail()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetProductDetails();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filter_product()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p=>p.ProductName.Contains("Ch"));

            Assert.AreEqual(14, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_category()
        {
            NhCategoryDal categoryDal = new NhCategoryDal(new SqlServerHelper());

            var result = categoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

    }
}
