using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Abstract;
using Common.CrossCuttingConcerns.Security.Web;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //   return View();
            return Redirect("/product");
        }

        public ActionResult Login()
        {
            return Redirect("/auth/login");
        }
    }
}