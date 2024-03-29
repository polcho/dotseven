//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pescador.Core.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Truck
    {
        public Truck()
        {
            this.Destinations = new HashSet<Destination>();
        }
    
        public int ID { get; set; }
        public string Plate { get; set; }
        public string DriveName { get; set; }
        public string DriverDocumentNumber { get; set; }
        public string DriverMobilePhone { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateAssigned { get; set; }
        public Nullable<int> DestinationAssignedID { get; set; }
        public string AssignationID { get; set; }
    
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
