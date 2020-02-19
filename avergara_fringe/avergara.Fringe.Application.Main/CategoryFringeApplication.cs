using AutoMapper;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;

namespace avergara.Fringe.Application.Main
{
    public class CategoryFringeApplication: ApplicationBase<CategoryFringeDto, Domain.Entity.CategoryFringe>, ICategoryFringeApplication
    {
        protected ICategoryFringeDomain _categoryFringeDomain;


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fringeDomain"></param>
        /// <param name="mapper"></param>
        public CategoryFringeApplication(ICategoryFringeDomain categoryFringeDomain, IMapper mapper)
        {
            _categoryFringeDomain = categoryFringeDomain;
            _mapper = mapper;

            DomainBase = _categoryFringeDomain as IDomainBase<Domain.Entity.CategoryFringe>;

        }


       
    }
}
