using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Entity.entities
{
    public class Media : EntityAuditBase
    {
        public string Title { get; set;}
        public string Path { get; set; }
        public int TypeMediaId { get; set; }
        public int FringeId { get; set; }

        
    }
}
