//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Find3dPrinting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoxSize
    {
        public BoxSize()
        {
            this.Printers = new HashSet<Printer>();
        }
        
        public long BoxSizes_id { get; set; }
        public float X_dimm_size { get; set; }
        public float Y_dimm_size { get; set; }
        public float Z_dimm_size { get; set; }
        public float ScallingRatio { get; set; }
    
        public virtual ICollection<Printer> Printers { get; set; }
    }
}
