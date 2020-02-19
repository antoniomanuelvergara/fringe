using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.DTO
{
    public class CommentDto:BaseDto
    {
        public string Title { get; set; }
        public string Comentario { get; set; }
        public int TypeCommentId { get; set; }
        public int FringeId { get; set; }
        public string Path { get; set; }  //lo usamos para guardar imagenes...
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual IEnumerable<TypeCommentDto> TypeCommentDto{ get; set; }
    }
}
