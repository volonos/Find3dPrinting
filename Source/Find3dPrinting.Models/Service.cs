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
    
    public partial class Service
    {
        public long ServicesId { get; set; } // Services_id (Primary key)
        public string ServiceName { get; set; } // ServiceName

        // Reverse navigation
        public virtual ManufacturersServices ManufacturersServices { get; set; } // Manufacturers_Services.FK_Manufacturers_Services_Services
    }
}
