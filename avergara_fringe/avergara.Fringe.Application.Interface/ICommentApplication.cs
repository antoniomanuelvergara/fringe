using avergara.Fringe.Application.DTO;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Interface
{
    public interface ICommentApplication : IApplicationBase<CommentDto>
    {


        Response<IEnumerable<CommentDto>> GetAll(int Id);

        Response<bool> DeleteCommentFringe(int FringeId);
    }
}
