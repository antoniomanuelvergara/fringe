using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Domain.Entity;


namespace avergara.Fringe.Domain.Interface
{
    public interface IFringeDomain : IDomainBase<Domain.Entity.Fringe>
    {
        IEnumerable<Entity.SpecialFringe> GetAllFringes();
    }
}
