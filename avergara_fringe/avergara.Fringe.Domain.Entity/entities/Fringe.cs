using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace avergara.Fringe.Domain.Entity
{
    public class Fringe: EntityAuditBase
    {
        //[Required(ErrorMessage = "esto es una prueba")]
        public string Title { get; set; }

        //[Required(ErrorMessage ="esto es una prueba2")]
        public int TypeFringeId { get; set; }
        //[Required]
        public int CategoryFringeId { get; set; }    //tiene que llamarse como en BD
    

       

       
    }

    public class SpecialFringe :Fringe
    {

        public virtual IEnumerable<CategoryFringe> CategoryFringe { get; set; }
        public virtual IEnumerable<TypeFringe> TypeFringe { get; set; }
    }

}
