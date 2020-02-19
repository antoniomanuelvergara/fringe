using avergara.Fringe.Infrastructure.Interface;
using avergara.Fringe.Transversal.Common;
using avergara.Fringe.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace avergara.Fringe.Infrastructure.Repository
{
    public class FringeRepository : DapperRepositoryBase, IFringeRepository
    {


        //esta clase es por si uno quiere añadir mas metodos , que tendra que sumarse en la interfaz IFringeRepository
        public FringeRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        //esto seria un ejemplo donde ampliamos el interfaz
        public Domain.Entity.Fringe SelectTwoKeys(int key1, int Key2)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Domain.Entity.SpecialFringe> GetAllFringes()
        {

           
            IEnumerable<Domain.Entity.Fringe> allFringes = SelectAll<Domain.Entity.Fringe>();


            IList<Domain.Entity.SpecialFringe> allSpecialFringes = new List<Domain.Entity.SpecialFringe>();

            foreach (var item in allFringes)
            {

                Domain.Entity.SpecialFringe aux = new SpecialFringe();

                aux.Id = item.Id;
                aux.Title = item.Title;
                aux.TypeFringeId = item.TypeFringeId;
                aux.CategoryFringeId = item.CategoryFringeId;
                aux.CreationDate = item.CreationDate;
                aux.UpdateDate = item.UpdateDate;

                allSpecialFringes.Add(aux);

            }


            IEnumerable<CategoryFringe> allCategories = SelectAll<Domain.Entity.CategoryFringe>();

            IEnumerable<TypeFringe> allTypes = SelectAll<TypeFringe>();


            foreach (var item in allSpecialFringes)
            {
                item.CategoryFringe = allCategories;
                item.TypeFringe = allTypes;

            }


            return allSpecialFringes;
        }

    }
}
