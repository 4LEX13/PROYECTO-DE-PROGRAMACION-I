//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Docente
    {
        public int docenteid { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public Nullable<System.DateTime> nacimiento { get; set; }
        public string dirreccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
    }
}