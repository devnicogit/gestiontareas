//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionTareas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tareas
    {
        public int id_tarea { get; set; }
        public int id_usuario { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public string estado { get; set; }
    
        public virtual usuarios usuarios { get; set; }
        public virtual usuarios usuarios1 { get; set; }
    }
}