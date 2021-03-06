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
    
    public partial class INMUEBLE
    {
        public INMUEBLE()
        {
            this.DOCUMENTACION = new HashSet<DOCUMENTACION>();
            this.PUBLICACION1 = new HashSet<PUBLICACION>();
        }
    
        public int ID_INMUEBLE { get; set; }
        public Nullable<int> ID_REGISTRO { get; set; }
        public Nullable<int> ID_PUBLICACION { get; set; }
        public Nullable<int> ID_COMUNA { get; set; }
        public Nullable<int> ID_DOCUMENTACION { get; set; }
        public string MATERIAL_INMUEBLE { get; set; }
        public string DIRECCION_INMUEBLE { get; set; }
        public double LATITUD { get; set; }
        public double LONGITUD { get; set; }
        public int CANTIDAD_M2 { get; set; }
        public int CANTIDAD_HABITACION { get; set; }
        public int CANTIDAD_BANO { get; set; }
        public string ESTACIONAMIENTO { get; set; }
        public int NUMERO_CONTACTO { get; set; }
        public int PRECIO_INMUEBLE { get; set; }
        public string FOTO_INMUEBLE_1 { get; set; }
        public string FOTO_INMUEBLE_2 { get; set; }
        public string FOTO_INMUEBLE_3 { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
        public virtual ICollection<DOCUMENTACION> DOCUMENTACION { get; set; }
        public virtual DOCUMENTACION DOCUMENTACION1 { get; set; }
        public virtual PUBLICACION PUBLICACION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PUBLICACION> PUBLICACION1 { get; set; }
    }
}
