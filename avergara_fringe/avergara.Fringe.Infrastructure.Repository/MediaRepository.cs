using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;

namespace avergara.Fringe.Infrastructure.Repository
{
    public class MediaRepository : DapperRepositoryBase, IMediaRepository
    {
        public MediaRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
    }

    //public class CategoryFringeRepository : DapperRepositoryBase, ICategoryFringeRepository
    //{
    //    public CategoryFringeRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
    //    {
    //    }
    //}


}
