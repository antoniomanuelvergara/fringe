using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Domain;
using avergara.Fringe.Infrastructure.Interface;

namespace avergara.Fringe.Infrastructure.Interface
{
    //public interface IFringeRepository : IRepositoryBase<Domain.Entity.Fringe>
    public interface IFringeRepository : IDapperRepositoryBase
    {
        Domain.Entity.Fringe SelectTwoKeys(int key1, int Key2);

        IEnumerable<Domain.Entity.SpecialFringe> GetAllFringes();
    }
}
