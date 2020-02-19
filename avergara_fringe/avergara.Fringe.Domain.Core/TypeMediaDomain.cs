using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
    public class TypeMediaDomain : DomainBase<TypeMedia>, ITypeMediaDomain
    {
        protected readonly ITypeMediaRepository _typeMediaRepository;

        public TypeMediaDomain(ITypeMediaRepository typeMediaRepository)
        {
           _typeMediaRepository = typeMediaRepository;

               DapperRepositoryBase = _typeMediaRepository as IDapperRepositoryBase;

          }

    }



   

}
