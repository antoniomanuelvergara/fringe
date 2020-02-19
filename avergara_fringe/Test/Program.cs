using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Infrastructure.Data;
using avergara.Fringe.Infrastructure.Repository;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDbConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

           // IConnectionFactory cn = new ConnectionFactory(dbConnection);

           // FringeRepository fr = new FringeRepository(cn);

            //IEnumerable<Fringe> result = fr.GetAll();


            //foreach (var item in result)
            //{
              //  Console.WriteLine(item.Id);
              //  Console.WriteLine(item.Title);
            //}
            //Console.ReadKey();

           
        }
    }
}
