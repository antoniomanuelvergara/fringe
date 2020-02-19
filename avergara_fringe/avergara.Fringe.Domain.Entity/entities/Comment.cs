using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Entity.entities
{
    public class Comment: EntityAuditBase
    {
        public string Title { get; set; }
        public string Comentario { get; set; }
        public int TypeCommentId { get; set; }
        public int FringeId { get; set; }
        public string Path { get; set; }
    }
}
