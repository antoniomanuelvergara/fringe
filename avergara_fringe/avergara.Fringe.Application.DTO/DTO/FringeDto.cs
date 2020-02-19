using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace avergara.Fringe.Application.DTO
{

    public class FringeDto: BaseDto { 
          
        
        [Required(ErrorMessage = "es necesario rellenar el titulo")]
        public string Title { get; set; }
        
        public int TypeFringeId { get; set; }
        public int CategoryFringeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }


        //aqui hacemos una imitacion de lo que hace entityFramework
        public virtual ObservableCollection<CategoryFringeDto> CategoryFringe { get; set; }
        public virtual ObservableCollection<TypeFringeDto> TypeFringe { get; set; }

        public virtual IEnumerable<CommentDto> Comment { get; set; }
        public virtual ObservableCollection<MediaDto> Media { get; set; }

        public virtual string CurrentCategoryFringe { get; set; }
        
        public virtual string CurrentTypeFringe { get; set; }

        public virtual string UpdateDateString { get; set; }

        
    }
}
