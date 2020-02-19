using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Transversal.Common;


namespace avergara.Fringe.Application.Interface
{
    public interface IFringeApplication: IApplicationBase<FringeDto>
    {

        AnexGRIDResponde GetGridAll(AnexGRID grid);
        IEnumerable<FringeDto> GetAllFringes();
    }
}
