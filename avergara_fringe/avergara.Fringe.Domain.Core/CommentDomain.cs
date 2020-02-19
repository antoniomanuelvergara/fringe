using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
    public class CommentDomain: DomainBase<Comment>, ICommentDomain
    {
        protected readonly ICommentRepository _commentRepository;


        public CommentDomain(ICommentRepository commentRepository)
        {
           _commentRepository = commentRepository;

               DapperRepositoryBase = _commentRepository as IDapperRepositoryBase;

           }

        public IEnumerable<Comment> GetAll(int Id)
        {
            return _commentRepository.SelectAll<Comment>(Id);
        }


        public void DeleteCommentFringe<Comment>(int FringeId)
        {
            _commentRepository.DeleteCommentFringe<Comment>(FringeId);
        }

    }


  

}
