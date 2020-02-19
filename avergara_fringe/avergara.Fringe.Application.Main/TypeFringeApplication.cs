using AutoMapper;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Main
{
    public class TypeFringeApplication : ApplicationBase<TypeFringeDto, Domain.Entity.TypeFringe>, ITypeFringeApplication
    {
        protected ITypeFringeDomain _typeFringeDomain;


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fringeDomain"></param>
        /// <param name="mapper"></param>
        public TypeFringeApplication(ITypeFringeDomain typeFringeDomain, IMapper mapper)
        {
            _typeFringeDomain = typeFringeDomain;
            _mapper = mapper;

            DomainBase = _typeFringeDomain as IDomainBase<Domain.Entity.TypeFringe>;

        }
    }
}
