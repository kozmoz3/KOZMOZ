//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ciudad
    {
        public ciudad()
        {
            this.ciudadempresas = new HashSet<ciudadempresa>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string imagen { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
    
        public virtual ICollection<ciudadempresa> ciudadempresas { get; set; }
    }
}
