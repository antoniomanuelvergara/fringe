using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;


namespace avergara.Fringe.Domain.Core
{
    public class FringeDomain : DomainBase<Entity.Fringe>, IFringeDomain
    {

        protected readonly IFringeRepository _fringeRepository;

     

        public FringeDomain(IFringeRepository fringeRepository)
        {
            _fringeRepository = fringeRepository;

            DapperRepositoryBase = _fringeRepository as IDapperRepositoryBase;

        }

        public IEnumerable<Entity.SpecialFringe> GetAllFringes()
        {
            return _fringeRepository.GetAllFringes();
        }
    }
}
