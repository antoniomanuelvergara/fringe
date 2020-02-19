using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using avergara.Fringe.Application.DTO;

namespace avergara.Fringe.Presentation.MVC.Controllers
{
    public class LoginController : Controller
    {
        private LoginDto usuario = new LoginDto();

        //[NoLogin]
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult Acceder(string Email, string Password)
        //{
            //var rm = usuario.Acceder(Email, Password);

           // if (rm.response)
           // {
                //rm.href = Url.Content("~/admin/usuario");
           // }
            //return Json(rm);
       // }
 
            public ActionResult Acceder()
        {
            return RedirectToAction("Index", "Fringe");
        }


        public ActionResult Logout()
        {
            //SessionHelper.DestroyUserSession();
            return Redirect("~/");
        }
    }
}