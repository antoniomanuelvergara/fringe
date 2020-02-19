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
    public class TypeMediaApplication:ApplicationBase<TypeMediaDto, TypeMedia>, ITypeMediaApplication
    {
        protected ITypeMediaDomain _typeMediaDomain;

        public TypeMediaApplication (ITypeMediaDomain typeMediaDomain, IMapper mapper)
       {
            _typeMediaDomain = typeMediaDomain;
            _mapper = mapper;

            DomainBase = _typeMediaDomain as IDomainBase<TypeMedia>;

            }

    }




   


}
