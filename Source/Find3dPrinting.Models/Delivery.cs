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
    
    public partial class Delivery
    {
        public Delivery()
        {
            this.Delivery_Manufacturers = new HashSet<Delivery_Manufacturers>();
        }
    
        public long Delivery_id { get; set; }
        public string ShippingMethod { get; set; }
    
        public virtual ICollection<Delivery_Manufacturers> Delivery_Manufacturers { get; set; }
    }
}