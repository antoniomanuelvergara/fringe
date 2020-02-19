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
    public class TypeCommentDomain: DomainBase<TypeComment>, ITypeCommentDomain
    {

        protected readonly ITypeCommentRepository _typeCommentRepository;

        public TypeCommentDomain(ITypeCommentRepository typeCommentRepository)
        {
            _typeCommentRepository = typeCommentRepository;

               DapperRepositoryBase = _typeCommentRepository as IDapperRepositoryBase;

         }

    }

  

}
