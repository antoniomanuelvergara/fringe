using AutoMapper;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;
using avergara.Fringe.Domain.Core;

namespace avergara.Fringe.Application.Main
{
    public class CommentApplication : ApplicationBase<CommentDto, Comment>, ICommentApplication
    {
        protected ICommentDomain _commentDomain;


        public CommentApplication(ICommentDomain commentDomain, IMapper mapper)
        {
            _commentDomain = commentDomain;
          _mapper = mapper;

               DomainBase = _commentDomain as IDomainBase<Comment>;

          }


        public Response<bool> DeleteCommentFringe(int FringeId)
        {
            var response = new Response<bool>();
            try
            {

                _commentDomain.DeleteCommentFringe<Comment>(FringeId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Se ha borrado registro!!!";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }





        public Response<IEnumerable<CommentDto>> GetAll(int Id)
        {
            var response = new Response<IEnumerable<CommentDto>>();
            try
            {

                var datas = _commentDomain.GetAll(Id);
                //como el resultado lo obtengo en forma de entidad, lo mapeo  a una lista de fringeDTO, lo que hago es que le especifico el destino
                response.Data = _mapper.Map<IEnumerable<CommentDto>>(datas);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }


}
