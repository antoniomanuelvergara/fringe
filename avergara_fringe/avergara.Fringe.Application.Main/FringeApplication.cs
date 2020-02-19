using avergara.Fringe.Application.Interface;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace avergara.Fringe.Application.Main
{
    public class FringeApplication : ApplicationBase<FringeDto, Domain.Entity.Fringe>, IFringeApplication
    {

        protected IFringeDomain _fringeDomain;


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fringeDomain"></param>
        /// <param name="mapper"></param>
        public FringeApplication(IFringeDomain fringeDomain, IMapper mapper)
        {
            _fringeDomain = fringeDomain;
            _mapper = mapper;

            DomainBase = _fringeDomain as IDomainBase<Domain.Entity.Fringe>;

        }

        public IEnumerable<FringeDto> GetAllFringes()
            // response.Data = _mapper.Map<IEnumerable<T>>(datas);
        {

            return _mapper.Map<IEnumerable<FringeDto>>(_fringeDomain.GetAllFringes());
        }

        public AnexGRIDResponde GetGridAll(AnexGRID grid)
        {
            try
            {

                grid.Inicializar();


                IEnumerable<FringeDto> query = GetAllFringes() as IEnumerable<FringeDto>;

                foreach (var item in query)
                {
                    IEnumerable<CategoryFringeDto> category = item.CategoryFringe;

                    IEnumerable<TypeFringeDto> type = item.TypeFringe;

                    item.UpdateDateString = item.UpdateDate.ToString();

                    foreach (var cat in category)
                    {
                        if(item.CategoryFringeId== cat.Id)
                        {
                            item.CurrentCategoryFringe = cat.Category;
                        }
                    }

                    foreach (var typ in type)
                    {
                        if (item.TypeFringeId == typ.Id)
                        {
                            item.CurrentTypeFringe = typ.Type;
                        }
                    }
                }

                //// Ordenamiento
                if (grid.columna == "Id")
                {
                    query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.Id)
                                                         : query.OrderBy(x => x.Id);
                }

                if (grid.columna == "Title")
                {
                  query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.Title)
                                                        : query.OrderBy(x => x.Title);
                }


                if (grid.columna == "CurrentCategoryFringe")
                {
                    query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.CurrentCategoryFringe)
                                                          : query.OrderBy(x => x.CurrentCategoryFringe);
                }

                if (grid.columna == "CurrentTypeFringe")
                {
                    query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.CurrentTypeFringe)
                                                          : query.OrderBy(x => x.CurrentTypeFringe);
                }



                // Filtrar
                foreach (var f in grid.filtros)
                {
                    if (f.columna == "Title")
                        query = query.Where(x => x.Title.Contains(f.valor));
                   
                    if (f.columna == "Id" && f.valor != "")
                        query = query.Where(x => x.Id.ToString() == f.valor);

                    if (f.columna == "CurrentCategoryFringe" && f.valor != "")
                        query = query.Where(x => x.CategoryFringeId.ToString() == f.valor);

                    if (f.columna == "CurrentTypeFringe" && f.valor != "")
                        query = query.Where(x => x.TypeFringeId.ToString() == f.valor);

                }



                IEnumerable<FringeDto> fringes = query.Skip(grid.pagina).Take(grid.limite).ToList();

                var total = query.Count();

                grid.SetData(
                    from a in fringes
                    select new
                    {
                        a.Id,
                        a.Title,
                        a.CurrentCategoryFringe,
                        a.CurrentTypeFringe,
                        a.CreationDate,
                        a.UpdateDateString
                    },
                    total
                );

            }
            catch (Exception E)
            {

                throw;
            }

            return grid.responde();
        }



    }
}
