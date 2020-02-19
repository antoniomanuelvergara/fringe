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
    public class TestController : Controller
    {

        private readonly IFringeApplication _fringeApplication;
        private readonly ICategoryFringeApplication _categoryFringeApplication;
        private readonly ITypeFringeApplication _typeFringeApplication;

        /// <summary>
        /// controlador
        /// </summary>
        /// <param name="fringeApplication"></param>
        /// <param name="categoryFringeApplication"></param>
        /// <param name="typeFringeApplication"></param>
        public TestController(IFringeApplication fringeApplication, ICategoryFringeApplication categoryFringeApplication, ITypeFringeApplication typeFringeApplication)
        {
            _fringeApplication = fringeApplication;
            _categoryFringeApplication = categoryFringeApplication;
            _typeFringeApplication = typeFringeApplication;

        }

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult CargarFringes(AnexGRID grid)
        {

            return Json(_fringeApplication.GetGridAll(grid));
        }

        /// <summary>
        /// obtenemos la lista de categorias para el anexgrid
        /// </summary>
        /// <returns></returns>
        public JsonResult getCategories()
        {

            var Cat = _categoryFringeApplication.GetAll().Data;
            List<ListGridDto> listGrid = new List<ListGridDto>();


            listGrid.Add(new ListGridDto { valor = 1, contenido = "Todos" });

            foreach (var item in Cat)
            {
                listGrid.Add(new ListGridDto { valor = item.Id, contenido = item.Category });
            }

           
            return Json(listGrid, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// obtenemos la lista de Tipos para el filtro AxexGrid
        /// </summary>
        /// <returns></returns>
        public JsonResult getTypes()
        {
            var Typ = _typeFringeApplication.GetAll().Data;

            List<ListGridDto> listGrid = new List<ListGridDto>();

            listGrid.Add(new ListGridDto { valor = 1, contenido = "Todos" });

            foreach (var item in Typ)
            {
                listGrid.Add(new ListGridDto { valor = item.Id, contenido = item.Type });
            }

            return Json(listGrid, JsonRequestBehavior.AllowGet);
        }


    }
}