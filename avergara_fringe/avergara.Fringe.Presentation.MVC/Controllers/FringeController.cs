using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace avergara.Fringe.Presentation.MVC.Controllers
{
    public class FringeController : Controller
    {


        private readonly IFringeApplication _fringeApplication;

        private readonly ICategoryFringeApplication _categoryFringeApplication;

        private readonly ITypeFringeApplication _typeFringeApplication;

        private readonly ICommentApplication _commentApplication;

        private readonly IMediaApplication _mediaApplication;

        private readonly ITypeCommentApplication _typeCommentApplication;


        /// <summary>
        /// controlador
        /// </summary>
        /// <param name="fringeApplication"></param>
        /// <param name="categoryFringeApplication"></param>
        /// <param name="typeFringeApplication"></param>
        public FringeController(IFringeApplication fringeApplication, ICategoryFringeApplication categoryFringeApplication, ITypeFringeApplication typeFringeApplication,
            ICommentApplication commentApplication, IMediaApplication mediaApplication, ITypeCommentApplication typeCommentApplication)
        {
            _fringeApplication = fringeApplication;
            _categoryFringeApplication = categoryFringeApplication;
            _typeFringeApplication = typeFringeApplication;
            _commentApplication = commentApplication;
            _mediaApplication = mediaApplication;
            _typeCommentApplication = typeCommentApplication;

        }

        // GET: Fringe
        public ActionResult Index(int id=0)
        {
           
            
            Response<FringeDto> response = _fringeApplication.Get(id);
            if(response.Data!=null)
            response.Data.Comment= _commentApplication.GetAll(id).Data as IEnumerable<CommentDto>;

            ViewBag.Categorias = _categoryFringeApplication.GetAll().Data;
            ViewBag.Tipos= _typeFringeApplication.GetAll().Data;


            //if (response.IsSuccess)
            //{
            //ViewBag.fringes = response.Data;

            // if (response.Data != null)
            // {
            return View(response.Data);

         //  }else{
           //      return View();
           // }
            
            //return View(prueba);
            //}
            //else
            //{
            //    return Redirect("~/");
            //}


        }

     public ActionResult GetView(int id)
      {

            Response<CommentDto> response = _commentApplication.Get(id);

            //decodificamos
            response.Data.Title = HelperString.DeCodeCharacters(response.Data.Title);
            response.Data.Comentario = HelperString.DeCodeCharacters(response.Data.Comentario);

            //le enviamos la lista 
            response.Data.TypeCommentDto = _typeCommentApplication.GetAll().Data;
                
           return PartialView("_CommentPartial",response.Data);
      }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ActionResult Delete(int id)
        {

            //primero borramos los commentarios asociados al Id
            _commentApplication.DeleteCommentFringe(id);
            //despues borramos el Fringe
            Response<bool> response = _fringeApplication.Delete(id);

            //return Redirect("~/Fringe/Index");
            //return View();
            return RedirectToAction("Index");
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult IndexTest(int id)
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
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



        // GET: Fringe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fringe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fringe/Create
        [HttpPost]
        public JsonResult Create(FringeDto fringeDto)
        {

            var rm =new  ResponseModel();

               
                //en este caso hacemos un Insert
                if (fringeDto.Id == 0)
                {

                    fringeDto.CreationDate = DateTime.Now;
                    fringeDto.UpdateDate = DateTime.Now;
                    Response<bool> response = _fringeApplication.Insert(fringeDto);

                    rm.response = true;
                    if (rm.response)
                    {

                        rm.href = Url.Content("~/Fringe/Index");
                    }

                //en caso contrario hacemos un Update
                }else{
                    fringeDto.CreationDate = DateTime.Now; //en realidad debemos tener en una celda oculta el dia de creacion y cogerla.
                    fringeDto.UpdateDate = DateTime.Now;
                    Response<bool> response = _fringeApplication.Update(fringeDto);
                    rm.response = true; //esto en realidad no debe llegar
                    if (rm.response)
                    {

                        rm.href = Url.Content("~/Fringe/Index");
                    }

            
            }

            return  Json(rm);

                                 
        }




        // GET: Fringe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fringe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       

        // POST: Fringe/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
