using avergara.Fringe.Domain.Entity.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Infrastructure.Interface
{
    public interface ICommentRepository: IDapperRepositoryBase
    {


        IEnumerable<Comment> SelectAll<Comment>(int Id);
        void DeleteCommentFringe<Comment>(int FringeId);
    }

    
}
