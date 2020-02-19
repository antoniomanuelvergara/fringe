using avergara.Fringe.Domain.Entity.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Interface
{
    public interface ICommentDomain: IDomainBase<Comment>
    {

        IEnumerable<Comment> GetAll(int Id);
        void DeleteCommentFringe<Comment>(int FringeId);
    }

   
}
