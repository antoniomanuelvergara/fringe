using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace avergara.Fringe.Domain.Entity
{
    public class EntityAuditBase: EntityBase
    {
       
        public DateTime CreationDate { get; set; }
       
        public DateTime UpdateDate { get; set; }
    }
}
