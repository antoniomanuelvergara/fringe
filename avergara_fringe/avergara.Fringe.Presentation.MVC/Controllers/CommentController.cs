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
    public class CommentController : Controller
    {


        private readonly ICommentApplication _commentApplication;
   

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="commentApplication"></param>
        public CommentController(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
           
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id, int fringeId)
        {

            Response<bool> response = _commentApplication.Delete(id);

            return Redirect("~/Fringe/Index/"+fringeId);

            //return View();
            //return PartialView();
        }



        // GET: Comment
        //public ActionResult _CommentPartial(int id = 0)
        //{
        //    Response<CommentDto> response = _commentApplication.Get(id);

        //    //ViewBag.Categorias = _categoryFringeApplication.GetAll().Data;
        //    //ViewBag.Tipos = _typeFringeApplication.GetAll().Data;


        //    return View(response.Data);


        //}


        //public PartialViewResult _CommentPartial(int id=0)
        //{
        //    Response<CommentDto> response = _commentApplication.Get(6);
        //    return PartialView(response.Data);
        //}



        [HttpPost]
        public JsonResult Create(CommentDto commentDto)
        {

            var rm = new ResponseModel();


            //en este caso hacemos un Insert
            if (commentDto.Id == 0)
            {
                commentDto.CreationDate = DateTime.Now;
                commentDto.UpdateDate = DateTime.Now;

                //codificamos el comentario
                commentDto.Title=HelperString.CodeCharacters(commentDto.Title);
                commentDto.Comentario = HelperString.CodeCharacters(commentDto.Comentario);
                commentDto.TypeCommentId = 1;

                Response<bool> response = _commentApplication.Insert(commentDto);

                rm.response = true;
                if (rm.response)
                {
                    rm.message = "Se creo correctamente";
                    rm.href = Url.Content("~/Fringe/Index/"+commentDto.FringeId);
                }

                //en caso contrario hacemos un Update
            }
            else
            {
                commentDto.CreationDate = DateTime.Now; //en realidad debemos tener en una celda oculta el dia de creacion y cogerla.
                commentDto.UpdateDate = DateTime.Now;
                commentDto.Title = HelperString.CodeCharacters(commentDto.Title);
                commentDto.Comentario = HelperString.CodeCharacters(commentDto.Comentario);
                Response<bool> response = _commentApplication.Update(commentDto);
                rm.response = true; //esto en realidad nos debe llegar
                if (rm.response)
                {
                    rm.message = "Se guardo correctamente";
                    rm.href = Url.Content("~/Fringe/Index/" + commentDto.FringeId);
                }
               
            }

            return Json(rm);

        }
    }
}