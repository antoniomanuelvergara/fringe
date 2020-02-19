using avergara.Fringe.Application.DTO;
using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Infrastructure.Data;
using avergara.Fringe.Infrastructure.Interface;
using avergara.Fringe.Infrastructure.Repository;
using avergara.Fringe.Presentation.WPF.Common;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace avergara.Fringe.Presentation.WPF.ViewModel
{
    public class FringeViewModel: INotifyPropertyChanged
    {
       
        private FringeDto fringeDto;

        public FringeDto FringeDto
        {
            get { return fringeDto; }
            set
            {
                fringeDto = value;
                OnPropertyChanged();
            }
        }

     
        private string idSearch;

        public string IdSearch

        {
            get { return idSearch; }
            set
            {
                idSearch = value;
                OnPropertyChanged();
            }
        }

        public ICommand BuscarFringe { get; set; }  

        IConnectionFactory conecction;
        IFringeRepository frigeRepository;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// constructor
        /// </summary>
        public FringeViewModel()
        {
   
            conecction = new ConnectionFactory();
            frigeRepository = new FringeRepository(conecction);
            BuscarFringe=new Command(ExecuteMethod, CanExecuteMethod);
            FringeDto = new FringeDto() { Id = 1, Title = "prueba" };
            FringeDto.CategoryFringe= new ObservableCollection<CategoryFringeDto>();
            getCategorias();


        }

        public void getCategorias()
        {
            IEnumerable<CategoryFringe> result = (frigeRepository.SelectAll<CategoryFringe>()) ;
      
            foreach (CategoryFringe c in result)
            {
                FringeDto.CategoryFringe.Add(MapToCategoryDto(c));
            }
            
        }
        public ObservableCollection<CategoryFringeDto> getCategorias2()
        {
            IEnumerable<CategoryFringe> result = (frigeRepository.SelectAll<CategoryFringe>());
            ObservableCollection<CategoryFringeDto> res = new ObservableCollection<CategoryFringeDto>();

            foreach (CategoryFringe c in result)
            {
                res.Add(MapToCategoryDto(c));
            }

            return res;
           
        }




        public bool CanExecuteMethod(object paramater)
        {
            return true;
        }


        public void ExecuteMethod(object paramater)
        {
            Domain.Entity.Fringe result = frigeRepository.Select<Domain.Entity.Fringe>(Convert.ToInt32(IdSearch));
            FringeDto = MapToFringeDto(result);
       

        }

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        /// <summary>
        /// mapeo
        /// </summary>
        /// <param name="categoryFringe"></param>
        /// <returns></returns>
        public CategoryFringeDto MapToCategoryDto(CategoryFringe categoryFringe)
        {

            CategoryFringeDto categoryAux = new CategoryFringeDto();
            categoryAux.Id = categoryFringe.Id;
            categoryAux.Category = categoryFringe.Category;
            categoryAux.Description = categoryFringe.Description;
            
               return categoryAux;
        }

        /// <summary>
        /// mapeo hasta que usemos el mapper
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public FringeDto MapToFringeDto(Domain.Entity.Fringe a)
        {
            FringeDto fringeDtoAux = new FringeDto();
            fringeDtoAux.Id = a.Id;
            fringeDtoAux.Title = a.Title;
            fringeDtoAux.CategoryFringe = getCategorias2();
            fringeDtoAux.CategoryFringeId = a.CategoryFringeId;
            return fringeDtoAux;
        }





    }
}
