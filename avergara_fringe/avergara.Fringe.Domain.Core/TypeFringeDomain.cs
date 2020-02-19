using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
    public class TypeFringeDomain: DomainBase<Entity.TypeFringe>, ITypeFringeDomain
    {

        protected readonly ITypeFringeRepository _typeFringeRepository;


        public TypeFringeDomain(ITypeFringeRepository typeFringeRepository)
        {
            _typeFringeRepository = typeFringeRepository;

            DapperRepositoryBase = _typeFringeRepository as IDapperRepositoryBase;

        }

    }
}
