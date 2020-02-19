using AutoMapper;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Main
{
    public class TypeCommentApplication: ApplicationBase<TypeCommentDto, TypeComment>, ITypeCommentApplication
    {

        protected ITypeCommentDomain _typeCommentDomain;

        public TypeCommentApplication(ITypeCommentDomain typeCommentDomain, IMapper mapper)
        {
            _typeCommentDomain = typeCommentDomain;
            _mapper = mapper;

            DomainBase = _typeCommentDomain as IDomainBase<TypeComment>;
          }


    }

   


}
