using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace avergara.Fringe.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFringeApplication _fringeApplication;

        private readonly ICategoryFringeApplication _categoryFringeApplication;

        private readonly ITypeFringeApplication _typeFringeApplication;

        public HomeController(IFringeApplication fringeApplication, ICategoryFringeApplication categoryFringeApplication, ITypeFringeApplication typeFringeApplication)
        {
            _fringeApplication = fringeApplication;
            _categoryFringeApplication = categoryFringeApplication;
            _typeFringeApplication = typeFringeApplication;

        }

        public ActionResult Index()
        {
            Response<IEnumerable<FringeDto>> response = _fringeApplication.GetAll();

           // Response<IEnumerable<CategoryFringeDto>> response2 = _categoryFringeApplication.GetAll();

            //Response<IEnumerable<TypeFringeDto>> respons32 = _typeFringeApplication.GetAll("");

            if (response.IsSuccess)
            {
                ViewBag.fringes = response.Data;
                return View(response.Data);
            }
            else{
                return Redirect("~/");
            }
           
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public JsonResult getCategories()
        {
            return Json(_categoryFringeApplication.GetAll().Data, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// obtenemos la lista de Tipos para el filtro AxexGrid
        /// </summary>
        /// <returns></returns>
        public JsonResult getTypes()
        {

            return Json(_typeFringeApplication.GetAll().Data, JsonRequestBehavior.AllowGet);
        }

    }
}