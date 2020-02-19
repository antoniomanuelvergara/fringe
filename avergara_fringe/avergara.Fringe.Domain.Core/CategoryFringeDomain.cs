using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
    public class CategoryFringeDomain: DomainBase<Entity.CategoryFringe>, ICategoryFringeDomain
    {


        protected readonly ICategoryFringeRepository _categoryFringeRepository;



        public CategoryFringeDomain(ICategoryFringeRepository categoryFringeRepository)
        {
            _categoryFringeRepository = categoryFringeRepository;

            DapperRepositoryBase = _categoryFringeRepository as IDapperRepositoryBase;

        }


    }
}
