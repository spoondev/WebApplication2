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
    
    public partial class PII
    {
        public Nullable<long> FID { get; set; }
        public long piiID { get; set; }
        public Nullable<int> filtertypeID { get; set; }
        public string piiFileName { get; set; }
        public string piiPath { get; set; }
        public string piiContainerPath { get; set; }
        public string piiVolumeName { get; set; }
        public string piiObjectType { get; set; }
        public string piiOwner { get; set; }
        public string piiSize { get; set; }
        public string piiCtime { get; set; }
        public string piiMTime { get; set; }
        public string piiATime { get; set; }
        public string piiMD5 { get; set; }
    
        public virtual fileInfo fileInfo { get; set; }
        public virtual filterTypeRef filterTypeRef { get; set; }
    }
}