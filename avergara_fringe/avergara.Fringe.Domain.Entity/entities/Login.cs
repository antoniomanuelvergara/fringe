using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Entity
{
    public class Login:EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
    
        public string PassWord { get; set; }

    }
}
