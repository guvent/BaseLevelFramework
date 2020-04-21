using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities.Concrete;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _producService;

        public ProductController(IProductService producService)
        {
            _producService = producService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Product = _producService.GetAll()
            };
            return View(model);
        }

        public ActionResult Add()
        {
            _producService.Add(new Product
            {
                CategoryID = 1,
                ProductName = "Deneme",
                QuantityPerUnit = "1",
                UnitPrice = 21
            });

            return View();
        }

        public ActionResult Add2()
        {
            _producService.TransactionalOperation(new Product
            {
                CategoryID = 1,
                ProductName = "KALEM",
                QuantityPerUnit = "1",
                UnitPrice = 21
            }, new Product
            {
                CategoryID = 1,
                ProductName = "KALEM 2",
                QuantityPerUnit = "1",
                UnitPrice = 11
            });

            return View();
        }
    }
}