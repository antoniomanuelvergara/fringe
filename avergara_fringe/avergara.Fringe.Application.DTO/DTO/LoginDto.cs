using avergara.Fringe.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.DTO
{
    public class LoginDto:BaseDto
    {
     
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Usuario { get; set; }
            public string PassWord { get; set; }

        
    }
}
