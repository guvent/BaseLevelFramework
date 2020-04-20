using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}