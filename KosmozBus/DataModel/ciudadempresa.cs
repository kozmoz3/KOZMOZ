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
    
    public partial class ciudadempresa
    {
        public int id { get; set; }
        public Nullable<int> idciudadfk { get; set; }
        public Nullable<int> idempresafk { get; set; }
    
        public virtual ciudad ciudad { get; set; }
        public virtual empresaservicio empresaservicio { get; set; }
    }
}