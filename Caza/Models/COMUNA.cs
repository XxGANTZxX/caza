//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caza.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMUNA
    {
        public COMUNA()
        {
            this.INMUEBLE = new HashSet<INMUEBLE>();
        }
    
        public int ID_COMUNA { get; set; }
        public Nullable<int> ID_PROVINCIA { get; set; }
        public string NOMBRE_COMUNA { get; set; }
    
        public virtual PROVINCIA PROVINCIA { get; set; }
        public virtual ICollection<INMUEBLE> INMUEBLE { get; set; }
    }
}
