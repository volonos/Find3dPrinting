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
    
    public partial class Payment
    {
        public long PaymentsId { get; set; } // Payments_id (Primary key)
        public string PaymentMethod { get; set; } // PaymentMethod

        // Reverse navigation
        public virtual ICollection<PaymentsManufacturers> PaymentsManufacturers { get; set; } // Payments_Manufacturers.FK_Payments_Manufacturers_Payments

        public Payment()
        {
            PaymentsManufacturers = new List<PaymentsManufacturers>();
        }
    }
}
