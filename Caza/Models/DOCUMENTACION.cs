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
    
    public partial class DOCUMENTACION
    {
        public DOCUMENTACION()
        {
            this.INMUEBLE1 = new HashSet<INMUEBLE>();
        }
    
        public int ID_DOCUMENTACION { get; set; }
        public Nullable<int> ID_INMUEBLE { get; set; }
        public string TIPO_SUBSIDIO { get; set; }
        public string ESCRITURA_DE_LA_PROPIEDAD { get; set; }
        public string DOMINIO_VIGENTE { get; set; }
        public string CERTIFICADO_DESLIDES { get; set; }
        public string ROL_EVALUO { get; set; }
        public string PLANO_PROPIEDAD { get; set; }
        public string CERTIFICADO_NUMERO { get; set; }
        public string CERTIFICADO_ASEO { get; set; }
        public string CERTIFICADO_DE_NO_EXPROPIACION { get; set; }
        public string CERTIFICADO_DE_HIPOTECA { get; set; }
    
        public virtual INMUEBLE INMUEBLE { get; set; }
        public virtual ICollection<INMUEBLE> INMUEBLE1 { get; set; }
    }
}
