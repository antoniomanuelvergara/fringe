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
    public class TypeController : Controller
    {

        private readonly ITypeFringeApplication _typeFringeApplication;


        public TypeController(ITypeFringeApplication typeFringeApplication)
        {

            _typeFringeApplication = typeFringeApplication;

        }

        // GET: Type
        public ActionResult Index()
        {
            return View();
        }

        // POST: Fringe/Create
        [HttpPost]
        public JsonResult Create(TypeFringeDto typeFringeDto)
        {

            var rm = new ResponseModel();


            //en este caso hacemos un Insert
            if (typeFringeDto.Id == 0)
            {

                //categoryFringeDto.CreationDate = DateTime.Now;
                //categoryFringeDto.UpdateDate = DateTime.Now;
                Response<bool> response = _typeFringeApplication.Insert(typeFringeDto);

                rm.response = true;
                if (rm.response)
                {

                    rm.href = Url.Content("~/Fringe/Index");
                }

                //en caso contrario hacemos un Update
            }
            //else
            //{
            // fringeDto.CreationDate = DateTime.Now; //en realidad debemos tener en una celda oculta el dia de creacion y cogerla.
            // fringeDto.UpdateDate = DateTime.Now;
            // Response<bool> response = _fringeApplication.Update(fringeDto);
            //rm.response = true; //esto en realidad no debe llegar
            //if (rm.response)
            //{

            //  rm.href = Url.Content("~/Fringe/Index");
            // }


            // }

            return Json(rm);


        }




    }
}