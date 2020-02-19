using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;

namespace avergara.Fringe.Infrastructure.Repository
{
    public class TypeMediaRepository : DapperRepositoryBase, ITypeMediaRepository
    {
        public TypeMediaRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
    }


    

}
