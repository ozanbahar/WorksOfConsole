//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorksOfConsole.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightDetails
    {
        public int Id { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<byte> Capacity { get; set; }
        public Nullable<System.DateTime> FlightDate { get; set; }
    }
}
