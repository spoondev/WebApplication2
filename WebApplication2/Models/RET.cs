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
    
    public partial class RET
    {
        public Nullable<long> FID { get; set; }
        public long retID { get; set; }
        public Nullable<int> filtertypeID { get; set; }
        public string retFileName { get; set; }
        public string retPath { get; set; }
        public string retContainerPath { get; set; }
        public string retVolumeName { get; set; }
        public string retObjectType { get; set; }
        public string retOwner { get; set; }
        public string retSize { get; set; }
        public string retCtime { get; set; }
        public string retMTime { get; set; }
        public string retATime { get; set; }
        public string retMD5 { get; set; }
    
        public virtual fileInfo fileInfo { get; set; }
        public virtual filterTypeRef filterTypeRef { get; set; }
    }
}