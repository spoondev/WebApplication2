//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class empRel
    {
        public Nullable<long> EID { get; set; }
        public Nullable<long> MID { get; set; }
        public long empRelId { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
    }
}
