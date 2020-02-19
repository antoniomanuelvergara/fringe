using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Transversal.Common
{
    public class Response<T>
    {
        //datos
        public T Data { get; set; }
        //estado de la ejecución
        public bool IsSuccess { get; set; }
        //mensaje que no devuelve, pore ejemplo que lo capturen los try...catch
        public string Message { get; set; }



    }




}
