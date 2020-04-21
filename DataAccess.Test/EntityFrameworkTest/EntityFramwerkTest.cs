using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFramwerkTest
    {
        [TestMethod]
        public void Get_all_returns_all_product()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_product_detail()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetProductDetails();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filter_product()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p => p.ProductName.Contains("Ch"));

            Assert.AreEqual(14, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_category()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();

            var result = categoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

    }
}
