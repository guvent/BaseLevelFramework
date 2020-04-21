using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Abstract;
using Common.CrossCuttingConcerns.Security.Web;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {

        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Auth
        public ActionResult Index()
        {
            //   return View();
            return Redirect("/product");
        }

        public string Login()
        {
            var user = _userService.GetUser("guven", "1234");
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(),
                    user.UserName,
                    user.Email,
                    DateTime.Now.AddDays(1),
                    _userService.GetUserRoleItems(user).Select(u => u.RoleName).ToArray(),
                    false,
                    user.FirstName,
                    user.LastName
                );
                return "Login Success";
            }
            return "Login Fail!";
        }
    }
}