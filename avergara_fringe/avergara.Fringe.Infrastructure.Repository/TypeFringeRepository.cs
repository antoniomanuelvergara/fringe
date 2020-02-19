using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;
using avergara.Fringe.Infrastructure.Interface;

namespace avergara.Fringe.Infrastructure.Repository
{
    public class TypeFringeRepository : DapperRepositoryBase, ITypeFringeRepository
    {
        public TypeFringeRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
    }
}
