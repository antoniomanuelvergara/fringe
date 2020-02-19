using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace avergara.Fringe.Infrastructure.Data
{

    public class ConnectionFactory : IConnectionFactory
    {

       
        public IDbConnection GetConnection
        {
            get
            {
                IDbConnection _configuration = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.ConnectionString;

                sqlConnection.Open();
                return sqlConnection;
            }
        }


    }

}
