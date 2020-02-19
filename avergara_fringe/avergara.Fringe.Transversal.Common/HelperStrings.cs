using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Transversal.Common
{
    public static class HelperString
    {

        /// <summary>
        /// codifica los caracteres que no permite sql server
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string CodeCharacters(string cadena)
        {
            string cadenaResult = cadena;
            //cadenaResult.Replace('ª', '<');
            //cadenaResult.Replace('º', '>');

            return cadenaResult;
        }


        /// <summary>
        /// decodifica los caracteres que no permite sql server
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string DeCodeCharacters(string cadena)
        {
            string cadenaResult = cadena;
            //cadenaResult.Replace('<', 'ª');
            //cadenaResult.Replace('>', 'º');
            return cadenaResult;
       
        }




    }
}
